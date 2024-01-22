using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev9pr.Classes
{
    public class Warrior2 : Warrior
    {
        public Warrior2(int health, int armor, float damage) : base(health, armor, damage)
        {

        }
        public override void damage()
        {
            Health -= 5;
            if (Armor > 0)
            {
                Armor = Health - 10;
            }
            
        }
    }
}
