using UnityEngine;
namespace chang 
{
    /// <summary>
    /// 陣列
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        //皮卡丘、小火龍、傑尼龜
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        //陣列:用來儲存多筆相同類型的資料
        //低第一種:不指定值，透過unity 面板輸入
        //修飾詞:資料類型[]陣列名稱;
        public string[] cards;
        //第二種: 直接定義陣列數量
        //定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        //第二種:直接定義陣列的值
        public string[] deck2 = { "急棟鳥", "賭霞", "寶石海星" };

        //二維陣列
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };

        private void Start()
        {
            #region 一維陣列

            //存取陣列 Set,Get
            //Get 取得陣列的資料
            // 陣列名稱{編號}
            Debug.Log($"<color=#f32> 的第三張卡片:{cards[2]}</color>");
            //超出陣列範圍會導致錯誤
            //錯誤會導致當機，閃退，不符合預期的結果或者不執行下方程是
            //Debug.Log($"<color=f#32>的第四張卡片:{cards[3]}</color>");

            //Set 設定陣列的資料
            //陣列名稱[編號]指定 值;
            //將寶石海星換成傑尼龜
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f32> 的第三張卡片:{deck2[2]}</color>");
            #endregion

            //存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具:{inventory[0,1]}</color>");

            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[0,1]的道具:{inventory[0, 1]}</color>");
        }


    }


}

