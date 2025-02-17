using UnityEngine;
namespace chang
{
    /// <summary>
    /// 類別與結構的差異
    /// </summary>
    public class Class_8_3ClassAndStruct : MonoBehaviour
    {
        private void Awake()
        {
            // 3.空值:類別可以空值，結構不行
            Class_8_3_Class class1 = new Class_8_3_Class();   //有實例化
            //Class_8_3_Class class2 =null;                     //空值

            Class_8_3_Struct struct1 = new Class_8_3_Struct();  //有實例化
            //Class_8_3_Struct struct2 = null;                  //空值


            LogSystem.LogwithColor(class1.ToString(), "#f96");
            //LogSystem.LogwithColor(class2.ToString(), "#f96");
            LogSystem.LogwithColor(struct1.ToString(), "#f96");
            //LogSystem.LogwithColor(struct2.ToString(), "#f96");
        }

        private void Start()
        {
            //var不指定類型，可以儲存所有資料
            var testClass = new Class_8_4_Class("我是類別");
            var testStruct = new Class_8_4_Struct("我是結構");

            var testClass2 = new Class_8_4_Class("我是類別2");
            var testStruct2 = new Class_8_4_Struct("我是結構2");

            LogSystem.LogwithColor(testClass.name, "#79f");
            LogSystem.LogwithColor(testClass2.name, "#79f");
            LogSystem.LogwithColor(testStruct.name, "#79f");
            LogSystem.LogwithColor(testStruct2.name, "#79f");

            testClass2 = testClass;    //傳址: 這時候的class與class2指向同一個地址
             testStruct2 = testStruct;// 傳值: 這時候的struct與struct2指向同一個值

            //修改class或class2資料都會被同步
            testClass.name = "類別";
            LogSystem.LogwithColor(testClass.name, "#f79");
            LogSystem.LogwithColor(testClass2.name, "#f79");

            //修改struct或struct2資料不會被同步
            testStruct.name = "結構";
            LogSystem.LogwithColor(testStruct.name, "#f79");
            LogSystem.LogwithColor(testStruct2.name, "#f79");




        }

    }

    //類別:
    // 1.繼承:允許繼承
    // 2.建構子:可以有多建購子
    // 4.資料類型:參考型別 
    public class Class_8_3_Class : MonoBehaviour
    {
        public Class_8_3_Class()
        {
            

        }

        public Class_8_3_Class(int test)
        {
            
   
        }


      }


    //結構:
    //1.結構:不允許繼承
    //2.建構子:不能有無參數建構子
    // 4.資料類型:實值型別
    public struct Class_8_3_Struct
    {
        //public Class_8_3_Struct()
        //{


        //}


        public Class_8_3_Struct(int test)
        {

        }
    }


 } 
     


