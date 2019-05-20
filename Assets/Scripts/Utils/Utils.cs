
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Security.Cryptography;

namespace Core.Utils
{
    public class Utils
    {
        //得到1970年的时间戳
        public static DateTime startTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

        // 获取1970年以来的秒数,最常用
        public static long GetTimeSeconds()
        {
            DateTime nowTime = DateTime.Now;
            return (long)((nowTime - startTime).TotalSeconds);
        }

        // 通过秒数得到时间的字符串,格式2012/8/4 12:32
        public static string GetDateStringBySecond(long second)
        {
            DateTime dt = new DateTime(second * 1000 * 1000 * 10 + startTime.Ticks);
            return dt.GetDateTimeFormats('g')[0].ToString();
        }

        //返回date对象
        public static DateTime GetDateObject(long second)
        {
            DateTime dt = new DateTime(second * 1000 * 1000 * 10 + startTime.Ticks);
            return dt;
        }

        /// <summary>
        /// 计算角色移动速度
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public static float CalculateActorSpeed(Vector3 p1, Vector3 p2, float deltaTime)
        {
            if (deltaTime <= 0)
            {
                return -1;
            }
            float distance = Vector3.Distance(new Vector3(p1.x, 0, p1.z), new Vector3(p2.x, 0, p2.z));
            return distance / deltaTime;
        }
        /// <summary>
        /// 计算起点到终点距离指定长度的插值
        /// </summary>
        /// <param name="p1"></param> 
        /// <param name="p2"></param>
        /// <param name="reduceDistance"></param>
        /// <returns></returns>
        public static Vector3 GetLerp(Vector3 p1, Vector3 p2, float reduceDistance)
        {
            float distance = Vector3.Distance(p1, p2);
            float lerp = (distance - reduceDistance) / distance;
            return Vector3.Lerp(p1, p2, lerp);
        }

        /// <summary>
        /// MD5转换方法
        /// </summary>
        public static string MD5(string toCryString)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            string md5 = BitConverter.ToString(hashmd5.ComputeHash(Encoding.Default.GetBytes(toCryString)));
            return md5.Replace("-", "");
        }

        public static void MD5(byte[] buffer, out ulong md51, out ulong md52)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] outData = hashmd5.ComputeHash(buffer);
            md51 = BitConverter.ToUInt64(outData, 0);
            md52 = BitConverter.ToUInt64(outData, 8);
        }

        //根据名字获取某个节点的子节点transform
        public static Transform GetChildTransformByName(Transform parent, string name)
        {
            Component[] componentArray = parent.GetComponentsInChildren(typeof(Transform));
            for (int i = 0; i < componentArray.Length; i++)
            {
                Transform t = (Transform)componentArray[i];
                //Core.Unity.Debug.Log(name + " ?= "+t.name);
                if (string.Compare(name, t.name) == 0)
                {
                    //Core.Unity.Debug.Log("string.Compare: " + t.name);
                    return t;
                }
            }
            return null;
        }

        //强路径检测 需要绝对匹配
        public static bool StrongFindPathCheck(Transform transform, string[] nameAry)
        {
            int nameIdx = nameAry.Length - 1;
            while (transform != null && nameIdx >= 0)
            {
                if (transform.name.Equals(nameAry[nameIdx]))
                {
                    transform = transform.parent;
                    --nameIdx;
                }
                else
                {
                    break;
                }
            }
            return nameIdx == -1;
        }

        //弱路径检测 只要有匹配就行
        public static bool WeakFindPathCheck(Transform transform, string[] nameAry)
        {
            int nameIdx = nameAry.Length - 1;
            while (transform != null && nameIdx >= 0)
            {
                if (transform.name.Equals(nameAry[nameIdx]))
                {
                    --nameIdx;
                }
                transform = transform.parent;
            }
            return nameIdx == -1;
        }
        public static TComponent FastFind<TComponent>(Core.NameCacheInterface<GameObject> objNameCache,
            GameObject current, string path) where TComponent : Component
        { 
            if (current == null)
            {
                return default(TComponent);
            }
            else
            {
                GameObject tempObj = null;
                TComponent com = null;
                if (null != objNameCache)
                {
                    tempObj = objNameCache.GetByName(path);
                    if (null != tempObj)
                    {
                        com = tempObj.GetComponent<TComponent>();
                    }

                    if (null != com)
                    {
                        return com;
                    } 
                } 

                Transform t = current.transform.Find(path);
                if (t != null)
                {
                    TComponent tcom = t.GetComponent<TComponent>();
                    if (tcom != null)
                    {
                        return tcom;
                    }
                }
 
                return Find<TComponent>(current, path); 
            }
        }

        //根据指定的路径查找某个节点的所有子节点
        public static TComponent Find<TComponent>(GameObject current, string path)
            where TComponent : Component
        {
            TComponent findCom = null;

            if (path != null && path.Length != 0)
            {
                TComponent[] coms = current.GetComponentsInChildren<TComponent>(true);

                string[] ary = path.Split('/');
                do
                {
                    if (ary.Length == 0) break;
                    if (ary.Length == 1)
                    {
                        for (int idx = 0, len = coms.Length; idx < len; ++idx)
                        {
                            if (coms[idx].name.Equals(ary[0]))
                            {
                                findCom = coms[idx];
                                break;
                            }
                        }
                        break;
                    }
                    if (findCom != null) break;
                    //strong name valid
                    for (int idx = 0, len = coms.Length; idx < len; ++idx)
                    {
                        if (coms[idx].name.Equals(ary[ary.Length - 1]))
                        {
                            if (StrongFindPathCheck(coms[idx].gameObject.transform, ary))
                            {
                                findCom = coms[idx];
                                break;
                            }
                        }
                    }
                    if (findCom != null) break;
                    //weak name valid
                    for (int idx = 0, len = coms.Length; idx < len; ++idx)
                    {
                        if (coms[idx].name.Equals(ary[ary.Length - 1]))
                        {
                            if (WeakFindPathCheck(coms[idx].gameObject.transform, ary))
                            {
                                findCom = coms[idx];
                                break;
                            }
                        }
                    }
                } while (false);
            }
            return findCom;
        }

        public static Camera FindCameraForName(string name)
        {
            /* error: this infomation will be update for the next frame
            Camera[] cams = Camera.allCameras;

            for (int i = 0; i < cams.Length; i++)
            {
                if (cams[i].name == name)
                    return cams[i];
            }
             */

            GameObject obj = GameObject.Find(name);
            if (obj)
                return obj.GetComponent<Camera>();

            return null;
        }

        public static string GetAbsulotePath(GameObject obj)
        {
            string path = obj.name;
            Transform preObj = obj.transform.parent;

            while (preObj != null)
            {
                path = preObj.gameObject.name + "/" + path;
                preObj = preObj.parent;
            }

            return path;
        }

        public static string GetFileNameByPath(string scenePath)
        {
            string name = null;
            if (scenePath != null && scenePath.Length > 0)
            {
                int pos0 = scenePath.LastIndexOf("/");
                int pos1 = scenePath.LastIndexOf(".");
                name = scenePath.Substring(pos0 + 1, pos1 - pos0 - 1);
            }
            return name;
        }

        private static int genID = 1000000;
        public static int GenID()
        {
            return genID++;
        }

        public static float GetTerrainHeight(float x, float z)
        {
            float height = 20f;

            Ray ray = new Ray(new Vector3(x, 100, z), Vector3.down);
            RaycastHit hit;

            // 判断点击地面移动
            if (Physics.Raycast(ray, out hit, 1000, ((int)1) << 10))
            {
                Vector3 point = hit.point;
                height = point.y;
            }
            //Core.Unity.Debug.Warn("cityscenescript GetHeight height:" + height);

            return height;
        }

        public static bool StringContainUpper(string text)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[A-Z]"))
                return true;

            return false;
        }

        /// <summary>
        /// 绑定后台计时服务 
        /// </summary>
        /// <param name="time">后台存在的时间(毫秒)</param>
        public static void BindService(int time)
        {
            //#if UNITY_ANDROID && !UNITY_EDITOR
            //			using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            //			{
            //				using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            //				{
            //					jo.Call("BindService",time);
            //				}
            //			}
            //#endif
        }
        /// <summary>
        /// 解绑后台计时服务
        /// </summary>
        public static void UnBindService()
        {
            //#if UNITY_ANDROID && !UNITY_EDITOR
            //			using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            //			{
            //				using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            //				{
            //					jo.Call("UnBindService");
            //				}
            //			}
            //#endif
        }

        public static void CheckGameObjectIsDestroyed(GameObject obj)
        {
            if(obj == null)
            {
                // var error = "access has been destroyed GameObject;lua " + Core.Unity.Debug.Get_Lua_Fun("debug.traceback");
// #if UNITY_EDITOR
//                 Core.Unity.Debug.LogError(error);
// #else
//                 Core.Unity.Debug.LogWarning(error);
// #endif
                
            }
        }
    }
}
