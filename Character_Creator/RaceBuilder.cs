using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    //NEEDS SUBRACE REDONE
    class Dwarf : Character
    {
        public Dwarf()
        {
            _conScore += 2;
            _chaSpeed += 25;
            _chaAbilities.Add("Darkvision");
            _chaResistances.Add("Poison");
            _profWeapons.Add("Battleaxe");
            _profWeapons.Add("Handaxe");
            _profWeapons.Add("Light Hammer");
            _profWeapons.Add("Warhammer");
            List<string> dwarfToolOptions = new List<string>();
            dwarfToolOptions.Add("Smith's Tools");
            dwarfToolOptions.Add("Bewer's Supplies");
            dwarfToolOptions.Add("Manson's Tools");
            Random rnd = new Random();
            int dwarfToolOptionsRoll = rnd.Next(0, 3);
            _profTools.Add(dwarfToolOptions[dwarfToolOptionsRoll]);
            _profLanguages.Add("Common");
            _profLanguages.Add("Dwarvish");
            int subRaceRoll = rnd.Next(1, 3);
            if (subRaceRoll == 1)
            {
                _chaRace = "Hill Dwarf";
                _wisScore += 1;
                _maxHealth += 1;
            }
            if (subRaceRoll == 2)
            {
                _chaRace = " Mountain Dwarf";
                _strScore += 2;
                _profArmor.Add("Light");
                _profArmor.Add("Medium");
            }
        }
    }

    //NEEDS SUBRACE REDONE
    class Elf : Character
    {
        public Elf()
        {
            _dexScore += 2;
            _chaSpeed += 30;
            _chaAbilities.Add("Darkvision");
            _perceptionProf = true;
            _chaAbilities.Add("Fey Ancestry");
            _chaAbilities.Add("Trance");
            _profLanguages.Add("Common");
            _profLanguages.Add("Elvish");
            Random rnd = new Random(); ;
            int subRaceRoll = rnd.Next(1, 4);
            if (subRaceRoll == 1)
            {
                _chaRace = "High Elf";
                _intScore += 1;
                _profWeapons.Add("Longsword");
                _profWeapons.Add("Shortsword");
                _profWeapons.Add("Shortbow");
                _profWeapons.Add("Longbow");
                _profLanguages.Add(Library.RandomAllLanguage());
            }
            if (subRaceRoll == 2)
            {
                _chaRace = "Wood Elf";
                _profWeapons.Add("Longsword");
                _profWeapons.Add("Shortsword");
                _profWeapons.Add("Shortbow");
                _profWeapons.Add("Longbow");
                _chaSpeed += 5;
                _chaAbilities.Add("Mask of the Wild");
            }
            if (subRaceRoll == 3)
            {
                _chaRace = "Dark Elf (Drow)";
                _chaScore += 1;
                _chaAbilities.Add("Sunlight Sensitivity");
                _chaAbilities.Add("Drow Magic");
                _profWeapons.Add("Rapiers");
                _profWeapons.Add("Shortsword");
                _profWeapons.Add("Hand Crossbows");
            }
        }
    }

    //NOT DONE
    class Halfling : Character
    {
        public Halfling()
        {
            _dexScore += 2;
            _chaSpeed += 25;
            _chaAbilities.Add("Lucky");
            _chaAbilities.Add("Brave");
            _chaAbilities.Add("Halfling Nimbleness");
            _profLanguages.Add("Common");
            _profLanguages.Add("Halfling");
            

        }

    }
}
