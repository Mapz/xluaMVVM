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
    public class MikuLuaProfilerLuaDeepProfilerSettingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaDeepProfilerSetting);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 12, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Save", _m_Save);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDeepMonoProfiler", _g_get_isDeepMonoProfiler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDeepLuaProfiler", _g_get_isDeepLuaProfiler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isCleanMode", _g_get_isCleanMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "captureLuaGC", _g_get_captureLuaGC);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isNeedCapture", _g_get_isNeedCapture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "assMd5", _g_get_assMd5);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isInited", _g_get_isInited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "discardInvalid", _g_get_discardInvalid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "captureMonoGC", _g_get_captureMonoGC);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "captureFrameRate", _g_get_captureFrameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ip", _g_get_ip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "port", _g_get_port);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "isDeepMonoProfiler", _s_set_isDeepMonoProfiler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isDeepLuaProfiler", _s_set_isDeepLuaProfiler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isCleanMode", _s_set_isCleanMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "captureLuaGC", _s_set_captureLuaGC);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isNeedCapture", _s_set_isNeedCapture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "assMd5", _s_set_assMd5);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isInited", _s_set_isInited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "discardInvalid", _s_set_discardInvalid);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "captureMonoGC", _s_set_captureMonoGC);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "captureFrameRate", _s_set_captureFrameRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ip", _s_set_ip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "port", _s_set_port);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeInstance", _m_MakeInstance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SettingsAssetName", MikuLuaProfiler.LuaDeepProfilerSetting.SettingsAssetName);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.LuaDeepProfilerSetting gen_ret = new MikuLuaProfiler.LuaDeepProfilerSetting();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.LuaDeepProfilerSetting constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        MikuLuaProfiler.LuaDeepProfilerSetting gen_ret = MikuLuaProfiler.LuaDeepProfilerSetting.MakeInstance(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Save(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        MikuLuaProfiler.LuaDeepProfilerSetting gen_ret = MikuLuaProfiler.LuaDeepProfilerSetting.Load(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.LuaDeepProfilerSetting.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDeepMonoProfiler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDeepMonoProfiler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDeepLuaProfiler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDeepLuaProfiler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isCleanMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isCleanMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_captureLuaGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.captureLuaGC);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isNeedCapture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isNeedCapture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assMd5(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.assMd5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isInited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isInited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_discardInvalid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.discardInvalid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_captureMonoGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.captureMonoGC);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_captureFrameRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.captureFrameRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_port(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.port);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isDeepMonoProfiler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isDeepMonoProfiler = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isDeepLuaProfiler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isDeepLuaProfiler = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isCleanMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isCleanMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_captureLuaGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.captureLuaGC = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isNeedCapture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isNeedCapture = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_assMd5(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.assMd5 = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isInited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isInited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_discardInvalid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.discardInvalid = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_captureMonoGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.captureMonoGC = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_captureFrameRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.captureFrameRate = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ip = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_port(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDeepProfilerSetting gen_to_be_invoked = (MikuLuaProfiler.LuaDeepProfilerSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.port = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
