using UnityEngine;
namespace chang
{    /// <summary>
     /// �R�A static
     /// </summary>
    public class Class_7_2_static : MonoBehaviour
    {
        //�D�R�A�ܼ�
        public int invertorywater = 10;
        //�R�A�ܼ�:�׹����᭱�K�[����rstatic
        //�R�A�ܼƤ���ܦb�ݩʭ��O�W
        public static int invertorypop = 20;

        private void Awake()
        {
            invertorywater = 7;
            invertorypop = 15;
            Debug.Log($"<color=#f31>�Ĥ�:{invertorywater}</color>");
            Debug.Log($"<color=#f31>�D��:{invertorypop}</color>");
        }
    }
}
