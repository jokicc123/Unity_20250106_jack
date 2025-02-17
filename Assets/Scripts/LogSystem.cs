using UnityEngine;

namespace chang
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class LogSystem
    {
       




        /// <summary>
        /// 輸出並指定顏色
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns>包含顏色的信息</returns>
        public static string LogwithColor(object message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result ;


        }
    }

}

