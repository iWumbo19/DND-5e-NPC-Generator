using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Character
    {
        //Lists containing proficiencies
        protected List<string> _profLanguages = new List<string>();
        protected List<string> _profTools = new List<string>();
        protected List<string> _profWeapons = new List<string>();
        protected List<string> _profArmor = new List<string>();
        protected List<string> _chaResistances = new List<string>();
        protected List<string> _chaAbilities = new List<string>();

        //Spell List (BETA)
        protected List<string> _chaSpellList = new List<string>();

        //Basic character information
        protected string _chaName;
        protected string _chaRace;
        protected string _chaClass;
        protected int _chaLevel;
        protected int _profBonus;
        protected string _chaBackGround;

        //Ability Scores/Modifiers
        protected int _strScore;
        protected int _dexScore;
        protected int _conScore;
        protected int _wisScore;
        protected int _intScore;
        protected int _chaScore;
        protected int _strMod;
        protected int _dexMod;
        protected int _conMod;
        protected int _wisMod;
        protected int _intMod;
        protected int _chaMod;

        //Saving Throw Mods
        protected int _strSave;
        protected bool _strProf;
        protected int _dexSave;
        protected bool _dexProf;
        protected int _conSave;
        protected bool _conProf;
        protected int _wisSave;
        protected bool _wisProf;
        protected int _intSave;
        protected bool _intProf;
        protected int _chaSave;
        protected bool _chaProf;

        //Skill Modifiers and Proficiencies
        protected int _acroScore;
        protected bool _acroProf;
        protected int _animalScore;
        protected bool _animalProf;
        protected int _arcanaScore;
        protected bool _arcanaProf;
        protected int _athleticsScore;
        protected bool _athleticsProf;
        protected int _deceptionScore;
        protected bool _deceptionProf;
        protected int _historyScore;
        protected bool _historyProf;
        protected int _insightScore;
        protected bool _insightProf;
        protected int _intimidationScore;
        protected bool _intimidationProf;
        protected int _investigationScore;
        protected bool _investigationProf;
        protected int _medicineScore;
        protected bool _medicineProf;
        protected int _natureScore;
        protected bool _natureProf;
        protected int _perceptionScore;
        protected bool _perceptionProf;
        protected int _performanceScore;
        protected bool _performanceProf;
        protected int _persuasionScore;
        protected bool _persuasionProf;
        protected int _religonScore;
        protected bool _religonProf;
        protected int _slieghtScore;
        protected bool _slieghtProf;
        protected int _stealthScore;
        protected bool _stealthProf;
        protected int _survivalScore;
        protected bool _survivalProf;

        //Misc Statisics
        protected int _chaSpeed;
        protected int _chaAC;
        protected int _hitDie;
        protected int _currentHealth;
        protected int _maxHealth;
        protected int _passiveWis;
        protected int _passiveInt;
        protected int _initiativeBonus;

        private void InitializeSkills()
        {
            Random rnd = new Random();
            _chaLevel = 1;
            //Rolls stats and sets ability scores
            List<int> statRolls = new List<int>();
            int x = 0;
            while (x < 7)
            {
                statRolls.Add(rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
                x++;
            }
            statRolls.Remove(statRolls.Min());
            _strScore = statRolls[0];
            _dexScore = statRolls[1];
            _conScore = statRolls[2];
            _wisScore = statRolls[3];
            _intScore = statRolls[4];
            _chaScore = statRolls[5];

            //Sets up Ability Modifiers
            _strMod = Library.scoreMod[_strScore];
            _dexMod = Library.scoreMod[_dexScore];
            _conMod = Library.scoreMod[_conScore];
            _wisMod = Library.scoreMod[_wisScore];
            _intMod = Library.scoreMod[_intScore];
            _chaMod = Library.scoreMod[_chaScore];

            //Sets Proficiency Bonus
            _profBonus = Library.levelProf[_chaLevel];

            //Sets up Skill Modifiers
            _acroScore = Library.SkillModMath(_dexScore, _acroProf, _profBonus);
            _animalScore = Library.SkillModMath(_wisScore, _animalProf, _profBonus);
            _arcanaScore = Library.SkillModMath(_intScore, _arcanaProf, _profBonus);
            _athleticsScore = Library.SkillModMath(_strScore, _athleticsProf, _profBonus);
            _deceptionScore = Library.SkillModMath(_chaScore, _deceptionProf, _profBonus);
            _historyScore = Library.SkillModMath(_intScore, _historyProf, _profBonus);
            _insightScore = Library.SkillModMath(_wisScore, _insightProf, _profBonus);
            _intimidationScore = Library.SkillModMath(_chaScore, _intimidationProf, _profBonus);
            _investigationScore = Library.SkillModMath(_intScore, _investigationProf, _profBonus);
            _medicineScore = Library.SkillModMath(_wisScore, _medicineProf, _profBonus);
            _natureScore = Library.SkillModMath(_wisScore, _natureProf, _profBonus);
            _perceptionScore = Library.SkillModMath(_wisScore, _perceptionProf, _profBonus);
            _performanceScore = Library.SkillModMath(_chaScore, _performanceProf, _profBonus);
            _persuasionScore = Library.SkillModMath(_chaScore, _persuasionProf, _profBonus);
            _religonScore = Library.SkillModMath(_intScore, _religonProf, _profBonus);
            _slieghtScore = Library.SkillModMath(_dexScore, _slieghtProf, _profBonus);
            _stealthScore = Library.SkillModMath(_dexScore, _stealthProf, _profBonus);
            _survivalScore = Library.SkillModMath(_wisScore, _survivalProf, _profBonus);

            //Sets up saving throws
            _strSave = Library.SkillModMath(_strScore, _strProf, _profBonus);
            _dexSave = Library.SkillModMath(_dexScore, _dexProf, _profBonus);
            _conSave = Library.SkillModMath(_conScore, _conProf, _profBonus);
            _wisSave = Library.SkillModMath(_wisScore, _wisProf, _profBonus);
            _intSave = Library.SkillModMath(_intScore, _intProf, _profBonus);
            _chaSave = Library.SkillModMath(_chaScore, _chaProf, _profBonus);


            //Sets up Misc stats
            _initiativeBonus = _dexMod;
            _passiveWis = 8 + _perceptionScore;
            _passiveInt = 8 + _investigationScore;
        }
        protected void CharacterProfGet(string skill)
        {
            if (skill == Library.skillCategories[0])
            {
                _acroProf = true;
            }
            else if (skill == Library.skillCategories[1])
            {
                _animalProf = true;
            }
            else if (skill == Library.skillCategories[2])
            {
                _arcanaProf = true;
            }
            else if (skill == Library.skillCategories[3])
            {
                _athleticsProf = true;
            }
            else if (skill == Library.skillCategories[4])
            {
                _deceptionProf = true;
            }
            else if (skill == Library.skillCategories[5])
            {
                _historyProf = true;
            }
            else if (skill == Library.skillCategories[6])
            {
                _insightProf = true;
            }
            else if (skill == Library.skillCategories[7])
            {
                _intimidationProf = true;
            }
            else if (skill == Library.skillCategories[8])
            {
                _investigationProf = true;
            }
            else if (skill == Library.skillCategories[9])
            {
                _medicineProf = true;
            }
            else if (skill == Library.skillCategories[10])
            {
                _natureProf = true;
            }
            else if (skill == Library.skillCategories[11])
            {
                _perceptionProf = true;
            }
            else if (skill == Library.skillCategories[12])
            {
                _performanceProf = true;
            }
            else if (skill == Library.skillCategories[13])
            {
                _persuasionProf = true;
            }
            else if (skill == Library.skillCategories[14])
            {
                _religonProf = true;
            }
            else if (skill == Library.skillCategories[15])
            {
                _slieghtProf = true;
            }
            else if (skill == Library.skillCategories[16])
            {
                _stealthProf = true;
            }
            else if (skill == Library.skillCategories[17])
            {
                _survivalProf = true;
            }
        }
        protected void RandomAbilityUpgrade(string ability)
        {
            if (ability == Library.abilityCategories[0])
            {
                _strScore += 1;
            }
            else if (ability == Library.abilityCategories[1])
            {
                _dexScore += 1;
            }
            else if (ability == Library.abilityCategories[2])
            {
                _conScore += 1;
            }
            else if (ability == Library.abilityCategories[3])
            {
                _wisScore += 1;
            }
            else if (ability == Library.abilityCategories[4])
            {
                _intScore += 1;
            }
            else if (ability == Library.abilityCategories[5])
            {
                _chaScore += 1;
            }
        }
        protected void MakeBarbarianClass()
        {
            Random rnd = new Random();
            _chaClass = "Barbarian";
            _chaLevel = 1;
            _hitDie = 12;
            _currentHealth = rnd.Next(1, _hitDie+1) + _conMod;
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

        //RETURNS TRUE IF YOU ARE PROFICIENT
        protected bool AmIProficient(string skill)
        {
            if (skill == Library.abilityCategories[0])
            {
                if (_strProf == true) return true;
                else return false;
            }
            else if (skill == Library.abilityCategories[1])
            {
                if (_dexProf == true) return true;
                else return false;
            }
            else if (skill == Library.abilityCategories[2])
            {
                if (_conProf == true) return true;
                else return false;
            }
            else if (skill == Library.abilityCategories[3])
            {
                if (_wisProf == true) return true;
                else return false;
            }
            else if (skill == Library.abilityCategories[4])
            {
                if (_intProf == true) return true;
                else return false;
            }
            else if (skill == Library.abilityCategories[5])
            {
                if (_chaProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[0])
            {
                if (_acroProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[1])
            {
                if (_animalProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[2])
            {
                if (_arcanaProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[3])
            {
                if (_athleticsProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[4])
            {
                if (_deceptionProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[5])
            {
                if (_historyProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[6])
            {
                if (_insightProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[7])
            {
                if (_intimidationProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[8])
            {
                if (_investigationProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[9])
            {
                if (_medicineProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[10])
            {
                if (_natureProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[11])
            {
                if (_perceptionProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[12])
            {
                if (_performanceProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[13])
            {
                if (_persuasionProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[14])
            {
                if (_religonProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[15])
            {
                if (_slieghtProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[16])
            {
                if (_stealthProf == true) return true;
                else return false;
            }
            else if (skill == Library.skillCategories[17])
            {
                if (_survivalProf == true) return true;
                else return false;
            }
            else return false;
        }
    }
}
