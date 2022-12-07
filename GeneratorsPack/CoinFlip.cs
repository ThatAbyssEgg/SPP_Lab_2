using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorsPack
{
    public class CoinFlip
    {
        Random random = new Random();
        public bool GetRandomValue()
        {
            return Convert.ToBoolean(random.Next(0, 2));
        }
    }
}
