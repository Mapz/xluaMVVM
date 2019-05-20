UI_Test = newclass("UI_Test", UIBase)

function UI_Test:init(data)
    self.super:init(data)
    self.data.TimeStr = "开始"
end

function UI_Test:Start()
    local int = 0
    TimerManager.Create(
        function()
            self._data.text = "测试绑定" .. tostring(int)
            int = int + 1
        end,
        1,
        2000,
        TimerTypes.Common,
        false
    )

    TimerManager.Create(
        function()
            self._inject.TestText:GetComponent("Text").text = "测试双向绑定"
        end,
        10,
        1,
        TimerTypes.Common,
        false
    )
end

function UI_Test:update()
    if (self._modelData and self._modelData.textComputed) then
        print("self._modelData.textComputed:" .. self._modelData.textComputed)
    end

    -- self.TimeStr = tostring(os.clock())
end

function UI_Test:ModelData()
    return {
        text = {
            viewObjects = {
                {
                    GO = "TestText",
                    component = "Text",
                    property = "text"
                }
            },
            default = "测试绑定"
        }
    }
end

-- 绑定计算 -- Computed 后面准备用代码生成来制作
function UI_Test:Computed()
    return {
        textComputed = {
            viewObjects = {
                {
                    GO = "TestText2",
                    component = "Text",
                    property = "text"
                }
            },
            func = function(this)
                print("text:" .. tostring(this.text))
                print("TimeStr:" .. tostring(this.TimeStr))
                print("table:" .. table.tostring(this))
                print("table Meta:" .. table.tostring(getmetatable(this)))

                return this.text and this.text.." + Computed 属性"

               
            end
        }
    }
end

return UI_Test
