﻿using UnityEngine;

namespace chang 
{

    /// <summary>
    /// 屬性
    /// </summary>
    public class Class_7_practice : MonoBehaviour
    {
        [SerializeField]
        private float _hp = 100;   


        public float hp 
        {
            get 
            {

                if (_hp <= 0) Debug.Log("<color=#f33>玩家角色死亡</color>");
                  return _hp;
            }
       

        }

        private void Update()
        {
            Debug.Log(hp);
        }
    }


}
