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

farm.menu();


