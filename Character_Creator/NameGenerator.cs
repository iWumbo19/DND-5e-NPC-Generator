using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class NameGenerator
    {
        //Creates Library object available for methods
        private readonly Library lib = new Library();

        //Dwarf Names
        private readonly List<string> dwarfMale = new List<string>()
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
        private readonly List<string> dwarfFemale = new List<string>()
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
        private readonly List<string> dwarfClan = new List<string>()
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
        private readonly List<string> elfMale = new List<string>()
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
        private readonly List<string> elfFemale = new List<string>()
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
        private readonly List<string> elfFamily = new List<string>()
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
        private readonly List<string> halflingMale = new List<string>()
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
        private readonly List<string> halflingFemale = new List<string>()
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
        private readonly List<string> halflingFamily = new List<string>()
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

        //Human Names
        private readonly List<string> humanMale = new List<string>()
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
            {"Varis" },
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
        private readonly List<string> humanFemale = new List<string>()
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
            {"Xanaphia" },
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
        private readonly List<string> humanFamily = new List<string>()
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
            {"Xiloscient (Goldpetal)" },
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

        //Dragonborn Names
        private readonly List<string> dragonbornMale = new List<string>()
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
            {"Pendjed" },
            {"Patrin" },
            {"Rhogar" },
            {"Shamash" },
            {"Shedinn" },
            {"Tarhun" },
            {"Torinn" }
        };
        private readonly List<string> dragonbornFemale = new List<string>()
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
        private readonly List<string> dragonbornClan = new List<string>()
        {
            { "Clenthtinthiallor" },
            { "Daardendrian" },
            { "Delmirev" },
            { "Drachendandion" },
            { "Fenkenkebradon" },
            { "Kepeshkmolik" },
            { "Kerrhylon" },
            { "Kimbatuul" },
            { "Linxakasendalor" },
            { "Myastan" },
            { "Nemmonis" },
            { "Norixius" },
            { "Ophinshtalajiir" },
            { "Prexijandilin" },
            { "Shestendeliath" },
            { "Turnuroth" },
            { "Verthisathurgiesh" },
            { "Yarjerit" }
        };

        //Gnome Names
        private readonly List<string> gnomeMale = new List<string>()
        {
            {"Alston" },
            {"Alvyn" },
            {"Boddynock" },
            {"Brocc" },
            {"Burgell" },
            {"Dimble" },
            {"Eldon" },
            {"Erky" },
            {"Fonkin" },
            {"Frug" },
            {"Gerbo" },
            {"Gimble" },
            {"Glim" },
            {"Jebeddo" },
            {"Kellen" },
            {"Namfoodle" },
            {"Orryn" },
            {"Roondar" },
            {"Seebo" },
            {"Sindri" },
            {"Warryn" },
            {"Wrenn" },
            {"Zook" }
        };
        private readonly List<string> gnomeFemale = new List<string>()
        {
            {"Bimpnottin" },
            {"Breena" },
            {"Caramip" },
            {"Carlin" },
            {"Donella" },
            {"Duvamil" },
            {"Ella" },
            {"Ellyjobell" },
            {"Ellywick" },
            {"Lilli" },
            {"Loppmottin" },
            {"Lorilla" },
            {"Mardnab" },
            {"Nissa" },
            {"Nyx" },
            {"Oda" },
            {"Orla" },
            {"Roywyn" },
            {"Shamil" },
            {"Tana" },
            {"Waywocket" },
            {"Zanna" }
        };
        private readonly List<string> gnomeClan = new List<string>()
        {
            {"Beren" },
            {"Daergel" },
            {"Folkor" },
            {"Garrick" },
            {"Nackle" },
            {"Murnig" },
            {"Ningel" },
            {"Raulnor" },
            {"Scheppen" },
            {"Timbers" },
            {"Turen" }
        };
        private readonly List<string> gnomeNickname = new List<string>()
        {
            {"Aleslosh" },
            {"Ashhearth" },
            {"Badger" },
            {"Cloak" },
            {"Doublelock" },
            {"Filchbatter" },
            {"Fnipper" },
            {"Ku" },
            {"Nim" },
            {"Oneshoe" },
            {"Pock" },
            {"Sparklegem" }
        };

        //Halforc Names
        private readonly List<string> halforcMale = new List<string>()
        {
            {"Dench" },
            {"Feng" },
            {"Gell" },
            {"Henk" },
            {"Holg" },
            {"Imsh" },
            {"Keth" },
            {"Krusk" },
            {"Mhurren" },
            {"Ront" },
            {"Shump" },
            {"Thokk" }
        };
        private readonly List<string> halforcFemale = new List<string>()
        {
            {"Baggi" },
            {"Emen" },
            {"Engong" },
            {"Kansif" },
            {"Myev" },
            {"Neega" },
            {"Ovak" },
            {"Ownka" },
            {"Shautha" },
            {"Sutha" },
            {"Vola" },
            {"Volen" },
            {"Yevelda" }
        };

        //Tiefling Names
        private readonly List<string> tieflingMale = new List<string>()
        {
            {"Akmenos" },
            {"Amnon" },
            {"Barakas" },
            {"Damakos" },
            {"Ekemon" },
            {"Lados" },
            {"Kairon" },
            {"Leucis" },
            {"Melech" },
            {"Mordai" },
            {"Morthos" },
            {"Pelaios" },
            {"Skamos" },
            {"Therai" }
        };
        private readonly List<string> tieflingFemale = new List<string>()
        {
            {"Akta" },
            {"Anakis" },
            {"Bryseis" },
            {"Criella" },
            {"Damaia" },
            {"Ea" },
            {"Kallista" },
            {"Lerissa" },
            {"Makaria" },
            {"Nemeia" },
            {"Orianna" },
            {"Phelaia" },
            {"Rieta" }
        };
        private readonly List<string> tieflingVirtue = new List<string>()
        {
            {"Art" },
            {"Carrion" },
            {"Chant" },
            {"Creed" },
            {"Despair" },
            {"Excellence" },
            {"Fear" },
            {"Glory" },
            {"Hope" },
            {"Ideal" },
            {"Music" },
            {"Nowhere" },
            {"Open" },
            {"Poetry" },
            {"Quest" },
            {"Random" },
            {"Reverence" },
            {"Sorrow" },
            {"Temerity" },
            {"Torment" },
            {"Weary" }
        };

        public string DwarfReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                 firstName = dwarfMale[lib.RandomRoll(dwarfMale.Count())];
            }
            else
            {
                 firstName = dwarfFemale[lib.RandomRoll(dwarfFemale.Count())];
            }
            string clanName = dwarfClan[lib.RandomRoll(dwarfClan.Count())];
            string returnName = String.Format("{0} {1}", firstName, clanName);
            return returnName;
        }

        public string ElfReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = elfMale[lib.RandomRoll(elfMale.Count())];
            }
            else
            {
                firstName = elfFemale[lib.RandomRoll(elfFemale.Count())];
            }
            string familyName = elfFamily[lib.RandomRoll(elfFamily.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }

        public string HalflingfReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = halflingMale[lib.RandomRoll(halflingMale.Count())];
            }
            else
            {
                firstName = halflingFemale[lib.RandomRoll(halflingFemale.Count())];
            }
            string familyName = halflingFamily[lib.RandomRoll(halflingFamily.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }

        public string HumanReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = humanMale[lib.RandomRoll(humanMale.Count())];
            }
            else
            {
                firstName = humanFemale[lib.RandomRoll(humanFemale.Count())];
            }
            string familyName = humanFamily[lib.RandomRoll(humanFamily.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }

        public string DragonbornReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = dragonbornMale[lib.RandomRoll(dragonbornMale.Count())];
            }
            else
            {
                firstName = dragonbornFemale[lib.RandomRoll(dragonbornFemale.Count())];
            }
            string familyName = dragonbornClan[lib.RandomRoll(dragonbornClan.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }

        public string GnomeReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = gnomeMale[lib.RandomRoll(gnomeMale.Count())];
            }
            else
            {
                firstName = gnomeFemale[lib.RandomRoll(gnomeFemale.Count())];
            }
            string nickName = gnomeNickname[lib.RandomRoll(gnomeNickname.Count())];
            string familyName = gnomeClan[lib.RandomRoll(gnomeClan.Count())];
            string returnName = String.Format("{0} \"{1}\" {2}", firstName, nickName, familyName);
            return returnName;
        }

        public string HalfelfReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = humanMale[lib.RandomRoll(humanMale.Count())];
            }
            else
            {
                firstName = humanFemale[lib.RandomRoll(humanFemale.Count())];
            }
            string familyName = humanFamily[lib.RandomRoll(humanFamily.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }

        public string HalforcReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = halforcMale[lib.RandomRoll(halforcMale.Count())];
            }
            else
            {
                firstName = halforcFemale[lib.RandomRoll(halforcFemale.Count())];
            }
            return firstName;
        }

        public string TieflingReturn()
        {
            int genderRoll = lib.RandomRoll(0, 2);
            string firstName;
            if (genderRoll == 1)
            {
                firstName = tieflingMale[lib.RandomRoll(tieflingMale.Count())];
            }
            else
            {
                firstName = tieflingFemale[lib.RandomRoll(tieflingFemale.Count())];
            }
            string familyName = tieflingVirtue[lib.RandomRoll(tieflingVirtue.Count())];
            string returnName = String.Format("{0} {1}", firstName, familyName);
            return returnName;
        }
    }
}