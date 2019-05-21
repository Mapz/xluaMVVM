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
    public class MikuLuaProfilerLuaDiffInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaDiffInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Restore", _m_Restore);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "addRef", _g_get_addRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "addDetail", _g_get_addDetail);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rmRef", _g_get_rmRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rmDetail", _g_get_rmDetail);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nullRef", _g_get_nullRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nullDetail", _g_get_nullDetail);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "addRef", _s_set_addRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "addDetail", _s_set_addDetail);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rmRef", _s_set_rmRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rmDetail", _s_set_rmDetail);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nullRef", _s_set_nullRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nullDetail", _s_set_nullDetail);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.LuaDiffInfo gen_ret = new MikuLuaProfiler.LuaDiffInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.LuaDiffInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        MikuLuaProfiler.LuaDiffInfo gen_ret = MikuLuaProfiler.LuaDiffInfo.Create(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Restore(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Restore(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_addRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.addRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_addDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.addDetail);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rmRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rmRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rmDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rmDetail);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nullRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.nullRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nullDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.nullDetail);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_addRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.addRef = (System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_addDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.addDetail = (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rmRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rmRef = (System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rmDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rmDetail = (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nullRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.nullRef = (System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, MikuLuaProfiler.LuaTypes>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nullDetail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.LuaDiffInfo gen_to_be_invoked = (MikuLuaProfiler.LuaDiffInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.nullDetail = (System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
