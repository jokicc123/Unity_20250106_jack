using UnityEngine;
namespace chang
{    /// <summary>
     /// 靜態 static
     /// </summary>
    public class Class_7_2_static : MonoBehaviour
    {
        //非靜態變數
        public int invertorywater = 10;
        //靜態變數:修飾詞後面添加關鍵字static
        //靜態變數不顯示在屬性面板上
        public static int invertorypop = 20;

        private void Awake()
        {
            invertorywater = 7;
            invertorypop = 15;
            Debug.Log($"<color=#f31>藥水:{invertorywater}</color>");
            Debug.Log($"<color=#f31>道具:{invertorypop}</color>");
        }
    }
}
