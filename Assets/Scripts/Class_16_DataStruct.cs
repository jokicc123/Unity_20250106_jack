using UnityEngine;
using System.Collections.Generic;            //有許多結構的命名空間

namespace chang.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        #region 清單

        //[陣列
        public int[] attacks = { 1, 2, 3, };
        public float[] defens = { 1.5f, 3.5f, 5.5f };

        //清單，泛型
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;

        #endregion
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
            #region  佇列
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
            #endregion
            #region 鏈結串列
            // LinkefList 鏈結串列
            string[] skillsArray = new string[] { "火球", "冰錐" };
            LinkedList<string> skills = new LinkedList<string>(skillsArray);
            LogLinkedList<string>(skills);
            skills.AddLast("落雷");
            LogLinkedList<string>(skills);
            skills.AddFirst("岩石");
            LogLinkedList<string>(skills);

            //在火球後面添加一個毒霧
            LinkedListNode<string> skillFire = skills.Find("火球");
            skills.AddAfter(skillFire, "毒霧");
            //在火球前面添加一個瞬移
            skills.AddBefore(skillFire, "瞬移");
            LogLinkedList<string>(skills);
            #endregion
            #region 排序集合
            //自動排序並且不重複的集合(由小到大排序)
            SortedSet<int> counts = new SortedSet<int> { 9, 20, 80, 1 };
            LogSortedSet<int>(counts);
            counts.Add(77);
            counts.Add(123);
            counts.Add(9);
            LogSortedSet<int>(counts);
            LogSystem.LogwithColor($"最大:{counts.Max}", "#f33");
            LogSystem.LogwithColor($"最大:{counts.Min}", "#f33");

            SortedSet<int> lv = new SortedSet<int> { 7, 3, 75, 123, 5, 80 };

            //交集與差集
            counts.IntersectWith(lv);
            LogSortedSet<int>(counts);
            counts.ExceptWith(lv);
            LogSortedSet<int>(counts);
            #endregion
            #region 字典
            //字典
            Dictionary<int, string> deck = new Dictionary<int, string>()
            {

                { 10,"真紅眼黑龍"},{ 3,"落穴"}, {1,"黑魔導" }
            };
            LogDictionary<int, string>(deck);
            deck.Add(7, "死者甦醒");
            LogSystem.LogwithColor($"是否有編號3資料:{deck.ContainsKey(3)}", "#f33");
            LogSystem.LogwithColor($"是否有編號3資料:{deck.ContainsValue("羽毛掃")}", "#f33");


            #endregion
            //保持排序並且不會有重複的鍵
            SortedList<string,int>board = new SortedList<string,int>();
            board.Add("Turtle", 90);
            board.Add("KID", 85);
            board.Add("Cherry", 85);
            //board.Add("Cherry", 77); //重複導致錯誤
            LogSortedList<string, int>(board);


            //保持排序的字典
            SortedDictionary<string,int>scores = new SortedDictionary<string,int>();
            scores.Add("Turtle", 80);
            scores.Add("KID", 85);
            scores.Add("Cherry", 85);
           // scores.Add("Cherry", 70); 重複導致錯誤
            LogSortedDictionary<string, int>(scores);

            //SortedList與SortedDictionary的差異
            //1.SortedList是使用陣列方式儲存，比較省記憶體空間
            //2.SortedDictionary是使用樹狀結構方式儲存，比較占記憶體空間
            //3.SortedList可以使用索引值儲存[0]
            LogSystem.LogwithColor($"排行第一筆:{board.Keys[0]}", "#f93");
            //LogSystem.LogwithColor($"排行第一筆:{scores.Keys[0]}", "#f93");

            //4.SortedList大量資料增減時比較占記憶體
            //如果不需要頻繁的增減建議使用SortedList反之建議使用SortedDictionary

        }



        private void LogQueue<T> (Queue<T> queue)
        {
            LogSystem.LogwithColor("-------------", "#fff");

            foreach (var item in queue)
            {

                LogSystem.LogwithColor($"佇列資料:{item}", "#7f7");
            }
        }
        private void LogLinkedList<T>(LinkedList<T> linkedList)
        {
            foreach (var item in linkedList)
            {

                LogSystem.LogwithColor(item, "#fa3");
            }
            LogSystem.LogwithColor("--------", "#fff");
        }
        private void LogSortedSet<T>(SortedSet<T> set)
        {
            foreach (var item in set)
            {

                LogSystem.LogwithColor(item, "#3f3");
            }
            LogSystem.LogwithColor("--------", "#fff");


        }
        private void LogDictionary<T, U>(Dictionary<T, U> dict)
        {

            foreach (var item in dict)
            {

                LogSystem.LogwithColor($"卡牌的編號:{item.Key}", "#3f3");
                LogSystem.LogwithColor($"卡牌的名稱:{item.Value}", "#3f3");
            }
            LogSystem.LogwithColor("--------", "#fff");
        }
        private void LogSortedList<T, U>(SortedList<T, U> list)
        {
            foreach (var item in list)
            {

                LogSystem.LogwithColor($"{item.Key}的分數{item.Value}", "#77f");
            }
            LogSystem.LogwithColor("--------", "#fff");
        }
        private void LogSortedDictionary<T, U>(SortedDictionary<T, U> dict)
        {
            foreach (var item in dict)
            {

                LogSystem.LogwithColor($"{item.Key}的分數{item.Value}", "#77f");
            }
            LogSystem.LogwithColor("--------", "#fff");
        }
    }  
}





    

