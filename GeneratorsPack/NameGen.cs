using System.Runtime.ConstrainedExecution;

namespace GeneratorsPack
{
    public class NameGen
    {
        Random random = new Random();

        //It is MUCH better to store it in a file but still
        List<string> firstNamePart = new List<string>() 
        { 
            "Ber", 
            "Brad", 
            "Bren",
            "Gow",
            "Os",
            "Ott",
            "Pa",
            "Ser",
            "Thor",
            "Wal" 
        };

        List<string> lastNamePart = new List<string>()
        {
            "ner",
            "ney",
            "ier",
            "ew",
            "bern",
            "well",
            "gan",
            "lo",
            "old",
            "weyn"
        };
        
        public string GetRandomName()
        {
            return firstNamePart[random.Next(0, firstNamePart.Count)] + lastNamePart[random.Next(0, lastNamePart.Count)];
        }
    }
}