using UnityEngine;
namespace chang 
{
    /// <summary>
    /// 元組
    /// </summary>
    public class Class_17_Tuple: MonoBehaviour 
    {
        private void Awake()
        {
            //元組:儲存多筆不同類型的資料
            //宣告方式1:指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 7);
            LogSystem.LogwithColor($"{card1.name}|消耗:{card1.cost}|編號:{card1.index}", "#f49");


            //宣告方式2:指定類型
            //取得元組資料使用Item1~ItemN
            (string, int, int) card2 = ("哥布林", 2, 23);
            LogSystem.LogwithColor($"{card2.Item1}|消耗:{card2.Item2}|編號:{card2.Item3}", "#f49");


            //宣告方式3:使用var
            var card3 = ("樹精", 4, 50);
            LogSystem.LogwithColor($"{card3.Item1}|消耗:{card3.Item2}|編號:{card3.Item3}", "#f49");

            //宣告方式4:使用var以及指名
            var card4 = (name: "蝙蝠", cost: 2, index: 6);
            LogSystem.LogwithColor($"{card4.name}|消耗:{card4.cost}|編號:{card4.index}", "#f49");

            UseCard(card1);
            UseCard(card2);
            UseCard(("暴龍",7,199));
            
            var card1Update=UpdateCardCost(card1);
            LogSystem.LogwithColor($"{card1Update.name}|" +
                $"消耗:{card1Update.cost}|編號:{card1Update.index}", "#f49");
            LogSystem.LogwithColor($"{card1Update == card1}", "#f79");
            LogSystem.LogwithColor($"{card1Update != card1}", "#f79");



        }

        /// <summary>
        /// 使用卡牌
        /// </summary>
        /// <param name="card">卡牌元組，名稱、消耗與編號</param>
        private void UseCard((string name, int cost, int index) card)
        {
            LogSystem.LogwithColor($"消耗{card.cost}使用卡牌:{card.name}", "#7f7");
        }
        private (string name, int cost, int index) UpdateCardCost((string name, int cost, int index) card)
        {
            card.name = card.name + "降低消耗版本";
            card.cost -= 1;
            return card;

        }
    }
}


