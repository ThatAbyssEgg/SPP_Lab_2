using System.Text.Json;

namespace SPP_Lab_2
{
    public class Program
    {
        public static void Main()
        {
            Faker faker = new Faker();
            var character = faker.Create<Character>();
            var country = faker.Create<Country>();
            var realm = faker.Create<Realm>();
        }
    }

}