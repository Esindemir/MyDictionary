using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        public static int No { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(1234, "Esin");
            Ogrenci.Add(2345, "Betül");
            Ogrenci.Add(3546, "Behiye");
            Ogrenci.Add(5666, "Evren");

            Console.WriteLine("Öğrenci No giriniz");
            int no=int.Parse( Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);

            }
            catch
            {
                Console.WriteLine("Öğrenci bulunamadı");
            }
        }
    }
}
