using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorsPack
{
    public class SignatureGen
    {
        Random random = new Random();
        public char GetRandomChar()
        {
            return (char)random.Next(0, 255);
        }
    }
}
