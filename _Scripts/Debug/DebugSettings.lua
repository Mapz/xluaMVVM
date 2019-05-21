local DebugSettings = {
    noPrint = false
}

local _print
if DebugSettings.noPrint then
    _print = print
    print = function()
    end
end
