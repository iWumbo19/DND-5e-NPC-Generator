using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Character
    {
        //Basic character information
        private string _chaName;
        private string _chaRace;
        private string _chaClass;
        private int _chaLevel;
        private int _profBonus;

        //Ability Scores/Modifiers
        private int _strScore;
        private int _dexScore;
        private int _conScore;
        private int _wisScore;
        private int _intScore;
        private int _chaScore;
        private int _strMod;
        private int _dexMod;
        private int _conMod;
        private int _wisMod;
        private int _intMod;
        private int _chaMod;

        //Saving Throw Mods
        private int _strSave;
        private bool _strProf;
        private int _dexSave;
        private bool _dexProf;
        private int _conSave;
        private bool _conProf;
        private int _wisSave;
        private bool _wisProf;
        private int _intSave;
        private bool _intProf;
        private int _chaSave;
        private bool _chaProf;

        //Skill Modifiers and Proficiencies
        private int _acroScore;
        private bool _acroProf;
        private int _animalScore;
        private bool _animalProf;
        private int _arcanaScore;
        private bool _arcanaProf;
        private int _athleticsScore;
        private bool _athleticsProf;
        private int _deceptionScore;
        private bool _deceptionProf;
        private int _historyScore;
        private bool _historyProf;
        private int _insightScore;
        private bool _insightProf;
        private int _intimidationScore;
        private bool _intimidationProf;
        private int _investigationScore;
        private bool _investigationProf;
        private int _medicineScore;
        private bool _medicineProf;
        private int _natureScore;
        private bool _natureProf;
        private int _perceptionScore;
        private bool _perceptionProf;
        private int _performanceScore;
        private bool _performanceProf;
        private int _persuasionScore;
        private bool _persuasionProf;
        private int _religonScore;
        private bool _religonProf;
        private int _slieghtScore;
        private bool _slieghtProf;
        private int _stealthScore;
        private bool _stealthProf;
        private int _survivalScore;
        private bool _survivalProf;

        //Misc Statisics
        private int _chaSpeed;
        private int _chaAC;
        private int _hitDie;
        private int _currentHealth;
        private int _maxHealth;
        private int _passiveWis;
        private int _passiveInt;
        private int _initiativeBonus;

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
        }

        public void CharacterCreatorMain()
        {
            RaceSelection();
            ClassSelection();
        }
        private void RaceSelection()
        {
            
        }
        private void ClassSelection()
        {

        }
    }
}
