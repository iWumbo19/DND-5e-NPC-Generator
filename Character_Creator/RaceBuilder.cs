using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Dwarf
    {
        private readonly Library lib = new Library();
        private List<string> dwarfSubRace = new List<string>()
        {
            {"Hill Dwarf" },
            {"Mountain Dwarf" }
        };

        public void MakeDwarf(Character player)
        {
            player.ConstitutionScoreChange(1);
            player.SpeedChange(25);
            player.AddAbility("Darkvision");
            player.AddResistance("Poison");
            player.AddWeaponProf("Battleaxe");
            player.AddWeaponProf("Handaxe");
            player.AddWeaponProf("Light Hammer");
            player.AddWeaponProf("Warhammer");
            List<string> dwarfToolOptions = new List<string>();
            dwarfToolOptions.Add("Smith's Tools");
            dwarfToolOptions.Add("Bewer's Supplies");
            dwarfToolOptions.Add("Manson's Tools");
            int dwarfToolOptionsRoll = lib.RandomRoll(0,3);
            player.AddToolProf(dwarfToolOptions[dwarfToolOptionsRoll]);
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Dwarvish");
            string subRaceRoll = RandomDwarfSubrace();
            if (subRaceRoll == "Hill Dwarf")
            {
                player.RaceChange("Hill Dwarf");
                player.WisdomScoreChange(1);
                player.MaxHealthChange(1);
            }
            if (subRaceRoll == "Mountain Dwarf")
            {
                player.RaceChange("Mountain Dwarf");
                player.StrengthScoreChange(1);
                player.AddArmorProf("Light");
                player.AddArmorProf("Medium");
            }
        }
        private string RandomDwarfSubrace()
        {
            return dwarfSubRace[lib.RandomRoll(0,dwarfSubRace.Count)];
        }

    }

    class Elf
    {
        private readonly Library lib = new Library();
        public void MakeElf(Character player)
        {
            player.DexterityScoreChange(2);
            player.SpeedChange(30);
            player.AddAbility("Darkvision");
            player.PerceptionProfToggle(true);
            player.AddAbility("Fey Ancestry");
            player.AddAbility("Trance");
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Elvish");
            string subRaceRoll = lib.RandomElfSubrace();
            if (subRaceRoll == "High Elf")
            {
                player.RaceChange("High Elf");
                player.IntelligenceScoreChange(1);
                player.AddWeaponProf("Longsword");
                player.AddWeaponProf("Shortsword");
                player.AddWeaponProf("Shortbow");
                player.AddWeaponProf("Longbow");
                player.AddLanguageProf(lib.RandomAllLanguage());
                player.AddSpell(lib.RandomWizardCantrip());
            }
            if (subRaceRoll == "Wood Elf")
            {
                player.RaceChange("Wood Elf");
                player.AddWeaponProf("Longsword");
                player.AddWeaponProf("Shortsword");
                player.AddWeaponProf("Shortbow");
                player.AddWeaponProf("Longbow");
                player.SpeedChange(5);
                player.AddAbility("Mask of the Wild");
            }
            if (subRaceRoll == "Dark Elf (Drow)")
            {
                player.RaceChange("Dark Elf (Drow)");
                player.CharismaScoreChange(1);
                player.AddAbility("Sunlight Sensitivity");
                player.AddAbility("Drow Magic");
                player.AddWeaponProf("Rapiers");
                player.AddWeaponProf("Shortsword");
                player.AddWeaponProf("Hand Crossbow");
            }
        }
    }

    class Halfling
    {
        private readonly Library lib = new Library();
        public void MakeHalfling(Character player)
        {
            player.DexterityScoreChange(2);
            player.SpeedChange(25);
            player.AddAbility("Lucky");
            player.AddAbility("Brave");
            player.AddAbility("Halfling Nimbleness");
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Halfling");
            string subRaceRoll = lib.RandomHalflingSubRace();
            if (subRaceRoll == "Lightfoot")
            {
                player.RaceChange("Lightfoot Halfling");
                player.CharismaScoreChange(1);
                player.AddAbility("Naturally Stealthy");
            }
            if (subRaceRoll == "Stout")
            {
                player.RaceChange("Stout Halfling");
                player.ConstitutionScoreChange(1);
                player.AddAbility("Stout Resilience");
            }
        }
    }

    class Human
    {
        private readonly Library lib = new Library();
        public void MakeHuman(Character player)
        {
            player.RaceChange("Human");
            player.StrengthScoreChange(1);
            player.DexterityScoreChange(1);
            player.ConstitutionScoreChange(1);
            player.WisdomScoreChange(1);
            player.IntelligenceScoreChange(1);
            player.CharismaScoreChange(1);
            player.SpeedChange(30);
            player.AddLanguageProf("Common");
            player.AddLanguageProf(lib.RandomAllLanguage());
        }
    }

    class Dragonborn
    {
        private readonly Library lib = new Library();
        private List<string> dragonbornAncestry = new List<string>()
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

        public void MakeDragonborn(Character player)
        {
            player.StrengthScoreChange(2);
            player.CharismaScoreChange(1);
            player.SpeedChange(30);
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Draconic");
            string dragonbornSubRaceRoll = dragonbornAncestry[lib.RandomRoll(dragonbornAncestry.Count)];
            if (dragonbornSubRaceRoll == "Black")
            {
                player.AddResistance("Acid");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Black Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Blue")
            {
                player.AddResistance("Lightning");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Blue Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Brass")
            {
                player.AddResistance("Fire");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Brass Dragonborn");

            }
            if (dragonbornSubRaceRoll == "Bronze")
            {
                player.AddResistance("Lightning");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Bronze Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Copper")
            {
                player.AddResistance("Acid");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Copper Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Gold")
            {
                player.AddResistance("Fire");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Gold Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Green")
            {
                player.AddResistance("Poison");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Green Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Red")
            {
                player.AddResistance("Fire");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Red Dragonborn");
            }
            if (dragonbornSubRaceRoll == "Silver")
            {
                player.AddResistance("Cold");
                player.AddAbility("Breath Weapon");
                player.RaceChange("Silver Dragonborn");
            }
            if (dragonbornSubRaceRoll == "White")
            {
                player.AddResistance("Cold");
                player.AddAbility("Breath Weapon");
                player.RaceChange("White Dragonborn");
            }

        }
    }

    class Gnome
    {
        private readonly Library lib = new Library();
        public void MakeGnome(Character player)
        {
            player.IntelligenceScoreChange(2);
            player.SpeedChange(30);
            player.AddAbility("Darkvision");
            player.AddAbility("Gnome Cunning");
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Gnomish");
            string subRaceRoll = lib.RandomGnomeSubrace();
            if (subRaceRoll == "Forest Gnome")
            {
                player.RaceChange("Forest Gnome");
                player.DexterityScoreChange(1);
                player.AddSpell("Minor Illusion");
                player.AddAbility("Speak with Small Beasts");
            }
            if (subRaceRoll == "Rock Gnome")
            {
                player.RaceChange("Rock Gnome");
                player.ConstitutionScoreChange(1);
                player.AddAbility("Artificer's Lore");
                player.AddAbility("Tinker");
                player.AddToolProf("Tinker's Tools");
            }
        }
    }

    class HalfElf
    {
        private readonly Library lib = new Library();
        public void MakeHalfElf(Character player)
        {
            player.CharismaScoreChange(2);
            player.SpeedChange(30);
            player.RaceChange("Half Elf");
            player.AddAbility("Darkvision");
            player.AddAbility("Fey Ancestry");
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
            player.RandomAbilityUpgrade(abilityRoll1);
            player.RandomAbilityUpgrade(abilityRoll2);
            player.CharacterProfGet(skillRoll1);
            player.CharacterProfGet(skillRoll2);
            player.AddLanguageProf(lib.RandomAllLanguage());
        }
    }

    class HalfOrc
    {
        public void MakeHalfOrc(Character player)
        {
            player.RaceChange("Half Orc");
            player.StrengthScoreChange(2);
            player.ConstitutionScoreChange(1);
            player.SpeedChange(30);
            player.AddAbility("Darkvision");
            player.IntimidationProfToggle(true);
            player.AddAbility("Relentless Endurance");
            player.AddAbility("Savage Attacks");
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Orc");
        }
    }

    class Tiefling
    {
        public void MakeTiefling(Character player)
        {
            player.RaceChange("Tiefling");
            player.IntelligenceScoreChange(1);
            player.CharismaScoreChange(2);
            player.SpeedChange(30);
            player.AddAbility("Darkvision");
            player.AddResistance("Fire");
            player.AddSpell("Thaumaturgy");
            player.AddLanguageProf("Common");
            player.AddLanguageProf("Infernal");
        }
    }
}
