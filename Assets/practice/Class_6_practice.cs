using UnityEngine;

/// <summary>
/// 作業:陣列
/// </summary>
public class Class_6_practice : MonoBehaviour
{
    private string[,,] characterNames =
    {

         { { "皮卡丘", "雷丘", "小火龍" }, { "妙蛙種子", "列空座", "皮皮" } },

         { { "木妖", "巴洛古", "菇菇寶貝" }, { "嫩寶", "綠水靈", "藍水靈" } },

         { { "烏爾加特", "圖奇", "艾希" }, { "希格斯", "蓋倫", "路西恩" } }
     };

    private void Awake()
    {
        Debug.Log($"<color=#f6a>皮卡丘:{characterNames[0, 0, 0]}<color>");
        Debug.Log($"<color=#f6a>菇菇寶貝:{characterNames[1, 0, 2]}<color>");
        Debug.Log($"<color=#f6a>蓋倫:{characterNames[2, 1, 1]}<color>");

        Debug.Log($"<color=#f6a>第二夜第一排第三個:{characterNames[1, 0, 2]}<color>");
    }





}