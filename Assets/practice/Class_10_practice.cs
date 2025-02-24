using chang;
using UnityEngine;
namespace chamg
{
    /// <summary>
    /// 繼承
    /// </summary>
    public class Class_10_practice : MonoBehaviour
    {
        private void Awake()
        {
            var redPotion = new Potion("紅水");
            var bluePotion = new Potion("藍水");
            Equipment helmet = new Equipment("頭盔");
            redPotion.Use();
            bluePotion.Use(100);
            helmet.Use();
        }
    }
    public class Item
    {
        public string name;
        public Item(string _name) => name = _name;  

        public virtual void Use()
        {

            LogSystem.LogwithColor($"{name}道具，使用Item方法", "#f33");
        }

    }

    public class Potion : Item 
    {
        public Potion(string name) : base(name)
        {
        }


        public void Use(int increase)
        {
            LogSystem.LogwithColor($"{name}藥水，使用Potion方法，恢復量:{increase}", "#3f3");

        }

    }

    public class Equipment : Item 
    {
        public Equipment(string name) : base(name)
        { 
        }

        public override void Use()
        {

            LogSystem.LogwithColor($"{name}道具，使用Equipment方法", "#77f");

        }
    }


}
