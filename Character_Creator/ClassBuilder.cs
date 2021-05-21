using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Barbarian
    {
        private readonly Library lib = new Library();
        private readonly List<string> barbSkillOptions = new List<string>()
        {
            {"Animal Handling" },
            {"Athletics" },
            {"Intimidation" },
            {"Nature" },
            {"Perception" },
            {"Survival" }
        };
        public void BarbarianOne(Character player)
        {
            player.HitDiceChange(12);
            player.MaxHealthSet(12 + player.ReturnConMod());
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Martial Weapons");
            player.StrProfToggle(true);
            player.ConProfToggle(true);
            string barbSkillRoll1 = barbSkillOptions[lib.RandomRoll(barbSkillOptions.Count)];
            string barbSkillRoll2 = barbSkillOptions[lib.RandomRoll(barbSkillOptions.Count)];
            if (barbSkillRoll1 == barbSkillRoll2)
            {
                while (barbSkillRoll1 == barbSkillRoll2)
                {
                    barbSkillRoll2 = barbSkillOptions[lib.RandomRoll(barbSkillOptions.Count)];
                }
            }
            player.CharacterProfGet(barbSkillRoll1);
            player.CharacterProfGet(barbSkillRoll2);
            player.AddAbility("Rage");
            player.AddAbility("Unarmored Defense");
        }

    }

    class Bard
    {
        private readonly Library lib = new Library();
        private readonly List<string> bardInstrumentOptions = new List<string>()
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

        public void BardOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.AddArmorProf("Light Armor");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Hand Crossbow");
            player.AddWeaponProf("Longsword");
            player.AddWeaponProf("Rapiers");
            player.AddWeaponProf("Shortsword");
            string bardInstrumentRoll1 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
            string bardInstrumentRoll2 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
            string bardInstrumentRoll3 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
            if (bardInstrumentRoll1 == bardInstrumentRoll2 ^ bardInstrumentRoll2 == bardInstrumentRoll3 ^ bardInstrumentRoll3 == bardInstrumentRoll1)
            {
                while (bardInstrumentRoll1 == bardInstrumentRoll2 ^ bardInstrumentRoll2 == bardInstrumentRoll3 ^ bardInstrumentRoll3 == bardInstrumentRoll1)
                {
                    bardInstrumentRoll1 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
                    bardInstrumentRoll2 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
                    bardInstrumentRoll3 = bardInstrumentOptions[lib.RandomRoll(bardInstrumentOptions.Count)];
                }
            }
            player.AddToolProf(bardInstrumentRoll1);
            player.AddToolProf(bardInstrumentRoll2);
            player.AddToolProf(bardInstrumentRoll3);
            player.DexProfToggle(true);
            player.ChaProfToggle(true);
            string bardSkillRoll1 = lib.RandomSkillCategory();
            string bardSkillRoll2 = lib.RandomSkillCategory();
            string bardSkillRoll3 = lib.RandomSkillCategory();
            if (bardSkillRoll1 == bardSkillRoll2 ^ bardSkillRoll2 == bardSkillRoll3 ^ bardSkillRoll3 == bardSkillRoll1)
            {
                while (bardSkillRoll1 == bardSkillRoll2 ^ bardSkillRoll2 == bardSkillRoll3 ^ bardSkillRoll3 == bardSkillRoll1)
                {
                    bardSkillRoll1 = lib.RandomSkillCategory();
                    bardSkillRoll2 = lib.RandomSkillCategory();
                    bardSkillRoll3 = lib.RandomSkillCategory();
                }
            }
            player.CharacterProfGet(bardSkillRoll1);
            player.CharacterProfGet(bardSkillRoll2);
            player.CharacterProfGet(bardSkillRoll3);
            ////ADD CANTRIP GETTER HERE
            player.AddAbility("Bardic Inspiration");
        }
    }
}
