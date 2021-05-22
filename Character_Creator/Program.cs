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

            //Moves through classes (BETA)
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

            player.RollNewStats();
            player.UpdateAbilityMods();
            player.UpdateSkills();

            player.PrintAllDump();
            Console.WriteLine("\n\nGenerate New? [y:n]");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                GenerateNew();
            }
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
