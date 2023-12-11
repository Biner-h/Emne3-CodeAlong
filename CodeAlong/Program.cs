//Lag en konsollapp med noen dyr på en bondegård.Hver dyr har sin egen “pratelyd” feks Moo eller Mjau.
//Når programmet starter opp skal alle dyrene i bondegården hilse på deg med sin pratelyd.
//Brukeren får så opp en meny der den kan velge hvilket dyr som skal snakke og få riktig pratelyd som svar i konsollen.
//Brukeren skal kunne legge til flere dyr og hvilken lyd de lager

using CodeAlong;

var farm = new Farm(new List<Animal>()
{
new Animal("Ku", "Moo"),
new Animal("Katt", "Mjau"),
new Animal("Hund", "Woff")
});

foreach (var animal in farm.AllAnimals)
{
    animal.Greet();
}

Console.WriteLine("\nHvilke dyr skal snakke med deg?");


for (int i = 0; i < farm.AllAnimals.Count; i++)
{
    Console.WriteLine($"{i} {farm.AllAnimals[i].Name}");
}

Console.WriteLine("\nSkriv inn tallet til dyret du vil snakke med");
int input = int.Parse(Console.ReadLine());

farm.AllAnimals[input].Greet();

Console.WriteLine("\nVil du legge til flere dyr og hvilken lyd de lager?");
string input2 = Console.ReadLine().ToLower();

if (input2 == "ja")
{
    farm.AddYourAnimal();
}


