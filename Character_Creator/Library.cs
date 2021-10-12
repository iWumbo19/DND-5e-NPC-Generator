using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Library
    {
        private readonly Random rnd = new Random(Program.Seeder());
        //Stat Number Translators
        public Dictionary<int, int> levelProf = new Dictionary<int, int>()
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
        public Dictionary<int, int> scoreMod = new Dictionary<int, int>()
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
            {26,8 },
            {27,8 },
            {28,9 },
            {29,9 },
            {30,10 },
        };
        public Dictionary<string, int> classHitDie = new Dictionary<string, int>()
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
        public int SkillModMath(int rawScore, bool prof, int profBonus)
        {
            int returnScore = scoreMod[rawScore];
            if (prof == true)
            {
                returnScore += profBonus;
            }
            return returnScore;
        }
        
        //Lists of Specific Choices
        public List<string> abilityCategories = new List<string>()
        {
            {"Strength" },
            {"Dexterity" },
            {"Constitution" },
            {"Wisdom" },
            {"Inteligence" },
            {"Charisma" }
        };
        public List<string> skillCategories = new List<string>()
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
        public List<string> musicalInstruments = new List<string>()
        {
            {"Bagpipes" },
            {"Drum" },
            {"Dulcimer" },
            {"Flute" },
            {"Lute" },
            {"Lyre" },
            {"Horn" },
            {"Pan Flute" },
            {"Shawm" },
            {"Viol" }
        };
        public List<string> artisansTools = new List<string>()
        {
            {"Alchemist's supplies" },
            {"Brewer's supplies" },
            {"Calligrapher's supplies" },
            {"Carpenter's tools" },
            {"Cartographer's tools" },
            {"Cobbler's tools" },
            {"Cook's utensils" },
            {"Glassblower's tools" },
            {"Jeweler's tools" },
            {"Leatherworker's tools" },
            {"Mason's tools" },
            {"Painter's supplies" },
            {"Potter's tools" },
            {"Smith's tools" },
            {"Tinker's tools" },
            {"Weaver's tools" },
            {"Woodcarver's tools" }
        };

        //Basic PHB Races/Classes
        public List<string> raceList = new List<string>()
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
        public List<string> classList = new List<string>()
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
        public List<string> halflingSubRace = new List<string>()
        {
            {"Lightfoot" },
            {"Stout" }
        };
        public List<string> elfSubRace = new List<string>()
        {
            {"High Elf" },
            {"Wood Elf" },
            {"Dark Elf (Drow)" }
        };
        public List<string> gnomeSubRace = new List<string>()
        {
            {"Forest Gnome" },
            {"Rock Gnome" }
        };

        //Lists containing PHB languages
        public List<string> standardLanguages = new List<string>()
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
        public List<string> exoticLanguages = new List<string>()
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
        public List<string> allLanguages = new List<string>()
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
        public List<string> spellWizardCantrips = new List<string>
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
        public string RandomAllLanguage()
        {
            int languageRoll = rnd.Next(allLanguages.Count);
            return allLanguages[languageRoll];
        }

        //Returns Subraces
        public string RandomElfSubrace()
        {
            return elfSubRace[rnd.Next(elfSubRace.Count)];
        }
        public string RandomHalflingSubRace()
        {
            return halflingSubRace[rnd.Next(halflingSubRace.Count)];
        }
        public string RandomGnomeSubrace()
        {
            return gnomeSubRace[rnd.Next(gnomeSubRace.Count)];
        }

        //Returns Spells
        public string RandomWizardCantrip()
        {
            return spellWizardCantrips[rnd.Next(spellWizardCantrips.Count)];
        }

        //Returns Random Things
        public string RandomAbilityCategory()
        {
            return abilityCategories[rnd.Next(abilityCategories.Count)];
        }
        public string RandomSkillCategory()
        {
            return skillCategories[rnd.Next(skillCategories.Count)];
        }

        //Returns Random Numbers
        public int RandomRoll(int low, int high) {return rnd.Next(low, high);}
        public int RandomRoll(int high) { return rnd.Next(high); }


    }
}
