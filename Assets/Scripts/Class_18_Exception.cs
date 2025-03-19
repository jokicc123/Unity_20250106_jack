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
            LogSystem.LogwithColor($"{Division(8, 4)}", "#f33");
            LogSystem.LogwithColor($"{Division(3, 9)}", "#f33");
            LogSystem.LogwithColor($"{Division(7, 0)}", "#f33");

            LogSystem.LogwithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogwithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogwithColor($"{GetScores(10)}", "#3f3");
            


        }


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
                LogSystem.LogwithColor("例外處理完畢","#f73");
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

    }
}



