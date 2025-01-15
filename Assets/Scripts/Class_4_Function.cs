using System.Xml.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Progress;




/// <summary>/// 方法
/// 中文:方法、函式、函數、功能
/// 英文: function、method(unity)
/// </summary> 



public class Class_4_Function : MonoBehaviour
{

    private void Awake()
    {
        #region 方法基本語法與參數呼叫
        FirstFunction();
        FirstFunction();
        FirstFunction();
        //呼叫有參數的方法:小括號內要放入敵人對應數量的引數
        //UseSkill(); //錯誤:少了引數
        UseSkill("火球術", 30);
        UseSkill("冰錐術", 50);
        //呼叫有預設值參數的方法:可以不用填(選項式參數)
        SpawnEnemy();
        SpawnEnemy("史萊姆");
        Fire(700);
        Fire(800, "棒球");
        //有多個選擇時的呼叫
        //買紅水，50個
        BuyItem();
        //買紅水，30個
        //BuyItem(30);錯誤:30會直接帶入到item參數導致資料類型不符合
        BuyItem(count: 30);
        //買藍水，50個
        BuyItem("藍水");
        //買藍水，100個
        BuyItem("藍水", 100);
        #endregion
        //呼叫有傳回方法
        //第一種:把結果放到區域變數內
        int number9 = Square(9);
        int number7 = Square(7);

        //第二種:把傳回方法當作該傳回類型使用
        Debug.Log($"<color=#f93>7 的平方:{Square(7)}</color>");
        Debug.Log($"<color=#f93>160 的平方:{Square(7)}</color>");
        
        Debug.Log($"<color=#f93>160 {BMI(60,1.68f)}</color>");
        Debug.Log($"<color=#f93>160 {BMI(80, 1.75f)}</color>");
        Move();
        Move(50.5f);
    }
    //框選要整理的程式> ctrl+ k s >#region快速完成程式碼片段
    //方法:
    //包含一系列程式區塊
    //方法語法:
    //修飾詞 傳回資料類型 方法名稱() {程式區塊}
    //方法命名習慣:unity習慣使用大寫開頭命名方法
    // void 無傳回:使用此方法不會傳回資料
    //參數語法: 與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
        Debug.Log($"<color=#f93>施放技能:{cost}</color>");

    }
    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>施放技能:{enemy}</color>");
    }

    #region 沒有預設值的參數:必要參數，有預設值稱為選擇性參數
    //private void Fire(string fire = "子彈",int speed);
    //{
    //    Debug.Log($"<color=#f66>發射物件:{fire}，速度:{speed}</color>");
    //} 
    #endregion
    #region 發射物件方法
    /// <summary> 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="fire"></param>
    #endregion
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#f66>發射物件:{fire}，速度:{speed}</color>");
    }


    private void BuyItem(string item = "紅水", int count = 50)
    {

        Debug.Log($"<color=#f66>購買商品:{item}，數量:{count}</color>");
    }
   
    //傳回方法:傳回類型不適void，呼叫該方法會獲得的結果
    //傳回方法必需在{}內使用 return 關鍵字將結果傳回
    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private int Square(int number)
    {
        return number * number;
    }
    private float Square(float number)
    {
      return number* number;
    }
    /// <summary>
    /// BMI計算
    /// </summary>
    /// <param name="weight">體重:公斤</param>
    /// <param name="height">身高:公尺</param>
    /// <returns></returns>
    private float BMI(float weight, float height)
    {
        return weight / Square(height);
    }
    //名稱不能重複，類別，變數，方法
    private void Test() { }
    // private void Test() { }名稱重複的-錯誤

    //方法多載function overload
    //參數的類型或數量不同
    //零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log($"<color=#f66>移動中</color>");
    }
    //一個參數
    private void Move(float speed)
    {
        Debug.Log($"<color=#f66>移動中,速度:{speed}</color>");
    }

}

