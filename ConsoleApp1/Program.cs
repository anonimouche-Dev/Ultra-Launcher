UltraLauncher();

















static int LireUnNombre()
{
    
    Console.WriteLine("Ecrire chiffre pour l'addition");
    string a = Console.ReadLine();
    
    int nb1;
    
    while (!Int32.TryParse(a, out nb1))
   
    { 
       LettreParLettre($"{a} n'est pas un nombre entier");
    Console.WriteLine("Ecrire le 2emes chiffre pour l'addition");
    a= Console.ReadLine();
}

    return nb1;
}

static void UltraLauncher()
{ 
   
    
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    X (@"
 /$$   /$$ /$$    /$$$$$$$$ /$$$$$$$   /$$$$$$      /$$        /$$$$$$  /$$   /$$ /$$   /$$  /$$$$$$  /$$   /$$ /$$$$$$$$ /$$$$$$$ 
| $$  | $$| $$   |__  $$__/| $$__  $$ /$$__  $$    | $$       /$$__  $$| $$  | $$| $$$ | $$ /$$__  $$| $$  | $$| $$_____/| $$__  $$
| $$  | $$| $$      | $$   | $$  \ $$| $$  \ $$    | $$      | $$  \ $$| $$  | $$| $$$$| $$| $$  \__/| $$  | $$| $$      | $$  \ $$
| $$  | $$| $$      | $$   | $$$$$$$/| $$$$$$$$    | $$      | $$$$$$$$| $$  | $$| $$ $$ $$| $$      | $$$$$$$$| $$$$$   | $$$$$$$/
| $$  | $$| $$      | $$   | $$__  $$| $$__  $$    | $$      | $$__  $$| $$  | $$| $$  $$$$| $$      | $$__  $$| $$__/   | $$__  $$
| $$  | $$| $$      | $$   | $$  \ $$| $$  | $$    | $$      | $$  | $$| $$  | $$| $$\  $$$| $$    $$| $$  | $$| $$      | $$  \ $$
|  $$$$$$/| $$$$$$$$| $$   | $$  | $$| $$  | $$    | $$$$$$$$| $$  | $$|  $$$$$$/| $$ \  $$|  $$$$$$/| $$  | $$| $$$$$$$$| $$  | $$
 \______/ |________/|__/   |__/  |__/|__/  |__/    |________/|__/  |__/ \______/ |__/  \__/ \______/ |__/  |__/|________/|__/  |__/
                                                                                             
");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Choisie une option ");
    Console.WriteLine("0 => Quitter");
    Console.WriteLine("1 => Histoire");
    Console.WriteLine("2 => Calculatrice");
    string choixFonction = Console.ReadLine();
    if (choixFonction == "1")
    {
        Histoire();
    }

    if (choixFonction == "2")
    {
        Calculatrice();
    }
    FinDuProgramme();
}

static void Calculatrice()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    X(@"
  
             __     _           __               _      __         _  __     _____  |                   /     _/
            /     /   \  |     /    \     /|   /   \   /    |   |  |  |\   | |      |                  /    _/
           |     |     | |    |     |\   / |  |     | |     |___|  |  | \  | |__    |                 /   _/
           |     |_____| |    |     | \_/  |  |_____| |     |   |  |  |  \ | |      |                /  _/
            \__  |     | |___  \__  |      |  |     |  \__  |   |  |  |   \| |____  | v. Beta 0.0.1 / _/
           _________________________________________________________________________|______________/_/
            ");
    int nb1 = LireUnNombre();
    int nb2 = LireUnNombre();
    int total = nb1 + nb2;
    LettreParLettre($"{nb1} + {nb2} = {total}");
}

static void Histoire()
{
    string nomHero = SaisirNomHero();
    string choix = ChoisirUneHistoire(nomHero);

    while (DoitContinuer(choix))
    {
        RaconterUneHistoire(nomHero, choix);
        choix = ChoisirUneHistoire(nomHero);
    }
}

static string SaisirNomHero()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("ecrit ton Nom ");
    Console.WriteLine(">");
    return Console.ReadLine();
}

static string ChoisirUneHistoire(string nomHero)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Choisi une histoire " + nomHero);
    Console.WriteLine("0 => Quitter");
    Console.WriteLine("1 => Histoire: le gateau");
    Console.WriteLine("2 => Le chien abandonné");
    return Console.ReadLine();
}

static void RaconterUneHistoire(string nomHero, string choix)
{
    if (choix == "1")
    {
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        LettreParLettre("histoire 1");
        LettreParLettre("            ");
        LettreParLettre("alerte alerte alert ");

        LettreParLettre("au voleur");
        LettreParLettre("on ma volé un gateau");

        LettreParLettre("un(e) hero  apparu");

        LettreParLettre("le nom(e) de ce hero était " + nomHero);
        LettreParLettre("ils ratrapérent le bandit");
        LettreParLettre("le boulanger dit merci " + nomHero); LettreParLettre("retrouvers les gateau ");
        LettreParLettre("le mangérent ");

        LettreParLettre(" MIAM Miam"); LettreParLettre("dit " + nomHero);
        ;
    }
    if (choix == "2")
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        LettreParLettre("histoire: Le Chien abandonné");
        LettreParLettre(" Alerte Alerte Alerte  ");
        LettreParLettre("Un Chien a été abandonné");
        LettreParLettre("cest un chihuahua, il est a la s.p.a");

        LettreParLettre("un(e) hero  apparu");

        LettreParLettre("le nom(e) de ce hero est " + nomHero);

        LettreParLettre("Heresement  le Hero est cool ");
        LettreParLettre(nomHero + " adopta Mambo");
        LettreParLettre("mabo joua toute l apres midi avec " + nomHero);
        LettreParLettre(nomHero + " est mambo sont super amis mitemenp");

    }
}

static bool DoitContinuer(string choix)
{
    return choix != "0";
}

static void FinDuProgramme()
{

    LettreParLettre("Fin du programme");
    Console.ReadLine();
}

static void LettreParLettre(string phrase)
{
   // Random aleatoire = new Random();

    foreach (char c in phrase)
    {
        //int attente = aleatoire.Next(500); //Génère un entier compris entre 0 et 1000        
        Console.Write(c);
        // attendre un temps
        Thread.Sleep(135);
    }
    Console.WriteLine();


    // v2 attendre un temps aléatoire entre 0.1s et 1 s
}


static void X(string phrase)
{
    // Random aleatoire = new Random();

    foreach (char X in phrase)
    {
             
        Console.Write(X);
        // attendre un temps
        Thread.Sleep(20);
    }
    Console.WriteLine();


    
}
