using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Dwarf : Character
    {
        public Dwarf()
        {
            _chaLevel = 1;
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
                _maxHealth += 1 * _chaLevel;
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
}
