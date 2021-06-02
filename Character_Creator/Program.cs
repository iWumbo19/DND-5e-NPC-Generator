using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Character_Creator
{
    class Program
    {
        private readonly Library lib = new Library();
        private readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.GenerateNew();
            
        }

        public void GenerateNew()
        {
            Library lib = new Library();
            Character player = new Character();
            string raceRoll = lib.raceList[lib.RandomRoll(lib.raceList.Count())];
            //Moves through races
            if (raceRoll == "Dwarf")
            {
                Dwarf race = new Dwarf();
                race.MakeDwarf(player);
            }
            if (raceRoll == "Elf")
            {
                Elf race = new Elf();
                race.MakeElf(player);
            }
            if (raceRoll == "Halfling")
            {
                Halfling race = new Halfling();
                race.MakeHalfling(player);
            }
            if (raceRoll == "Human")
            {
                Human race = new Human();
                race.MakeHuman(player);
            }
            if (raceRoll == "Dragonborn")
            {
                Dragonborn race = new Dragonborn();
                race.MakeDragonborn(player);
            }
            if (raceRoll == "Gnome")
            {
                Gnome race = new Gnome();
                race.MakeGnome(player);
            }
            if (raceRoll == "Half-elf")
            {
                HalfElf race = new HalfElf();
                race.MakeHalfElf(player);
            }
            if (raceRoll == "Half-orc")
            {
                HalfOrc race = new HalfOrc();
                race.MakeHalfOrc(player);
            }
            if (raceRoll == "Tiefling")
            {
                Tiefling race = new Tiefling();
                race.MakeTiefling(player);
            }

            //Moves through classes
            string classRoll = lib.classList[lib.RandomRoll(lib.classList.Count())];
            if (classRoll == "Barbarian")
            {
                Barbarian myclass = new Barbarian();
                myclass.BarbarianOne(player);
            }
            if (classRoll == "Bard")
            {
                Bard myclass = new Bard();
                myclass.BardOne(player);
            }
            if (classRoll == "Cleric")
            {
                Cleric myclass = new Cleric();
                myclass.ClericOne(player);
            }
            if (classRoll == "Druid")
            {
                Druid myclass = new Druid();
                myclass.DruidOne(player);
            }
            if (classRoll == "Fighter")
            {
                Fighter myclass = new Fighter();
                myclass.FighterOne(player);
            }
            if (classRoll == "Monk")
            {
                Monk myclass = new Monk();
                myclass.MonkOne(player);
            }
            if (classRoll == "Paladin")
            {
                Paladin myclass = new Paladin();
                myclass.PaladinOne(player);
            }
            if (classRoll == "Ranger")
            {
                Ranger myclass = new Ranger();
                myclass.RangerOne(player);
            }
            if (classRoll == "Rouge")
            {
                Rouge myclass = new Rouge();
                myclass.RougeOne(player);
            }
            if (classRoll == "Sorcerer")
            {
                Sorcerer myclass = new Sorcerer();
                myclass.SorcererOne(player);
            }
            if (classRoll == "Warlock")
            {
                Warlock myclass = new Warlock();
                myclass.WarlockOne(player);
            }
            if (classRoll == "Wizard")
            {
                Wizard myclass = new Wizard();
                myclass.WizardOne(player);
            }

            //Generates Name
            if (raceRoll == "Dwarf")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.DwarfReturn());
            }
            if (raceRoll == "Elf")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.ElfReturn());
            }
            if (raceRoll == "Halfling")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.HalflingfReturn());
            }
            if (raceRoll == "Human")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.HumanReturn());
            }
            if (raceRoll == "Dragonborn")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.DragonbornReturn());
            }
            if (raceRoll == "Gnome")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.GnomeReturn());
            }
            if (raceRoll == "Half-elf")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.HalfelfReturn());
            }
            if (raceRoll == "Half-orc")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.HalforcReturn());
            }
            if (raceRoll == "Tiefling")
            {
                NameGenerator names = new NameGenerator();
                player.NameChange(names.TieflingReturn());
            }

            //Finishes Initializing Stats
            player.RollNewStats();
            player.UpdateAbilityMods();
            player.UpdateSkills();

            BackstoryGenerator bsgen = new BackstoryGenerator(player);
            player.BackgroundChange(bsgen.BackgroundOptions());
            player._chaBackStory = bsgen.BackgroundGenerator();

            CharacterSheet mySheet = new CharacterSheet();
            mySheet.InitializeSheet(player);
            mySheet.ShowDialog();
        }





        //DONT FUCKING TOUCH THIS CODE
        static public int Seeder()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            rng.GetBytes(byteArray);
            var randomInteger = BitConverter.ToInt32(byteArray, 0);
            return randomInteger;
        }
    }
}
