using UnityEngine;
namespace chang
{
    /// <summary>
    /// 資料轉換類型
    /// </summary>
    public class Class_9_2DataTypeSwitch :MonoBehaviour

    {
        private void Awake()
        {
            //隱式轉換:不需要另外宣告轉換類型
            //將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogwithColor(byte1, "#7f7");
            LogSystem.LogwithColor(byte1.GetType(), "#7f7");
            LogSystem.LogwithColor(int1, "#7f7");
            LogSystem.LogwithColor(int1.GetType(), "#7f7");
            //隱式轉換:將比較小的byte放到大的int
            int1 = byte1;
            LogSystem.LogwithColor(int1, "#7f7");
            LogSystem.LogwithColor(int1.GetType(), "#7f7");



            //顯示轉換: 需要宣告轉換類型
            //將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogwithColor(int2, "#7f7");
            LogSystem.LogwithColor(int2.GetType(), "#7f7");
            LogSystem.LogwithColor(byte2, "#7f7");
            LogSystem.LogwithColor(byte2.GetType(), "#7f7");
            //顯示轉換:將比較大的int放到小的byte
            //添加資料類型
            byte2= (byte)int2;
            LogSystem.LogwithColor(byte2, "#7f7");
            LogSystem.LogwithColor(byte2.GetType(), "#7f7");

            //浮點數轉為整數類別，小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0; 

            byte3= (byte)float1;
            LogSystem.LogwithColor(byte3, "#f77");
            
            //範圍較大的轉為範圍較小的會導致溢位
            int int3 = 257;
            byte byte4 = 0; 
            byte4 = (byte)int3;
            LogSystem.LogwithColor(byte4, "#f77");

            LogSystem.LogwithColor("--------------" ,"#f77");

        }



    }

}

