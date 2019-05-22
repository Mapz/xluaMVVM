DataClassBase = newclass("DataClassBase")

-- 子类不重写这个，重写 Start
--[[
    Awake 的时候，C# 会把绑定数据传入 self._inject[key] 中，其中 key 为编辑器中的 inject key
]]
function DataClassBase:init()
    self.vm = ViewModel(self:CreateVMData())
    self:Init()
end

function DataClassBase:Init()
    self:InitBindData()
end

function DataClassBase:Get(k)
    return self.vm:Get(k)
end

function DataClassBase:Set(k, v)
    self.vm:Set(k, v)
end

function DataClassBase:InitBindData()
    self.computeTable = self:Computed()
end

function DataClassBase:Bind(key, obj, property, callBack, getter)
    if obj == nil or property == nil then
        error("绑定的对象或属性为空，绑定失败：" .. tostring(obj) .. "   " .. tostring(property))
        return
    end
    self.vm:Bind(key, obj, property, callBack, getter or self.computeTable[key])
end

function DataClassBase:BindTwoWay(key, obj, property, callBack)
    if obj == nil or property == nil then
        error("绑定的对象或属性为空，绑定失败：" .. tostring(obj) .. "   " .. tostring(property))
        return
    end
    self.vm:BindTwoWay(key, obj, property, callBack)
end

function DataClassBase:UnBind(key, obj, property, callBack)
    if obj == nil or property == nil then
        error("绑定的对象或属性为空，绑定失败：" .. tostring(obj) .. "   " .. tostring(property))
        return
    end
    self.vm:UnBind(key, obj, property)
end

function DataClassBase:CreateVMData()
    local vmData = {}
    for k, v in pairs(self:Data()) do
        if type(v) == "table" then
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
                    vmData[k] = false
                end
            end
        else
            vmData[k] = v
        end
    end
    return vmData
end

DataClassBase:virtual("Data")
-- 绑定数据 -- Data 后面准备用代码生成来制作
function DataClassBase:Data()
    --[[
        [k] = {
            
        
            default = "测试绑定" -- 默认值
            type @table,string,number,bool,function
        }
    ]]
    --格式
    return {}
end

DataClassBase:virtual("Computed")
-- 绑定计算 -- Computed 后面准备用代码生成来制作
function DataClassBase:Computed()
    --[[
        [k] = 
            function(this)
                return this.a + this.b
            end
        
    ]]
    --格式
    return {}
end

return DataClassBase
