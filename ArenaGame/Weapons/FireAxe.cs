using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class FireAxe : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public double CriticalHitChance { get; private set; }
        protected Random random = new Random();

        public FireAxe(string name)
        {
            double coef = random.NextDouble();
            Name = name;
            CriticalHitChance = 0.1;
            if (coef <= CriticalHitChance)
            {
                AttackDamage = 20 * 2;
            }
            else
            {
                AttackDamage = 20;
            }
            BlockingPower = 10;
        }
    }
}
