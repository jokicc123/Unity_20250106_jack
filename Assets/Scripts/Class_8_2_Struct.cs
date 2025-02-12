using UnityEngine;
namespace chang 
{

    /// <summary>
    /// 結構
    /// </summary>
    public class Class_8_2_Struct : MonoBehaviour
    {
        private void Awake()
        {
            Class_8_2PlayerData Player1 = new Class_8_2PlayerData(2, 30);
            Class_8_2PlayerData Player2 = new Class_8_2PlayerData(5, 100);
        }

    }


}
