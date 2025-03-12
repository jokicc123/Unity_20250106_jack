using UnityEngine;
namespace chang.Class_15
{
    /// <summary>
    /// 泛型
    /// </summary>
    public class Class_15_Generics : MonoBehaviour
    {
       

        private void Awake()
        {

            #region  不使用泛型
            int numberA = 7, numberB = 9;
            LogSystem.LogwithColor($"數字A與B:{numberA}|{numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogwithColor($"數字A與B:{numberA}|{numberB}", "#f93");
            char charA = '嗨', charB = '嘿';
            LogSystem.LogwithColor($"字元A與B:{charA}|{charB}", "#3f3");
            SwapChar(ref charA, ref charB);
            LogSystem.LogwithColor($"字元A與B:{charA}|{charB}", "#3f3");
            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");
            SwapObject(ref objA, ref objB);
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");

            #endregion
           bool boolA = true, boolB = false;
            LogSystem.LogwithColor($"物件A與B:{boolA}|{boolB}", "#9f9");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogwithColor($"物件A與B:{boolA}|{boolB}", "#9f9");
            byte byteA = 1, byteB = 9;
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");

            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);
            
            var player2 = new DataPlayer<string>();
            player2.data = "玩家2號";
            player2.LogData("哈囉");



        }


        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        #region 方法區域
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;    //將第一個數字放去旁邊(暫存)
            a = b;           //將第二個放到第一個數字內
            b = temp;       //將旁邊的數字放到第二個數字 

        }


        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;

        }


        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;

        }



        public void Swap<T>(ref T a, ref T b)
        {

            T temp = a;
            a = b;
            b = temp;
        }
        #endregion



        private void Start()
        {
            var player = new Player();
            var enemy = new Enemy();
            var attackEvent = new AttackEvent<Player, Enemy>();
            attackEvent.Attack(player, enemy);
            var hp = new Hp();
            var attack = new Attack();
            hp.Increase(10.5f);
            attack.Increase(50);
            hp.Increase(3.75f);
            var checker = new ChenkValue<Hp, float>();
            checker.Check(hp);

        }

        #region  泛型類別
        public class DataPlayer<T>
        {
            public T data;

            public void LogData(T data)
            {

                LogSystem.LogwithColor(data, "3ff");

            }



        }


        public class Player { }
        public class Enemy { }
        public class AttackEvent<T, U>
        {
            public void Attack(T attacker, U defender)
            {
                LogSystem.LogwithColor($"{attacker}攻擊{defender}", "#f3f");

            }


        }
        #endregion
        #region 泛型介面
        //泛型介面
        public  interface Istat<T>
        {
            public T value { get; set; }     //該狀態的值
            public void Increase(T amount);  // 增加該狀態

        }
        public class Hp : Istat<float>
        {

            public float value { get; set; }
            public void Increase(float amount)
            {
                value += amount;
                LogSystem.LogwithColor($"血量:{value}", "#f3f");

            }
        }
        public class Attack : Istat<int>
        {


            public int value { get; set; }
            public void Increase(int amount)
            {
                value += amount;


                LogSystem.LogwithColor($"攻擊力:{value}", "#f3f");
            }
        }
        #endregion

        //泛型約束:泛型T必須實作IStat<T>介面
        public class ChenkValue<T,U> where T : Istat<U>
        {
            public void Check(T stat)
            {
                //添加約束後可以使用IStat<T>成員
                LogSystem.LogwithColor($"狀態的值:{stat.value}", "$3d3");

            }

        }

    }
}

