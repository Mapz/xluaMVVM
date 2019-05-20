using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mapz.Core.Resource
{
	public class FileUtil
	{
        public enum DirectoryType
        {
            ReadPath = 1,
            WritePath = 2,
        }

		private static string readOnlyDirectory = "";
		private static string writeDirectory = "";
        private static HashSet<string> fileSet = null;


        public static void SeparateFileDirAndName(string fullFileName, ref string fileDir, ref string fileName)
        {
            int lastIndexofSlash = fullFileName.LastIndexOf('/');
            if (null != fileDir)
            {
                fileDir = fullFileName.Substring(0, lastIndexofSlash + 1);
            }

            if (null != fileName)
            {
                fileName = fullFileName.Substring(lastIndexofSlash + 1, fullFileName.Length - lastIndexofSlash - 1);
            }
        }

        public static void SeparateFileDirNameExt(string fullFileName, ref string fileDir, ref string fileName, ref string ext)
        {
            int lastIndexofSlash = fullFileName.LastIndexOf('/');
            int lastIndexofDot = fullFileName.LastIndexOf('.');

            if (null != fileDir)
            {
                fileDir = fullFileName.Substring(0, lastIndexofSlash + 1);
            }

            if (null != fileName)
            {
                fileName = fullFileName.Substring(lastIndexofSlash + 1, lastIndexofDot - lastIndexofSlash - 1);
            }

            if (null != ext)
            {
                ext = fullFileName.Substring(lastIndexofDot + 1, fullFileName.Length - lastIndexofDot - 1);
            }
        }
        

        public static string GetParentDir(string fileName)
        {
            fileName.Replace('\\', '/'); 
            /*
            bool isDir = false;
            if (fileName[fileName.Length-1] == '/')
            { 
                isDir = true;
            }

            int checkLen = fileName.Length;
            if (isDir)
            {
                --checkLen;
            }
            */

            int index = fileName.LastIndexOf("/", fileName.Length - 2, fileName.Length - 2);
            return fileName.Substring(0, index);
        }

        // public static void InitAndroidFileSet()
        // {
        //     byte[] bs = Core.Resource.ResourceManager.GetInstance().LoadResourceByWWW("file_names.txt");

        //     if(bs == null || bs.Length == 0)
        //     {
        //         Core.Unity.Debug.LogError("[FileUtil InitAndroidFileSet] file_names.txt is not exist");
        //         return;
        //     }

        //     fileSet = new HashSet<string>();

        //     MemoryStream ms = new MemoryStream(bs);
        //     StreamReader sr = new StreamReader(ms);

        //     while (sr.Peek() >= 0)
        //     {
        //        string file = sr.ReadLine();
        //        fileSet.Add(file);

        //        Core.Unity.Debug.Log("[FileUtil InitAndroidFileSet] read file: " + file, Unity.Debug.LogLevel.Normal);
        //     }
        // }

		public static void SetReadOnlyDirectory(string dir)
		{
            if (dir == null) dir = "";
            dir = dir.Replace("\\", "/");
            if (dir.Length != 0 && dir[dir.Length - 1] != '/')
			{
				readOnlyDirectory = dir + "/";
			}
			else
			{
				readOnlyDirectory = dir;
			}
		}

		public static void SetWriteDirectory(string dir)
		{
			if (dir == null) dir = "";
            dir = dir.Replace("\\", "/");
			if (dir.Length != 0 && dir[dir.Length-1]!='/' )
			{
				writeDirectory = dir + "/";
			}
			else
			{
				writeDirectory = dir;
			}
		}

		public static string GetReadOnlyPath(string filepath)
		{
			return readOnlyDirectory + filepath;
		}

		public static string GetWritePath(string filepath)
		{
			return writeDirectory + filepath;
		}

        // public static string GetWriteGrayPath(string filepath)
        // {
        //     return writeDirectory + App3.GetInstance().GetGrayPath() + filepath;
        // }

        public static string GetReadDir()
        {
            return readOnlyDirectory;
        }

        public static string GetWriteDir()
        {
            return writeDirectory;
        }

        public static string GetWWWReadPath(string filepath)
        {

            //string path = "";

            //// WritePath's priority is higher than ReadPath 
            //if (FileExist(filepath, DirectoryType.WritePath))
            //{
            //    path = "file:///" + GetWritePath(filepath);
            //}

            string path = GetFilePathGrayWrite(filepath);
            // WritePath's priority is higher than ReadPath 
            if (path != "")
            {
                path = "file:///" + path;
            }
            else
            {
                // use default ReadPath
                // Core.Unity.Debug.LogWarning("[FileUtil GetWWWReadPath] file is not exist: " + filepath + ", use default ReadPath as www path");

            #if ((UNITY_ANDROID && !UNITY_EDITOR))
                path = GetReadOnlyPath(filepath);
            #else
                path = "file:///" + GetReadOnlyPath(filepath);
            #endif
            }

            return path;
        }

        public static string GetAssetBundlePath(string filepath)
        {
            //string path = "";

            //// WritePath's priority is higher than ReadPath 
            //if (FileExist(filepath, DirectoryType.WritePath))
            //{
            //    path = GetWritePath(filepath);
            //}

            string path = GetFilePathGrayWrite(filepath);
            // WritePath's priority is higher than ReadPath 
            if (path != "")
            {
                //path = GetWritePath(filepath);
            }
            else
            {
                // use default ReadPath
                // Core.Unity.Debug.LogWarning("[FileUtil GetWWWReadPath] file is not exist: " + filepath + ", use default ReadPath as www path");

#if ((UNITY_ANDROID && !UNITY_EDITOR))
                path = GetReadOnlyPath(filepath);
#else
                path = GetReadOnlyPath(filepath);
#endif
            }

            return path;
        }

        //转换目录，直接返回真实PATH（中间有灰度PATH）
        public static string GetFilePathGrayAll(string filepath)
        {
            if (filepath == null || filepath.Length == 0)
                return "";

            //灰度
            // if (FileExist(App3.GetInstance().GetGrayPath() + filepath, DirectoryType.WritePath))
            // {
            //     return GetWriteGrayPath(filepath);
            // }else 
            if (FileExist(filepath, DirectoryType.WritePath))
            { 
                //写
                return GetWritePath(filepath);
            }else if (FileExist(filepath, DirectoryType.ReadPath))
            {
                //读
                return GetReadOnlyPath(filepath);
            }

            return "";
        }


        //写目录 验证  灰度
        public static string GetFilePathGrayWrite(string filepath)
        {
            if (filepath == null || filepath.Length == 0)
                return "";

            // //灰度
            // if (FileExist(App3.GetInstance().GetGrayPath() + filepath, DirectoryType.WritePath))
            // {
            //     return GetWriteGrayPath(filepath);
            // }
            // else 
            if (FileExist(filepath, DirectoryType.WritePath))
            {
                //写
                return GetWritePath(filepath);
            }

            return "";
        }


        // public static string GetGaryPath(string filepath)
        // {
        //     return GetWriteDir() + App3.GetInstance().GetGrayPath() + filepath;
        // }

        public static bool FileExist(string filepath)
		{
			string fullpath = "";
            return FileExist(filepath, ref fullpath);
		}

		public static bool FileExist(string filepath, ref string outFullPath)
		{
			do
			{
                if (filepath == null || filepath.Length == 0)
                    break;
         
                if (FileExist(filepath, DirectoryType.WritePath))
                {
                    outFullPath = GetWritePath(filepath);
                    return true;
                }

                if (FileExist(filepath, DirectoryType.ReadPath))
                {
                    outFullPath = GetReadOnlyPath(filepath);
                    return true;
                }
                
			}while (false);
			
			return false;
		}

        public static bool FileExist(string filepath, DirectoryType type)
        {
            do
            {
                if (filepath == null || filepath.Length == 0)
                    break;

                if (type == DirectoryType.WritePath)
                {
                    if (File.Exists(GetWritePath(filepath)))
                        return true;
                }
               
                if (type == DirectoryType.ReadPath)
				{
#if ((UNITY_ANDROID && !UNITY_EDITOR))
                    if (fileSet != null && fileSet.Contains(filepath))
                        return true;        
#endif
					if (File.Exists(GetReadOnlyPath(filepath)))
                        return true;
                }
            } while (false);

            return false;
        }

        public static string FilePath(string filepath, DirectoryType type)
        {
            string fullPath = "";

            if (filepath == null || filepath.Length == 0)
                return fullPath;

            if (type == DirectoryType.WritePath)
                fullPath = GetWritePath(filepath);
            if (type == DirectoryType.ReadPath)
                fullPath = GetReadOnlyPath(filepath);

            return fullPath;

        }

        public static bool Save(MemoryStream m, string path)
        {
            /* @ modify by hushuang
             * why do we first creat a temp file and rename it, it will cause two I/O operation
             */
            if (m != null)
            {
                string CompletePath = GetWritePath(path);
                //string tempPath = CompletePath + ".tmp";
                if (CreateFolderByFile(CompletePath))
                {
                    try
                    {
                        if (File.Exists(CompletePath))
                            File.Delete(CompletePath);
                        FileStream fs = File.Create(CompletePath);
                        fs.Write(m.GetBuffer(), Convert.ToInt32(m.Position), Convert.ToInt32(m.Length - m.Position));
                        fs.Flush();
                        fs.Close();
                        //return Rename(tempPath, CompletePath);
                        return true;
                    }
                    catch (System.Exception ex)
                    {
                        // Core.Unity.Debug.LogError(ex.ToString());
                    }
                }
            }
            return false;
        }

        public static bool Save(char[] buffer, string path)
        {
            /* @ modify by hushuang
             * why do we first creat a temp file and rename it, it will cause two I/O operation
             */
            if (buffer != null)
            {
                string CompletePath = GetWritePath(path);
                //string tempPath = CompletePath + ".tmp";
                if (CreateFolderByFile(CompletePath))
                {
                    try
                    {
                        if (File.Exists(CompletePath))
                            File.Delete(CompletePath);
                        FileStream fs = File.Create(CompletePath);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.Write(buffer);
                        sw.Flush();
                        sw.Close();
                        //return Rename(tempPath, CompletePath);
                    }
                    catch (System.Exception ex)
                    {
                        // Core.Unity.Debug.LogError(ex.ToString());
                    }
                }
            }
            return false;
        }

        public static bool CreateFolderByFile(string filepath)
        {
            bool result = false;
            do
            {
                int lastIndex = filepath.LastIndexOf('/');
                if (lastIndex == -1)
                {
                    // Core.Unity.Debug.LogWarning("CreateFolderByFile failed. not find '/'. filepath:" + filepath);
                    break;
                }
                string dir = filepath.Substring(0, lastIndex);
                try
                {
                    if (Directory.Exists(dir) == false)
                        Directory.CreateDirectory(dir);
                    result = true;
                }
                catch(System.Exception ex)
                {
                    // Core.Unity.Debug.LogWarning(ex.ToString());
                    break;
                }
            } while (false);
            return result;
        }

        public static bool Fremove(string path)
        {
            string CompletePath = GetWritePath(path);
            if (File.Exists(CompletePath))
            {
                try
                {
                    File.Delete(CompletePath);
                    return true;
                }
                catch (System.Exception ex)
                {
                    // Core.Unity.Debug.LogWarning(ex.ToString());
                }
            }
            return false;
        }

        private static bool Rename(string from, string to)
        {
            try
            {
                if (File.Exists(from) == false)
                    return false;
                if (File.Exists(to))
                    File.Delete(to);
                File.Move(from, to);
                return true;
            }
            catch (System.Exception ex)
            {
                // Core.Unity.Debug.LogError(ex.ToString());
            }
            return false;
        }

        //获取所有文件名
        public static List<string> GetFileName(string dirPath)
        {
            List<string> files = new List<string>();

            if (Directory.Exists(dirPath))
            {
                files.AddRange(Directory.GetFiles(dirPath));
            }

            return files;
        }

        //获取所有文件夹及子文件夹
        public static List<string> GetDirs(string dirPath)
        {
            List<string> dirs = new List<string>();

            string[] dirPaths = Directory.GetDirectories(dirPath);
            if (dirPaths.Length > 0)
            {
                foreach (string path in dirPaths)
                {
                    dirs.Add(path);
                    dirs.AddRange(GetDirs(path));
                }
            }

            return dirs;
        }

        //获取文件夹下所有文件， 包括子文件夹
        public static List<string> GetAllFileName(string rootPath)
        {
            List<string> dirs = new List<string>();

            dirs.Add(rootPath);
            dirs.AddRange(GetDirs(rootPath));
            string[] allDir = dirs.ToArray();

            List<string> files = new List<string>();
            foreach (object o in allDir)
            {
                files.AddRange(GetFileName(o.ToString()));
            }

            return files;
        }
	}
}
