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

        //Basic character information
        protected string _chaName;
        protected string _chaRace;
        protected string _chaClass;
        protected int _chaLevel;
        protected int _profBonus;

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

            //Sets up Misc stats
            _initiativeBonus = _dexMod;
            _passiveWis = 8 + _perceptionScore;
            _passiveInt = 8 + _investigationScore;
        }
    }
}
