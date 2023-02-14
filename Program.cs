using DMCsharp;
using tools;

Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine();
Console.WriteLine("Bienvenue dans le jeu !");
System.Console.WriteLine();
Console.WriteLine("Combien de joueurs ?");
System.Console.WriteLine();
int nombreDeJoueurs = int.Parse(Console.ReadLine());
System.Console.WriteLine();

//Création des personnages
List<ICharacter> players = new List<ICharacter>();

for (int i = 1; i < nombreDeJoueurs + 1; i++)
{

    System.Console.WriteLine("Choisissez un nom pour votre personnage:");
    System.Console.WriteLine();
    string name = Console.ReadLine();
    System.Console.WriteLine();

    Console.WriteLine($"Choisissez votre personnage {i} et entrez son numéro:");
    System.Console.WriteLine();
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

    System.Console.WriteLine();
    int choice = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
   
  
    switch (choice)
    {
        case 1:
            System.Console.WriteLine("Vous avez choisi le Berserker");
            System.Console.WriteLine();
            players.Add(new Berserker(name));
            break;
        case 2:
            System.Console.WriteLine("Vous avez choisi le Gardien");
            System.Console.WriteLine();
            players.Add(new Gardien(name));
            break;
        case 3:
            System.Console.WriteLine("Vous avez choisi la Goule");
            System.Console.WriteLine();
            players.Add(new Goule(name));
            break;
        case 4:
            System.Console.WriteLine("Vous avez choisi le Guerrier");
            System.Console.WriteLine();
            players.Add(new Guerrier(name));
            break;
        case 5:
            System.Console.WriteLine("Vous avez choisi le Kamikaze");
            System.Console.WriteLine();
            players.Add(new Kamikaze(name));
            break;
        case 6:
            System.Console.WriteLine("Vous avez choisi la Liche");
            System.Console.WriteLine();
            players.Add(new Liche(name));
            break;
        case 7:
            System.Console.WriteLine("Vous avez choisi le Pretre");
            System.Console.WriteLine();
            players.Add(new Pretre(name));
            break;
        case 8:
            System.Console.WriteLine("Vous avez choisi le Robot");
            System.Console.WriteLine();
            players.Add(new Robot(name));
            break;
        case 9:
            System.Console.WriteLine("Vous avez choisi le Vampire");
            System.Console.WriteLine();
            players.Add(new Vampire(name));
            break;
        case 10:
            System.Console.WriteLine("Vous avez choisi le Zombie");
            System.Console.WriteLine();
            players.Add(new Zombie(name));
            break;
        default:
            Console.WriteLine("Option non valide, choisissez à nouveau");
            return;
    }
}
System.Console.WriteLine();

List<ICharacter> deadPlayers = new List<ICharacter>();

// Boucle du jeu (tant qu'il reste plus d'un joueur en vie)
while (players.Count(p => p.CurrentLife > 0) > 1)
//while (players.Count > 1)
{
    // Jet d'initiative de tous les joueurs
    foreach(var player in players)
    {
        player.JetInitiativeCeRound =  player.Initiative + Tools.jet();
    }

    // Tri des joueurs par ordre d'initiative
    players = players.OrderByDescending(p => p.Initiative).ToList();

    int numeroDuJoueur = 0;



    // Boucle de round de jeu
    foreach(var player in players)
    {
        if(player.CurrentLife >= 0)
        {
            numeroDuJoueur++;

            // On définit une cible aléatoire
            Random random = new Random();
            List<ICharacter> targets = players.Where(p => p.CurrentLife > 0 && p != player).ToList();
            ICharacter target = targets[random.Next(targets.Count)];
           
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine();
            System.Console.WriteLine($"{player.name} attaque {target.name}");
            System.Console.WriteLine();

            // On lance l'attaque
            int jetAttaquePlayer = player.Attack + Tools.jet();
            int jetDefenseTarget = target.Defense + Tools.jet();

            int margeAttaque = jetAttaquePlayer - jetDefenseTarget;

            // Si l'attaque réussit
            if (margeAttaque > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("L'attaque a réussie");
                player.DoAttack(player, target, margeAttaque);
                System.Console.WriteLine($"Vie de {player.name}: {player.CurrentLife}");
                System.Console.WriteLine($"Vie de {target.name}: {target.CurrentLife}");
                if(target.CurrentLife <= 0)
                {
                    System.Console.WriteLine($"{target.name} est mort");
                    deadPlayers.Add(target);
                }
            } 
            else
            // Si l'attaque échoue
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"L'attaque a échouée, {target.name} contre-attaque");
                target.DoCounterAttack(target, player, margeAttaque);
                System.Console.WriteLine($"Vie de {player.name}: {player.CurrentLife}");
                System.Console.WriteLine($"Vie de {target.name}: {target.CurrentLife}");
                if(player.CurrentLife <= 0)
                {
                    System.Console.WriteLine($"{player.name} est mort");
                    deadPlayers.Add(player);
                }
            }
        }
        if(players.Count(p => p.CurrentLife > 0) <= 1)
        {
            break;
        }
    }
}

// On affiche le classement des joueurs
deadPlayers.Reverse();
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine();
System.Console.WriteLine("Classement des joueurs:");
System.Console.WriteLine();

int numero = 0;
//Dernier player en vie
foreach(var player in players.Where(p => p.CurrentLife > 0)){
    numero++;
    System.Console.WriteLine($"{numero}. {player.name}");
}
// Players dead
foreach(var player in deadPlayers)
{
    numero++;
    System.Console.WriteLine($"{numero}. {player.name}");
}
System.Console.WriteLine();