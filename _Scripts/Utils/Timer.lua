_TimerManager = CS.Mapz.Core.Component.TimerManager.GetInstance()
Timer = CS.Mapz.Core.Timer
local Create = _TimerManager.Create

TimerManager = {}
-- Action callback, float interval, int loop, int type, bool bpause
TimerManager.Create = function(callBack, interval, loop, type, bpause)
    local timer = Timer()
    timer.callback = callBack
    timer.interval = interval
    timer.loop = loop
    timer.type = type
    timer.pause = bpause
    return Create(_TimerManager, timer)
end

TimerTypes = {
    Common = 1,
    Accurage_Time_Ignore_Loop = 2,
    Accurage_Time_Fill_Loop = 3
}
