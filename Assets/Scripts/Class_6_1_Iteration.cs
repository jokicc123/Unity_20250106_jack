using Unity.VisualScripting;
using UnityEngine;
namespace chang
{   /// <summary>
    /// ���йB�⳯�z��:�j��
    /// for�Bforeach�Bdo�Bwhile
    /// </summary>
    public class Class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {

            //�j��Цb�@���ʨƥ󤺨ϥ� Awake�BStart
            //while�j��:���L�Ȭ�true�ɷ|�������
            //while(���L��) {�{���϶�}
            //�L���j��:���L�Ȥ@���Otrue
            //�ŧi�ϰ��ܼƬ�i��0
            int i = 0;
            i = 5;  //����while�Pdo���t��
            //��i<5�N����{}
            while (i < 5)
            {
                Debug.Log($"<color=#f33>while�j��Ai:{i}</color>");
                // i���W(i+1)
                i++;
            }
            // do�j��:
            //do{�{���϶�}while(���L��)
            int j = 0;
            j = 5;    //����while�Pdo���t��
            do
            {
                Debug.Log($"<color=#f79>do �j��Aj:{j}</color>");
                j++;

            }
            while (j < 5);
            // for �j��:
            // for (��l�ȡA���L��;���N��){�{���϶�}
            for (int k = 0; k < 5; k++)
            {

                Debug.Log($"<color=#f78>for �j��Ak:{k}</color>");

            }

        } 

     }


}
