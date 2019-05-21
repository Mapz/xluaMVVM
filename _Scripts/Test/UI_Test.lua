UI_Test = newclass("UI_Test", UIBase)

function UI_Test:init(data)
    self.super:init(data)
end

function UI_Test:Start()
    TimerManager.Create(
        function()
            local curHP = DataCenter.Player:Get("HP")
            if curHP then
                DataCenter.Player:Set("HP", curHP + 1)
            end
        end,
        1,
        2000,
        TimerTypes.Common,
        false
    )

    TimerManager.Create(
        function()
            DataCenter.Player:UnBind("HP", self._inject.TestText:GetComponent("Text"), "text")
        end,
        2,
        1,
        TimerTypes.Common,
        false
    )

    -- TimerManager.Create(
    --     function()
    --         DataCenter.Player:BindTwoWay("HP", self._inject.TestText:GetComponent("Text"), "text")
    --     end,
    --     5,
    --     1,
    --     TimerTypes.Common,
    --     false
    -- )

    -- TimerManager.Create(
    --     function()
    --         DataCenter.Player:UnBind("HPPercent", self._inject.TestText2:GetComponent("Text"), "text")
    --     end,
    --     8,
    --     1,
    --     TimerTypes.Common,
    --     false
    -- )

    -- TimerManager.Create(
    --     function()
    --         DataCenter.Player:Bind("HPPercent", self._inject.TestText2:GetComponent("Text"), "text")
    --     end,
    --     12,
    --     1,
    --     TimerTypes.Common,
    --     false
    -- )

    TimerManager.Create(
        function()
            self._inject.TestText:GetComponent("Text").text = 500
        end,
        5,
        1,
        TimerTypes.Common,
        false
    )
end

function UI_Test:update()
    print(DataCenter.Player:Get("HP"))
end

function UI_Test:BindData()
    return {
        {
            twoWay = true,
            GO = "TestText",
            component = "Text",
            componentProperty = "text",
            bindData = DataCenter.Player,
            bindProperty = "HP"
        },
        {
            GO = "TestText2",
            component = "Text",
            componentProperty = "text",
            bindData = DataCenter.Player,
            bindProperty = "HPPercent"
        }
    }
end

return UI_Test
