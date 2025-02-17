using UnityEngine;

namespace chang
{

    /// <summary>
    /// 裝箱Boxing與拆箱Unboxing
    /// </summary>
    public class Class_9_1Boxing: MonoBehaviour
    {
        //實值型別的資料類型
        //結構、列舉、整數、浮點數、布林值、字元
        //實執型別的資料會儲存在Stack記憶體內

        private int number = 100;

        //物件資料類型為參考型別
        private object box;
        private object boxNumber = 50;
        private int count;

        private void Awake()
        {
            //裝箱boxing
            //將實值型別資料到參考型別資料內

            box = number;
            LogSystem.LogwithColor(box.ToString(), "#f33");

            //拆箱Unboxing
            //將參考型別資料放到實值型別資料內
            //在前方添加(要轉換的資料類型)
            count = (int)boxNumber;

            LogSystem.LogwithColor(count.ToString(), "#f33");

        }

    }
}
