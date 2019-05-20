using System;
using Core;
using UnityEngine;
using XLua;

namespace Mapz.Core
{
    public enum TimerTypes
    {
        Common = 1,
        Accurage_Time_Ignore_Loop = 2,
        Accurage_Time_Fill_Loop = 3
    }

    [LuaCallCSharp]
    public class Timer : BaseObject
    {

        public Action callback;
        public float interval = -1;
        public int loop = -1;
        public int type = (int)TimerTypes.Common;
        public float lastTime = 0.0f;
        public bool pause = false;

    }
}
