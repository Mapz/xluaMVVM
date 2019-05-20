function AddWatch(Component, key, func)
    if Component["on_change_" .. key] == nil then
        Component["on_change_" .. key] = func
    else
        Component["on_change_" .. key] = Component["on_change_" .. key] + func
    end
    return Component
end
