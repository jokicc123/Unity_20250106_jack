using UnityEngine;

namespace chang.Class_15 
{
    /// <summary>
    /// 介面物件:實做介面的物件
    /// </summary>
    public class Class_15_InterfaceObject
    {

    }

    //介面的使用步驟
    //1:定義介面與介面成員
    //2:類別實做介面
    //3實做介面成員
    //步驟1.
    //帶有[使用]功能的介面，遊戲內可被使用的物品
    public interface IUse
    {
        //不用宣告法主體，不用寫大括號
        public void Use();
    }

    public interface IDestroy
    {
        
       public  void Destroy();
    }


    //步驟2.
    //C# 單一繼承，多重實做介面
    public class Weapon : IUse
    {
        public void Use()
        {
            LogSystem.LogwithColor("使用武器，施展武器技能", "#fa3");

        }
    }

    public class Potion : IUse,IDestroy
    
    {
        public void Destroy()
        {
            LogSystem.LogwithColor("藥水使用完畢，刪除", "#f11");
        }
        public void Use()
        {
            LogSystem.LogwithColor("使用藥水，恢復魔力", "#a3f");

        }


        public class Chest : IUse ,IDestroy

        {
            public void Destroy()
            {
                LogSystem.LogwithColor("寶箱使用完畢，刪除", "#f11");
            }
            public void Use()
            {
                LogSystem.LogwithColor("使用寶箱，獲得隨機道具", "#a3f");
            }
        }
    }

}
