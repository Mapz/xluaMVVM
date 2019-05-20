using UnityEngine;
using XLua;

namespace Mapz.Core.Component
{
    public class ResManager : ManagerComponent
    {
        public static ResManager instance;

        private static string go_name = "_ResManager";
        public static ResManager GetInstance()
        {
            if (instance == null)
            {
                UnityEngine.GameObject go = CreateGameObject(go_name);
                instance = go.AddComponent<ResManager>();
            }
            return instance;
        }

        public void Run()
        {
        }


        public static Object LoadPrefab(string path)
        {
            if (Config.m_launchMode == LaunchMode.Debug)
            {
                path = path;
                return Resources.Load(path);
            }
            return null;
        }

        [LuaCallCSharp]
        public static GameObject LoadAndInstaniate(string path)
        {
            return (GameObject)Instantiate(LoadPrefab(path));
        }

    }
}