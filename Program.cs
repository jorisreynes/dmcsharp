using DMCsharp;
using tools;

Console.ForegroundColor = ConsoleColor.White;

//Création des personnages
Console.WriteLine("Bienvenue dans notre jeu!");
Console.WriteLine("Choisissez votre personnage 1:");
Console.WriteLine("1. Berserker");
Console.WriteLine("2. Gardien");
Console.WriteLine("3. Goule");
Console.WriteLine("4. Guerrier");
Console.WriteLine("5. Kamikaze");
Console.WriteLine("6. Liche");
Console.WriteLine("7. Pretre");
Console.WriteLine("8. Robot");
Console.WriteLine("9. Vampire");
Console.WriteLine("10. Zombie");

int choice1 = int.Parse(Console.ReadLine());
ICharacter player1;
    switch (choice1)
    {
        case 1:
            player1 = new Berserker();
            break;
        case 2:
            player1 = new Gardien();
            break;
        case 3:
            player1 = new Goule();
            break;
        case 4:
            player1 = new Guerrier();
            break;
        case 5:
            player1 = new Kamikaze();
            break;
        case 6:
            player1 = new Liche();
            break;
        case 7:
            player1 = new Pretre();
            break;
        case 8:
            player1 = new Robot();
            break;
        case 9:
            player1 = new Vampire();
            break;
        case 10:
            player1 = new Zombie();
            break;
        default:
            Console.WriteLine("Option non valide, choisissez à nouveau");
            return;
    }

Console.WriteLine("Choisissez votre personnage 2:");
Console.WriteLine("1. Berserker");
Console.WriteLine("2. Gardien");
Console.WriteLine("3. Goule");
Console.WriteLine("4. Guerrier");
Console.WriteLine("5. Kamikaze");
Console.WriteLine("6. Liche");
Console.WriteLine("7. Pretre");
Console.WriteLine("8. Robot");
Console.WriteLine("9. Vampire");
Console.WriteLine("10. Zombie");

int choice2 = int.Parse(Console.ReadLine());
ICharacter player2;
    switch (choice2)
    {
        case 1:
            player2 = new Berserker();
            break;
        case 2:
            player2 = new Gardien();
            break;
        case 3:
            player2 = new Goule();
            break;
        case 4:
            player2 = new Guerrier();
            break;
        case 5:
            player2 = new Kamikaze();
            break;
        case 6:
            player2 = new Liche();
            break;
        case 7:
            player2 = new Pretre();
            break;
        case 8:
            player2 = new Robot();
            break;
        case 9:
            player2 = new Vampire();
            break;
        case 10:
            player2 = new Zombie();
            break;
        default:
            Console.WriteLine("Option non valide, choisissez à nouveau");
            return;
    }

// Boucle du jeu
while(player1.CurrentLife > 0 && player2.CurrentLife > 0)
{

    // Jet d'initiative des personnages
    int jetInitiativePlayer1 =  player1.Initiative + Tools.jet();
    int jetInitiativePlayer2 = player2.Initiative + Tools.jet();

    if (jetInitiativePlayer1 > jetInitiativePlayer2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine();
        System.Console.WriteLine("Player 1 attaque");
        System.Console.WriteLine();

        int jetAttaquePlayer1 = player1.Attack + Tools.jet();
        int jetDefensePlayer2 = player2.Defense + Tools.jet();
        
        int margeAttaque = jetDefensePlayer2 - jetAttaquePlayer1;

        if (margeAttaque > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("L'attaque a réussie");
            player1.DoAttack(player1, player2, margeAttaque);
            System.Console.WriteLine($"Vie Player1: {player1.CurrentLife}");
            System.Console.WriteLine($"Vie Player2: {player2.CurrentLife}");
        } else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("L'attaque a échouée, le Player2 contre-attaque");
            player2.DoCounterAttack(player2, player1, margeAttaque);
            System.Console.WriteLine($"Vie Player1: {player1.CurrentLife}");
            System.Console.WriteLine($"Vie Player2: {player2.CurrentLife}");
        }

        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine();
        System.Console.WriteLine("Player 2 attaque");
        System.Console.WriteLine();

        int jetAttaquePlayer2 = player2.Attack + Tools.jet();
        int jetDefensePlayer1 = player1.Defense + Tools.jet();
        
        int margeAttaque = jetDefensePlayer1 - jetAttaquePlayer2;

        if (margeAttaque > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("L'attaque a réussie");
            player2.DoAttack(player2, player1, margeAttaque);
            System.Console.WriteLine($"Vie Player1: {player1.CurrentLife}");
            System.Console.WriteLine($"Vie Player2: {player2.CurrentLife}");
        } else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("L'attaque a échouée, le Player1 contre-attaque");
            player1.DoCounterAttack(player1, player2, margeAttaque);
            System.Console.WriteLine($"Vie Player1: {player1.CurrentLife}");
            System.Console.WriteLine($"Vie Player2: {player2.CurrentLife}");
        }
    }
}

if (player1.CurrentLife <= 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine();
    System.Console.WriteLine("Player 2 a gagné");
    System.Console.WriteLine();
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.WriteLine();
    System.Console.WriteLine("Player 1 a gagné");
    System.Console.WriteLine();
}


// test pour classer les jets d'initiative des personnages
// Dictionary<string, int> jetInitiativeListe = new Dictionary<string, int>();
// var jetInitiativeListeTriee = from entry in jetInitiativeListe orderby entry.Value ascending select entry;