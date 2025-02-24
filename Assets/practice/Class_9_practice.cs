using UnityEngine;

namespace chang
{

    /// <summary>
    /// 資料轉換類型
    /// </summary>
    public class Class_9_practice : MonoBehaviour   
    {
        private void Awake()
        {
            float number = 999.321f;
            sbyte byNumner = (sbyte)number;
            LogSystem.LogwithColor(byNumner, "6f6");
        }
    }
}

