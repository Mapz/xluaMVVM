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
    public class MapzCoreResourceFileUtilWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Mapz.Core.Resource.FileUtil);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 22, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SeparateFileDirAndName", _m_SeparateFileDirAndName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SeparateFileDirNameExt", _m_SeparateFileDirNameExt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetParentDir", _m_GetParentDir_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetReadOnlyDirectory", _m_SetReadOnlyDirectory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetWriteDirectory", _m_SetWriteDirectory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetReadOnlyPath", _m_GetReadOnlyPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWritePath", _m_GetWritePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetReadDir", _m_GetReadDir_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWriteDir", _m_GetWriteDir_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWWWReadPath", _m_GetWWWReadPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetBundlePath", _m_GetAssetBundlePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFilePathGrayAll", _m_GetFilePathGrayAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFilePathGrayWrite", _m_GetFilePathGrayWrite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FileExist", _m_FileExist_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FilePath", _m_FilePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Save", _m_Save_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateFolderByFile", _m_CreateFolderByFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Fremove", _m_Fremove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFileName", _m_GetFileName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDirs", _m_GetDirs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllFileName", _m_GetAllFileName_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Mapz.Core.Resource.FileUtil gen_ret = new Mapz.Core.Resource.FileUtil();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Mapz.Core.Resource.FileUtil constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SeparateFileDirAndName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _fullFileName = LuaAPI.lua_tostring(L, 1);
                    string _fileDir = LuaAPI.lua_tostring(L, 2);
                    string _fileName = LuaAPI.lua_tostring(L, 3);
                    
                    Mapz.Core.Resource.FileUtil.SeparateFileDirAndName( _fullFileName, ref _fileDir, ref _fileName );
                    LuaAPI.lua_pushstring(L, _fileDir);
                        
                    LuaAPI.lua_pushstring(L, _fileName);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SeparateFileDirNameExt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _fullFileName = LuaAPI.lua_tostring(L, 1);
                    string _fileDir = LuaAPI.lua_tostring(L, 2);
                    string _fileName = LuaAPI.lua_tostring(L, 3);
                    string _ext = LuaAPI.lua_tostring(L, 4);
                    
                    Mapz.Core.Resource.FileUtil.SeparateFileDirNameExt( _fullFileName, ref _fileDir, ref _fileName, ref _ext );
                    LuaAPI.lua_pushstring(L, _fileDir);
                        
                    LuaAPI.lua_pushstring(L, _fileName);
                        
                    LuaAPI.lua_pushstring(L, _ext);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParentDir_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetParentDir( _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetReadOnlyDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _dir = LuaAPI.lua_tostring(L, 1);
                    
                    Mapz.Core.Resource.FileUtil.SetReadOnlyDirectory( _dir );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWriteDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _dir = LuaAPI.lua_tostring(L, 1);
                    
                    Mapz.Core.Resource.FileUtil.SetWriteDirectory( _dir );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetReadOnlyPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetReadOnlyPath( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWritePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetWritePath( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetReadDir_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetReadDir(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWriteDir_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetWriteDir(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWWWReadPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetWWWReadPath( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundlePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetAssetBundlePath( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFilePathGrayAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetFilePathGrayAll( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFilePathGrayWrite_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.GetFilePathGrayWrite( _filepath );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FileExist_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.FileExist( _filepath );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    string _outFullPath = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.FileExist( _filepath, ref _outFullPath );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _outFullPath);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Mapz.Core.Resource.FileUtil.DirectoryType>(L, 2)) 
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    Mapz.Core.Resource.FileUtil.DirectoryType _type;translator.Get(L, 2, out _type);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.FileExist( _filepath, _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Mapz.Core.Resource.FileUtil.FileExist!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FilePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    Mapz.Core.Resource.FileUtil.DirectoryType _type;translator.Get(L, 2, out _type);
                    
                        string gen_ret = Mapz.Core.Resource.FileUtil.FilePath( _filepath, _type );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.IO.MemoryStream>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IO.MemoryStream _m = (System.IO.MemoryStream)translator.GetObject(L, 1, typeof(System.IO.MemoryStream));
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.Save( _m, _path );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<char[]>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    char[] _buffer = (char[])translator.GetObject(L, 1, typeof(char[]));
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.Save( _buffer, _path );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Mapz.Core.Resource.FileUtil.Save!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateFolderByFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _filepath = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.CreateFolderByFile( _filepath );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Fremove_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = Mapz.Core.Resource.FileUtil.Fremove( _path );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFileName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _dirPath = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<string> gen_ret = Mapz.Core.Resource.FileUtil.GetFileName( _dirPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirs_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _dirPath = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<string> gen_ret = Mapz.Core.Resource.FileUtil.GetDirs( _dirPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllFileName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _rootPath = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<string> gen_ret = Mapz.Core.Resource.FileUtil.GetAllFileName( _rootPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
