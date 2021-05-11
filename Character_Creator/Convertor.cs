using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    static class Convertor
    {
        static public Dictionary<int, int> levelProf = new Dictionary<int, int>()
        {
            {1,2 },
            {2,2 },
            {3,2 },
            {4,2 },
            {5,3 },
            {6,3 },
            {7,3 },
            {8,3 },
            {9,4 },
            {10,4 },
            {11,4 },
            {12,4 },
            {13,5 },
            {14,5 },
            {15,5 },
            {16,5 },
            {17,6 },
            {18,6 },
            {19,6 },
            {20,6 },
        };
        static public Dictionary<int, int> scoreMod = new Dictionary<int, int>()
        {
            {1,-5 },
            {2,-4 },
            {3,-4 },
            {4,-3 },
            {5,-3 },
            {6,-2 },
            {7,-2 },
            {8,-1 },
            {9,-1 },
            {10,0 },
            {11,0 },
            {12,1 },
            {13,1 },
            {14,2 },
            {15,2 },
            {16,3 },
            {17,3 },
            {18,4 },
            {19,4 },
            {20,5 },
            {21,5 },
            {22,6 },
            {23,6 },
            {24,7 },
            {25,7 },
            {25,8 },
            {26,8 },
            {27,9 },
            {28,9 },
            {29,10 },
            {30,10 },
        };
        static public Dictionary<string, int> classDie = new Dictionary<string, int>()
        {
            {"sorcerer",6 },
            {"wizard",6 },
            {"artificer",8 },
            {"bard",8 },
            {"cleric",8 },
            {"druid",8 },
            {"monk",8 },
            {"rouge",8 },
            {"warlock",8 },
            {"fighter",10 },
            {"paladin",10 },
            {"ranger",10 },
            {"barbarian",12 },
        };
    }
}
