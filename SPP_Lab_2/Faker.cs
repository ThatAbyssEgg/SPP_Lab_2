using GeneratorsPack;
using System;
using System.Collections.Generic;

namespace SPP_Lab_2
{
    public class Faker
    {
        public object Create<T>()
        {
            NameGen nameGen = new NameGen();
            CoinFlip coinFlip = new CoinFlip();
            IntGen intGen = new IntGen();
            SignatureGen signatureGen = new SignatureGen();
            EldritchStringListsGen eldritchStringListsGen = new EldritchStringListsGen();

            switch (typeof(T).Name)
            {
                case "bool":
                    return coinFlip.GetRandomValue();

                case "string":
                    return nameGen.GetRandomName();

                case "int":
                    return intGen.GetRandomInt();

                case "uint":
                    return intGen.GetRandomUInt();

                case "Character":
                    Country motherland = (Country)Create<Country>();    
                    string name = nameGen.GetRandomName();
                    uint age = intGen.GetRandomUInt();
                    int karmaPoints = intGen.GetRandomInt();
                    bool isCorrupted = coinFlip.GetRandomValue();
                    char signature = signatureGen.GetRandomChar();
                    List<string> listOfItems = eldritchStringListsGen.getRandomNameList(7);
                    Character character = new Character(motherland, name, age, karmaPoints, isCorrupted, signature, listOfItems);
                    return character;

                case "Country":
                    Realm reality = (Realm)Create<Realm>();
                    string countryName = nameGen.GetRandomName();
                    int wealth = intGen.GetRandomInt();
                    List<string> listOfCities = eldritchStringListsGen.getRandomNameList(50);
                    Country country = new Country(reality, countryName, wealth, listOfCities);
                    return country;

                case "Realm":
                    Character divineChar = (Character)Create<Character>();
                    Realm realm = new Realm(divineChar);
                    return realm;

                default:
                    throw new Exception("Ты тип нормальный введи, э. Вот тебе пока эксепшон.");
                    
            }
        }


    }
}
