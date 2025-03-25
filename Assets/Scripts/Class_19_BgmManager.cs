using UnityEngine;
namespace chang.Class_19.Event
{
    /// <summary>
    ///  背景音樂管理器
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        //步驟3.訂閱事件(Unity習慣在Awake或Start訂閱)
        private void Awake()
        {
            //事件:輸入+=可以使用Tab自動完成>命名方法後>Enter完成
            class_19_event.onDead += ChangeBgm;
            class_19_event.onDeadAction += ChangeBgmViaHP;
            class_19_event.onEvent += ChnageBgmEvent;
            class_19_event.onEventWithHP += ChangeBgmEventWithHP; 
        }

        private void ChangeBgmEventWithHP(object sender, float e)
        {
            LogSystem.LogwithColor($"發送事件者:{sender},參數:{e}", "#ff3");
        }

        private void ChnageBgmEvent(object sender, System.EventArgs e)
        {
            LogSystem.LogwithColor($"發送事件者:{sender},參數:{e}", "#ff3");
        }

        private void ChangeBgmViaHP(string arg1,float arg2)

        {
            LogSystem.LogwithColor($"{arg1},|血量:{arg2}","#78f");
            if(arg2<=5)LogSystem.LogwithColor("變更為遊戲結束音樂", "#777");
        }


        private void ChangeBgm()
        {
            LogSystem.LogwithColor("變更音樂", "#3f3");
        }
    }

}
