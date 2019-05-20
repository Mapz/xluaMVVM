using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mapz.Core;
using XLua;

namespace Mapz.Core.Component
{

    public class TimerManager : ManagerComponent

    {
        private static string go_name = "_TimerManager";
        private static TimerManager instance = null;
        public static TimerManager GetInstance()
        {
            if (instance == null)
            {
                UnityEngine.GameObject go = CreateGameObject(go_name);
                instance = go.AddComponent<TimerManager>();
            }
            return instance;
        }

        [LuaCallCSharp]
        public int Create(Timer timer)
        {
            if (timer.callback == null)
                return 0;
            if (timer.interval <= 0 || timer.loop == 0)
                return 0;
            if (!(timer.type == (int)TimerTypes.Common || timer.type == (int)TimerTypes.Accurage_Time_Ignore_Loop || timer.type == (int)TimerTypes.Accurage_Time_Fill_Loop))
                return 0;

            if (processingTimes)
            {
                needAddTimers.AddLast(timer);
            }
            else
            {
                updateTimers.Add(timer.GetPid(), timer);
            }

            return timer.GetPid();
        }

        [LuaCallCSharp]
        public void Remove(int timerId)
        {
            delayRemoveTimer.AddLast(timerId);
        }

        [LuaCallCSharp]
        private Timer GetTimer(int timerid)
        {
            Timer t = null;
            if (!updateTimers.TryGetValue(timerid, out t))
            {
                t = null;

                foreach (Timer tm in needAddTimers)
                {
                    if (tm.GetPid() == timerid)
                    {
                        t = tm;
                    }
                }
            }
            return t;
        }

        [LuaCallCSharp]
        public void Pause(int timerId, bool pause)
        {

            Timer t = GetTimer(timerId);
            if (null != t)
            {
                t.pause = pause;
            }

        }

        [LuaCallCSharp]
        public void Pause(bool pause)
        {
            Dictionary<int, Timer>.Enumerator e = updateTimers.GetEnumerator();
            while (e.MoveNext())
            {
                e.Current.Value.pause = pause;
            }

            foreach (Timer tm in needAddTimers)
            {
                tm.pause = pause;
            }
        }

        void Update()
        {
            LinkedListNode<int> ln = null;
            if (delayRemoveTimer.Count > 0)
            {
                ln = delayRemoveTimer.First;
                while (ln != delayRemoveTimer.Last)
                {
                    updateTimers.Remove(ln.Value);
                    ln = ln.Next;
                }

                updateTimers.Remove(delayRemoveTimer.Last.Value);

                delayRemoveTimer.Clear();
            }

            processingTimes = true;

            if (updateTimers.Count > 0)
            {
                Dictionary<int, Timer>.Enumerator e = updateTimers.GetEnumerator();
                Timer t = null;
                while (e.MoveNext())
                {
                    t = e.Current.Value;

                    if (t.pause)
                    {
                        continue;
                    }

                    ProcessTimer(t);

                    //remove
                    if (t.loop == 0)
                    {
                        needRemoveTimers.AddLast(e.Current.Key);
                    }
                }
            }

            processingTimes = false;

            LinkedListNode<Timer> lnT = null;
            if (needAddTimers.Count > 0)
            {
                lnT = needAddTimers.First;
                while (lnT != needAddTimers.Last)
                {
                    updateTimers.Add(lnT.Value.GetPid(), lnT.Value);
                    lnT = lnT.Next;
                }
                updateTimers.Add(needAddTimers.Last.Value.GetPid(), needAddTimers.Last.Value);

                needAddTimers.Clear();
            }


            if (needRemoveTimers.Count > 0)
            {
                ln = needRemoveTimers.First;
                while (ln != needRemoveTimers.Last)
                {
                    updateTimers.Remove(ln.Value);
                    ln = ln.Next;
                }

                updateTimers.Remove(needRemoveTimers.Last.Value);

                needRemoveTimers.Clear();
            }

        }


        void ProcessTimer(Timer t)
        {
#if LOG_TIMER_INFO
            Core.Unity.Debug.Log("process 1 " + UnityEngine.Time.deltaTime );
#endif
            if (t.lastTime + UnityEngine.Time.deltaTime >= t.interval)
            {
                float currentTime = t.lastTime + UnityEngine.Time.deltaTime;
                //process by type
                if (t.type == (int)TimerTypes.Common)
                {
                    int selfLoopCount = (int)Math.Floor(currentTime / t.interval);
                    t.lastTime = currentTime - selfLoopCount * t.interval;
                    if (t.loop > 0)
                    {
                        --t.loop;
                    }
#if LOG_TIMER_INFO
                    Core.Unity.Debug.Log(String.Format("process Common t.lastTime:{0} = currentTime:{1} - selfLoopCount:{2} * t.interval:{3};", t.lastTime, currentTime, selfLoopCount, t.interval));
#endif
                    CallTimer(t);
                }
                else if (t.type == (int)TimerTypes.Accurage_Time_Ignore_Loop)
                {
                    int selfLoopCount = (int)Math.Floor(currentTime / t.interval);
                    t.lastTime = currentTime - selfLoopCount * t.interval;
                    if (t.loop > 0) t.loop = t.loop - (selfLoopCount > t.loop ? t.loop : selfLoopCount);
#if LOG_TIMER_INFO
                    Core.Unity.Debug.Log(String.Format("process Accurage_Time_Ignore_Loop t.lastTime:{0} = currentTime:{1} - selfLoopCount:{2} * t.interval:{3};", t.lastTime, currentTime, selfLoopCount, t.interval));
#endif 
                    CallTimer(t);
                }
                else if (t.type == (int)TimerTypes.Accurage_Time_Fill_Loop)
                {
                    while (currentTime >= t.interval)
                    {
                        CallTimer(t);
                        currentTime = currentTime - t.interval;
                        if (t.loop > 0) --t.loop;
                        if (t.loop == 0) break;
                    }
                    t.lastTime = currentTime;
#if LOG_TIMER_INFO
                    Core.Unity.Debug.Log("process Accurage_Time_Fill_Loop " + t.lastTime);
#endif
                }
            }
            else
            {
                t.lastTime += UnityEngine.Time.deltaTime;
            }
        }

        void CallTimer(Timer t)
        {
            t.callback.Invoke();
        }


        Dictionary<int, Timer> updateTimers = new Dictionary<int, Timer>();

        //是否正在处理timer回调。
        private bool processingTimes = false;
        LinkedList<int> delayRemoveTimer = new LinkedList<int>();
        LinkedList<int> needRemoveTimers = new LinkedList<int>();
        LinkedList<Timer> needAddTimers = new LinkedList<Timer>();
    }


}