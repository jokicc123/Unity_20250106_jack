using UnityEngine;
/// <summary>
/// 課程3:運算子
/// 補充:unity欄位屬性、unity事件
/// </summary>

public class Class_3_Operator : MonoBehaviour
{
    #region 基本欄位屬性
    //C#變數 = 欄位 Field
    //欄位屬性 Field Attritube
    [Header("等級")]
    public int lv = 1;
    //[提示(提示文字)]:在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過 100。")]
    public float moveSpeed = 2.5f;
    //[範圍(最小、最大)]:幫數值類型添加範圍(面板上改為滑桿)
    [Range(1, 100)]
    public byte count = 10;
    //範圍不能使用非數值類型上，會顯示"Use Range With..."
    [Range(0, 10)]
    public string weapon = "匕首";
    //[文字範圍(最小行，最大行)]:使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這是道具的描述、這是道具的描述、這是道具的描述";
    //多個欄位屬性
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力")]
    [Range(0, 100)]
    public float acttack = 30.5f;
    //[在屬性面板隱藏]:將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";
    [SerializeField]
    private float mp = 500;
    #endregion
    // 使用unity的事件
    // 1.必須在腳本後面添加 : MonoBehaviour(繼承)
    // 2.適用關鍵字快速完成，例如:輸入Awake挑選要使用的事件按Enter
    // 喚醒事件:播放遊戲後會執行的第一個事件，只執行一次
    // 事件名稱是藍色的(沒有變色不影響)
    private void Awake()
    {
        #region 輸出訊息
        //將小括號內的訊息輸出到unity的console控制台面板
        //ctrl+shift+c開啟控制台面板
        Debug.Log("Hollow，world");     //輸出文字
        Debug.Log(hp);                  // 輸出變數的值
        Debug.Log("攻擊力:" + acttack); //字串與變數
        Debug.Log($"攻擊力:{acttack}"); //$字串格式
        Debug.Log("攻擊力:{acttack }"); //沒有寫$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");
        //色碼:#紅紅綠綠藍藍，數值:0~9，a~f越右邊顏色越亮 #000黑 #fff白
        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>");

        #endregion
        #region 算數運算子
        //運算子
        //1.算術運算子
        //加、減、乘、除
        //+、-、*、%
        Debug.Log(10 + 3); // 13
        Debug.Log(10 - 3); // 7
        Debug.Log(10 * 3); // 30 
        Debug.Log(10 / 3); //  3
        Debug.Log(10 % 3); // 10/3=餘1、結果1
        Debug.Log("<color=#f93>---算數運算子:區域變數---</color>");
        //區域變數:僅在大括號內存取(不需要修飾詞的變數)
        float number1 = 10;
        float number2 = 3;



        Debug.Log(number1 + number2);
        Debug.Log(number1 - number2);
        Debug.Log(number1 * number2);
        Debug.Log(number1 / number2);  //3.333
        Debug.Log(number1 % number2);
        #endregion
        #region 比較運算子
        Debug.Log("<color=#f93>--比較運算子---</color>");
        int numberC = 100, numberD = 1;

        Debug.Log(numberC > numberD);   //C大於D     ，Flase
        Debug.Log(numberC < numberD);   //C小於D     ，Ture
        Debug.Log(numberC >=numberD);   //C大於等於D ，Ture
        Debug.Log(numberC <=numberD);   //C小於等於D ，Flase
        Debug.Log(numberC ==numberD);   //C大於D     ，Flase
        Debug.Log(numberC !=numberD);   //C不等於D   ，Ture
        #endregion
    }
}
