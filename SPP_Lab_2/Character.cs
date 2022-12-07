using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Lab_2
{
    public class Character
    {
        public Character() {} 
        public Character(Country motherland, string name, uint age, int karmaPoints, bool isCorrupted, char signature, List<string> itemList)
        {
            this.motherland = motherland;
            this.name = name;
            this.age = age;
            this.karmaPoints = karmaPoints;
            this.isCorrupted = isCorrupted;
            this.signature = signature;
            this.itemList = itemList;
        }
        public Country motherland { get; set; }
        public string name { get; set; }
        public uint age { get; set; }
        public int karmaPoints { get; set; }
        public bool isCorrupted { get; set; }
        public char signature { get; set; }
        public List<string> itemList { get; set; }
    }
}
