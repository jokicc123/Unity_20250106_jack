using UnityEngine;

namespace chang
{

    /// <summary>
    /// 屬性 property
    /// </summary>
    public class Class_7_1_Proprety : MonoBehaviour
    {

        #region  認識屬性
        //公開的變數:可以讓外部讀取與寫入
        public float moveSpeed = 3.5f;

        //私人的變數:不允許外部讀取與寫入
        private float turnSpeed = 1.0f;

        //公開屬性:允許存取
        public float runSpeed { get; set; }

        //私人屬性:不允許存取
        private float SprinSpeed { get; set; }

        //公開的屬性:只有get代表唯獨(只能讀取不能寫入)
        public float jumpSpeed { get; }


        //prop + Tab* 2
        //有預設的屬性
        public byte lv { get; set; } = 1;

        private void Awake()
        {
            Debug.Log("-----取得變數屬性------");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log(runSpeed);
            Debug.Log(SprinSpeed);
            Debug.Log(jumpSpeed);
            Debug.Log("-----設定變數屬性------");
            moveSpeed = 11.1f;
            turnSpeed = 2.5f;                     //私人變數在類別內可以設定
            runSpeed = 30;
            SprinSpeed = 60.2f;
            //jumpSpeed =90;                       //沒有 set的屬性類別內也無法設定
            lv = 10;

        }
        #endregion

        //屬性縮寫
        public float hp { get; set; } = 100;

        //屬性標準寫法
        //_mp用來裝屬性 mp 值的容器
        private float _mp = 50;
        //屬性是給予外部存取權限的窗口
        public float mp
        {

            get
            {

                return _mp;
            }
            set
            {

                _mp = value;
            }

        }
        //取得屬性的簡寫(箭頭=> Labda)
        //唯獨屬性 防禦值是30 
        public int defence { get; } = 30;
        //唯獨屬性 攻擊值是50
        public int attack => 50;
        private void Start()
            {
            Debug.Log($"<color=#77f>魔力:{mp}</color>");
            mp = 500;
            Debug.Log($"<color=#77f>魔力:{mp}</color>");
            }
    
    }
}

