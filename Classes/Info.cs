using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev9pr.Classes
{
    public class Warrior
    {

        public int Health { get; set; }
        public int Armor { get; set; }
        public float Damage { get; set; }
        public Warrior(int health, int armor, float Damage)
        {
            Health = health;
            Armor = armor;
            this.Damage = Damage;
        }

        public virtual void damage()
        {

            Health -= Convert.ToInt32(Damage * 100f / (100f - Armor));
            Armor -= Convert.ToInt32(Damage * 100f / (100f - Armor));
        }
    }
}
