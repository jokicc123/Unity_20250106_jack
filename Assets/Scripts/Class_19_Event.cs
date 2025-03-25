using System;
using UnityEngine;
namespace chang.Class_19.Event
{
    //事件使用步驟:
    //1.宣告事件(委派)
    //2.呼叫事件(什麼時間點要觸發)
    //3.其他系統訂閱事件
    /// </summary>
    public class Class_19_Event: MonoBehaviour
    {
      
        private float hp = 10;
        //步驟1.宣告事件(委派)
        public delegate void delegateMethod();
        //事件關鍵字:event
        public event delegateMethod onDead;
        public event Action<string, float> onDeadAction;
        //C#內建的事件:無參數、有參數
        public event EventHandler onEvent;
        public event EventHandler<float> onEventWithHP;

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Alpha1)) Damage(5);

        }

        private void Damage(float damage)
        {

            hp -= damage;
            if (hp <= 0)
            {
                LogSystem.LogwithColor("玩家死亡", "#f99");
                //步驟2.呼叫事件
                onDead?.Invoke();                   //?問號:判斷onDead如果有訂閱者才會呼叫

                onDeadAction?.Invoke("玩家",hp);   //事件有參數時呼叫要帶人
                onEvent?.Invoke(this, EventArgs.Empty); //呼叫內建事件必須要有兩個參數
                onEventWithHP?.Invoke(this, hp);  //呼叫內建事件有參數    

            }


        }
    }
}

