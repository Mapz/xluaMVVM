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
    public class MikuLuaProfilerLuaProfilerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaProfiler);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 5, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginSampleCSharp", _m_BeginSampleCSharp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndSampleCSharp", _m_EndSampleCSharp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginSample", _m_BeginSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PopAllSampleWhenLateUpdate", _m_PopAllSampleWhenLateUpdate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndSample", _m_EndSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddRef", _m_AddRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SendAddRef", _m_SendAddRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveRef", _m_RemoveRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SendRemoveRef", _m_SendRemoveRef_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SendAllRef", _m_SendAllRef_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mainL", _g_get_mainL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsMainThread", _g_get_IsMainThread);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "getcurrentTime", _g_get_getcurrentTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "mainThreadId", _g_get_mainThreadId);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "m_hasL", _g_get_m_hasL);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "mainL", _s_set_mainL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "mainThreadId", _s_set_mainThreadId);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "m_hasL", _s_set_m_hasL);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MikuLuaProfiler.LuaProfiler does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSampleCSharp_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                    MikuLuaProfiler.LuaProfiler.BeginSampleCSharp( _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSampleCSharp_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    MikuLuaProfiler.LuaProfiler.EndSampleCSharp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSample_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MikuLuaProfiler.LuaProfiler.BeginSample( _luaState, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopAllSampleWhenLateUpdate_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaProfiler.PopAllSampleWhenLateUpdate( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSample_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaProfiler.EndSample( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _refName = LuaAPI.lua_tostring(L, 1);
                    string _refAddr = LuaAPI.lua_tostring(L, 2);
                    byte _type = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaProfiler.AddRef( _refName, _refAddr, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendAddRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _funName = LuaAPI.lua_tostring(L, 1);
                    string _funAddr = LuaAPI.lua_tostring(L, 2);
                    byte _type = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaProfiler.SendAddRef( _funName, _funAddr, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _refName = LuaAPI.lua_tostring(L, 1);
                    string _refAddr = LuaAPI.lua_tostring(L, 2);
                    byte _type = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaProfiler.RemoveRef( _refName, _refAddr, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendRemoveRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _funName = LuaAPI.lua_tostring(L, 1);
                    string _funAddr = LuaAPI.lua_tostring(L, 2);
                    byte _type = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaProfiler.SendRemoveRef( _funName, _funAddr, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendAllRef_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    MikuLuaProfiler.LuaProfiler.SendAllRef(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushlightuserdata(L, MikuLuaProfiler.LuaProfiler.mainL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMainThread(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, MikuLuaProfiler.LuaProfiler.IsMainThread);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_getcurrentTime(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushint64(L, MikuLuaProfiler.LuaProfiler.getcurrentTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainThreadId(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, MikuLuaProfiler.LuaProfiler.mainThreadId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m_hasL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, MikuLuaProfiler.LuaProfiler.m_hasL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainL(RealStatePtr L)
        {
		    try {
                
			    MikuLuaProfiler.LuaProfiler.mainL = LuaAPI.lua_touserdata(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainThreadId(RealStatePtr L)
        {
		    try {
                
			    MikuLuaProfiler.LuaProfiler.mainThreadId = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m_hasL(RealStatePtr L)
        {
		    try {
                
			    MikuLuaProfiler.LuaProfiler.m_hasL = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
