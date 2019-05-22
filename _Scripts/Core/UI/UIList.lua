UIList = newclass("UIList")

function UIList:init(UI_Obj, bindingData)
    --[[
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
            }
        }
    ]]
    self.BaseGO = UI_Obj._inject[bindingData.BaseGO]
    self.itemTemplate = self.BaseGO.transform:Find(bindingData.listItem).gameObject
    self.bd = bindingData
    self.listItem = {} -- For ItemObjects
    -- bindingData.bindData:Bind(bindingData.bindProperty, self.BaseGO, "__list", self.OnChange)
    self:ResetList()
end

function UIList:ResetList()
    local listData = self.bd.bindData:Get(self.bd.bindProperty)
    local listLength = #listData
    local numOfItemToCreate = listLength - #self.listItem

    for i = 1, numOfItemToCreate, 1 do
        self:AddItem()
    end

    for i = 0, numOfItemToCreate, -1 do
        self:HideItem(#self.listItem + i)
    end

    for i, data in DefineProperty.walk(listData) do
        if not self.listItem[i] then
            self.listItem[i] = self:CreateItem()
        end
        for _, nodeData in pairs(self.bd.listDescriptsions) do
            local node = self.listItem[i].transform:Find(nodeData.path).gameObject
            local dataVM = ViewModel(data, "Part")
            dataVM:Bind(
                nodeData.bindProperty,
                node:GetComponent(nodeData.component),
                nodeData.componentProperty
            )
        end
    end
end

function UIList:HideItem(index)
    self.listItem[index]:SetActive(false)
end

function UIList:AddItem(addToList)
    table.insert(self.listItem, self:CreateItem())
end

function UIList:CreateItem()
    local item = CS.UnityEngine.Object.Instantiate(self.itemTemplate, self.BaseGO.transform)
    item:SetActive(true)
    return item
end

function UIList.OnChange(vm, oldValue, value)
    print("OnChange")
    print(table.tostring(oldValue))
    print(table.tostring(value))
end
