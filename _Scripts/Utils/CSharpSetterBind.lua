CSharpWatchManager = {
    funcCache = {}
}

function CSharpWatchManager:AddWatch(Component, componentProperty, func, bindId)
    print("func" .. tostring(func))
    local id = Component:GetPid()
    if not self.funcCache[id] then
        self.funcCache[id] = {}
    end
    if not self.funcCache[id][componentProperty] then
        self.funcCache[id][componentProperty] = {}
    end

    if not self.funcCache[id][componentProperty][bindId] then
        self.funcCache[id][componentProperty][bindId] = func
    end
    if Component["on_change_" .. componentProperty] == nil then
        Component["on_change_" .. componentProperty] = func
    else
        Component["on_change_" .. componentProperty] = Component["on_change_" .. componentProperty] + func
    end
    return Component
end

function CSharpWatchManager:RemoveWatch(Component, componentProperty, bindId)
    local id = Component:GetPid()
    print("self.funcCache:" .. table.tostring(self.funcCache))
    if self.funcCache[id] and self.funcCache[id][componentProperty] and self.funcCache[id][componentProperty][bindId] then
        print("Component[on_changecomponentProperty]:" .. tostring(Component["on_change_" .. componentProperty]))
        if Component["on_change_" .. componentProperty] == nil then
            return
        else
            Component["on_change_" .. componentProperty] =
                Component["on_change_" .. componentProperty] - self.funcCache[id][componentProperty][bindId]
            self.funcCache[id][componentProperty][bindId] = nil
            return
        end
    end
end
