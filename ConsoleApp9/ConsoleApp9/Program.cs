using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam / sayi);

            string[] arabalar = { "BMV", "FORD", "MERCEDES" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);

            }
        }
    }
}
