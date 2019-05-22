function DestroyGO(component)
    CS.UnityEngine.Object.Destroy(component.gameObject)
end

function Destroy(component)
    CS.UnityEngine.Object.Destroy(component)
end

function GetChildByPath(GO)
    if GO ~= nil then
        GO.transform:Find()
    end
end
