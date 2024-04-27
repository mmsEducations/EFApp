using System;
using System.Collections.Generic;
using System.Linq;

namespace EFApp.LinqToObjects
{
    internal static class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Ex3()
        {
            int[] numbers = { 1, 2, 21, 34, 44, 51, 47, 61, 32, 100, 1400, 2000, 150, 20, 40, 90 };

            // => lamda expression 
            //where ile veri üzerinde filitreleme ,sınırlandırma yapabiliyoruz 
            IEnumerable<int> evenNumber = numbers.Where(n => n % 2 == 0);


            var length = numbers.Length;
            int firstElement = numbers.First();
            int lastElement = numbers.Last();

            int[] numbers2 = { };
            //int firstElementNum2 = numbers2.First();
            //int lastElementNum2 = numbers2.Last();

            int firstElementNum2 = numbers2.FirstOrDefault();
            int lastElementNum2 = numbers2.LastOrDefault();


            //int firstElement= numbers.FirstOrDefault();
            //int firstElement= numbers.LastOrDefault();

            //Diziyi listeye dönüştürme 
            List<int> numbersList = numbers.ToList();
            var numCount = numbers.Count();

            List<string> ozanExGirls = new List<string> { "Adriana Lima", "Bionce", "Gülben Ergen", "Hülya Avşar" };
            string[] ozanExGirlsArray = ozanExGirls.ToArray();
            IEnumerable<string> twoData = ozanExGirls.Take(2);
            IEnumerable<string> oneData = ozanExGirls.Skip(1).Take(1);
            IEnumerable<string> oneData_ = ozanExGirls.Skip(2).Take(1);

            double res = getCircleArea(3);

            3.14.getCircleAreaWithExtension();

            2.5.getCircleAreaWithExtension();
        }

        private static void Ex2()
        {
            List<string> countries = new List<string>() { "Türkiye", "Abd", "Almanya", "Brezilya", "Fransa", "Cezayir", "Dubai" };

            IEnumerable<string> countryNameEndA = (from country in countries
                                                   where country.EndsWith("a")
                                                   select country + "- sonu a ile biten ülkeler");

            List<string> countryNameEndA_List = countryNameEndA.ToList();

            foreach (string country in countryNameEndA)
            {
                Console.WriteLine(country);
            }
        }

        private static void Ex1()
        {
            int[] plates = { 1, 2, 21, 34, 44, 51, 47, 61, 32 };

            int minNumber = plates.Min();
            int maxNumber = plates.Max();
            double average = plates.Average();


            string[] names = { "Ozan", "Esra", "Onur", "Ozlem", "Bekir", "Yuşa", "Hamdi", "Miraç" };

            var namesStartWithO = (from n in names where n.StartsWith("O") select n);

            Console.WriteLine("Adı O ile başlayan öğrenciler");
            foreach (var item in namesStartWithO)
            {
                Console.WriteLine(item);
            }

            /*
            List<string> newNames = new List<string>();
            foreach (var n in names)
            {
                if (n.StartsWith("O"))
                {
                    newNames.Add(n);
                }
            }
            */
        }


        public static double getCircleArea(double r)
        {
            return 3.14 * r * r;
        }

        public static double getCircleAreaWithExtension(this double r)
        {
            return 3.14 * r * r;
        }

    }

    //public static class ExtensionExample
    //{


    //}
}


//linq(Language Integrated Query-Dile entegre edilmiş sorgu):Veri kaynakları üzerinde sorgulama yapmamızı sağlar 
//Linq 
/*
   Linq To Objects 

Genel Olarak Linq uygulamanın 2 yolu var
1)Extension metod olarak uygulama
 plates.Min();
2)sorgu olarak uygulama 

 */