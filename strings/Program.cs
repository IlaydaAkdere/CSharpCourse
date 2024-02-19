using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace strings
{
    class program
    {

        static void Main(string[] args)
        {
            // Intro();
            string sentence = "My name is ilayda akdere yönel";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is samet yönel";

            bool result3 = sentence.EndsWith(" h"); // h ile bitiyor mu
            bool result4 = sentence.StartsWith(" a"); // a ile baslıyor mu

            var result5 = sentence.IndexOf("Name"); // ındexof kelime ya da harf arama
            var result6 = sentence.LastIndexOf(" "); // Lastındexof sondan kelime ya da harf arama
            var result7 = sentence.Insert(0, "hello , "); // birsey eklemek için kullanılır
            var result8 = sentence.Substring(3, 4); // birsey  ayırmak(parçqalamak) için kullanılır
            var ressult9 = sentence.ToUpper(); // tüm harfleri büyük yapar
            var ressult10 = sentence.ToLower(); // tüm harfleri küçük yapar
            var ressult11 = sentence.Replace(" ", " "); // karakter değiştirnede kullanılır
            var ressult12 = sentence.Remove(2); // bazı kısımlerı sılmek ıcın kullanılır

            Console.WriteLine(result2);
            Console.ReadLine();

        }

        //private static void Intro()
        //{
        //    string city = "WROCLAW";
        //    //Console.WriteLine(city[0]);
        //    foreach (var item in city)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();
        //    }
    }
}
