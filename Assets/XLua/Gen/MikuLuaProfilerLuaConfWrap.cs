#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class MikuLuaProfilerLuaConfWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaConf);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 1, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUAI_BITSINT", MikuLuaProfiler.LuaConf.LUAI_BITSINT);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUAI_MAXSTACK", MikuLuaProfiler.LuaConf.LUAI_MAXSTACK);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUAI_FIRSTPSEUDOIDX", MikuLuaProfiler.LuaConf.LUAI_FIRSTPSEUDOIDX);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_SIGNATURE", MikuLuaProfiler.LuaConf.LUA_SIGNATURE);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LUA_DIRSEP", _g_get_LUA_DIRSEP);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MikuLuaProfiler.LuaConf does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LUA_DIRSEP(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, MikuLuaProfiler.LuaConf.LUA_DIRSEP);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
