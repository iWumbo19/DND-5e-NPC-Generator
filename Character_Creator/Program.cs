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
            Random rnd = new Random(Seeder());            
            int raceRoll = rnd.Next(lib.raceList.Count);
            if (raceRoll == 0)
            {
                Dwarf player = new Dwarf();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
                ClassSelection(Dwarf, player)

            }
            else if (raceRoll == 1)
            {
                Elf player = new Elf();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 2)
            {
                Halfling player = new Halfling();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 3)
            {
                Human player = new Human();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 4)
            {
                Dragonborn player = new Dragonborn();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 5)
            {
                Gnome player = new Gnome();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 6)
            {
                HalfElf player = new HalfElf();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 7)
            {
                HalfOrc player = new HalfOrc();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else if (raceRoll == 8)
            {
                Tiefling player = new Tiefling();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
            }
            else
            {
                Character player = new Character();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
                ClassSelection(;
            }
            
            Console.WriteLine("Generate New Character? [y/n]");
            string ask = Console.ReadLine();
            if (ask == "y")
            {
                GenerateNew();

            }
            
        }
        private void ClassSelection(Character player)
        {

        }
        private void ClassSelection(Dwarf player)
        {

        }
        private void ClassSelection(Elf player)
        {

        }

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
