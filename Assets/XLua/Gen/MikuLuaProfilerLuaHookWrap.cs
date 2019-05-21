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
    public class MikuLuaProfilerLuaHookWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaHook);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Hookloadbuffer", _m_Hookloadbuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HookRef", _m_HookRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HookUnRef", _m_HookUnRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Record", _m_Record_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DiffServer", _m_DiffServer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Diff", _m_Diff_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryGetLuaString", _m_TryGetLuaString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RefString", _m_RefString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRefString", _m_GetRefString_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "stringDict", MikuLuaProfiler.LuaHook.stringDict);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isHook", _g_get_isHook);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "historyRef", _g_get_historyRef);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "isHook", _s_set_isHook);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "historyRef", _s_set_historyRef);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.LuaHook gen_ret = new MikuLuaProfiler.LuaHook();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.LuaHook constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Hookloadbuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buff = LuaAPI.lua_tobytes(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        byte[] gen_ret = MikuLuaProfiler.LuaHook.Hookloadbuffer( _L, _buff, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HookRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaHook.HookRef( _L, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HookUnRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaHook.HookUnRef( _L, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Record_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    MikuLuaProfiler.LuaHook.Record(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DiffServer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    MikuLuaProfiler.LuaHook.DiffServer(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Diff_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        MikuLuaProfiler.LuaDiffInfo gen_ret = MikuLuaProfiler.LuaHook.Diff(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetLuaString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _p = LuaAPI.lua_touserdata(L, 1);
                    object _result;
                    
                        bool gen_ret = MikuLuaProfiler.LuaHook.TryGetLuaString( _p, out _result );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _result);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RefString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _strPoint = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _s = translator.GetObject(L, 3, typeof(object));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 4);
                    
                    MikuLuaProfiler.LuaHook.RefString( _strPoint, _index, _s, _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRefString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = MikuLuaProfiler.LuaHook.GetRefString( _L, _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isHook(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, MikuLuaProfiler.LuaHook.isHook);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_historyRef(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, MikuLuaProfiler.LuaHook.historyRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isHook(RealStatePtr L)
        {
		    try {
                
			    MikuLuaProfiler.LuaHook.isHook = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_historyRef(RealStatePtr L)
        {
		    try {
                
			    MikuLuaProfiler.LuaHook.historyRef = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
