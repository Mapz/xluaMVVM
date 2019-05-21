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
    public class MikuLuaProfilerSampleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.Sample);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 16, 16);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckSampleValid", _m_CheckSampleValid);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Restore", _m_Restore);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSample", _m_AddSample);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "fahter", _g_get_fahter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentLuaMemory", _g_get_currentLuaMemory);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentMonoMemory", _g_get_currentMonoMemory);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentTime", _g_get_currentTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "calls", _g_get_calls);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameCount", _g_get_frameCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fps", _g_get_fps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pss", _g_get_pss);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "power", _g_get_power);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "costLuaGC", _g_get_costLuaGC);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "costMonoGC", _g_get_costMonoGC);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "costTime", _g_get_costTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "_father", _g_get__father);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childs", _g_get_childs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "captureUrl", _g_get_captureUrl);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fahter", _s_set_fahter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentLuaMemory", _s_set_currentLuaMemory);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentMonoMemory", _s_set_currentMonoMemory);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentTime", _s_set_currentTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "calls", _s_set_calls);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "frameCount", _s_set_frameCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fps", _s_set_fps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pss", _s_set_pss);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "power", _s_set_power);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "costLuaGC", _s_set_costLuaGC);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "costMonoGC", _s_set_costMonoGC);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "costTime", _s_set_costTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "_father", _s_set__father);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childs", _s_set_childs);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "captureUrl", _s_set_captureUrl);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Capture", _m_Capture_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.Sample gen_ret = new MikuLuaProfiler.Sample();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.Sample constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckSampleValid(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.CheckSampleValid(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    long _time = LuaAPI.lua_toint64(L, 1);
                    int _memory = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        MikuLuaProfiler.Sample gen_ret = MikuLuaProfiler.Sample.Create( _time, _memory, _name );
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
            
            
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Restore(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSample(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MikuLuaProfiler.Sample _s = (MikuLuaProfiler.Sample)translator.GetObject(L, 2, typeof(MikuLuaProfiler.Sample));
                    
                    gen_to_be_invoked.AddSample( _s );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Capture_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string gen_ret = MikuLuaProfiler.Sample.Capture(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MikuLuaProfiler.Sample gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fahter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.fahter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentLuaMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.currentLuaMemory);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentMonoMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.currentMonoMemory);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.currentTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_calls(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.calls);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frameCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.frameCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pss(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pss);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_power(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.power);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_costLuaGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.costLuaGC);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_costMonoGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.costMonoGC);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_costTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.costTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__father(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked._father);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.childs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_captureUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.captureUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fahter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fahter = (MikuLuaProfiler.Sample)translator.GetObject(L, 2, typeof(MikuLuaProfiler.Sample));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentLuaMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.currentLuaMemory = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentMonoMemory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.currentMonoMemory = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.currentTime = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_calls(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.calls = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_frameCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.frameCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fps = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pss(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pss = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_power(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.power = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_costLuaGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.costLuaGC = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_costMonoGC(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.costMonoGC = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_costTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.costTime = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__father(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked._father = (MikuLuaProfiler.Sample)translator.GetObject(L, 2, typeof(MikuLuaProfiler.Sample));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childs = (MikuLuaProfiler.MList<MikuLuaProfiler.Sample>)translator.GetObject(L, 2, typeof(MikuLuaProfiler.MList<MikuLuaProfiler.Sample>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_captureUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MikuLuaProfiler.Sample gen_to_be_invoked = (MikuLuaProfiler.Sample)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.captureUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
