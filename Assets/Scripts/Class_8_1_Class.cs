using UnityEngine;
namespace chang 
{   

    /// <summary>
    /// 類別Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        //類別
        //用來定義一個物件以及擁有他的資料與功能(成員)

        private void Awake()
        {
            //實例化NPC並儲存讚npcJack變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("傑克");
            Class_8_1_NPC npcKID = new Class_8_1_NPC("KID", "你好啊~");

            npcJack.LogName();
            npcJack.LogName();
            npcKID.Talk();
            npcJack.Talk();

        }
    }

}

