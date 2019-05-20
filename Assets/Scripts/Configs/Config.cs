using UnityEngine;
using System.IO;
namespace Mapz
{
    public enum LaunchMode
    {
        Debug = 1,
        Release = 2,
    }
    public static class Config
    {
        public static LaunchMode m_launchMode = LaunchMode.Debug;

        public static string m_debugScriptRoot = Path.Combine(Core.Resource.FileUtil.GetParentDir(Application.dataPath),"_Scripts");
    }
}