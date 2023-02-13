using DMCsharp;

// Genere un nombre aléatoire entre 1 et 100


static int random()
{
    Random rnd = new Random();
    int number = rnd.Next(1, 101);
    return number;
}


//Console.WriteLine(random());


//Création des personnages
Berserker Hector = new Berserker();
Berserker Simon = new Berserker();

// Jet d'initiative des personnages
int jetInitiativeHector =  Hector.Initiative + random();
int jetInitiativeSimon = Simon.Initiative + random();

// test pour classer les jets d'initiative des personnages
Dictionary<string, int> jetInitiativeListe = new Dictionary<string, int>();
jetInitiativeListe.Add("Hector", jetInitiativeHector);
jetInitiativeListe.Add("Simon", jetInitiativeSimon);
var jetInitiativeListeTriee = from entry in jetInitiativeListe orderby entry.Value ascending select entry;


System.Console.WriteLine($"Vie Hector: {Hector.CurrentLife}");


if (jetInitiativeHector + random() < jetInitiativeSimon + random())
{
   Console.WriteLine("Simon commence");
}
else
{
   Console.WriteLine("Hector commence");

}


// foreach(var entry in jetInitiativeListeTriee)
// {
//     Console.WriteLine(entry);
// }



while(Hector.CurrentLife > 0 && Simon.CurrentLife > 0)
{
    int jetDefenseSimon = Simon.Defense + random();
    int jetAttaqueHector = Hector.Attack + random();

    int margeAttaque = jetDefenseSimon - jetAttaqueHector;

    if (margeAttaque > 0)
    {
        Hector.DoAttack(Hector, Simon, margeAttaque);
    }
    else
    {
        Simon.DoCounterAttack(Simon, Hector, margeAttaque);
    }
}


Console.WriteLine($"Attaque Simon: {Simon.Attack}");
Console.WriteLine($"Attaque Hector: {Hector.Attack}");
Console.WriteLine($"Vie Simon: {Simon.CurrentLife}");
Console.WriteLine($"Vie Hector: {Hector.CurrentLife}");



// Console.WriteLine(Simon.currentLife);
// Console.WriteLine(Hector.currentLife);