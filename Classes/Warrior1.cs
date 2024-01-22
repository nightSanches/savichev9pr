using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev9pr.Classes
{
    public class Warrior1 : Warrior
    {
        public Warrior1(int health, int armor, float damage) : base(health, armor, damage)
        {

        }
        public override void damage()
        {
            Health -= 10;
            if (Armor > 0)
            {
                Armor = Health - 2;
                if (Armor < 0)
                {
                    Armor = 0;
                }
            }
        }
    }
}
