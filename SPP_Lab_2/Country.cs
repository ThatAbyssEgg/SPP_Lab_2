using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Lab_2
{
    public class Country
    {
        public Country() {}
        public Country(Realm currentReality, string name, int wealth, List<string> listOfCities)
        {
            this.currentReality = currentReality;
            this.name = name;
            this.wealth = wealth;
            this.listOfCities = listOfCities;
        }

        public Realm currentReality { get; set; }
        public string name { get; set; }
        public int wealth { get; set; }
        public List<string> listOfCities { get; set; }
        

    }
}
