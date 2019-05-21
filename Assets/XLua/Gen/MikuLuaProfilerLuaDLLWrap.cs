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
    public class MikuLuaProfilerLuaDLLWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MikuLuaProfiler.LuaDLL);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 44, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_getglobal", _m_xlua_getglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_setglobal", _m_xlua_setglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_get_registry_index", _m_xlua_get_registry_index_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_setglobal", _m_lua_setglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_getglobal", _m_lua_getglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_getref", _m_lua_getref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_unref", _m_lua_unref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_close", _m_lua_close_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_gettop", _m_lua_gettop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_settop", _m_lua_settop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushvalue", _m_lua_pushvalue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_remove", _m_lua_remove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_insert", _m_lua_insert_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_type", _m_lua_type_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tonumber", _m_lua_tonumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushnil", _m_lua_pushnil_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushnumber", _m_lua_pushnumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushstring", _m_lua_pushstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushboolean", _m_lua_pushboolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_getfield", _m_lua_getfield_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawget", _m_lua_rawget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawgeti", _m_lua_rawgeti_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_createtable", _m_lua_createtable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_setfield", _m_lua_setfield_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawset", _m_lua_rawset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pcall", _m_lua_pcall_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_gc", _m_lua_gc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_next", _m_lua_next_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pop", _m_lua_pop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_newtable", _m_lua_newtable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isfunction", _m_lua_isfunction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isnil", _m_lua_isnil_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_istable", _m_lua_istable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_openlibs", _m_luaL_openlibs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_initlibs", _m_luaL_initlibs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_ref", _m_luaL_ref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_unref", _m_luaL_unref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_loadbuffer", _m_luaL_loadbuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tostring", _m_lua_tostring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_ptrtostring", _m_lua_ptrtostring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tolstring", _m_lua_tolstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushcclosure", _m_lua_pushcclosure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushstdcallcfunction", _m_lua_pushstdcallcfunction_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MikuLuaProfiler.LuaDLL gen_ret = new MikuLuaProfiler.LuaDLL();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MikuLuaProfiler.LuaDLL constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_getglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.xlua_getglobal( _L, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_setglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.xlua_setglobal( _L, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_get_registry_index_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.xlua_get_registry_index(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_setglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_setglobal( _luaState, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_getglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_getglobal( _luaState, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_getref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_getref( _luaState, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_unref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_unref( _luaState, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_close_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaDLL.lua_close( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_gettop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.lua_gettop( _luaState );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_settop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _top = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_settop( _luaState, _top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushvalue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushvalue( _luaState, _idx );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_remove_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_remove( _luaState, _idx );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_insert_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_insert( _luaState, _idx );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_type_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        MikuLuaProfiler.LuaTypes gen_ret = MikuLuaProfiler.LuaDLL.lua_type( _luaState, _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tonumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        double gen_ret = MikuLuaProfiler.LuaDLL.lua_tonumber( _luaState, _idx );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushnil_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushnil( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushnumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    double _number = LuaAPI.lua_tonumber(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushnumber( _luaState, _number );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    string _str = LuaAPI.lua_tostring(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushstring( _luaState, _str );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushboolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushboolean( _luaState, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_getfield_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    string _key = LuaAPI.lua_tostring(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.lua_getfield( _L, _idx, _key );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawget_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_rawget( _luaState, _idx );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawgeti_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.lua_rawgeti( _luaState, _idx, _n );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_createtable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _narr = LuaAPI.xlua_tointeger(L, 2);
                    int _nrec = LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.lua_createtable( _luaState, _narr, _nrec );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_setfield_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    string _key = LuaAPI.lua_tostring(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.lua_setfield( _L, _idx, _key );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_rawset( _luaState, _idx );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pcall_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _nArgs = LuaAPI.xlua_tointeger(L, 2);
                    int _nResults = LuaAPI.xlua_tointeger(L, 3);
                    int _errfunc = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.lua_pcall( _luaState, _nArgs, _nResults, _errfunc );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_gc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    MikuLuaProfiler.LuaGCOptions _what;translator.Get(L, 2, out _what);
                    int _data = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.lua_gc( _luaState, _what, _data );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_next_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.lua_next( _luaState, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _amount = LuaAPI.xlua_tointeger(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pop( _luaState, _amount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_newtable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaDLL.lua_newtable( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isfunction_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _n = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = MikuLuaProfiler.LuaDLL.lua_isfunction( _luaState, _n );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isnil_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _n = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = MikuLuaProfiler.LuaDLL.lua_isnil( _luaState, _n );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_istable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _n = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = MikuLuaProfiler.LuaDLL.lua_istable( _luaState, _n );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_openlibs_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaDLL.luaL_openlibs( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_initlibs_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    
                    MikuLuaProfiler.LuaDLL.luaL_initlibs( _luaState );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_ref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _t = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.luaL_ref( _luaState, _t );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_unref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _registryIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _reference = LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.luaL_unref( _luaState, _registryIndex, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_loadbuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buff = LuaAPI.lua_tobytes(L, 2);
                    System.IntPtr _size = LuaAPI.lua_touserdata(L, 3);
                    string _name = LuaAPI.lua_tostring(L, 4);
                    
                        int gen_ret = MikuLuaProfiler.LuaDLL.luaL_loadbuffer( _luaState, _buff, _size, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tostring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = MikuLuaProfiler.LuaDLL.lua_tostring( _luaState, _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_ptrtostring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _str = LuaAPI.lua_touserdata(L, 1);
                    int _len = LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = MikuLuaProfiler.LuaDLL.lua_ptrtostring( _str, _len );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tolstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.IntPtr _strLen;
                    
                        System.IntPtr gen_ret = MikuLuaProfiler.LuaDLL.lua_tolstring( _luaState, _index, out _strLen );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    LuaAPI.lua_pushlightuserdata(L, _strLen);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushcclosure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fn = LuaAPI.lua_touserdata(L, 2);
                    int _nup = LuaAPI.xlua_tointeger(L, 3);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushcclosure( _L, _fn, _nup );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushstdcallcfunction_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _luaState = LuaAPI.lua_touserdata(L, 1);
                    MikuLuaProfiler.LuaCSFunction _func = translator.GetDelegate<MikuLuaProfiler.LuaCSFunction>(L, 2);
                    
                    MikuLuaProfiler.LuaDLL.lua_pushstdcallcfunction( _luaState, _func );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
