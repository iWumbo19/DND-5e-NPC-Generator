using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Creator
{
    public partial class CharacterSheet : Form
    {
        private Program pro = new Program();
        public CharacterSheet()
        {
            InitializeComponent();
        }

        public void InitializeSheet(Character player)
        {
            StrScoreBox.Text = player.StrengthScoreReturn().ToString();
            DexScoreBox.Text = player.DexterityScoreReturn().ToString();
            ConScoreBox.Text = player.ConstitutionScoreReturn().ToString();
            WisScoreBox.Text = player.WisdomScoreReturn().ToString();
            IntScoreBox.Text = player.IntelligenceScoreReturn().ToString();
            ChaScoreBox.Text = player.CharismaScoreReturn().ToString();
            StrModBox.Text = String.Format("({0})", player.ReturnStrMod());
            DexModBox.Text = String.Format("({0})", player.ReturnDexMod());
            ConModBox.Text = String.Format("({0})", player.ReturnConMod());
            WisModBox.Text = String.Format("({0})", player.ReturnWisMod());
            IntModBox.Text = String.Format("({0})", player.ReturnIntMod());
            ChaModBox.Text = String.Format("({0})", player.ReturnChaMod());
            AcroModBox.Text = player.AcroSkillReturn().ToString();
            ArcanaModBox.Text = player.ArcanaSkillReturn().ToString();
            AnimalModBox.Text = player.AnimalSkillReturn().ToString();
            AthleticsModBox.Text = player.AthleticsSkillReturn().ToString();
            DeceptionModBox.Text = player.DecpetionSkillReturn().ToString();
            HistoryModBox.Text = player.HistorySkillReturn().ToString();
            InsightModBox.Text = player.InsightSkillReturn().ToString();
            IntimidationModBox.Text = player.IntimidationSkillReturn().ToString();
            InvestigationModBox.Text = player.InvestigationSkillReturn().ToString();
            MedicineModBox.Text = player.MedicineSkillReturn().ToString();
            NatureModBox.Text = player.NatureSkillReturn().ToString();
            PerceptionModBox.Text = player.PerceptionSkillReturn().ToString();
            PerformanceModBox.Text = player.PerformanceSkillReturn().ToString();
            PersuasionModBox.Text = player.PersuasionSkillReturn().ToString();
            ReligionModBox.Text = player.ReligionSkillReturn().ToString();
            SlieghtModBox.Text = player.SlieghtSkillReturn().ToString();
            StealthModBox.Text = player.StealthSkillReturn().ToString();
            SurvivalModBox.Text = player.SurvivalSkillReturn().ToString();
            CharNameBox.Text = player.NameReturn();
            CharRaceBox.Text = player.RaceReturn();
            CharClassBox.Text = player.ClassReturn();
            PassIntBox.Text = (8 + player.PerceptionSkillReturn()).ToString();
            PassWisBox.Text = (8 + player.ReturnIntMod()).ToString();
            foreach (var item in player._profTools)
            {
                ToolProfList.Items.Add(item);
            }
            foreach (var item in player._profLanguages)
            {
                LangProfList.Items.Add(item);
            }
            foreach (var item in player._profWeapons)
            {
                WeaponProfList.Items.Add(item);
            }
            foreach (var item in player._profArmor)
            {
                ArmorProfList.Items.Add(item);
            }
            foreach (var item in player._chaResistances)
            {
                ResistancesList.Items.Add(item);
            }
            foreach (var item in player._chaAbilities)
            {
                AbilitiesList.Items.Add(item);
            }
            foreach (var item in player._chaSpellList)
            {
                SpellsList.Items.Add(item);
            }
            SpeedBox.Text = player.SpeedReturn();
            BackstoryBox.Text = player._chaBackStory;
        }

        private void NewCharButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            pro.GenerateNew();
        }
    }
}
