ViewModel = newclass("ViewModel")

function ViewModel:init(initData, deepCopy, preventExtensions)
    self._data = {}
    self._watchers = {}
    if initData then
        if deepCopy then
            self._data = DeepCopy(initData)
        else
            self._data = initData
        end
    end
    self.ob = observe(self._data)
    self.computedComponent = InitComputed(self._data)
    --不准扩展此表
    if preventExtensions then
        DefineProperty.preventExtensions(self._data)
    end
end

function ViewModel:Get(key)
    print("self._data:" .. table.tostring(self._data, 5))
    print("meta self._data:" .. table.tostring(getmetatable(self._data)))
    print("key:"..key)
    print("self._data[key]:" .. tostring(self._data[key]))
    return self._data[key]
end

function ViewModel:Set(key, val)
    self.ob:set(self._data, key, val)
end

function ViewModel:BindTwoWay(key, obj, property, onChangeCallback, getter)
    if getter then
        error("不能双向绑定计算属性")
        return
    end
    self:Bind(key, obj, property, onChangeCallback)
    AddWatch(
        obj,
        property,
        function(oldValue, newValue)
            -- 同样的值不再更新
            if self._data[key] == newValue then
                return
            end
            self._data[key] = newValue
        end
    )
end

--[[Computed when getter is function]]
function ViewModel:Bind(key, obj, property, onChangeCallback, getter)
    local watcher =
        Watcher(
        self._data,
        getter and getter or function(vm)
                return vm[key]
            end,
        function(vm, oldVal, val)
            obj[property] = val
            if onChangeCallback then
                onChangeCallback(vm, oldVal, val)
            end
        end
    )
    if not self._watchers[key] then
        self._watchers[key] = {}
    end
    if not self._watchers[key][obj] then
        self._watchers[key][obj] = {}
    end
    self._watchers[key][obj][property] = watcher
    watcher:update()
end

function ViewModel:UnBind(key, obj, property)
    if obj and property then
        self._watchers[key][obj][property]:destroy()
        return
    end

    -- TODO Also Unbind C# to lua
    self.ob:delete(self._data, key)
end
