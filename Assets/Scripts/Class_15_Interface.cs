using UnityEngine;
using static chang.Class_15.Potion;
namespace chang.Class_15
{
    /// <summary>
    /// 介面Interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object invertoryFrist;
        public object invertorySecond;
        private void Awake()
        {
            int random = Random.Range(0, 3); //隨機0~3(不會出現3)
            LogSystem.LogwithColor($"隨機:{random}", "#f33");
            if (random == 0) invertoryFrist = new Prop();
            else if (random == 1) invertoryFrist = new Equipment();
            else if (random == 2) invertoryFrist = new Map();



            int randomSecond = Random.Range(0, 3); //隨機0~3(不會出現
            if (randomSecond == 0) invertorySecond = new Weapon();
            else if (randomSecond == 1) invertorySecond = new Potion();
            else if (randomSecond == 2) invertorySecond = new Chest();
        }

        

        private void Update()
        {
            //按下數字鍵1可以使用第一個物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {  //如果第一個是道具，就使用道具
                if (invertoryFrist is Prop) ((Prop)invertoryFrist).Use();
                //如果第一個是裝備，就使用裝備
                if (invertoryFrist is Equipment) ((Equipment)invertoryFrist).Use();
                //如果第一個是地圖，就使用地圖
                if (invertoryFrist is Map) ((Map)invertoryFrist).Use();
                //當遊戲的物品越多種的時候，這邊的判斷會很恐怖
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //如果第二格道具有實做介面就使用
                if (invertorySecond is IUse) ((IUse)invertorySecond).Use();
                //如果擴充物品，判斷式不需要添加，指需要讓物品都實做介面即可
                if (invertorySecond is IDestroy) ((IDestroy)invertorySecond).Destroy();
            }
        }



        public class Prop : MonoBehaviour
        {
            public void Use()
            {

                LogSystem.LogwithColor("使用道具，恢復體力", "f96");
            }
                    
        }

        public class  Equipment : MonoBehaviour
        {
            public void Use()
            {

                LogSystem.LogwithColor("使用裝備，裝到對應位置", "#9f6");


            }



        }
        public class Map : MonoBehaviour
        {
            public void Use()
            {

                LogSystem.LogwithColor("使用地圖，開啟地圖功能", "#96f");

            }


        }






    }
}

