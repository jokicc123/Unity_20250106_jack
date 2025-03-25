using UnityEngine;
using System.Linq; //引用LinQ命名空間
namespace chang.Class_19.LinQ
{
    /// <summary>
    /// LinQ 整合查詢語言 Language Integrated Query
    /// 查詢資料庫，所有程式語言共同技能
    /// </summary>
    public class Class_19_LinQ : MonoBehaviour

    {
        public int[] scores = { 90, 80, 77, 88, 93, 1, 5, 10, 35 };

        private void Awake()
        {
            //使用LinQ的關鍵字查詢資料
            //起手式:
            //from資料來源
            //select選取結果
            var queryAllData = from score in scores
                               select score;

            foreach (var item in queryAllData)
            {
                LogSystem.LogwithColor(item, "#3f3");
            }

            //情境:希望找到大於60分的玩家分數
            //Where篩選的條件
            //Orderby排序(預設從大到小)dscending由大到小
            var querySixty = from score in scores
                            where score >= 60
                             orderby score descending
                             select score;


            foreach (var item in querySixty)
            {
                LogSystem.LogwithColor(item, "#ff3");
            }

            //情境:篩選出分數為偶數的資料與奇數
            //group by
            var queryGroup = from score in scores
                            group score by score % 2 ;


            foreach (var group in queryGroup)
            {

                LogSystem.LogwithColor(group, "#f11");

                foreach (var item in group)
                {
                    LogSystem.LogwithColor(item, "#f79");
                }


                LogSystem.LogwithColor("-------------", "#79f");
            }

        }


    }
}

