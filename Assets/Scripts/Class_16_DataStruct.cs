using UnityEngine;
using System.Collections.Generic;            //有許多結構的命名空間

namespace chang.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        //[陣列
        public int[] attacks = { 1, 2, 3, };
        public float[] defens = { 1.5f, 3.5f, 5.5f };

        //清單，泛型
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;

        private void Awake()
        {
            #region  清單
            LogSystem.LogwithColor($"第三筆速度:{speeds[2]}", "#3f3");
            LogSystem.LogwithColor($"第一筆速度:{speeds[0]}", "#3f3");
            //添加一筆道具
            props.Add("寶劍");
            //刪除第一筆道具
            props.RemoveAt(0);
            //添加頭盔到編號1上
            props.Insert(1, "頭盔");
            foreach (var prop in props)
            {
                LogSystem.LogwithColor($"道具:{prop}", "#f93");

            }

            //使用建構子帶入陣列
            playerDefens = new List<float>(defens);
            //排序:由小到大
            playerDefens.Sort();
            //反排序:由大到小
            playerDefens.Reverse();


            foreach (var item in playerDefens)
            {
                LogSystem.LogwithColor($"資料:{item}", "#f93");

            }


            //count指清單內的資料，根據Add或Remove改變
            LogSystem.LogwithColor($"數量:{props.Count}", "#77f");
            //capcity指清單內的容量，系統自動分配，預設為4並且以倍數成長(C#各版本不同)
            LogSystem.LogwithColor($"容量:{props.Count}", "#77f");
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                LogSystem.LogwithColor($"數量:{numbers.Count}", "#3a3");
                LogSystem.LogwithColor($"容量:{numbers.Capacity}", "#f39");
            }

            #endregion
            #region  堆疊
            //堆疊:陷進後出，類似椅子堆在一起
            Stack<string> enemys = new Stack<string>();
            //放資料進入堆疊
            enemys.Push("史萊姆");
            enemys.Push("哥布林");
            LogStack<string>(enemys);
            //拿資料並且不移除
            enemys.Peek();
            LogStack<string>(enemys);
            //拿資料並移除
            enemys.Pop();
            LogStack<string>(enemys);
            //判斷是否包含某筆資料
            LogSystem.LogwithColor($"{enemys.Contains("哥布林")}", "#3f6");
            //清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);

        }
        private void LogStack<T>(Stack<T> stack)
        {
            LogSystem.LogwithColor("-------------", "#fff");
            foreach (var item in stack)
            {

                LogSystem.LogwithColor($"堆疊資料:{item}", "#f77");
            } 
            #endregion
            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");
            LogQueue<string>(player);
            //拿東西不刪除，與堆疊Peek相同
            LogSystem.LogwithColor(player.Peek(), "#f33");
            LogQueue<string>(player);
            //拿東西並刪除，與堆疊Pop相同
            LogSystem.LogwithColor(player.Dequeue(), "#f33");
            LogQueue<string>(player);
        }
     
        private void LogQueue<T> (Queue<T> queue)
        {
            LogSystem.LogwithColor("-------------", "#fff");

            foreach (var item in queue)
            {

                LogSystem.LogwithColor($"佇列資料:{item}", "#7f7");
            }
        }
       

           
          


           

    }  
}





    

