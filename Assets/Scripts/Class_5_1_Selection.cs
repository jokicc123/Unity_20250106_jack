using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//�R�W�Ŷ�:
//�N���O�����A�����ܮw�������C���P�ܮw�i�H���ۦP�W�����O�C
//�y�k:namespace �R�W�Ŷ��W��{���e}
namespace chang
{
    /// <summary>
    /// ������z�� Selection statement
    /// 1.if�P�_��
    /// 2.Switch�P�_��
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour

    {
        [SerializeField, Header("�O�_�}��")]
        private bool isOpen;
        [SerializeField, Header("����"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("��q"), Range(0, 100)]
        private int hp = 100;
        [SerializeField, Header("�Z��")]
        private string weapon;
        private void Awake()
        {
            //if�P�_��
            //if(���L��){���z��}
            if (true)
            {
                Debug.Log("���L�Ȭ� True�|����o��");
            }
            //�ֳt����:��Jif���if���z����Enter��Tab
            // if (false)
            // {
            //     Debug.Log("2���L�Ȭ� Flase ���|����o�̦ӥB�|����L�C");
            //  }

        }


        //��s�ƥ�:�@���������60��(60FPS)Frame Per Second
        private void Update()
        {
            //�`�Χֱ���
            //1.�榡��(�ƪ� ctrl + +k d
            //2.�{���X���q Ctrl + k s

            #region �P�_��if
            Debug.Log("<color=#f79>��s�ƥ�</color>");
            //�p�Gis Open ���L�ȵ���True  �w�g�}���A�N��ܤw�g�}��
            if (isOpen)
            {
                Debug.Log("<color=#f93>�w�g�}��</color>");
            }
            //�_�his Open ���L�ȵ���False�A�N��ܪ����F
            else
            {
                Debug.Log("<color=#f93>�����F</color>");
            }
            //����B��l�A�޿�B��l���G�����L��
            //�p�G ����>=60�N�q�L
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>���ߧA��c#�ҵ{�L�F</color>");
            }
            //�_�h �p�G����>=40 �i�H�ɦ�
            else if (score >= 40)
            {
                Debug.Log("<color=#f33>�A�i�H�ɦҤF</color>");
            }
            //�_�h �p�G����>=20 �i�H�ɦҦ��n�s�@�p�M�D
            else if (score >= 20)
            {
                Debug.Log("<color=#f33>�i�H�ɦҦ��n���@��C#�p�M�D�F</color>");
            }
            //�_�h��
            else
            {
                Debug.Log("<color=#f33>�A��c#�ҵ{�Q��F</color>");
            }
            #endregion
            #region �P�_��
            //switch �P�_��
            //switch(�n�P�_����){���z��}
            //�ֳt����:Switch + Tab *2
            switch (weapon)
            {
                //case��:
                //��P�_���ȵ���Ȯɴ�����o��
                //break:���X�P�_��
                //�p�G�Z������p�M�A�����O����20
                //�����M��p�M�@��
                case "�����M":
                case "�p�M":
                    Debug.Log("<color=#f93>�����O:20</color>");
                    break;
                case "�h��":
                    Debug.Log("<color=#f93>�����O:999</color>");
                    break;
                case "����":
                    Debug.Log("<color=#f93>�����O:10</color>");
                    break;

                //��weapon ���Ȥ�����W�����Ҧ��Ȱ���o��
                default:
                    Debug.Log("<color=#f93�o���O��Ϊ��Z��</color>");
                    break;

            }
            #endregion




            if (hp >= 10)
            {
                Debug.Log("<color=#3f3>�֦����F</color>");

            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#3f3>ĵ�i�ֳܤ�</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#3f3>���d���p�X���D</color>");
            }
            else if (hp >= 80)
            {
                Debug.Log("<color=#3f3>��q�w��</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>�A�w�g���F</color>");
            }


            if (hp >= 80)
            {
                Debug.Log("<color=#3f3>�֦����F</color>");

            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#3f3>ĵ�i�ֳܤ�</color>");
            }
            else if (hp >=40)
            {
                Debug.Log("<color=#3f3>���d���p�X���D</color>");
            }
            else if (hp >=10)
            {
                Debug.Log("<color=#3f3>��q�w��</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>�A�w�g���F</color>");
            }
        }

    }
}



