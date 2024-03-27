using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureRpg.Classes.Functions
{
    class Rooms
    {
        int roomID;
        string roomDescription;
        string[] inputOptions;
        int[] inputResults;
        string[] inputResultsDescription;
        public Rooms(int _roomID, string _roomDescription, string[] _inputOptions,
            int[] _inputResults, string[] _inputResultsDescr)
        {
            roomID = _roomID;
            roomDescription = _roomDescription;
            inputOptions = _inputOptions;
            inputResults = _inputResults;
            inputResultsDescription = _inputResultsDescr;
        }
    }
}
/*
 * start = 0
 * hub = 1
 * Shop = 2
 * inn = 3
 * Dun1!ent = 4
 * Dun1!1 = 5
 * Dun1!2 = 6
 * Dun1!3 = 7
 * Dun1!4 = 8
 * Dun1!boss = 9
 * Field1 = 10
 * Dun2!ent = 11
 * Dun2!1 = 12
 * Dun2!2 = 13
 * Dun2!boss = 14
 * Field2 = 15
 * Field3 = 16
 * Dun3!ent = 17
 * Dun3!1 = 18
 * Dun3!2 = 19
 * Dun3!3 = 20
 * Dun3!4 = 21
 * Dun3!5 = 22
 * Dun3!boss = 23
 * Field4 = 24
 * Dun4!ent = 25
 * Dun4!1 = 26
 * Dun4!2 = 27
 * Dun4!3 = 28
 * Dun4!4 = 29
 * Dun4!5 = 30
 * Dun4!boss = 31
 * DunF!ent = 32
 * DunF!1 = 33
 * DunF!2 = 34
 * DunF!3 = 35
 * DunF!4 = 36
 * DunF!5 = 37
 * FinalBoss = 38
 * DunS!ent = 39
 * DunS!1 = 40
 * DunS!2 = 41
 * DunS!3 = 42
 * DunS!4 = 43
 * DunS!5 = 44
 * DunS!6 = 45
 * SecretBoss = 46
 */