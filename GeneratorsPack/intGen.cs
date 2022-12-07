using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorsPack
{
    public class IntGen
    {
        Random random = new Random();
        public int GetRandomInt()
        {
            return random.Next();
        }
        
        public uint GetRandomUInt()
        {
            return Convert.ToUInt32(random.Next());
        }
    }
}
