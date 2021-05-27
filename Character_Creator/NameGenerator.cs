using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class NameGenerator
    {
        //Dwarf Names
        public List<string> DwarfMale = new List<string>()
        {
            {"Adrik" },
            {"Alberich" },
            {"Baern" },
            {"Barendd" },
            {"Brottor" },
            {"Bruenor" },
            {"Dain" },
            {"Darrak" },
            {"Delg" },
            {"Eberk" },
            {"Einkil" },
            {"Fargrim" },
            {"Flint" },
            {"Gardain" },
            {"Harbek" },
            {"Kildrak" },
            {"Morgran" },
            {"Orsik" },
            {"Oskar" },
            {"Rangrim" },
            {"Rurik" },
            {"Taklinn" },
            {"Thoradin" },
            {"Thorin" },
            {"Tordek" },
            {"Traubon" },
            {"Travok" },
            {"Ulfgar" },
            {"Viet" },
            {"Vondal" }
        };
        public List<string> DwarfFemale = new List<string>()
        {
            { "Amber" },
            { "Artin" },
            { "Audhild" },
            { "Bardryn" },
            { "Dagnal" },
            { "Diesa" },
            { "Eldeth" },
            { "Falkrunn" },
            { "Finellen" },
            { "Gunnloda" },
            { "Gurdis" },
            { "Helja" },
            { "Hlin" },
            { "Kathra" },
            { "Kristryd" },
            { "Ilde" },
            { "Liftrasa" },
            { "Mardred" },
            { "Riswynn" },
            { "Sannl" },
            { "Torbera" },
            { "Torgga" },
            { "Vistra" }
        };
        public List<string> DwarfClan = new List<string>()
        {
            { "Balderk" },
            { "Battlehammer" },
            { "Brawnanvil" },
            { "Dankil" },
            { "Fireforge" },
            { "Frostbeard" },
            { "Gorunn" },
            { "Holderhek" },
            { "Ironfist" },
            { "Loderr" },
            { "Lutgehr" },
            { "Rumnaheim" },
            { "Strakeln" },
            { "Torunn" },
            { "Ungart" }
        };

        //Elf Names
        public List<string> ElfMale = new List<string>()
        {
            {"Adran" },
            {"Aelar" },
            {"Aramil" },
            {"Arannis" },
            {"Aust" },
            {"Beiro" },
            {"Berrian" },
            {"Carric" },
            {"Erdan" },
            {"Galinndan" },
            {"Hadarai" },
            {"Heian" },
            {"Himo" },
            {"Immeral" },
            {"Ivellios" },
            {"Laucian" },
            {"Mindartis" },
            {"Paelias" },
            {"Peren" },
            {"Quarion" },
            {"Riardon" },
            {"Rolen" },
            {"Soveliss" },
            {"Thamior" },
            {"Tharivol" },
            {"Theren" },
            {"Varis" }
        };
        public List<string> ElfFemale = new List<string>()
        {
            {"Adrie" },
            {"Althaea" },
            {"Anastrianna" },
            {"Andraste" },
            {"Antinua" },
            {"Bethrynna" },
            {"Birel" },
            {"Caelynn" },
            {"Drusilia" },
            {"Enna" },
            {"Felosial" },
            {"Ielenia" },
            {"Jelenneth" },
            {"Keyleth" },
            {"Leshanna" },
            {"Lia" },
            {"Meriele" },
            {"Mialee" },
            {"Naivara" },
            {"Quelenna" },
            {"Quilathe" },
            {"Sariel" },
            {"Shanairra" },
            {"Shava" },
            {"Silaqui" },
            {"Theirastra" },
            {"Thia" },
            {"Vadania" },
            {"Valanthe" },
            {"Xanaphia" }
        };
        public List<string> ElfFamily = new List<string>()
        {
            {"Amakiir (Gemflower)" },
            {"Amastacia(Starflower)" },
            {"Galanodel (Moonwhisper)" },
            {"Holimion (Diamonddew)" },
            {"Ilphelkiir (Gemblossom)" },
            {"Liadon (Silverfrond)" },
            {"Meliamne (Oakenheel)" },
            {"Nailo (Nightbreeze)" },
            {"Siannodel (Moonbrook)" },
            {"Xiloscient (Goldpetal)" }
        };

        //Halfing Names
        public List<string> HalflingMale = new List<string>()
        {
            {"Alton" },
            {"Ander" },
            {"Cade" },
            {"Corrin" },
            {"Eldon" },
            {"Errich" },
            {"Finnan" },
            {"Garret" },
            {"Lindal" },
            {"Lyle" },
            {"Merric" },
            {"Milo" },
            {"Osborn" },
            {"Perrin" },
            {"Reed" },
            {"Roscoe" },
            {"Wellby" }
        };
        public List<string> HalflingFemale = new List<string>()
        {
            {"Andry" },
            {"Bree" },
            {"Callie" },
            {"Cora" },
            {"Euphemia" },
            {"Jillian" },
            {"Kithri" },
            {"Lavinia" },
            {"Lidda" },
            {"Merla" },
            {"Nedda" },
            {"Paela" },
            {"Portia" },
            {"Seraphina" },
            {"Shaena" },
            {"Trym" },
            {"Vani" },
            {"Verna" }
        };
        public List<string> HalflingFamily = new List<string>()
        {
            {"Brushgather" },
            {"Goodbarrel" },
            {"Greenbottle" },
            {"High-hill" },
            {"Hilltopple" },
            {"Leagallow" },
            {"Tealeaf" },
            {"Thorngage" },
            {"Tosscobble" },
            {"Underbough" }
        };

        public List<string> DragonbornMale = new List<string>()
        {
            {"Arjhan" },
            {"Balasar" },
            {"Bharash" },
            {"Donaar" },
            {"Ghesh" },
            {"Heskan" },
            {"Kriv" },
            {"Medrash" },
            {"Mehen" },
            {"Nadarr" },
            {'Pendjed' },
            {"Patrin" },
            {"Rhogar" },
            {"Shamash" },
            {"Shedinn" },
            {"Tarhun" },
            {"Torinn" }
        };
        public List<string> DragonbornFemale = new List<string>()
        {
            {"Akra" },
            {"Biri" },
            {"Daar" },
            {"Farideh" },
            {"Harann" },
            {"Havilar" },
            {"Jheri" },
            {"Kava" },
            {"Korinn" },
            {"Mishann" },
            {"Nala" },
            {"Perra" },
            {"Raiann" },
            {"Sora" },
            {"Surina" },
            {"Thava" },
            {"Uadjit" }
        };
    }
}
