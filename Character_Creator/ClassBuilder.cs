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
            player.ClassChange("Barbarian");
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
        public List<string> spellBardCantrip = new List<string>()
        {
            {"Dancing Lights" },
            {"Light" },
            {"Mage Hand" },
            {"Mending" },
            {"Minor Ilusion" },
            {"Prestidigitation" },
            {"True Strike" },
            {"Vicious Mockery" }
        };

        public void BardOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.ClassChange("Bard");
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
            string bardSpellChoice1 = spellBardCantrip[lib.RandomRoll(spellBardCantrip.Count())];
            string bardSpellChoice2 = spellBardCantrip[lib.RandomRoll(spellBardCantrip.Count())];
            if (bardSpellChoice1 == bardSpellChoice2)
            {
                while (bardSpellChoice1 == bardSpellChoice2)
                {
                    bardSpellChoice2 = spellBardCantrip[lib.RandomRoll(spellBardCantrip.Count())];
                }
            }
            player.AddSpell(bardSpellChoice1);
            player.AddSpell(bardSpellChoice2);
            player.AddAbility("Bardic Inspiration");
        }
    }

    class Cleric
    {
        private readonly Library lib = new Library();
        private List<string> clericSkillOptions = new List<string>()
        {
            {"History" },
            {"Insight" },
            {"Medicine" },
            {"Persuasion" },
            {"Religion" }
        };
        public List<string> clericDomains = new List<string>()
        {
            {"Knowledge" },
            {"Life" },
            {"Light" },
            {"Nature" },
            {"Tempest" },
            {"Trickery" },
            {"War" }
        };
        private List<string> clericKnowledgeOneSkills = new List<string>()
        {
            {"Arcana" },
            {"History" },
            {"Nature" },
            {"Religion" }
        };
        private List<string> clericNatureOneSkills = new List<string>()
        {
            {"Animal Handling" },
            {"Nature" },
            {"Survival" }
        };
        public List<string> spellClericCantrip = new List<string>()
        {
            {"Guidance" },
            {"Light" },
            {"Mending" },
            {"Resistance" },
            {"Sacred Flame" },
            {"Spare the Dying" },
            {"Thaumaturgy" }
        };
        public void ClericOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Simple Weapons");
            player.WisProfToggle(true);
            player.ChaProfToggle(true);
            string clericSkillRoll1 = clericSkillOptions[lib.RandomRoll(clericSkillOptions.Count())];
            string clericSkillRoll2 = clericSkillOptions[lib.RandomRoll(clericSkillOptions.Count())];
            if (clericSkillRoll1 == clericSkillRoll2)
            {
                while (clericSkillRoll1 == clericSkillRoll2)
                {
                    clericSkillRoll2 = clericSkillOptions[lib.RandomRoll(clericSkillOptions.Count())];
                }
            }
            player.CharacterProfGet(clericSkillRoll1);
            player.CharacterProfGet(clericSkillRoll2);
            string clericCantripChoice1 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
            string clericCantripChoice2 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
            string clericCantripChoice3 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
            if (clericCantripChoice1 ==  clericCantripChoice2 ^ clericCantripChoice2 == clericCantripChoice3 ^ clericCantripChoice3 == clericCantripChoice1)
            {
                while (clericCantripChoice1 == clericCantripChoice2 ^ clericCantripChoice2 == clericCantripChoice3 ^ clericCantripChoice3 == clericCantripChoice1)
                {
                    clericCantripChoice1 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
                    clericCantripChoice2 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
                    clericCantripChoice3 = spellClericCantrip[lib.RandomRoll(spellClericCantrip.Count())];
                }
            }
            player.AddSpell(clericCantripChoice1);
            player.AddSpell(clericCantripChoice2);
            player.AddSpell(clericCantripChoice3);
            string clericDomainRoll = clericDomains[lib.RandomRoll(clericDomains.Count())];
            player.ClassChange(clericDomainRoll + " Cleric");
            //Domain Parsing
            if (player.ClassReturn() == "Knowledge Cleric")
            {
                player.AddSpell("Command");
                player.AddSpell("Identify");
                string knowledgeSkillRoll1 = clericKnowledgeOneSkills[lib.RandomRoll(clericKnowledgeOneSkills.Count())];
                string knowledgeSkillRoll2 = clericKnowledgeOneSkills[lib.RandomRoll(clericKnowledgeOneSkills.Count())];
                if (knowledgeSkillRoll1 == knowledgeSkillRoll2)
                {
                    while (knowledgeSkillRoll1 == knowledgeSkillRoll2)
                    {
                        knowledgeSkillRoll2 = clericKnowledgeOneSkills[lib.RandomRoll(clericKnowledgeOneSkills.Count())];
                    }
                }
            }
            if (player.ClassReturn() == "Life Cleric")
            {
                player.AddSpell("Bless");
                player.AddSpell("Cure Wounds");
                player.AddAbility("Disciple of Life");
                player.AddArmorProf("Heavy Armor");
            }
            if (player.ClassReturn() == "Light Cleric")
            {
                player.AddSpell("Burning Hands");
                player.AddSpell("Faerie Fire");
                player.AddSpell("Light");
                player.AddAbility("Warding Flare");
            }
            if (player.ClassReturn() == "Nature Cleric")
            {
                player.AddSpell("Animal Friendship");
                player.AddSpell("Speak with Animals");
                player.AddArmorProf("Heavy Armor");
                string natureOneSkills1 = clericNatureOneSkills[lib.RandomRoll(clericNatureOneSkills.Count())];
                player.CharacterProfGet(natureOneSkills1);
            }
            if (player.ClassReturn() == "Tempest Cleric")
            {
                player.AddSpell("Fog Cloud");
                player.AddSpell("Thunderwave");
                player.AddWeaponProf("Martial Weapons");
                player.AddArmorProf("Heavy Armor");
                player.AddAbility("Wrath of the Storm");
            }
            if (player.ClassReturn() == "Trickery Cleric")
            {
                player.AddSpell("Charm Person");
                player.AddSpell("Disguise Self");
                player.AddAbility("Blessing of the Trickster");
            }
            if (player.ClassReturn() == "War Cleric")
            {
                player.AddSpell("Divine Favor");
                player.AddSpell("Shield of Faith");
                player.AddWeaponProf("Martial Weapons");
                player.AddArmorProf("Heavy Armor");
                player.AddAbility("War Priest");
            }
        }
    }

    class Druid
    {
        private readonly Library lib = new Library();
        private List<string> druidSkillChoices = new List<string>()
        {
            {"Arcana" },
            {"Animal Handling" },
            {"Insight" },
            {"Medcine" },
            {"Nature" },
            {"Perception" },
            {"Religion" },
            {"Survival" }
        };
        public List<string> spellDruidCantrip = new List<string>()
        {
            {"Druidcraft" },
            {"Guidance" },
            {"Mending" },
            {"Poison Spray" },
            {"Produce Flame" },
            {"Resistance" },
            {"Shillelagh" }
        };

        public void DruidOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthChange(8 + player.ReturnConMod());
            player.ClassChange("Druid");
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Club");
            player.AddWeaponProf("Dagger");
            player.AddWeaponProf("Dart");
            player.AddWeaponProf("Javelin");
            player.AddWeaponProf("Mace");
            player.AddWeaponProf("Quarterstaff");
            player.AddWeaponProf("Scimitar");
            player.AddWeaponProf("Sickle");
            player.AddWeaponProf("Sling");
            player.AddWeaponProf("Spear");
            player.AddToolProf("Herbalism Kit");
            player.IntProfToggle(true);
            player.WisProfToggle(true);
            string druidSkillRoll1 = druidSkillChoices[lib.RandomRoll(druidSkillChoices.Count())];
            string druidSkillRoll2 = druidSkillChoices[lib.RandomRoll(druidSkillChoices.Count())];
            if (druidSkillRoll1 == druidSkillRoll2)
            {
                while (druidSkillRoll1 == druidSkillRoll2)
                {
                    druidSkillRoll2 = druidSkillChoices[lib.RandomRoll(druidSkillChoices.Count())];
                }
            }
            player.CharacterProfGet(druidSkillRoll1);
            player.CharacterProfGet(druidSkillRoll2);
            player.AddLanguageProf("Druidic");
            string druidCantrip1 = spellDruidCantrip[lib.RandomRoll(spellDruidCantrip.Count())];
            string druidCantrip2 = spellDruidCantrip[lib.RandomRoll(spellDruidCantrip.Count())];
            player.AddSpell(druidCantrip1);
            player.AddSpell(druidCantrip2);
            player.AddAbility("Wild Shape");
        }
    }

    class Fighter
    {
        private Library lib = new Library();
        private List<string> fighterSkillOptions = new List<string>()
        {
            {"Acrobatics" },
            {"Animal Handling" },
            {"Athletics" },
            {"History" },
            {"Insight" },
            {"Intimidation" },
            {"Perception" },
            {"Survival" }
        };
        private List<string> fighterFightingStyle = new List<string>()
        {
            {"Archery" },
            {"Defense" },
            {"Dueling" },
            {"Great Weapon Fighting" },
            {"Protection" },
            {"Two-Weapon Fighting" }
        };

        public void FighterOne(Character player)
        {
            player.HitDiceChange(10);
            player.MaxHealthSet(10 + player.ReturnConMod());
            player.AddArmorProf("Heavy Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Martial Weapons");
            player.StrProfToggle(true);
            player.ConProfToggle(true);
            string fighterSkillRoll1 = fighterSkillOptions[lib.RandomRoll(fighterSkillOptions.Count())];
            string fighterSkillRoll2 = fighterSkillOptions[lib.RandomRoll(fighterSkillOptions.Count())];
            if (fighterSkillRoll1 == fighterSkillRoll2)
            {
                while (fighterSkillRoll1 == fighterSkillRoll2)
                {
                    fighterSkillRoll2 = fighterSkillOptions[lib.RandomRoll(fighterSkillOptions.Count())];
                }
            }
            string fighterStyleChoice = fighterFightingStyle[lib.RandomRoll(fighterFightingStyle.Count())];
            player.ClassChange(fighterStyleChoice + " Fighter");
        }
    }

    class Monk
    {
        private readonly Library lib = new Library();
        private List<string> monkToolChoices = new List<string>()
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
            {"Woodcarver's tools" },
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

        public void MonkOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.ClassChange("Monk");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Shortswords");
            string monkToolRoll = monkToolChoices[lib.RandomRoll(monkToolChoices.Count())];
            player.AddToolProf(monkToolRoll);
            player.StrProfToggle(true);
            player.DexProfToggle(true);
            player.AddAbility("Unarmored Defense");
            player.AddAbility("Martial Arts");
        }
    }

    class Paladin
    {
        private readonly Library lib = new Library();
        private List<string> paladinSkillChoices = new List<string>()
        {
            {"Athletics" },
            {"Insight" },
            {"Intimidation" },
            {"Medicine" },
            {"Persuasion" },
            {"Religion" }
        };
        public void PaladinOne(Character player)
        {
            player.HitDiceChange(10);
            player.MaxHealthSet(10 + player.ReturnConMod());
            player.ClassChange("Paladin");
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Heavy Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Martial Weapons");
            player.WisProfToggle(true);
            player.ChaProfToggle(true);
            string paladinSkillRoll1 = paladinSkillChoices[lib.RandomRoll(paladinSkillChoices.Count())];
            string paladinSkillRoll2 = paladinSkillChoices[lib.RandomRoll(paladinSkillChoices.Count())];
            if (paladinSkillRoll1 == paladinSkillRoll2)
            {
                while (paladinSkillRoll1 == paladinSkillRoll2)
                {
                    paladinSkillRoll2 = paladinSkillChoices[lib.RandomRoll(paladinSkillChoices.Count())];
                }
            }
            player.CharacterProfGet(paladinSkillRoll1);
            player.CharacterProfGet(paladinSkillRoll2);
            player.AddAbility("Divine Sense");
            player.AddAbility("Lay on Hands");
        }
    }

    class Ranger
    {
        private Library lib = new Library();
        private List<string> rangerSkillOptions = new List<string>()
        {
            {"Animal Handling" },
            {"Athletics" },
            {"Insight" },
            {"Investigation" },
            {"Nature" },
            {"Perception" },
            {"Stealth" },
            {"Survival" }
        };
        public void RangerOne(Character player)
        {
            player.HitDiceChange(10);
            player.MaxHealthSet(10 + player.ReturnConMod());
            player.ClassChange("Ranger");
            player.AddArmorProf("Light Armor");
            player.AddArmorProf("Medium Armor");
            player.AddArmorProf("Shields");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Martial Weapons");
            player.StrProfToggle(true);
            player.DexProfToggle(true);
            string rangerSkillRoll1 = rangerSkillOptions[lib.RandomRoll(rangerSkillOptions.Count())];
            string rangerSkillRoll2 = rangerSkillOptions[lib.RandomRoll(rangerSkillOptions.Count())];
            string rangerSkillRoll3 = rangerSkillOptions[lib.RandomRoll(rangerSkillOptions.Count())];
            if (rangerSkillRoll1 == rangerSkillRoll2 ^ rangerSkillRoll2 == rangerSkillRoll3 ^ rangerSkillRoll3 == rangerSkillRoll1)
            {
                while (rangerSkillRoll1 == rangerSkillRoll2 ^ rangerSkillRoll2 == rangerSkillRoll3 ^ rangerSkillRoll3 == rangerSkillRoll1)
                {
                    rangerSkillRoll2 = rangerSkillOptions[lib.RandomRoll(rangerSkillOptions.Count())];
                    rangerSkillRoll3 = rangerSkillOptions[lib.RandomRoll(rangerSkillOptions.Count())];
                }
            }
            player.AddAbility("Favored Enemy");
            player.AddAbility("Natural Explorer");
        }
    }

    class Rouge
    {
        private readonly Library lib = new Library();
        private List<string> rougeSkillOptions = new List<string>()
        {
            {"Acrobatics" },
            {"Athletics" },
            {"Deception" },
            {"Insight" },
            {"Intimidation" },
            {"Investigation" },
            {"Perception" },
            {"Performance" },
            {"Persuasion" },
            {"Sleight of Hand" },
            {"Stealth" }
        };
        public void RougeOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.ClassChange("Rouge");
            player.AddArmorProf("Light Armor");
            player.AddWeaponProf("Simple Weapons");
            player.AddWeaponProf("Hand Crossbows");
            player.AddWeaponProf("Longsword");
            player.AddWeaponProf("Rapier");
            player.AddWeaponProf("Shortsword");
            player.AddToolProf("Thieve's tools");
            player.DexProfToggle(true);
            player.IntProfToggle(true);
            string rougeSkillRoll1 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
            string rougeSkillRoll2 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
            string rougeSkillRoll3 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
            string rougeSkillRoll4 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
            if (UniqueSkills(rougeSkillRoll1, rougeSkillRoll2, rougeSkillRoll3, rougeSkillRoll4) == false)
            {
                rougeSkillRoll1 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
                rougeSkillRoll2 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
                rougeSkillRoll3 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
                rougeSkillRoll4 = rougeSkillOptions[lib.RandomRoll(rougeSkillOptions.Count())];
            }
            player.CharacterProfGet(rougeSkillRoll1);
            player.CharacterProfGet(rougeSkillRoll2);
            player.CharacterProfGet(rougeSkillRoll3);
            player.CharacterProfGet(rougeSkillRoll4);
            player.AddAbility("Expertise");
            player.AddAbility("Sneak Attack");
            player.AddLanguageProf("Thieves' Cant");
        }

        private bool UniqueSkills(string skill1, string skill2, string skill3, string skill4)
        {
            if (skill1 == skill2 ^ skill1 == skill3 ^ skill1 == skill4 ^ skill2 == skill3 ^ skill2 == skill4 ^ skill3 == skill4)
            {
                return false;
            }
            else return true;
        }
    }

    class Sorcerer
    {
        private readonly Library lib = new Library();
        private List<string> sorcererSkillOptions = new List<string>()
        {
            {"Arcana" },
            {"Deception" },
            {"Insight" },
            {"Intimidation" },
            {"Persuasion" },
            {"Religion" }
        };
        public List<string> spellSorcererCantrips = new List<string>()
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
        public void SorcererOne(Character player)
        {
            player.HitDiceChange(6);
            player.MaxHealthSet(6 + player.ReturnConMod());
            player.ClassChange("Sorcerer");
            player.AddWeaponProf("Dagger");
            player.AddWeaponProf("Dart");
            player.AddWeaponProf("Sling");
            player.AddWeaponProf("Quarterstaff");
            player.AddWeaponProf("Light Crossbow");
            player.ConProfToggle(true);
            player.ChaProfToggle(true);
            string sorcererSkillRoll1 = sorcererSkillOptions[lib.RandomRoll(sorcererSkillOptions.Count())];
            string sorcererSkillRoll2 = sorcererSkillOptions[lib.RandomRoll(sorcererSkillOptions.Count())];
            if (sorcererSkillRoll1 == sorcererSkillRoll2)
            {
                while (sorcererSkillRoll1 == sorcererSkillRoll2)
                {
                    sorcererSkillRoll2 = sorcererSkillOptions[lib.RandomRoll(sorcererSkillOptions.Count())];
                }
            }
            player.CharacterProfGet(sorcererSkillRoll1);
            player.CharacterProfGet(sorcererSkillRoll2);
            string sorcererCantrip1 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
            string sorcererCantrip2 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
            string sorcererCantrip3 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
            string sorcererCantrip4 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
            if (UniqueSkills(sorcererCantrip1, sorcererCantrip2, sorcererCantrip3, sorcererCantrip4) == false)
            {
                sorcererCantrip2 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
                sorcererCantrip3 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
                sorcererCantrip4 = spellSorcererCantrips[lib.RandomRoll(spellSorcererCantrips.Count())];
            }
            player.AddSpell(sorcererCantrip1);
            player.AddSpell(sorcererCantrip2);
            player.AddSpell(sorcererCantrip3);
            player.AddSpell(sorcererCantrip4);
        }
        private bool UniqueSkills(string skill1, string skill2, string skill3, string skill4)
        {
            if (skill1 == skill2 ^ skill1 == skill3 ^ skill1 == skill4 ^ skill2 == skill3 ^ skill2 == skill4 ^ skill3 == skill4)
            {
                return false;
            }
            else return true;
        }
    }

    class Warlock
    {
        private readonly Library lib = new Library();
        private List<string> warlockSkillOptions = new List<string>()
        {
            {"Arcana" },
            {"Deception" },
            {"History" },
            {"Intimidation" },
            {"Investigation" },
            {"Nature" },
            {"Religion" }
        };
        public List<string> spellWarlockCantrip = new List<string>()
        {
            {"Chill Touch" },
            {"Eldritch Blast" },
            {"Mage Hand" },
            {"Minor Illusion" },
            {"Poison Spray" },
            {"Prestidigitation" },
            {"True Strike" }
        };

        public void WarlockOne(Character player)
        {
            player.HitDiceChange(8);
            player.MaxHealthSet(8 + player.ReturnConMod());
            player.ClassChange("Warlock");
            player.AddArmorProf("Light Armor");
            player.AddWeaponProf("Simple Weapons");
            player.WisProfToggle(true);
            player.ChaProfToggle(true);
            string warlockSkillRoll1 = warlockSkillOptions[lib.RandomRoll(warlockSkillOptions.Count())];
            string warlockSkillRoll2 = warlockSkillOptions[lib.RandomRoll(warlockSkillOptions.Count())];
            if (warlockSkillRoll1 == warlockSkillRoll2)
            {
                while (warlockSkillRoll1 == warlockSkillRoll2)
                {
                    warlockSkillRoll2 = warlockSkillOptions[lib.RandomRoll(warlockSkillOptions.Count())];
                }
            }
            player.CharacterProfGet(warlockSkillRoll1);
            player.CharacterProfGet(warlockSkillRoll2);
            player.AddAbility("Other Worldy Patron");
            player.AddAbility("Pact Magic");
            string warlockSpellChoice1 = spellWarlockCantrip[lib.RandomRoll(spellWarlockCantrip.Count())];
            string warlockSpellChoice2 = spellWarlockCantrip[lib.RandomRoll(spellWarlockCantrip.Count())];
            if (warlockSpellChoice1 == warlockSpellChoice2)
            {
                while (warlockSpellChoice1 == warlockSpellChoice2)
                {
                    warlockSpellChoice2 = spellWarlockCantrip[lib.RandomRoll(spellWarlockCantrip.Count())];
                }
            }
            player.AddSpell(warlockSpellChoice1);
            player.AddSpell(warlockSpellChoice2);
        }
    }

    class Wizard
    {
        private readonly Library lib = new Library();
        private List<string> wizardSkillOptions = new List<string>()
        {
            {"Arcana" },
            {"History" },
            {"Insight" },
            {"Investigation" },
            {"Medicine" },
            {"Religion" }
        };
        public List<string> spellWizardCantrips = new List<string>()
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


        public void WizardOne(Character player)
        {
            player.HitDiceChange(6);
            player.MaxHealthSet(6 + player.ReturnConMod());
            player.ClassChange("Wizard");
            player.AddWeaponProf("Dagger");
            player.AddWeaponProf("Dart");
            player.AddWeaponProf("Sling");
            player.AddWeaponProf("Quarterstaff");
            player.AddWeaponProf("Light Crossbow");
            player.IntProfToggle(true);
            player.WisProfToggle(true);
            string wizardSkillRoll1 = wizardSkillOptions[lib.RandomRoll(wizardSkillOptions.Count())];
            string wizardSkillRoll2 = wizardSkillOptions[lib.RandomRoll(wizardSkillOptions.Count())];
            if (wizardSkillRoll1 == wizardSkillRoll2)
            {
                while (wizardSkillRoll1 == wizardSkillRoll2)
                {
                    wizardSkillRoll2 = wizardSkillOptions[lib.RandomRoll(wizardSkillOptions.Count())];
                }
            }
            player.CharacterProfGet(wizardSkillRoll1);
            player.CharacterProfGet(wizardSkillRoll2);
            string wizardSpellChoice1 = spellWizardCantrips[lib.RandomRoll(spellWizardCantrips.Count())];
            string wizardSpellChoice2 = spellWizardCantrips[lib.RandomRoll(spellWizardCantrips.Count())];
            string wizardSpellChoice3 = spellWizardCantrips[lib.RandomRoll(spellWizardCantrips.Count())];
            if (wizardSpellChoice1 == wizardSpellChoice2 ^ wizardSpellChoice1 == wizardSpellChoice3 ^ wizardSpellChoice2 == wizardSpellChoice3)
            {
                while (wizardSpellChoice1 == wizardSpellChoice2 ^ wizardSpellChoice1 == wizardSpellChoice3 ^ wizardSpellChoice2 == wizardSpellChoice3)
                {
                    wizardSpellChoice2 = spellWizardCantrips[lib.RandomRoll(spellWizardCantrips.Count())];
                    wizardSpellChoice3 = spellWizardCantrips[lib.RandomRoll(spellWizardCantrips.Count())];
                }
            }
            player.AddAbility("Arcane Recovery");
        }
    }
}
