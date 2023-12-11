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
    }
}
