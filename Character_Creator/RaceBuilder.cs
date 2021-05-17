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
            Library lib = new Library();
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
            string subRaceRoll = lib.RandomDwarfSubrace();
            if (subRaceRoll == "Hill Dwarf")
            {
                _chaRace = "Hill Dwarf";
                _wisScore += 1;
                _maxHealth += 1;
            }
            if (subRaceRoll == "Mountain Dwarf")
            {
                _chaRace = "Mountain Dwarf";
                _strScore += 2;
                _profArmor.Add("Light");
                _profArmor.Add("Medium");
            }
        }
    }

    class Elf : Character
    {
        public Elf()
        {
            Library lib = new Library();
            _dexScore += 2;
            _chaSpeed += 30;
            _chaAbilities.Add("Darkvision");
            _perceptionProf = true;
            _chaAbilities.Add("Fey Ancestry");
            _chaAbilities.Add("Trance");
            _profLanguages.Add("Common");
            _profLanguages.Add("Elvish");
            string subRaceRoll = lib.RandomElfSubrace();
            if (subRaceRoll == "High Elf")
            {
                _chaRace = "High Elf";
                _intScore += 1;
                _profWeapons.Add("Longsword");
                _profWeapons.Add("Shortsword");
                _profWeapons.Add("Shortbow");
                _profWeapons.Add("Longbow");
                _profLanguages.Add(lib.RandomAllLanguage());
                _chaSpellList.Add(lib.RandomWizardCantrip());
            }
            if (subRaceRoll == "Wood Elf")
            {
                _chaRace = "Wood Elf";
                _profWeapons.Add("Longsword");
                _profWeapons.Add("Shortsword");
                _profWeapons.Add("Shortbow");
                _profWeapons.Add("Longbow");
                _chaSpeed += 5;
                _chaAbilities.Add("Mask of the Wild");
            }
            if (subRaceRoll == "Dark Elf (Drow)")
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

    class Halfling : Character
    {
        public Halfling()
        {
            Library lib = new Library();
            _dexScore += 2;
            _chaSpeed += 25;
            _chaAbilities.Add("Lucky");
            _chaAbilities.Add("Brave");
            _chaAbilities.Add("Halfling Nimbleness");
            _profLanguages.Add("Common");
            _profLanguages.Add("Halfling");
            string subRaceRoll = lib.RandomHalflingSubRace();
            if (subRaceRoll == "Lightfoot")
            {
                _chaRace = "Lightfoot Dwarf";
                _chaScore += 1;
                _chaAbilities.Add("Naturally Stealthy");
            }
            if (subRaceRoll == "Stout")
            {
                _chaRace = "Stout Dwarf";
                _conScore += 1;
                _chaAbilities.Add("Stout Resilience");
            }


        }

    }

    class Human : Character
    {
        public Human()
        {
            Library lib = new Library();
            _chaRace = "Human";
            _strScore += 1;
            _dexScore += 1;
            _conScore += 1;
            _wisScore += 1;
            _intScore += 1;
            _chaScore += 1;
            _chaSpeed += 30;
            _profLanguages.Add("Common");
            _profLanguages.Add(lib.RandomAllLanguage());
        }
    }

    class Dragonborn : Character
    {
        public Dragonborn()
        {
            Library lib = new Library();
            _chaScore += 1;
            _strScore += 2;
            _chaSpeed += 30;
            string ancestryRoll = lib.RandomDragonbornAncestry();
            if (ancestryRoll == "Black")
            {
                _chaResistances.Add("Acid");
                _chaAbilities.Add("Acid Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Blue")
            {
                _chaResistances.Add("Lightning");
                _chaAbilities.Add("Lightning Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Brass")
            {
                _chaResistances.Add("Fire");
                _chaAbilities.Add("Fire Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Bronze")
            {
                _chaResistances.Add("Lightning");
                _chaAbilities.Add("Lightning Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Copper")
            {
                _chaResistances.Add("Acid");
                _chaAbilities.Add("Acid Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Gold")
            {
                _chaResistances.Add("Fire");
                _chaAbilities.Add("Fire Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Green")
            {
                _chaResistances.Add("Poison");
                _chaAbilities.Add("Poison Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Red")
            {
                _chaResistances.Add("Fire");
                _chaAbilities.Add("Fire Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "Silver")
            {
                _chaResistances.Add("Cold");
                _chaAbilities.Add("Cold Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
            if (ancestryRoll == "White")
            {
                _chaResistances.Add("Cold");
                _chaAbilities.Add("Cold Breath");
                _profLanguages.Add("Common");
                _profLanguages.Add("Draconic");
            }
        }
    }

    class Gnome : Character
    {
        public Gnome()
        {
            Library lib = new Library();
            _intScore += 2;
            _chaSpeed += 25;
            _chaAbilities.Add("Darkvision");
            _chaAbilities.Add("Gnome Cunning");
            _profLanguages.Add("Common");
            _profLanguages.Add("Gnomish");
            string subRaceRoll = lib.RandomGnomeSubrace();
            if (subRaceRoll == "Forest Gnome")
            {
                _chaRace = "Forest Gnome";
                _dexScore += 1;
                _chaSpellList.Add("Minor Illusion");
                _chaAbilities.Add("Speak with Small Beasts");
            }
            if (subRaceRoll == "Rock Gnome")
            {
                _conScore += 1;
                _chaAbilities.Add("Artificer's Lore");
                _chaAbilities.Add("Tinker");
                _profTools.Add("Tinker's Tools");
            }
        }

    }

    class HalfElf : Character
    {
        public HalfElf()
        {
            Library lib = new Library();
            _chaScore += 2;
            _chaSpeed += 30;
            _chaAbilities.Add("Darkvision");
            _chaAbilities.Add("Fey Ancestry");
            string abilityRoll1 = lib.RandomAbilityCategory();
            string abilityRoll2 = lib.RandomAbilityCategory();
            string skillRoll1 = lib.RandomSkillCategory();
            string skillRoll2 = lib.RandomSkillCategory();
            if (abilityRoll1 == abilityRoll2)
            {
                while (abilityRoll1 == abilityRoll2)
                {
                    abilityRoll2 = lib.RandomAbilityCategory();
                }
            }
            if (skillRoll1 == skillRoll2)
            {
                while (skillRoll1 == skillRoll2)
                {
                    skillRoll2 = lib.RandomSkillCategory();
                }
            }
            RandomAbilityUpgrade(abilityRoll1);
            RandomAbilityUpgrade(abilityRoll2);
            CharacterProfGet(skillRoll1);
            CharacterProfGet(skillRoll2);
            _profLanguages.Add(lib.RandomAllLanguage());
        }
    }

    class HalfOrc : Character
    {
        public HalfOrc()
        {
            _strScore += 2;
            _conScore += 1;
            _chaSpeed += 30;
            _chaAbilities.Add("Darkvision");
            _intimidationProf = true;
            _chaAbilities.Add("Relentless Endurance");
            _chaAbilities.Add("Savage Attacks");
            _profLanguages.Add("Common");
            _profLanguages.Add("Orc");
        }
    }

    class Tiefling : Character
    {
        public Tiefling()
        {
            _intScore += 1;
            _chaScore += 2;
            _chaSpeed += 30;
            _chaAbilities.Add("Darkvision");
            _chaResistances.Add("Fire");
            _chaSpellList.Add("Thaumaturgy");
            _profLanguages.Add("Common");
            _profLanguages.Add("Infernal");
        }
    }



}
