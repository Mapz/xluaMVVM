using UnityEngine;
using Mapz.Core;
namespace Mapz
{
    public class GameEntry : MonoBehaviour
    {
        GameMain game;
        public static int mainThreadId = 0;

        void Start()
        {
            //{
            //    Thread t = new Thread(TestUncompress);

            //    //UnzipAssetFileOut.Instance().copyAssetFileOut("aaa/fight_scene.assetbundle.zip", "/sdcard/aaa/fight_scene.assetbundle.zip");

            //    UnzipAssetFileOut.Instance().initThreadNum(7);
            //    UnzipAssetFileOut.Instance().startExecuteTask();
            //    //for (int i = 1; i < 100; i++)
            //    //    UnzipAssetFileOut.Instance().addZipFile("aaa/s3d.assetbundle", "aaa/s3d.assetbundle.zip", "/sdcard/aaa/" + i);
            //    Thread.Sleep(10);
            //    t.Start();

            //    return;
            //}

            mainThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

            //屏幕常亮
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            UnityEngine.Object.DontDestroyOnLoad(this.gameObject);

            game = GameMain.GetInstance();
            game.Run();
        }


        void Awake()
        {
            Application.targetFrameRate = 30;//此处限定帧
        }
    }
}