using UnityEngine;

public class Class_4_practice : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=#3f3>���L�� Ture:{ReturnTrue()}</color>");
        Debug.Log($"<color=#3f3>���L�� Flase:{ReturnFalse()}</color>");
    }




    private bool ReturnTrue()
    {
        return true;
    }


    private bool ReturnFalse()
    {
        return false;
    } 
}

