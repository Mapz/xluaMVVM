ViewModel = newclass("ViewModel")

local isList = "__list"

function ViewModel:init(initData, initMode, preventExtensions)
    self._data = {}
    self._watchers = {}
    self.id = GenID()
    if initData then
        if initMode == "DeepCopy" then
            self._data = DeepCopy(initData)
        else
            self._data = initData
        end
    end
    if initMode and initMode == "Part" then
        return
    end
    self.ob = observe(self._data)
    self.computedComponent = InitComputed(self._data)
    --不准扩展此表
    if preventExtensions then
        DefineProperty.preventExtensions(self._data)
    end
end

function ViewModel:Get(key)
    return self._data[key]
end

function ViewModel:Set(key, val)
    self.ob:set(self._data, key, val)
end

function ViewModel:GetBindKey(key)
    return tostring(self.id) .. key
end

function ViewModel:BindTwoWay(key, obj, property, onChangeCallback, getter)
    if getter then
        error("自定义Getter暂不能双绑定")
        return
    end
    self:Bind(key, obj, property, onChangeCallback)
    if property == isList then
        return
    end
    CSharpWatchManager:AddWatch(
        obj,
        property,
        function(oldValue, newValue)
            -- 同样的值不再更新
            if self._data[key] == newValue then
                return
            end
            self._data[key] = newValue
        end,
        self:GetBindKey(key)
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
            if property ~= isList then
                obj[property] = val
            end
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
        if property ~= isList then
            CSharpWatchManager:RemoveWatch(obj, property, self:GetBindKey(key))
        end
        return
    end
    self.ob:delete(self._data, key)
end
