UIBase = newclass("UIBase")

function UIBase:init(data)
    self._inject = data and data._inject
    self:Bind()
end

UIBase:virtual("Start")
function UIBase:start()
    self:Start()
end

function UIBase:Bind()
    for _, bindData in pairs(self:BindData()) do
        if bindData.twoWay then
            bindData.bindData:BindTwoWay(
                bindData.bindProperty,
                self._inject[bindData.GO]:GetComponent(bindData.component),
                bindData.componentProperty
            )
        else
            bindData.bindData:Bind(
                bindData.bindProperty,
                self._inject[bindData.GO]:GetComponent(bindData.component),
                bindData.componentProperty
            )
        end
    end
end

UIBase:virtual("BindData")

return UIBase
