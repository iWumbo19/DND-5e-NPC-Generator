using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    static class Library
    {
        
        //Stat Number Translators
        static public Dictionary<int, int> levelProf = new Dictionary<int, int>()
        {
            {1,2 },
            {2,2 },
            {3,2 },
            {4,2 },
            {5,3 },
            {6,3 },
            {7,3 },
            {8,3 },
            {9,4 },
            {10,4 },
            {11,4 },
            {12,4 },
            {13,5 },
            {14,5 },
            {15,5 },
            {16,5 },
            {17,6 },
            {18,6 },
            {19,6 },
            {20,6 },
        };
        static public Dictionary<int, int> scoreMod = new Dictionary<int, int>()
        {
            {1,-5 },
            {2,-4 },
            {3,-4 },
            {4,-3 },
            {5,-3 },
            {6,-2 },
            {7,-2 },
            {8,-1 },
            {9,-1 },
            {10,0 },
            {11,0 },
            {12,1 },
            {13,1 },
            {14,2 },
            {15,2 },
            {16,3 },
            {17,3 },
            {18,4 },
            {19,4 },
            {20,5 },
            {21,5 },
            {22,6 },
            {23,6 },
            {24,7 },
            {25,7 },
            {25,8 },
            {26,8 },
            {27,9 },
            {28,9 },
            {29,10 },
            {30,10 },
        };
        static public Dictionary<string, int> classHitDie = new Dictionary<string, int>()
        {
            {"sorcerer",6 },
            {"wizard",6 },
            {"artificer",8 },
            {"bard",8 },
            {"cleric",8 },
            {"druid",8 },
            {"monk",8 },
            {"rouge",8 },
            {"warlock",8 },
            {"fighter",10 },
            {"paladin",10 },
            {"ranger",10 },
            {"barbarian",12 },
        };
        static public int SkillModMath(int rawScore, bool prof, int profBonus)
        {
            int returnScore = scoreMod[rawScore];
            if (prof == true)
            {
                returnScore += profBonus;
            }
            return returnScore;
        }
        
        //Lists of Specific Choices
        static public List<string> abilityCategories = new List<string>()
        {
            {"Strength" },
            {"Dexterity" },
            {"Constitution" },
            {"Wisdom" },
            {"Inteligence" },
            {"Charisma" }
        };
        static public List<string> skillCategories = new List<string>()
        {
            {"Acrobatics" },
            {"Animal Handling" },
            {"Arcana" },
            {"Athletics" },
            {"Deception" },
            {"History" },
            {"Insight" },
            {"Intimidation" },
            {"Invetigation" },
            {"Medicine" },
            {"Nature" },
            {"Perception" },
            {"Performance" },
            {"Persuasion" },
            {"Religon" },
            {"Slieght Of Hand" },
            {"Stealth" },
            {"Survival" }
        };
        static public List<string> barbSkillOptions = new List<string>()
            {
                {"Animal Handling" },
                {"Athletics" },
                {"Intimidation" },
                {"Nature" },
                {"Perception" },
                {"Survival" }
            };

        //Basic PHB Races/Classes
        static public List<string> raceList = new List<string>()
        {
            {"Dwarf" },
            {"Elf" },
            {"Halfling" },
            {"Human" },
            {"Dragonborn" },
            {"Gnome" },
            {"Half-elf" },
            {"Half-orc" },
            {"Tiefling" }
        };
        static public List<string> classList = new List<string>()
        {
            {"Barbarian" },
            {"Bard" },
            {"Cleric" },
            {"Druid" },
            {"Fighter" },
            {"Monk" },
            {"Paladin" },
            {"Ranger" },
            {"Rouge" },
            {"Sorcerer" },
            {"Warlock" },
            {"Wizard" }
        };

        //Lists containing PHB Subraces
        static public List<string> halflingSubRace = new List<string>()
        {
            {"Lightfoot" },
            {"Stout" }
        };
        static public List<string> dwarfSubRace = new List<string>()
        {
            {"Hill Dwarf" },
            {"Mountain Dwarf" }
        };
        static public List<string> elfSubRace = new List<string>()
        {
            {"High Elf" },
            {"Wood Elf" },
            {"Dark Elf (Drow)" }
        };
        static public List<string> dragonbornAncestry = new List<string>()
        {
            {"Black" },
            {"Blue" },
            {"Brass" },
            {"Bronze" },
            {"Copper" },
            {"Gold" },
            {"Green" },
            {"Red" },
            {"Silver" },
            {"White" }
        };
        static public List<string> gnomeSubRace = new List<string>()
        {
            {"Forest Gnome" },
            {"Rock Gnome" }
        };

        //Lists containing PHB languages
        static public List<string> standardLanguages = new List<string>()
        {
            {"Common" },
            {"Dwarvish" },
            {"Elvish" },
            {"Giant" },
            {"Gnomish" },
            {"Goblin" },
            {"Halfling" },
            {"Orc" }
        };
        static public List<string> exoticLanguages = new List<string>()
        {
            {"Abyssal" },
            {"Celestial" },
            {"Draconic" },
            {"Deep Speech" },
            {"Infernal" },
            {"Primordial" },
            {"Sylvan" },
            {"Undercommon" }
        };
        static public List<string> allLanguages = new List<string>()
        {
            {"Common" },
            {"Dwarvish" },
            {"Elvish" },
            {"Giant" },
            {"Gnomish" },
            {"Goblin" },
            {"Halfling" },
            {"Orc" },
            {"Abyssal" },
            {"Celestial" },
            {"Draconic" },
            {"Deep Speech" },
            {"Infernal" },
            {"Primordial" },
            {"Sylvan" },
            {"Undercommon" }
        };

        //Spell Compendium
        static public List<string> spellWizardCantrips = new List<string>
        {
            {"Acid Splash" },
            {"Chill Touch" },
            {"Dancing Lights" },
            {"Fire Bolt" },
            {"Light" },
            {"Mage Hand" },
            {"Mending" },
            {"Message" },
            {"Minor Illusion" },
            {"Poison Spray" },
            {"Prestidigitation" },
            {"Ray of Frost" },
            {"Shocking Grasp" },
            {"True Strike" }
        };



        ////Rolls on tables to generate random choosings of traits
        //Returns Languages
        static public string RandomAllLanguage()
        {
            Random rnd = new Random();
            int languageRoll = rnd.Next(allLanguages.Count);
            return allLanguages[languageRoll];
        }

        //Returns Subraces
        static public string RandomDwarfSubrace()
        {
            Random rnd = new Random();
            return dwarfSubRace[rnd.Next(dwarfSubRace.Count)];
        }
        static public string RandomElfSubrace()
        {
            Random rnd = new Random();
            return elfSubRace[rnd.Next(elfSubRace.Count)];
        }
        static public string RandomHalflingSubRace()
        {
            Random rnd = new Random();
            return halflingSubRace[rnd.Next(halflingSubRace.Count)];
        }
        static public string RandomDragonbornAncestry()
        {
            Random rnd = new Random();
            return dragonbornAncestry[rnd.Next(dragonbornAncestry.Count)];
        }
        static public string RandomGnomeSubrace()
        {
            Random rnd = new Random();
            return gnomeSubRace[rnd.Next(gnomeSubRace.Count)];
        }

        //Returns Spells
        static public string RandomWizardCantrip()
        {
            Random rnd = new Random();
            return spellWizardCantrips[rnd.Next(spellWizardCantrips.Count)];
        }

        //Returns Random Things
        static public string RandomAbilityCategory()
        {
            Random rnd = new Random();
            return abilityCategories[rnd.Next(abilityCategories.Count)];
        }
        static public string RandomSkillCategory()
        {
            Random rnd = new Random();
            return skillCategories[rnd.Next(skillCategories.Count)];
        }
        static public string RandomBarbSkill()
        {
            Random rnd = new Random();
            return barbSkillOptions[rnd.Next(barbSkillOptions.Count)];
        }
            
    }
}
