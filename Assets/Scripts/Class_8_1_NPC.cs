using UnityEngine;
namespace chang 
{
    public class Class_8_1_NPC : MonoBehaviour
    {
        private string name;
        private string dialogue;
        //建構子:沒有傳回類別，名稱與類別相同的公開方法
        //預設建構子:沒有參數
        public Class_8_1_NPC()

        {

            Debug.Log("<color=#f3d>預設建構子</color>");

        }


        public Class_8_1_NPC(string _name) => name = _name;

        public Class_8_1_NPC(string _name,string _dialogue)
        {
            
           name = _name;
           dialogue = _dialogue;

            Debug.Log("<color=#f3d>有參數的建構子<color>");
           
        }




        public void LogName()
        {

            Debug.Log($"<color=#f3d>NPC的名稱:{name}</color>");
        }



        public void Talk() 
        {
            Debug.Log($"<color=#f3d>{dialogue}</color>");

        }
    }


}


