/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;
using Mapz.Core.Component;

namespace Mapz.Core.Lua
{
    [System.Serializable]
    public class Injection
    {
        public string name;
        public GameObject value;
    }

    [LuaCallCSharp]
    public class LuaClassBehaviour : MonoBehaviour
    {
        public string luaScriptPath;
        public Injection[] injections;
        internal static LuaEnv luaEnv = LuaManager.luaenv;
        private Action<LuaTable> luaStart;
        private Action<LuaTable> luaUpdate;
        private Action<LuaTable> luaOnDestroy;
        private LuaTable scriptEnv;
        private LuaTable luaObject;
        // private LuaTable initDataTable;
        // private LuaTable injectTable;

        private static Dictionary<string, LuaTable> classTableCache = new Dictionary<string, LuaTable>();

        void Awake()
        {
            scriptEnv = luaEnv.NewTable();

            // 为每个脚本设置一个独立的环境，可一定程度上防止脚本间全局变量、函数冲突
            LuaTable meta = luaEnv.NewTable();
            meta.Set("__index", luaEnv.Global);
            scriptEnv.SetMetaTable(meta);
            meta.Dispose();

            LuaTable classTable;
            if (!classTableCache.TryGetValue(luaScriptPath, out classTable))
            {
                object[] obj = luaEnv.DoString("return require '" + luaScriptPath + "'", luaScriptPath, scriptEnv);
                classTable = (LuaTable)obj[0];
                classTableCache.Add(luaScriptPath, classTable);
            }

            // 注入的 GO
            var initDataTable = luaEnv.NewTable();
            var injectTable = luaEnv.NewTable();
            // luaObject.Set("_inject", initDataTable);
            initDataTable.Set("_inject", injectTable);
            foreach (var injection in injections)
            {
                injectTable.Set(injection.name, injection.value);
            }

            luaObject = (LuaTable)classTable.CallSelf("new", initDataTable)[0];

            luaObject.Set("this", this);

            initDataTable.Dispose(false);
            injectTable.Dispose(false);

            // 注入的 函数
            Action<LuaTable> luaAwake = luaObject.Get<Action<LuaTable>>("awake");
            luaObject.Get("start", out luaStart);
            luaObject.Get("update", out luaUpdate);
            luaObject.Get("ondestroy", out luaOnDestroy);

            // classTable.Dispose();

            if (luaAwake != null)
            {
                luaAwake(luaObject);

            }
        }

        // Use this for initialization
        void Start()
        {
            if (luaStart != null)
            {
                luaStart(luaObject);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (luaUpdate != null)
            {
                luaUpdate(luaObject);
            }

        }

        void OnDestroy()
        {
            if (luaOnDestroy != null)
            {
                luaOnDestroy(luaObject);
            }
            luaOnDestroy = null;
            luaUpdate = null;
            luaStart = null;
            luaObject.Dispose();
            scriptEnv.Dispose();
            injections = null;
        }
    }
}
