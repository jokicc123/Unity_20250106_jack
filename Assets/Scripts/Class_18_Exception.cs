using chang;
using System;
using Unity.VisualScripting;
using UnityEngine;
namespace cnang.Class_18
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18_Exception : MonoBehaviour

    {
        private void Awake()
        {
            #region  例外處理
            LogSystem.LogwithColor($"{Division(8, 4)}", "#f33");
            LogSystem.LogwithColor($"{Division(3, 9)}", "#f33");
            LogSystem.LogwithColor($"{Division(7, 0)}", "#f33");

            LogSystem.LogwithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogwithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogwithColor($"{GetScores(10)}", "#3f3");
            #endregion
            try
            {
                Damage(35);
                Damage(70);
            }
            catch (Exception e)
            {
                LogSystem.LogwithColor(e, "#fa9");

            }
            try
            {
                Cure(30);
                Cure(-10);
            }
            catch (CureValueLowerZeroException e)
            {
                LogSystem.LogwithColor(e.Message, "#7f3");

            }



        }



        


        #region  例外處理
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        private int? Division(int numberA, int numberB)
        {
            //可能發生例外的區域
            try
            {
                return numberA / numberB;         //發生例外
            }
            //捕捉到例外為(除以零)時會執行此區域
            catch (DivideByZeroException e)
            {
                LogSystem.LogwithColor($"分子不能為零| {e.Message} ", "#f99");
                return null;

            }
            //最後區域
            finally
            {
                LogSystem.LogwithColor("例外處理完畢", "#f73");
            }
        }

        private int[] scores = { 70, 91, 64, 53, 88 };
        private int? GetScores(int index)
        {
            try
            {

                return scores[index];
            }
            catch (DivideByZeroException)
            {

                LogSystem.LogwithColor("發生例外", "#f11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {

                LogSystem.LogwithColor($"發生例外|{e.Message}", "#f11");
                return null;

            }

        }
        [SerializeField]
        private GameObject enemy;



        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true);  //顯示敵人物件

            }
            catch (Exception e)          //Exception處理所有例外
            {
                LogSystem.LogwithColor($"發生例外|{e.Message}", "#f39");

            }
        }
        #endregion

        private float hp = 100;
        private void Damage(float damege)
        {
            hp -= damege;
            if (hp < 0)
            {
                //自訂例外
                throw new Exception("血量小於零");

            }
            else
            {
                LogSystem.LogwithColor($"血量:{hp}", "#93f");
            }
            

        }

        private void Cure(float cure)
        {
            if (cure < 0)
            {
                //throw new Exception("治療值低於零");
                throw new CureValueLowerZeroException("治療值低於零");
            }
            else
            {
                
                hp += cure;

            }
        }

    }



    public class CureValueLowerZeroException : Exception
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="message"></param>
        public CureValueLowerZeroException(string message) : base(message) { }  

    }




}



