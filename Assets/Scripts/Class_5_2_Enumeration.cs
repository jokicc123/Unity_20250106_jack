using UnityEngine;

public class Class_5_2_Enumeration : MonoBehaviour
{
    #region �{�ѦC�|���򥻥Ϊk
    //�C�|:�w�q�U�Կ�檺�ﶵ()�q�`���O���)
    //�y�k
    //�׹��� ����r enum�C�|�W��{�C�|�ﶵ}
    //�w�q�@�ӦC�|�A�W�٥s���u�`
    private enum Season
    {
        //�w�q�C�|�ﶵ
        Spring, Summer, Autumn, Winter
    }

    //�ŧi�ܼơA���欰�u�`�C�|�A�w�]�Ȭ��L��
    [SerializeField, Header("�u�`")]
    private Season season = Season.Summer;

    private void Awake()
    {
        //���o�C�|����(Get)��X��
        Debug.Log(season);
        //���o�C�|�ƪ���
        Debug.Log((int)season);
        //���o�C�|����(Set)�ק��
        season = Season.Winter;
        Debug.Log(season);
        //�z�L�ƭȳ]�w�C�|
        season = (Season)2;
        Debug.Log(season);
    }
    #endregion
    //�w�q�C�|���ƭ�
    /// <summary>
    /// �D��
    /// </summary>
    private enum Item 
    { 

        None=0,coin=1,RedWater=10,BiueWater=15,Chinken =30
    }



    [SerializeField,Header("�D��")]
    private Item item = Item.Chinken;

    //���涶��:Awake>Start>Update
    //�}�l�ƥ�:�b����ƥ�����@��(��l��)
    private void Start()
    {
        Debug.Log ((int)item);
    }
}
