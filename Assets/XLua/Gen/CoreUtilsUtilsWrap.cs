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
    public class CoreUtilsUtilsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Core.Utils.Utils);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 19, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTimeSeconds", _m_GetTimeSeconds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDateStringBySecond", _m_GetDateStringBySecond_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDateObject", _m_GetDateObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateActorSpeed", _m_CalculateActorSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLerp", _m_GetLerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MD5", _m_MD5_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetChildTransformByName", _m_GetChildTransformByName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StrongFindPathCheck", _m_StrongFindPathCheck_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WeakFindPathCheck", _m_WeakFindPathCheck_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindCameraForName", _m_FindCameraForName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAbsulotePath", _m_GetAbsulotePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFileNameByPath", _m_GetFileNameByPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GenID", _m_GenID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTerrainHeight", _m_GetTerrainHeight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StringContainUpper", _m_StringContainUpper_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BindService", _m_BindService_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnBindService", _m_UnBindService_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CheckGameObjectIsDestroyed", _m_CheckGameObjectIsDestroyed_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "startTime", _g_get_startTime);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "startTime", _s_set_startTime);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Core.Utils.Utils gen_ret = new Core.Utils.Utils();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Core.Utils.Utils constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTimeSeconds_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        long gen_ret = Core.Utils.Utils.GetTimeSeconds(  );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDateStringBySecond_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _second = LuaAPI.lua_toint64(L, 1);
                    
                        string gen_ret = Core.Utils.Utils.GetDateStringBySecond( _second );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDateObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    long _second = LuaAPI.lua_toint64(L, 1);
                    
                        System.DateTime gen_ret = Core.Utils.Utils.GetDateObject( _second );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateActorSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _p1;translator.Get(L, 1, out _p1);
                    UnityEngine.Vector3 _p2;translator.Get(L, 2, out _p2);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float gen_ret = Core.Utils.Utils.CalculateActorSpeed( _p1, _p2, _deltaTime );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLerp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _p1;translator.Get(L, 1, out _p1);
                    UnityEngine.Vector3 _p2;translator.Get(L, 2, out _p2);
                    float _reduceDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector3 gen_ret = Core.Utils.Utils.GetLerp( _p1, _p2, _reduceDistance );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MD5_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _toCryString = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Core.Utils.Utils.MD5( _toCryString );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    ulong _md51;
                    ulong _md52;
                    
                    Core.Utils.Utils.MD5( _buffer, out _md51, out _md52 );
                    LuaAPI.lua_pushuint64(L, _md51);
                        
                    LuaAPI.lua_pushuint64(L, _md52);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Core.Utils.Utils.MD5!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChildTransformByName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Transform gen_ret = Core.Utils.Utils.GetChildTransformByName( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StrongFindPathCheck_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string[] _nameAry = (string[])translator.GetObject(L, 2, typeof(string[]));
                    
                        bool gen_ret = Core.Utils.Utils.StrongFindPathCheck( _transform, _nameAry );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WeakFindPathCheck_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    string[] _nameAry = (string[])translator.GetObject(L, 2, typeof(string[]));
                    
                        bool gen_ret = Core.Utils.Utils.WeakFindPathCheck( _transform, _nameAry );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindCameraForName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Camera gen_ret = Core.Utils.Utils.FindCameraForName( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAbsulotePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        string gen_ret = Core.Utils.Utils.GetAbsulotePath( _obj );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFileNameByPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _scenePath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Core.Utils.Utils.GetFileNameByPath( _scenePath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = Core.Utils.Utils.GenID(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTerrainHeight_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _z = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        float gen_ret = Core.Utils.Utils.GetTerrainHeight( _x, _z );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StringContainUpper_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _text = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = Core.Utils.Utils.StringContainUpper( _text );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BindService_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _time = LuaAPI.xlua_tointeger(L, 1);
                    
                    Core.Utils.Utils.BindService( _time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnBindService_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    Core.Utils.Utils.UnBindService(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckGameObjectIsDestroyed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject _obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    Core.Utils.Utils.CheckGameObjectIsDestroyed( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Core.Utils.Utils.startTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.DateTime gen_value;translator.Get(L, 1, out gen_value);
				Core.Utils.Utils.startTime = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
