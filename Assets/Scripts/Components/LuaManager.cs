
using XLua;
using UnityEngine;
using static XLua.LuaEnv;
using LuaAPI = XLua.LuaDLL.Lua;
using System.IO;
using Mapz.Core.Resource;

namespace Mapz.Core.Component
{
    public class LuaManager : ManagerComponent
    {
        public static LuaEnv luaenv = new LuaEnv(); // Lua 虚拟机
        // public CustomLoa
        public static LuaManager instance;
        private static string go_name = "_LuaManager";
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;//1 second 

        private static CustomLoader m_currentLoader;

        public static LuaManager GetInstance()
        {
            if (instance == null)
            {
                UnityEngine.GameObject go = CreateGameObject(go_name);
                instance = go.AddComponent<LuaManager>();
            }
            return instance;
        }

        void Update()
        {
            if (Time.time - LuaManager.lastGCTime > GCInterval)
            {
                luaenv.Tick();
                LuaManager.lastGCTime = Time.time;
            }
        }


        byte[] DebugLoader(ref string filePath)
        {
            string filename = filePath.Replace('.', '/') + ".lua";
            var path = Path.Combine(Config.m_debugScriptRoot, filename);
            Debug.Log(path);
            if (FileUtil.FileExist(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {
                return null;
            }
        }

        // 启动
        public void Run()
        {
            // Debug 加载器
            if (Config.m_launchMode == LaunchMode.Debug)
            {
                luaenv.AddLoader(DebugLoader);
            }

            luaenv.DoString("require 'GameEntry'");

        }

        void OnDestroy()
        {
            // luaenv.Dispose();
        }

    }
}