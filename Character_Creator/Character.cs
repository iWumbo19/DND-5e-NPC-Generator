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
        protected int _chaLevel = 1;
        protected int _profBonus = 2;
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
        protected int _religionScore;
        protected bool _religionProf;
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

        public void RollNewStats()
        {
            Random rnd = new Random();
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
        }
        public void UpdateAbilityMods()
        {
            Library lib = new Library();
            _strMod = lib.scoreMod[_strScore];
            _dexMod = lib.scoreMod[_dexScore];
            _conMod = lib.scoreMod[_conScore];
            _wisMod = lib.scoreMod[_wisScore];
            _intMod = lib.scoreMod[_intScore];
            _chaMod = lib.scoreMod[_chaScore];
        }
        public void UpdateSkills()
        {
            Library lib = new Library();
            //Sets up Skill Modifiers
            _acroScore = lib.SkillModMath(_dexScore, _acroProf, _profBonus);
            _animalScore = lib.SkillModMath(_wisScore, _animalProf, _profBonus);
            _arcanaScore = lib.SkillModMath(_intScore, _arcanaProf, _profBonus);
            _athleticsScore = lib.SkillModMath(_strScore, _athleticsProf, _profBonus);
            _deceptionScore = lib.SkillModMath(_chaScore, _deceptionProf, _profBonus);
            _historyScore = lib.SkillModMath(_intScore, _historyProf, _profBonus);
            _insightScore = lib.SkillModMath(_wisScore, _insightProf, _profBonus);
            _intimidationScore = lib.SkillModMath(_chaScore, _intimidationProf, _profBonus);
            _investigationScore = lib.SkillModMath(_intScore, _investigationProf, _profBonus);
            _medicineScore = lib.SkillModMath(_wisScore, _medicineProf, _profBonus);
            _natureScore = lib.SkillModMath(_wisScore, _natureProf, _profBonus);
            _perceptionScore = lib.SkillModMath(_wisScore, _perceptionProf, _profBonus);
            _performanceScore = lib.SkillModMath(_chaScore, _performanceProf, _profBonus);
            _persuasionScore = lib.SkillModMath(_chaScore, _persuasionProf, _profBonus);
            _religionScore = lib.SkillModMath(_intScore, _religionProf, _profBonus);
            _slieghtScore = lib.SkillModMath(_dexScore, _slieghtProf, _profBonus);
            _stealthScore = lib.SkillModMath(_dexScore, _stealthProf, _profBonus);
            _survivalScore = lib.SkillModMath(_wisScore, _survivalProf, _profBonus);

            //Sets up saving throws
            _strSave = lib.SkillModMath(_strScore, _strProf, _profBonus);
            _dexSave = lib.SkillModMath(_dexScore, _dexProf, _profBonus);
            _conSave = lib.SkillModMath(_conScore, _conProf, _profBonus);
            _wisSave = lib.SkillModMath(_wisScore, _wisProf, _profBonus);
            _intSave = lib.SkillModMath(_intScore, _intProf, _profBonus);
            _chaSave = lib.SkillModMath(_chaScore, _chaProf, _profBonus);


            //Sets up Misc stats
            _initiativeBonus = _dexMod;
            _passiveWis = 8 + _perceptionScore;
            _passiveInt = 8 + _investigationScore;
        }
        public void CharacterProfGet(string skill)
        {
            Library lib = new Library();
            if (skill == lib.skillCategories[0])
            {
                _acroProf = true;
            }
            else if (skill == lib.skillCategories[1])
            {
                _animalProf = true;
            }
            else if (skill == lib.skillCategories[2])
            {
                _arcanaProf = true;
            }
            else if (skill == lib.skillCategories[3])
            {
                _athleticsProf = true;
            }
            else if (skill == lib.skillCategories[4])
            {
                _deceptionProf = true;
            }
            else if (skill == lib.skillCategories[5])
            {
                _historyProf = true;
            }
            else if (skill == lib.skillCategories[6])
            {
                _insightProf = true;
            }
            else if (skill == lib.skillCategories[7])
            {
                _intimidationProf = true;
            }
            else if (skill == lib.skillCategories[8])
            {
                _investigationProf = true;
            }
            else if (skill == lib.skillCategories[9])
            {
                _medicineProf = true;
            }
            else if (skill == lib.skillCategories[10])
            {
                _natureProf = true;
            }
            else if (skill == lib.skillCategories[11])
            {
                _perceptionProf = true;
            }
            else if (skill == lib.skillCategories[12])
            {
                _performanceProf = true;
            }
            else if (skill == lib.skillCategories[13])
            {
                _persuasionProf = true;
            }
            else if (skill == lib.skillCategories[14])
            {
                _religionProf = true;
            }
            else if (skill == lib.skillCategories[15])
            {
                _slieghtProf = true;
            }
            else if (skill == lib.skillCategories[16])
            {
                _stealthProf = true;
            }
            else if (skill == lib.skillCategories[17])
            {
                _survivalProf = true;
            }
        }
        public void RandomAbilityUpgrade(string ability)
        {
            Library lib = new Library();
            if (ability == lib.abilityCategories[0])
            {
                _strScore += 1;
            }
            else if (ability == lib.abilityCategories[1])
            {
                _dexScore += 1;
            }
            else if (ability == lib.abilityCategories[2])
            {
                _conScore += 1;
            }
            else if (ability == lib.abilityCategories[3])
            {
                _wisScore += 1;
            }
            else if (ability == lib.abilityCategories[4])
            {
                _intScore += 1;
            }
            else if (ability == lib.abilityCategories[5])
            {
                _chaScore += 1;
            }
        }

        //RETURNS TRUE IF YOU ARE PROFICIENT
        public bool AmIProficient(string skill)
        {
            Library lib = new Library();
            if (skill == lib.abilityCategories[0])
            {
                if (_strProf == true) return true;
                else return false;
            }
            else if (skill == lib.abilityCategories[1])
            {
                if (_dexProf == true) return true;
                else return false;
            }
            else if (skill == lib.abilityCategories[2])
            {
                if (_conProf == true) return true;
                else return false;
            }
            else if (skill == lib.abilityCategories[3])
            {
                if (_wisProf == true) return true;
                else return false;
            }
            else if (skill == lib.abilityCategories[4])
            {
                if (_intProf == true) return true;
                else return false;
            }
            else if (skill == lib.abilityCategories[5])
            {
                if (_chaProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[0])
            {
                if (_acroProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[1])
            {
                if (_animalProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[2])
            {
                if (_arcanaProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[3])
            {
                if (_athleticsProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[4])
            {
                if (_deceptionProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[5])
            {
                if (_historyProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[6])
            {
                if (_insightProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[7])
            {
                if (_intimidationProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[8])
            {
                if (_investigationProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[9])
            {
                if (_medicineProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[10])
            {
                if (_natureProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[11])
            {
                if (_perceptionProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[12])
            {
                if (_performanceProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[13])
            {
                if (_persuasionProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[14])
            {
                if (_religionProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[15])
            {
                if (_slieghtProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[16])
            {
                if (_stealthProf == true) return true;
                else return false;
            }
            else if (skill == lib.skillCategories[17])
            {
                if (_survivalProf == true) return true;
                else return false;
            }
            else return false;
        }

        ////Acts as an interface to to update stats
        //Saving Throw Proficiency Toggles
        public void StrProfToggle(bool prof)
        {
            if (prof == true)
            {
                _strProf = true;
            }
            if (prof == false)
            {
                _strProf = false;
            }
        }
        public void DexProfToggle(bool prof)
        {
            if (prof == true)
            {
                _dexProf = true;
            }
            if (prof == false)
            {
                _dexProf = false;
            }
        }
        public void ConProfToggle(bool prof)
        {
            if (prof == true)
            {
                _conProf = true;
            }
            if (prof == false)
            {
                _conProf = false;
            }
        }
        public void WisProfToggle(bool prof)
        {
            if (prof == true)
            {
                _wisProf = true;
            }
            if (prof == false)
            {
                _wisProf = false;
            }
        }
        public void IntProfToggle(bool prof)
        {
            if (prof == true)
            {
                _intProf = true;
            }
            if (prof == false)
            {
                _intProf = false;
            }
        }
        public void ChaProfToggle(bool prof)
        {
            if (prof == true)
            {
                _chaProf = true;
            }
            if (prof == false)
            {
                _chaProf = false;
            }
        }

        //Skill Proficieny Toggles
        public void AcroProfToggle(bool prof)
        {
            if (prof == true)
            {
                _acroProf = true;
            }
            if (prof == false)
            {
                _acroProf = false;
            }
        }
        public void AnimalProfToggle(bool prof)
        {
            if (prof == true)
            {
                _animalProf = true;
            }
            if (prof == false)
            {
                _animalProf = false;
            }
        }
        public void ArcanaProfToggle(bool prof)
        {
            if (prof == true)
            {
                _arcanaProf = true;
            }
            if (prof == false)
            {
                _arcanaProf = false;
            }
        }
        public void AthleticsProfToggle(bool prof)
        {
            if (prof == true)
            {
                _athleticsProf = true;
            }
            if (prof == false)
            {
                _athleticsProf = false;
            }
        }
        public void DeceptionProfToggle(bool prof)
        {
            if (prof == true)
            {
                _deceptionProf = true;
            }
            if (prof == false)
            {
                _deceptionProf = false;
            }
        }
        public void HistoryProfToggle(bool prof)
        {
            if (prof == true)
            {
                _historyProf = true;
            }
            if (prof == false)
            {
                _historyProf = false;
            }
        }
        public void InsightProfToggle(bool prof)
        {
            if (prof == true)
            {
                _insightProf = true;
            }
            if (prof == false)
            {
                _insightProf = false;
            }
        }
        public void IntimidationProfToggle(bool prof)
        {
            if (prof == true)
            {
                _intimidationProf = true;
            }
            if (prof == false)
            {
                _intimidationProf = false;
            }
        }
        public void InvestigationProfToggle(bool prof)
        {
            if (prof == true)
            {
                _investigationProf = true;
            }
            if (prof == false)
            {
                _investigationProf = false;
            }
        }
        public void MedicineProfToggle(bool prof)
        {
            if (prof == true)
            {
                _medicineProf = true;
            }
            if (prof == false)
            {
                _medicineProf = false;
            }
        }
        public void NatureProfToggle(bool prof)
        {
            if (prof == true)
            {
                _natureProf = true;
            }
            if (prof == false)
            {
                _natureProf = false;
            }
        }
        public void PerceptionProfToggle(bool prof)
        {
            if (prof == true)
            {
                _perceptionProf = true;
            }
            if (prof == false)
            {
                _perceptionProf = false;
            }
        }
        public void PerformanceProfToggle(bool prof)
        {
            if (prof == true)
            {
                _performanceProf = true;
            }
            if (prof == false)
            {
                _performanceProf = false;
            }
        }
        public void PersuasionProfToggle(bool prof)
        {
            if (prof == true)
            {
                _persuasionProf = true;
            }
            if (prof == false)
            {
                _persuasionProf = false;
            }
        }
        public void ReligionProfToggle(bool prof)
        {
            if (prof == true)
            {
                _religionProf = true;
            }
            if (prof == false)
            {
                _religionProf = false;
            }
        }
        public void SlieghtProfToggle(bool prof)
        {
            if (prof == true)
            {
                _slieghtProf = true;
            }
            if (prof == false)
            {
                _slieghtProf = false;
            }
        }
        public void StealthProfToggle(bool prof)
        {
            if (prof == true)
            {
                _stealthProf = true;
            }
            if (prof == false)
            {
                _stealthProf = false;
            }
        }
        public void SurvialProfToggle(bool prof)
        {
            if (prof == true)
            {
                _survivalProf = true;
            }
            if (prof == false)
            {
                _survivalProf = false;
            }
        }

        //Ability Score Modifiers
        public void StrengthScoreChange(int change)
        {
            if (_strScore + change < 30)
            {
                _strScore += change;
            }
            else { _strScore = 30; }            
        }
        public void DexterityScoreChange(int change)
        {
            if (_dexScore + change < 30)
            {
                _dexScore += change;
            }
            else { _dexScore = 30; }
        }
        public void ConstitutionScoreChange(int change)
        {
            if (_conScore + change < 30)
            {
                _conScore += change;
            }
            else { _conScore = 30; }
        }
        public void WisdomScoreChange(int change)
        {
            if (_wisScore + change < 30)
            {
                _wisScore += change;
            }
            else { _wisScore = 30; }
        }
        public void IntelligenceScoreChange(int change)
        {
            if (_intScore + change < 30)
            {
                _intScore += change;
            }
            else { _intScore = 30; }
        }
        public void CharismaScoreChange(int change)
        {
            if (_chaScore + change < 30)
            {
                _chaScore += change;
            }
            else { _chaScore = 30; }
        }

        //Returns Ability Modifiers
        public int ReturnStrMod() { return _strMod; }
        public int ReturnDexMod() { return _dexMod; }
        public int ReturnConMod() { return _conMod; }
        public int ReturnWisMod() { return _wisMod; }
        public int ReturnIntMod() { return _intMod; }
        public int ReturnChaMod() { return _chaMod; }


        //Changes Misc Statistics
        public void CurrentHealthChange(int change)
        {
            if (_currentHealth + change > _maxHealth)
            {
                _currentHealth = _maxHealth;
            }
            else if (_currentHealth + change < 0)
            {
                _currentHealth = 0;
            }
            else
            {
                _currentHealth += change;
            }
        }
        public void MaxHealthChange(int change)
        {
            if (_maxHealth + change < 0)
            {
                _maxHealth = 0;
            }
            else
            {
                _maxHealth += change;
            }
        }
        public void MaxHealthSet(int set) { _maxHealth = set; }
        public void AcChange(int change)
        {
            if (_chaAC + change < 0)
            {
                _chaAC = 0;
            }
            else
            {
                _chaAC += change;
            }
        }
        public void SpeedChange(int change)
        {
            if (_chaSpeed + change < 0)
            {
                _chaSpeed = 0;
            }
            else { _chaSpeed += change; }
        }
        public void RaceChange(string race) { _chaRace = race; }
        public void HitDiceChange(int die) { _hitDie = die; }

        //Methods to add things to lists
        public void AddLanguageProf(string addition)
        {
            if (!_profLanguages.Contains(addition))
            {
                _profLanguages.Add(addition);
            }
        }
        public void AddToolProf(string addition)
        {
            if (!_profTools.Contains(addition))
            {
                _profTools.Add(addition);
            }
        }
        public void AddWeaponProf(string addition)
        {
            if (!_profWeapons.Contains(addition))
            {
                _profWeapons.Add(addition);
            }
        }
        public void AddArmorProf(string addition)
        {
            if (!_profArmor.Contains(addition))
            {
                _profArmor.Add(addition);
            }
        }
        public void AddResistance(string addition)
        {
            if (!_chaResistances.Contains(addition))
            {
                _chaResistances.Add(addition);
            }
        }
        public void AddAbility(string addition)
        {
            if (!_chaAbilities.Contains(addition))
            {
                _chaAbilities.Add(addition);
            }
        }
        public void AddSpell(string addition)
        {
            if (!_chaSpellList.Contains(addition))
            {
                _chaSpellList.Add(addition);
            }
        }


        ///CONSOLE STAT DUMP FOR DEBUG PURPOSES
        public void PrintAllDump()
        {
            Console.WriteLine("Character Name: {0}",_chaName);
            Console.WriteLine("Character Level: {0}", _chaLevel);
            Console.WriteLine("Character Race: {0}",_chaRace);
            Console.WriteLine("Character Class: {0}",_chaClass);
            Console.WriteLine("Strength: {0}({1})",_strScore, _strMod);
            Console.WriteLine("Dexterity: {0}({1})",_dexScore, _dexMod);
            Console.WriteLine("Constitution: {0}({1})",_conScore, _conMod);
            Console.WriteLine("Wisdom: {0}({1})",_wisScore, _wisMod);
            Console.WriteLine("Inteligence: {0}({1})",_intScore, _intMod);
            Console.WriteLine("Charisma: {0}({1})", _chaScore, _chaMod);

            Console.WriteLine("\nWeapon Proficiencies:");
            foreach (string i in _profWeapons)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nArmor Proficiencies:");
            foreach (string i in _profArmor)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nTool Proficiencies:");
            foreach (string i in _profTools)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nKnown Languages:");
            foreach (string i in _profLanguages)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nResitances:");
            foreach (string i in _chaResistances)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nAbilties:");
            foreach (string i in _chaAbilities)
            {
                Console.WriteLine(i);
            }
        }
    }
}
