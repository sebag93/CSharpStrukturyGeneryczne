﻿using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<bool> drukuj = x => Console.WriteLine(x);
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;

            Predicate<double> jestMniejszeOdSto = d => d < 100;

            drukuj(jestMniejszeOdSto(potegowanie(dodaj(6, 8))));

            var kolejka = new KolejkaKolowa<double>();
            WprowadzanieDanych(kolejka);

            kolejka.Drukuj(d => Console.WriteLine(d));

            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
