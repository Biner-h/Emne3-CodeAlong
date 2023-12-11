using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Farm
    {
        public List<Animal> AllAnimals { get; set; }


        public Farm(List<Animal> list)
        {
            AllAnimals = list;
        }

        public void AddAnimal(Animal animal)
        {
            AllAnimals.Add(animal);
        }

        public void AddYourAnimal()
        {
            Console.WriteLine("Hva heter dyret?");
            string name = Console.ReadLine();
            Console.WriteLine("\nhvilken lyd lager den?");
            string sound = Console.ReadLine();
            var newAnimal = new Animal(name, sound);
            AddAnimal(newAnimal);
            newAnimal.Greet();
        }

        public void GreetAllAnimals()
        {
            foreach (var animal in AllAnimals)
            {
                animal.Greet();
            }
        }

        public void TalkToAnimal()
        {
            Console.WriteLine("\nHvilke dyr skal snakke med deg?");


            for (int i = 0; i < AllAnimals.Count; i++)
            {
                Console.WriteLine($"{i} {AllAnimals[i].Name}");
            }

            Console.WriteLine("\nSkriv inn tallet til dyret du vil snakke med");
            int input = int.Parse(Console.ReadLine());

            AllAnimals[input].Greet();
        }

        public void menu()
        {
            while (true)
            { 
                Console.WriteLine("1. Hils på dyrene.");
                Console.WriteLine("2. Snakk med et spesifikt dyr.");
                Console.WriteLine("3. Legg til nytt dyr.");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GreetAllAnimals(); break;

                    case "2":
                        TalkToAnimal(); break;

                    case "3":
                        AddYourAnimal(); break;

                    default: Console.WriteLine("Feil!"); break;
                }
            }
        }
    }
}
