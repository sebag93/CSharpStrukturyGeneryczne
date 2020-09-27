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
            //HashSet();
            //LinkedList();
            //LinkedList2();
            //Dictionary();
            //SortedDictionary();
            //SortedList();
            //SortedSet();

            var pracownicy = new DzialyKolekcja();

            pracownicy.Add("Sprzedaż", new Pracownik { Nazwisko = "Nowak" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Czapla" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Głowacki" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Ksiegowosc", new Pracownik { Nazwisko = "Nowak" })
                      .Add("Ksiegowosc", new Pracownik { Nazwisko = "Kowal" })
                      .Add("Ksiegowosc", new Pracownik { Nazwisko = "Kaczor" })
                      .Add("Ksiegowosc", new Pracownik { Nazwisko = "Bogacki" })
                      .Add("Ksiegowosc", new Pracownik { Nazwisko = "Nowak" });

            foreach (var dzial in pracownicy)
            {
                Console.WriteLine(dzial.Key);
                foreach (var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);
                }
            }
        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();

            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();

            set2.Add("tomek");
            set2.Add("iza");
            set2.Add("ola");
            set2.Add("ala");
            set2.Add("piotr");
            set2.Add("beata");
            set2.Add("alan");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedList<string, List<Pracownik>>();

            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                                                             new Pracownik { Imie = "Marcin", Nazwisko = "Bien" } });

            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Marcin", Nazwisko = "Kowal" },
                                                                new Pracownik { Imie = "Tomek", Nazwisko = "Wróbel" } });

            pracownicy.Add("Księgowość", new List<Pracownik> { new Pracownik { Imie = "Olek", Nazwisko = "Kowalski" },
                                                               new Pracownik { Imie = "Bartek", Nazwisko = "Nawrocko" },
                                                               new Pracownik { Imie = "Jurek", Nazwisko = "Pytel" },
                                                               new Pracownik { Imie = "Robert", Nazwisko = "Stach" } });

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1}", item.Key, item.Value.Count);
            }
        }

        private static void Dictionary()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Księgowość", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Kowal" },
                                                                 new Pracownik { Nazwisko = "Kaczor"} });

            // ...

            pracownicy["Księgowość"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski" },
                                                                  new Pracownik { Nazwisko = "Bogacki" }});

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział : " + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }

                Console.WriteLine();
            }


            Console.WriteLine("Pracownicy z księgowości: ");
            foreach (var item in pracownicy["Księgowość"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;
            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
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
