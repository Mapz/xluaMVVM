unpack = table.unpack or unpack

local scriptLoadList = {
    "Core.Stack",
    "Core.Set",
    "Utils.LuaUtils",
    "Utils.GoUtils",
    "Core.Class_Yaci",
    {"DefineProperty", "Utils.DefineProperty"},
    "Utils.MVVMUtils",
    "Utils.CSharpSetterBind",
    "Core.UI.UIManager",
    "Core.LuaViewModelBehaviorBase",
    "Core.UI.UIBase",
    "Utils.Timer"
}

-- 按照顺序来加载脚本
local function LoadScripts()
    for _, v in ipairs(scriptLoadList) do
        if type(v) == "table" then
            _G[v[1]] = require(v[2])
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
