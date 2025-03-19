using chang;
using UnityEngine;

namespace Chang.Class_19
{
    public class Class_19_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數和元組
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));

        }



        //將float當作參數
        private void Cure(float cure)
        {

            LogSystem.LogwithColor($"治癒的值:{cure}", "3f3");
        }

        //將元組做為參考值
        private void Card((string name, int index) card)
        {

            LogSystem.LogwithColor($"卡片:{card.name}|{card.index}", "3f3");
        }

        #endregion
        //委派:將方法當作參數
        //1.宣告委派:簽章(傳回與參數)
        // 宣告一個無傳回與無參數的委派
        private delegate void DelegateMehod();
        private delegate float Calculate(float numberA, float numberB);
        private delegate void DelegatCombine<T>(T a);
        //2.目標方法:簽章必須與委派相同
        #region  無傳回與無參數方法
        private void Test()
        {
            LogSystem.LogwithColor("測試", "#f3f");

        }
        private void Talk()
        {

            LogSystem.LogwithColor("哈囉，你好", "#f3f");
        }

        private void MagicCard()
        {

            LogSystem.LogwithColor("招喚小兵", "#f3f");
        }
        #endregion
        private float Add(float numberA, float number)
        {
            float result = numberA + number;
            LogSystem.LogwithColor(result, "#7ff");
            return result;

        }
        private float Sub(float numberA, float number)
        {
            float result = numberA - number;
            LogSystem.LogwithColor(result, "#7ff");
            return result;

        }
        private float Mul(float numberA, float number)
        {
            float result = numberA * number;
            LogSystem.LogwithColor(result, "#7ff");
            return result;

        }

        private void Combine<T>(T a)
        {
            LogSystem.LogwithColor(a, "#ff3");

        }

        // 3.宣告變數方法(預設為空值)
        private DelegateMehod delegateMehod;
        private Calculate calculate;
        private DelegatCombine<float> delegatCombineFloat;
        private DelegatCombine<int> delegatCombineInt;


        //4. 呼叫委派

        private void Start()
        {
            #region  基本委派
            delegateMehod = Test;   //將方法Test存放到變數 delegateMehod內
            delegateMehod = Talk;   //多播委派:一個委派存放多個方法，相同簽章
            delegateMehod += MagicCard;   //可添加多個方法
            delegateMehod -= Test;   //也可刪除方法
            delegateMehod();        //呼叫委派 
            #endregion

            calculate += Add;
            calculate -= Sub;
            calculate += Mul;
            calculate (10,3);
            calculate (100,70);

            CalcuteNumber(Sub, 3, 7);
            delegatCombineFloat = Combine<float>;
            delegatCombineFloat(3.5f);
            delegatCombineInt = Combine<int>;
            delegatCombineInt(999);
        }
        //委派:'將方法當作參數
        private void CalcuteNumber(Calculate calculate, float a, float b)
        {
            
            var result = calculate(a, b);
         

        }


    }   
  
    
} 





