
using XLua;
using UnityEngine;
using Mapz.Core.Component;
namespace Mapz.Core
{


    public class GameMain : ManagerComponent
    {
        private static string go_name = "_Game";
        public static GameMain instance;

        public static GameMain GetInstance()
        {
            if (instance == null)
            {
                UnityEngine.GameObject go = CreateGameObject(go_name);
                instance = go.AddComponent<GameMain>();
            }
            parentTransform = instance.transform;
            return instance;
        }

        void Update()
        {

        }

        // 启动主入口
        public void Run()
        {
            // 启动 Lua 模块
            LuaManager.GetInstance().Run();
        }

    }
}