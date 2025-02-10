using UnityEngine;
/// <summary>
/// 迴圈
/// </summary>

public class Class_5_practice : MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    private float hp = 100;

    private void Update()
    {
        switch (hp)
        {
            case >= 80:
                Debug.Log("<color=#68f>血量安全<color>");
                break;
            case >= 60:
                Debug.Log("<color=#3f3>健康狀態有疑慮<color>");
                break;
            case >= 40:
                Debug.Log("<color=#f39>警告，快喝水<color>");
                break;
            case >= 10:
                Debug.Log("<color=#f33>快死掉了<color>");
                break;
            case >= 0:
                Debug.Log("<color=#f11>你已經死了<color>");
                break;

        }
    }
}
