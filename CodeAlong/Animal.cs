
using System.Runtime.ConstrainedExecution;
using System.Text;
using System;
namespace CodeAlong
{
    //Lag en konsollapp med noen dyr på en bondegård.Hver dyr har sin egen “pratelyd” feks Moo eller Mjau.
    //Når programmet starter opp skal alle dyrene i bondegården hilse på deg med sin pratelyd.
    //Brukeren får så opp en meny der den kan velge hvilket dyr som skal snakke og få riktig pratelyd som svar i konsollen.
    //Brukeren skal kunne legge til flere dyr og hvilken lyd de lager
    internal class Animal
    {
        public string Name { get; set; }
        public string Sound {  get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void Greet()
        {
            Console.WriteLine($"{Sound}, jeg er en {Name}");
        } 
    }
}
