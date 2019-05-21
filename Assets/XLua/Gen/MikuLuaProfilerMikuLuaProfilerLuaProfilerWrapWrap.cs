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
    public class MikuLuaProfilerMikuLuaProfilerLuaProfilerWrapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 7, 7);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__Register", _m___Register_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "beginSample", _g_get_beginSample);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "endSample", _g_get_endSample);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unpackReturnValue", _g_get_unpackReturnValue);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "addRefFunInfo", _g_get_addRefFunInfo);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "removeRefFunInfo", _g_get_removeRefFunInfo);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "checkType", _g_get_checkType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "handleError", _g_get_handleError);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "beginSample", _s_set_beginSample);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "endSample", _s_set_endSample);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "unpackReturnValue", _s_set_unpackReturnValue);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "addRefFunInfo", _s_set_addRefFunInfo);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "removeRefFunInfo", _s_set_removeRefFunInfo);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "checkType", _s_set_checkType);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "handleError", _s_set_handleError);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap gen_ret = new MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Register_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.__Register( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_beginSample(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.beginSample);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endSample(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.endSample);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_unpackReturnValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.unpackReturnValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_addRefFunInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.addRefFunInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_removeRefFunInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.removeRefFunInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_checkType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.checkType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handleError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.handleError);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_beginSample(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.beginSample = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endSample(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.endSample = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_unpackReturnValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.unpackReturnValue = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_addRefFunInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.addRefFunInfo = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_removeRefFunInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.removeRefFunInfo = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_checkType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.checkType = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handleError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MikuLuaProfiler.MikuLuaProfilerLuaProfilerWrap.handleError = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
