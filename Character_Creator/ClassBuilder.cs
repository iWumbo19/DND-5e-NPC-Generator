using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class DwarfBarbarian : Dwarf
    {
        public DwarfBarbarian()
        {
            Random rnd = new Random();
            _chaClass = "Barbarian";
            _chaLevel = 1;
            _hitDie = 12;
            _currentHealth = rnd.Next(1, _hitDie + 1) + _conMod;
            _maxHealth = _currentHealth;
            if (!_profArmor.Contains("Light Armor")) { _profArmor.Add("Light Armor"); }
            if (!_profArmor.Contains("Medium Armor")) { _profArmor.Add("Medium Armor"); }
            if (!_profArmor.Contains("Shields")) { _profArmor.Add("Shields"); }
            if (!_profWeapons.Contains("Simple Weapons")) { _profWeapons.Add("Simple Weapons"); }
            if (!_profWeapons.Contains("Martial Weapons")) { _profWeapons.Add("Martial Weapons"); }
            _strProf = true;
            _conProf = true;
            string barbSkillProf1 = Library.RandomBarbSkill();
            string barbSkillProf2 = Library.RandomBarbSkill();
            if (barbSkillProf1 == barbSkillProf2 ^ AmIProficient(barbSkillProf1) ^ AmIProficient(barbSkillProf2))
            {
                while (barbSkillProf1 == barbSkillProf2 ^ AmIProficient(barbSkillProf1) ^ AmIProficient(barbSkillProf2))
                {
                    barbSkillProf1 = Library.RandomBarbSkill();
                    barbSkillProf2 = Library.RandomBarbSkill();
                }
            }
            CharacterProfGet(barbSkillProf1);
            CharacterProfGet(barbSkillProf2);
            _chaAbilities.Add("Rage");
            _chaAbilities.Add("Unarmored Defense");
            _chaAC = 10 + _dexMod + _conMod;
        }

    }

    class DwarfBard : Dwarf
    {
        public DwarfBard()
        {
            Random rnd = new Random();
            _chaClass = "Bard";
            _chaLevel = 1;
            _hitDie = 8;
            _currentHealth = rnd.Next(1, _hitDie + 1) + _conMod;
            _maxHealth = _currentHealth;
            _profArmor.Add("Light Armor");
            _profWeapons.Add("Simple Weapons");
            _profWeapons.Add("Hand Crossbows");
            _profWeapons.Add("Longswords");
            _profWeapons.Add("Rapiers");
            _profWeapons.Add("Shortswords");
            string instrumentOne = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
            string instrumentTwo = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
            string instrumentThree = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
            if (instrumentOne == instrumentTwo ^ instrumentTwo == instrumentThree ^ instrumentThree == instrumentOne)
            {
                while (instrumentOne == instrumentTwo ^ instrumentTwo == instrumentThree ^ instrumentThree == instrumentOne)
                {
                    instrumentOne = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
                    instrumentTwo = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
                    instrumentThree = Library.musicalInstruments[rnd.Next(Library.musicalInstruments.Count)];
                }
            }
            _profTools.Add(instrumentOne);
            _profTools.Add(instrumentTwo);
            _profTools.Add(instrumentThree);
            _dexProf = true;
            _chaProf = true;
            string bardSkill1 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
            string bardSkill2 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
            string bardSkill3 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
            if (bardSkill1 == bardSkill2 ^ bardSkill2 == bardSkill3 ^ bardSkill3 == bardSkill1)
            {
                while (bardSkill1 == bardSkill2 ^ bardSkill2 == bardSkill3 ^ bardSkill3 == bardSkill1)
                {
                    bardSkill1 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
                    bardSkill2 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
                    bardSkill3 = Library.skillCategories[rnd.Next(Library.skillCategories.Count)];
                }
            }
            CharacterProfGet(bardSkill1);
            CharacterProfGet(bardSkill2);
            CharacterProfGet(bardSkill3);
            _chaAC = 11 + _dexMod;

        }
    }
}
