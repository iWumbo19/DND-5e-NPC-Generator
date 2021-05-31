using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class BackstoryGenerator
    {
        //Instanciates Different Libraries for Reference
        private readonly Library lib = new Library();
        private readonly NameGenerator names = new NameGenerator();

        private readonly List<string> backgroundOptions = new List<string>()
        {
            {"Acolyte" },
            {"Charlatan" },
            {"Criminal" },
            {"Entertainer" },
            {"Folk Hero" },
            {"Gladiator" },
            {"Guild Artisan" },
            {"Hermit" },
            {"Knight" },
            {"Noble" },
            {"Outlander" },
            {"Pirate" },
            {"Sage" },
            {"Sailor" },
            {"Soldier" },
            {"Urchin" }
        };
        private readonly List<string> backstoryBase = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> homeTowns = new List<string>()
        {
            {"Home Town 1" },
            {"Home Town 2" },
            {"Home Town 3" },
            {"Home Town 4" }
        };
        private readonly List<string> enemyBase = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> timeElapse = new List<string>()
        {
            {"Fill in holes" },
        };
        private readonly List<string> fantasyLocation = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> somethingToFightFor = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> prizedPosetion = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> nameOfCoolWeapon = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> nameOfCoolItem = new List<string>()
        {
            {"Fill in holes" }
        };
        private readonly List<string> characterRelative = new List<string>()
        {
            {"Fill in holes" }
        };
    }
}
