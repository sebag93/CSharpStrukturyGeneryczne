using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Stos();

            HashSet();
        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Michał" };

            set.Add(pracownik);
            set.Add(pracownik);

            set.Add(new Pracownik { Imie = "Marcin" });
            set.Add(new Pracownik { Imie = "Marcin" });

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Kowal" });
            stos.Push(new Pracownik { Imie = "Jacek", Nazwisko = "Zając" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine();
            Console.WriteLine("STOS");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Zając" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine("KOLEJKA");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
