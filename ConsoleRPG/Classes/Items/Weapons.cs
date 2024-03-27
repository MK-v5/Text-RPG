using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Classes.Characters;

namespace ConsoleRPG.Classes.Items
{
    class Weapons : Items
    {
        protected string weaponDescription;
        protected int sharpness;

        public string WeaponDescription
        {
            get => weaponDescription;
            protected set => weaponDescription = value;
        }

        public int Sharpness
        {
            get => sharpness;
            protected set => sharpness = value;
        }
    }

    class Sword : Weapons
    {
        public Sword(string weaponDesc, int sharpness)
        {
            weaponDescription = weaponDesc;
            this.sharpness = sharpness;
        }
    }
}
