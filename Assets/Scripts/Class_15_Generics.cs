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
            int numberA = 7, numberB = 9;
            LogSystem.LogwithColor($"數字A與B:{numberA}|{numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogwithColor($"數字A與B:{numberA}|{numberB}", "#f93");
           char charA ='嗨', charB = '嘿';
            LogSystem.LogwithColor($"字元A與B:{charA}|{charB}", "#3f3");
            SwapChar (ref charA, ref charB);
            LogSystem.LogwithColor($"字元A與B:{charA}|{charB}", "#3f3");
           object objA = 3.5f, objB = 7.7f;
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");
            SwapObject(ref objA, ref objB);
            LogSystem.LogwithColor($"物件A與B:{objA}|{objB}", "#3f3");
        }


        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
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
    }
}

