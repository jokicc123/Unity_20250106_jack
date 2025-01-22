using Unity.VisualScripting;
using UnityEngine;
namespace chang
{   /// <summary>
    /// 反覆運算陳述式:迴圈
    /// for、foreach、do、while
    /// </summary>
    public class Class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            #region while，do，for迴圈

            //迴圈請在一次性事件內使用 Awake、Start
            //while迴圈:當布林值為true時會持續執行
            //while(布林值) {程式區塊}
            //無限迴圈:布林值一直是true
            //宣告區域變數為i為0
            int i = 0;
            i = 5;  //測試while與do的差異
            //當i<5就執行{}
            while (i < 5)
            {
                Debug.Log($"<color=#f33>while迴圈，i:{i}</color>");
                // i遞增(i+1)
                i++;
            }
            // do迴圈:
            //do{程式區塊}while(布林值)
            int j = 0;
            j = 5;    //測試while與do的差異
            do
            {
                Debug.Log($"<color=#f79>do 迴圈，j:{j}</color>");
                j++;

            }
            while (j < 5);
            // for 迴圈:
            // for (初始值，布林值;迭代器){程式區塊}
            for (int k = 0; k < 5; k++)
            {

                Debug.Log($"<color=#f78>for 迴圈，k:{k}</color>");

            }
            #endregion
            // foreach迴圈
            // 資料結構:陣列、清單等等...
            //foreach(資料類型 資料名稱 in 資料結構) {程式區塊}
            string dialogue = "嗨，你好，我是npc~";

            foreach (var text in dialogue)
            {

                Debug.Log($"<color=#f63>{text}</color>");
            }

        }
       
     }


}
