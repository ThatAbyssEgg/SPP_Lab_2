using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Lab_2
{
    public class Realm
    {
        public Realm(Character divineCharacter)
        {
            this.divineCharacter = divineCharacter;
        }
        public Character divineCharacter { get; set; }
    }
}
