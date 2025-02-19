using UnityEngine;
namespace chang
{   
    /// <summary>
    /// 繼承 inherit
    /// </summary>
    public class Class_10_1_inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            LogSystem.LogwithColor($"哥布林1號的攻擊:{goblin1.attack}", "#f3d");
            var slimel = new Slime(3, 2);
            LogSystem.LogwithColor($"史萊姆1號的攻擊:{goblin1.attack}", "#f3d");

        }
    }

    public class Goblin
    {

        public int attack;
        public int defense;

        public Goblin(int _attack, int _defense)
        {
            
            attack = _attack;
            defense = _defense;

        }
}
          public class Slime : Goblin
          {
            public Slime(int _attack, int _defence) : base(_attack, _defence)
            { }


          }




    }






