LuaViewModelBehaviorBase = newclass("LuaViewModelBehaviorBase")

-- 子类不重写这个，重写 Start
--[[
    Awake 的时候，C# 会把绑定数据传入 self._inject[key] 中，其中 key 为编辑器中的 inject key
]]
function LuaViewModelBehaviorBase:start()
    self:Start()
end

function LuaViewModelBehaviorBase:init(data)
    self.super:init(data)
    self._inject = data and data._inject
    self:Init()
end

-- 给子类重写的 Start
LuaViewModelBehaviorBase:virtual("Start")
function LuaViewModelBehaviorBase:Start()
end

function LuaViewModelBehaviorBase:Init()
    self.data = {}
    self._data = {}
    self._modelData = self:CreateVMData()
    print("self._modelData:" .. table.tostring(self._modelData))
    observe(self._modelData)
    -- self:InitUserDefinedData()
    self:InitBindData()
end

function LuaViewModelBehaviorBase:CreateBinding()
    local bindTable = self:ModelData()

    if not table.is_empty(bindTable) then
        for k, v in pairs(bindTable) do
            if v.viewObjects == nil or table.is_empty(v.viewObjects) then
                return
            end
            -- 创建监听
            for _, viewObj in ipairs(v.viewObjects) do
                if viewObj.component and viewObj.property and viewObj.GO then
                    -- 先判断组件是否存在
                    local checkPassed = true
                    if self._inject[viewObj.GO] == nil then
                        checkPassed = false
                        error("GameObject " .. viewObj.GO .. " 未找到")
                    end
                    if self._inject[viewObj.GO]:GetComponent(viewObj.component) == nil then
                        checkPassed = false
                        error("GameObject " .. viewObj.GO .. " 未找到组件 " .. viewObj.component)
                    end

                    if checkPassed then
                        -- 创建节点的 Watcher
                        Watcher(
                            self._modelData,
                            function(vm)
                                return vm[k]
                            end,
                            function(vm, oldValue, value)
                                print("CallBack:" .. oldValue .. "   " .. value)
                                self._inject[viewObj.GO]:GetComponent(viewObj.component)[viewObj.property] = value
                            end
                        )
                        print("创建watcher")

                        -- 绑定 view 到 model
                        AddWatch(
                            self._inject[viewObj.GO]:GetComponent(viewObj.component),
                            viewObj.property,
                            function(oldValue, newValue)
                                -- 同样的值不再更新
                                if self._data[k] == newValue then
                                    return
                                end
                                self._data[k] = newValue
                            end
                        )
                    end
                end
            end
        end
    end
end

-- 初始化 Computed 数据
function LuaViewModelBehaviorBase:CreateComputedBinding()
    InitComputed(self._modelData, self:CreateComputedData())
end

-- 初始化用户操作数据
function LuaViewModelBehaviorBase:InitUserDefinedData()
    local dataMeta = {
        __index = function(tb, key)
            local bindData = self._data[key]
            if bindData then
                return bindData
            end
            return rawget(tb, key)
        end,
        __newindex = function(tb, key, value)
            if DefineProperty.hasProperty(self._modelData, key) then
                self._modelData[key] = value
            elseif DefineProperty.hasProperty(self._computedData, key) then
                error("不能设置计算值")
            else
                print("RawSet.." .. key .. " value:" .. value)
                rawset(tb, key, value)
            end
        end
    }
    setmetatable(self.data, dataMeta)
end

-- 初始化绑定该数据
function LuaViewModelBehaviorBase:InitBindData()
    local mt = {
        __index = function(tb, key)
            local modelData = self._modelData[key]
            if modelData ~= nil then
                return modelData
            end

            local ori = rawget(tb, key)
            if ori ~= nil then
                return ori
            end
        end,
        __newindex = function(tb, key, value)
            if DefineProperty.hasProperty(self._modelData, key) then
                self._modelData[key] = value
            end
        end
    }
    setmetatable(self._data, mt)

    self:CreateBinding()
    self:CreateComputedBinding()

    print("Binding ...:" .. table.tostring(self._modelData))
    print("Binding Meta ...:" .. table.tostring(getmetatable(self._modelData)))

    --不准扩展此表
    DefineProperty.preventExtensions(self._modelData)
end

function LuaViewModelBehaviorBase:CreateComputedData()
    local computedData = {}
    for k, v in pairs(self:Computed()) do
        computedData[k] = {}
        computedData[k].func = v.func
        computedData[k].callBack = function(vm, oldValue, value)
            print("callBack..computed")
            for _, viewObj in pairs(v.viewObjects) do
                self._inject[viewObj.GO]:GetComponent(viewObj.component)[viewObj.property] = value
            end
        end
    end
    print("computedData:" .. table.tostring(computedData))
    return computedData
end

function LuaViewModelBehaviorBase:CreateVMData()
    local vmData = {}
    for k, v in pairs(self:ModelData()) do
        if v.default then
            vmData[k] = v.default
        else
            local _type = v.type
            if _type == "string" then
                vmData[k] = ""
            elseif _type == "number" then
                vmData[k] = 0
            elseif _type == "table" then
                vmData[k] = {}
            elseif _type == "bool" then
                vmData[k] = true
            elseif _type == "function" then
                vmData[k] = function()
                end
            end
        end
    end
    return vmData
end

LuaViewModelBehaviorBase:virtual("ModelData")
-- 绑定数据 -- ModelData 后面准备用代码生成来制作
function LuaViewModelBehaviorBase:ModelData()
    --[[
        [k] = {
            viewObjects = {
                {
                    GO = "TestText",  -- 注入进来的GameObject
                    component = "Text",    -- 需要获得的组件类型名
                    property = "text",  -- 需要绑定的组件 property --> 需要先用代码生成器生成 setDelegate
                },
                ...
            }
            default = "测试绑定" -- 默认值
            type @table,string,number,bool,function
        }
    ]]
    --格式
    return {}
end

LuaViewModelBehaviorBase:virtual("Computed")
-- 绑定计算 -- Computed 后面准备用代码生成来制作
function LuaViewModelBehaviorBase:Computed()
    --[[
        [k] = {
            viewObjects = {
                {
                    GO = "TestText",  -- 注入进来的GameObject
                    component = "Text",    -- 需要获得的组件类型名
                    property = "text",  -- 需要绑定的组件 property --> 需要先用代码生成器生成 setDelegate
                },
                ...
            }
            func = function(this)
                return this.a + this.b
            end
        }
    ]]
    --格式
    return {}
end

return LuaViewModelBehaviorBase
