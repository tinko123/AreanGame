using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Mace : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        Random random = new Random();
        public Mace(string name)
        {
            double coef = random.NextDouble();
            Name = name;
            if (coef <= 0.1)
            {
                AttackDamage = 100;
            }
            else
            {
                AttackDamage = 20;
            }
            BlockingPower = 10;
        }
    }
}
