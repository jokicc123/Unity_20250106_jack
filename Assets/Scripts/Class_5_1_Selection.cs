using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//命名空間:
//將類別分類，類似倉庫的概念。不同倉庫可以有相同名稱類別。
//語法:namespace 命名空間名稱{內容}
namespace chang
{
    /// <summary>
    /// 選取陳述式 Selection statement
    /// 1.if判斷式
    /// 2.Switch判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour

    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp = 100;
        [SerializeField, Header("武器")]
        private string weapon;
        private void Awake()
        {
            //if判斷式
            //if(布林值){陳述式}
            if (true)
            {
                Debug.Log("當布林值為 True會執行這裡");
            }
            //快速完成:輸入if選取if陳述式按Enter或Tab
            // if (false)
            // {
            //     Debug.Log("2當布林值為 Flase 不會執行這裡而且會有綠蚯蚓");
            //  }

        }


        //更新事件:一秒鐘執行約60次(60FPS)Frame Per Second
        private void Update()
        {
            //常用快捷鍵
            //1.格式化(排版 ctrl + +k d
            //2.程式碼片段 Ctrl + k s

            #region 判斷式if
            Debug.Log("<color=#f79>更新事件</color>");
            //如果is Open 布林值等於True  已經開門，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            //否則is Open 布林值等於False，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }
            //比較運算子，邏輯運算子結果為布林值
            //如果 分數>=60就通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的c#課程過了</color>");
            }
            //否則 如果分數>=40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f33>你可以補考了</color>");
            }
            //否則 如果分數>=20 可以補考但要製作小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f33>可以補考但要做一個C#小專題了</color>");
            }
            //否則當掉
            else
            {
                Debug.Log("<color=#f33>你的c#課程被當了</color>");
            }
            #endregion
            #region 判斷式
            //switch 判斷式
            //switch(要判斷的值){陳述式}
            //快速完成:Switch + Tab *2
            switch (weapon)
            {
                //case值:
                //當判斷的值等於值時換執行這裡
                //break:跳出判斷式
                //如果武器等於小刀，攻擊力等於20
                //蝴蝶刀跟小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#f93>攻擊力:20</color>");
                    break;
                case "榴槤":
                    Debug.Log("<color=#f93>攻擊力:999</color>");
                    break;
                case "香蕉":
                    Debug.Log("<color=#f93>攻擊力:10</color>");
                    break;

                //當weapon 的值不等於上面的所有值執行這裡
                default:
                    Debug.Log("<color=#f93這不是能用的武器</color>");
                    break;

            }
            #endregion




            if (hp >= 10)
            {
                Debug.Log("<color=#3f3>快死掉了</color>");

            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#3f3>警告快喝水</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#3f3>健康狀況出問題</color>");
            }
            else if (hp >= 80)
            {
                Debug.Log("<color=#3f3>血量安全</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>你已經死了</color>");
            }


            if (hp >= 80)
            {
                Debug.Log("<color=#3f3>快死掉了</color>");

            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#3f3>警告快喝水</color>");
            }
            else if (hp >=40)
            {
                Debug.Log("<color=#3f3>健康狀況出問題</color>");
            }
            else if (hp >=10)
            {
                Debug.Log("<color=#3f3>血量安全</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>你已經死了</color>");
            }
        }

    }
}



