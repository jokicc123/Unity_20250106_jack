using chang;
using UnityEngine;
using UnityEngine.U2D.IK;
namespace chang 
{
    public class Class_7_2_staticdata : MonoBehaviour
    {
        //���o�D�R�A��� (����)
        // 1.���w�q�n��o������O���ܼ�
        // 2.�z�L�ܼƨ��o�D�R�A���(����) 
        public Class_7_2_Static class_7_2;

        public void Awake()
        {
            //�ܼƦW��.�D�R�A����
            //���o�D�R�A�ܼ�
            Debug.Log($"<color=#f3d>�D�R�A�ܼ�:{class_7_2.invertoryWater}</color>");
            //���o�D�R�A�ݩ�
            Debug.Log($"<color=#f3d>�D�R�A�ݩ�:{class_7_2.skillMain}</color>");
            //�I�s�D�R�A��k
            class_7_2.Punch();
            //���O�W��.�R�A����
            //���o�R�A�ܼ�
            Debug.Log($"<color=#f3d>�R�A����:{Class_7_2_Static.invertoryProp}</color>");
            //���o�R�A�ݩ�
            Debug.Log($"<color=#f3d>�R�A����:{Class_7_2_Static.skillSecond}</color>");
            //�I�s�R�A��k
            Class_7_2_Static.Kick();



        }

        public Class_7_2_Slime slimeGreen, slimeBlue;

        private void Start()
        {
            //�D�R�A����
            slimeGreen.hp -= 10;
            Debug.Log($"<color=#3f3>��v�ܩiHP:{slimeGreen.hp}</color>");
            slimeBlue.hp -= 10;
            Debug.Log($"<color=#3f3>�ťv�ܩiHP:{slimeBlue.hp}</color>");

            //�R�A����
            //�R�A�����S��k�z�L����s��
            //slimeGreen.moveSpeed =3.5f;
            Class_7_2_Slime.moveSpeed = 3.5f;
            Debug.Log($"<color=#3f3>�v�ܩi���ʳt��:{Class_7_2_Slime.moveSpeed}</color>");



        }


    }
}

