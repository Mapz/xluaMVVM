--[[
    参考（照抄） Vue 源码实现的 Lua MVVM
    @Chenhui 2019-5-17
]]
-- Dep Begin
local Dep = newclass("Dep")
local DepUid = 0
local DepTarget = nil

function Dep:init()
    self.subs = {}
    self.id = DepUid
    DepUid = DepUid + 1
end

function Dep:addSub(sub)
    table.insert(self.subs, sub)
end

function Dep:depend()
    if DepTarget then
        DepTarget:addDep(self)
    end
end

function Dep:notify()
    for _, sub in ipairs(self.subs) do
        sub:update()
    end
end

function Dep:removeWatch(id, dataTable)
    table.removeTableData(
        dataTable and dataTable or self.subs,
        function(data)
            return data.id == id
        end,
        function(data)
            print("data:" .. table.tostring(data))
            Dep:removeWatch(id, data.subs.deps)
        end
    )
end

local targetStack = Stack.Create()

function pushTarget(Watcher)
    if DepTarget then
        targetStack:push(DepTarget)
    end
    DepTarget = Watcher
end
function popTarget()
    DepTarget = targetStack:pop()
end

-- Dep Over

-- Watcher

Watcher = newclass("Watcher")
local WatcherUID = 0
function Watcher:init(vm, getter, callBack, options)
    self.vm = vm
    self.getter = getter
    self.callBack = callBack
    self.deps = {}
    self.newDeps = {}
    self.depIds = Set.Create()
    self.newDepIds = Set.Create()
    self.id = WatcherUID
    WatcherUID = WatcherUID + 1

    if options then
        self.deep = options.deep
        self.user = options.user
        self.lazy = options.lazy
    else
        self.deep = false
        self.user = false
        self.lazy = false
    end

    self.dirty = self.lazy

    if self.lazy then
        self.value = nil
    else
        self.value = self:get()
    end
end

local EmptyFunc = function()
end

function Watcher:destroy()
    --remove deps
    self.deps = {}
    self.newDeps = {}
    self.depIds = Set.Create()
    self.newDepIds = Set.Create()
    self.getter = EmptyFunc
    self.callBack = EmptyFunc
    self = nil
end

function Watcher:get()
    pushTarget(self)
    local value = self.getter(self.vm)
    popTarget()
    return value
end

function Watcher:addDep(dep)
    local id = dep.id
    if not self.newDepIds:contains(id) then
        self.newDepIds:insert(id)
        table.insert(self.newDeps, dep)
        if not self.depIds:contains(id) then
            dep:addSub(self)
        end
    end
end

function Watcher:update()
    if self.lazy then
        self.dirty = true
    else
        local value = self:get()
        local oldValue = self.value
        self.callBack(self.vm, oldValue, value)
        self.value = value
    end
end

function Watcher:depend()
    for _, v in pairs(self.deps) do
        v:depend()
    end
end

function Watcher:evaluate()
    self.value = self:get()
    self.dirty = false
end

-- Watcher Over

-- Observer Begin

local Observer = newclass("Observer")

function Observer:init(value)
    self.value = value
    self.dep = Dep()
    value["__ob__"] = self
    self:walk(self.value)
end

function Observer:walk(value)
    for k, v in pairs(value) do
        if not (string.sub(k, 1, 2) == "__") then
            defineReactive(value, k, v)
        end
    end
end

function Observer:set(target, key, value)
    if DefineProperty.hasProperty(target, key) then
        target[key] = value
        return value
    end
    local ob = target.__ob__
    DefineProperty.defineReactive(ob.value, key, value)
    ob.dep:notify()
    return value
end

function Observer:delete(target, key)
    local ob = target.__ob__

    if not DefineProperty.hasProperty(target, key) then
        return
    end
    DefineProperty.delete(target, key)
    if not ob then
        return
    end
    ob.dep:notify()
end

function observe(value)
    if type(value) ~= "table" then
        return
    end
    local ob = Observer(value)
    return ob
end

function defineReactive(dataTable, key, value)
    local dep = Dep()
    local childOb = observe(value)
    local val = value
    DefineProperty.defineProperty(
        dataTable,
        key,
        {
            get = function()
                if DepTarget then
                    dep:depend()
                    if (childOb) then
                        childOb.dep:depend()
                    end
                end
                return val
            end,
            set = function(newVal)
                val = newVal
                childOb = observe(newVal)
                dep:notify()
            end
        }
    )
end

local noop = function()
end
-- computed初始化的Watcher传入lazy: true就会触发Watcher中的dirty值为true
local computedWatcherOptions = {lazy = true}
local sharedPropertyDefinition = {
    get = noop,
    set = noop
}

InitComputed = newclass("InitComputed")

-- 创建计算监听
function InitComputed:init(vm)
    self._computedWatchers = {}
    self.vm = vm
end

function InitComputed:bind(key, getter, callBack)
    self._computedWatchers[key] = Watcher(self.vm, getter, callBack, computedWatcherOptions)
    if not DefineProperty.hasProperty(self.vm, key) then
        self:defineComputed(self.vm, key)
    else
        error("不可以用 Computed 覆盖 Data ：" .. key)
    end
end

function InitComputed:defineComputed(target, key)
    sharedPropertyDefinition.get = self:createComputedGetter(key)
    sharedPropertyDefinition.set = noop
    DefineProperty.defineProperty(target, key, sharedPropertyDefinition)
end

function InitComputed:createComputedGetter(key)
    return function()
        local watcher = self._computedWatchers and self._computedWatchers[key]
        if watcher then
            local oldValue = watcher.value
            if watcher.dirty then
                watcher:evaluate()
                watcher.callBack(watcher.vm, oldValue, watcher.value)
            end
            --获取依赖
            if DepTarget then
                watcher:depend()
            end
            --返回计算属性的值
            return watcher.value
        end
    end
end
