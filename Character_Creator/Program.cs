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

        static void Main(string[] args)
        {
            GenerateNew();
        }

        static void GenerateNew()
        {
            string xx = "faskjldhfa";
            RandomNumberGenerator.Create(xx);
            RandomNumberGenerator
            
            
            Library lib = new Library();
            int raceRoll = rnd.Next(lib.raceList.Count);
            if (raceRoll == 0)
            {
                Dwarf player = new Dwarf();
                player.RollNewStats();
                player.UpdateAbilityMods();
                player.UpdateSkills();
                player.PrintAllDump();
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
            }
            Console.WriteLine("Generate New Character? [y/n]");
            string ask = Console.ReadLine();
            if (ask == "y")
            {
                GenerateNew();
            }
        }
    }
}
