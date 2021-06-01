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
        private readonly List<string> prizedPossesion = new List<string>()
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
        private readonly List<string> backstoryBase = new List<string>()
        {
            {"Fill in holes" }
        };

        public void CompileStories()
        {
            
        }

        public string HomeTowns() { return homeTowns[lib.RandomRoll(homeTowns.Count())]; }
        public string EnemyBase() { return enemyBase[lib.RandomRoll(enemyBase.Count())]; }
        public string TimeElapse() { return timeElapse[lib.RandomRoll(timeElapse.Count())]; }
        public string FantasyLocation() { return fantasyLocation[lib.RandomRoll(fantasyLocation.Count())]; }
        public string SomethingToFightFor() { return somethingToFightFor[lib.RandomRoll(somethingToFightFor.Count())]; }
        public string PrizedPossesion() { return prizedPossesion[lib.RandomRoll(prizedPossesion.Count())]; }
        public string NameOfCoolWeapon() { return nameOfCoolWeapon[lib.RandomRoll(nameOfCoolWeapon.Count())]; }
        public string NameOfCoolItem() { return nameOfCoolItem[lib.RandomRoll(nameOfCoolItem.Count())]; }
        public string CharacterRelative() { return characterRelative[lib.RandomRoll(characterRelative.Count())]; }

        
    }
}
