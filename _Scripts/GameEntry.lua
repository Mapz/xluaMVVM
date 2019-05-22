unpack = table.unpack or unpack

App = {
    debug = true
}

local scriptLoadList = {
    -- Debug
    "Debug.DebugSettings",

    -- Core
    {"Profiler", "Debug.profiler", "Debug"},
    "Core.Stack",
    "Core.Set",
    "Utils.LuaUtils",
    "Utils.GoUtils",
    "Core.Class_Yaci",
    {"DefineProperty", "Utils.DefineProperty"},
    "Utils.MVVMUtils",
    "Utils.CSharpSetterBind",
    "Core.UI.UIManager",
    "Core.MVVM.ViewModel",
    "Core.MVVM.DataClassBase",

    -- DataClass
    "DataClass.PlayerData",

    -- Init
    "Logic.DataCenter",
    "Core.UI.UIBase",
    "Core.UI.UIList",
    "Utils.Timer",
    
}

-- 按照顺序来加载脚本
local function LoadScripts()
    for _, v in ipairs(scriptLoadList) do
        if type(v) == "table" then
            if (App.debug and v[3]) or (v[3] == nil) then
                _G[v[1]] = require(v[2])
            end
        else
            require(v)
        end
    end
end

local function GameEntry()
    LoadScripts()
    require "Loaders.UI_Test"
end

GameEntry()
