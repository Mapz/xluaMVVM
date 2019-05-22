UI_Test = newclass("UI_Test", UIBase)

function UI_Test:init(data)
    self.super:init(data)
end

function UI_Test:Start()
    TimerManager.Create(
        function()
            local curItems = DataCenter.Player:Get("Items")
            if curItems then
                curItems[1].Name = "fasd"
                curItems[1].Count = 500
            end
        end,
        1,
        2000,
        TimerTypes.Common,
        false
    )

    -- TimerManager.Create(
    --     function()
    --         DataCenter.Player:UnBind("HP", self._inject.TestText:GetComponent("Text"), "text")
    --     end,
    --     2,
    --     1,
    --     TimerTypes.Common,
    --     false
    -- )

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

    -- TimerManager.Create(
    --     function()
    --         self._inject.TestText:GetComponent("Text").text = 500
    --     end,
    --     5,
    --     1,
    --     TimerTypes.Common,
    --     false
    -- )
end

function UI_Test:update()
    print("ajdflaskjdflasdjf         " .. (DataCenter.Player:Get("Items")[1]["Name"]))
end

function UI_Test:BindData()
    return {
        {
            twoWay = true,
            BaseGO = "TestText",
            component = "Text",
            componentProperty = "text",
            bindData = DataCenter.Player,
            bindProperty = "HP"
        },
        {
            BaseGO = "TestText2",
            component = "Text",
            componentProperty = "text",
            bindData = DataCenter.Player,
            bindProperty = "HPPercent"
        },
        {
            BaseGO = "ListContent",
            listItem = "item",
            bindProperty = "Items",
            bindData = DataCenter.Player,
            listDescriptsions = {
                {
                    path = "ListText",
                    component = "Text",
                    componentProperty = "text",
                    bindProperty = "Name"
                },
                {
                    path = "ListText/ChildText",
                    component = "Text",
                    componentProperty = "text",
                    bindProperty = "Count"
                }
            }
        }
    }
end

return UI_Test
