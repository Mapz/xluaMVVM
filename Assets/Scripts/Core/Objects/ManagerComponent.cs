
//namespace Core
//{
public abstract class ManagerComponent : UnityEngine.MonoBehaviour
{
    public static UnityEngine.Transform parentTransform = null;
    public static UnityEngine.GameObject CreateGameObject(string name)
    {
        UnityEngine.GameObject go = null;
        if (name != null)
            go = new UnityEngine.GameObject(name);
        else
            go = new UnityEngine.GameObject();
        //

        if (parentTransform != null)
        {
            go.transform.parent = parentTransform;
        }
        else
        {
            UnityEngine.Object.DontDestroyOnLoad(go);
        }

        return go;
    }

}
//}
