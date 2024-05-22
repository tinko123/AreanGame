using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class IceStaff : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set;}

        public double BlockingPower { get; set; }
        public IceStaff(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 2;
        }
    }
}
