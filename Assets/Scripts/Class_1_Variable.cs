﻿
/*多行註解
 * 第二行註解
 * 第三行註解
 */
//引用unity游戲引擎的函示庫 (開發遊戲的程式集合,命名空間)
using UnityEngine;
// 修飾詞 類別關鍵字(腳本)類別名稱 腳本名稱
public class Class_1_variable : MonoBehaviour

{
    //程式內的括號都是成對出現的()[]{}<>''""
    // class{}此類別的程式內容

    //變數: 會改變的數值，用來存放遊戲或系統內的資訊
    //例如:砲車+90
    //定義一個記憶體的空間用來存放資訊

    //變數語法:
    //變數資料類型 變數名稱;
    //資料類型:告訴記憶體可以放入那些資料，例如:整數 int 可以放沒有小數值的數值
    //變數名稱:習慣用小寫開頭名稱，駝峰式命名，規則與腳本名稱相同
    //公開: 允許其他類別存取、顯示在屬性面板上 public
    //私人: 禁止其他類別存取、隱藏在屬性面板上 Private(預設)
    public int coin =500;
    private int level =3;
}

//類別外，不要將程式寫在這裡