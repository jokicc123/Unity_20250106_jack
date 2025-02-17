using UnityEngine;

namespace chang
{
    /// <summary>
    /// 練習類別
    /// </summary>
    public class Class_8_practice : MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_BOSS boosDeagon = new Practice_8_BOSS("龍獸", "龍之吐習", 2999);
            Practice_8_BOSS bossBird = new Practice_8_BOSS("列空座", "光速砲", 3999);

            Debug.Log($"<color=#f93>{boosDeagon.name},招式:{boosDeagon.skill}</color>");
            Debug.Log($"<color=#f93>{bossBird.name},招式:{bossBird.skill}</color>");



        }



    }



    public class Practice_8_BOSS
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_BOSS(string _name, string _skill, float _hp)
        {
            
            name = _name;
            skill = _skill;
            hp = _hp;
        }


    }
}
