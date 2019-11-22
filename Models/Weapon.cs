using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusterPoint.Models
{
    public class Weapon
    {
        public int WeaponID { get; set; }
        public string Game { get; set; }
        public int Edition { get; set; }
        public string WeaponName { get; set; }
        public int WeaponCost { get; set; }
        public string WeaponPower { get; set; }
        
        public int NumberOfProfiles { get; set; }

        // set up one of the parameters for this class with the following information
        public string WeaponRange { get; set; }
        public string WeaponType { get; set; }
        public string NumberOfShots { get; set; }
        public string WeaponStrenght { get; set; }
        public string WeaponAp { get; set; }
        public string WeaponDamage { get; set; }
        public string WeaponRules { get; set; }


    }
}
