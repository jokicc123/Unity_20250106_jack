using UnityEngine;
namespace chang 
{
    /// <summary>
    /// �}�C
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        //�֥d�C�B�p���s�B�ǥ��t
        public string card1 = "�֥d�C", card2 = "�p���s", card3 = "�d���~";

        //�}�C:�Ψ��x�s�h���ۦP���������
        //�C�Ĥ@��:�����w�ȡA�z�Lunity ���O��J
        //�׹���:�������[]�}�C�W��;
        public string[] cards;
        //�ĤG��: �����w�q�}�C�ƶq
        //�w�q�@�ӵP��1�A�i�H�񤭱i�d�P
        public string[] deck1 = new string[5];
        //�ĤG��:�����w�q�}�C����
        public string[] deck2 = { "��ɳ�", "����", "�_�ۮ��P" };

        //�G���}�C
        public string[,] inventory = { { "�����Ĥ�", "�Ŧ��Ĥ�" }, { "���u", "����" } };

        private void Start()
        {
            #region �@���}�C

            //�s���}�C Set,Get
            //Get ���o�}�C�����
            // �}�C�W��{�s��}
            Debug.Log($"<color=#f32> ���ĤT�i�d��:{cards[2]}</color>");
            //�W�X�}�C�d��|�ɭP���~
            //���~�|�ɭP����A�{�h�A���ŦX�w�������G�Ϊ̤�����U��{�O
            //Debug.Log($"<color=f#32>���ĥ|�i�d��:{cards[3]}</color>");

            //Set �]�w�}�C�����
            //�}�C�W��[�s��]���w ��;
            //�N�_�ۮ��P�����ǥ��t
            deck2[2] = "�ǥ��t";
            Debug.Log($"<color=#f32> ���ĤT�i�d��:{deck2[2]}</color>");
            #endregion

            //�s���G���}�C
            Debug.Log($"<color=#3f3>�s��[0,1]���D��:{inventory[0,1]}</color>");

            inventory[1, 1] = "�n����";
            Debug.Log($"<color=#3f3>�s��[0,1]���D��:{inventory[0, 1]}</color>");
        }


    }


}

