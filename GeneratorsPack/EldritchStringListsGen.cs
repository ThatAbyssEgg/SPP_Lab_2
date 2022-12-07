using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorsPack
{
    public class EldritchStringListsGen
    {
        Random random = new Random();

        public List<string> getRandomNameList(int namesAmount)
        {
            List<string> namesList = new List<string>();
            for (int i = 0; i < namesAmount; i++)
            {
                string currentString = "";
                for (int j = 0; j < random.Next(0, 50); j++)
                {
                    currentString += (char)random.Next(0, 127);
                }
                namesList.Add(currentString);
            }
            return namesList;  
        }
    }
}
