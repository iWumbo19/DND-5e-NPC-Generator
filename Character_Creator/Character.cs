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
        private string chaName;
        private string chaRace;
        private string chaClass;
        private int chaLevel;
        private string chaAlightment;

        //Ability Scores/Modifiers
        private int strScore;
        private int dexScore;
        private int conScore;
        private int wisScore;
        private int intScore;
        private int chaScore;
        private int strMod;
        private int dexMod;
        private int conMod;
        private int wisMod;
        private int intMod;
        private int chaMod;

        //Skill Modifiers and Proficiencies
        private int acroScore;
        private bool acroProf;
        private int animalScore;
        private bool animalProf;
        private int arcanaScore;
        private bool arcanaProf;
        private int athleticsScore;
        private bool athleticsProf;
        private int deceptionScore;
        private bool deceptionProf;
        private int historyScore;
        private bool historyProf;
        private int insightScore;
        private bool insightProf;
        private int intimidationScore;
        private bool intimidationProf;
        private int investigationScore;
        private bool investigationProf;
        private int medicineScore;
        private bool medicineProf;
        private int natureScore;
        private bool natureProf;
        private int perceptionScore;
        private bool perceptionProf;
        private int performaceScore;
        private bool performanceProf;
        private int persuasionScore;
        private bool persuasionProf;
        private int religonScore;
        private bool religonProf;
        private int slieghtScore;
        private bool slieghtProf;
        private int stealthScore;
        private bool stealthProf;
        private int survivalScore;
        private bool survivalProf;

        //Misc Statisics
        private int chaSpeed;
        private int chaAC;
        private int hitDie;
        private int currentHealth;
        private int maxHealth;
        private int passiveWis;
        private int passiveInt;
        private int initiativeBonus;

        private void InitializeStats()
        {
            
        }
    }
}
