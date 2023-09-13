UltraLauncher();


static int LireUnNombre()
{
    Console.WriteLine("Ecrire le 1er chiffre pour l'addition");
    string a = Console.ReadLine();
    
    int nb1;
    
    while (!Int32.TryParse(a, out nb1))
   
    { 
        Console.WriteLine($"{a} n'est pas un nombre entier");
    Console.WriteLine("Ecrire le 2emes chiffre pour l'addition");
    a= Console.ReadLine();
}

    return nb1;
}

static void UltraLauncher()
{ 
   
    
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    LettreParLettre("Ultra Launcher");
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
    int nb1 = LireUnNombre();
    int nb2 = LireUnNombre();
    int total = nb1 + nb2;
    Console.WriteLine($"{nb1} + {nb2} = {total}");
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
        Console.WriteLine("histoire 1");
        Console.WriteLine("            ");
        Console.WriteLine("alerte alerte alert ");

        Console.WriteLine("au voleur");
        Console.WriteLine("on ma volé un gateau");

        Console.WriteLine("un(e) hero  apparu");

        Console.WriteLine("le nom(e) de ce hero était " + nomHero);
        Console.WriteLine("ils ratrapérent le bandit");
        Console.WriteLine("le boulanger dit merci " + nomHero); Console.WriteLine("retrouvers les gateau ");
        Console.WriteLine("le mangérent ");

        Console.WriteLine(" MIAM Miam"); Console.WriteLine("dit " + nomHero);
        ;
    }
    if (choix == "2")
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("histoire: Le Chien abandonné");
        Console.WriteLine(" Alerte Alerte Alerte  ");
        Console.WriteLine("Un Chien a été abandonné");
        Console.WriteLine("cest un chihuahua, il est a la s.p.a");

        Console.WriteLine("un(e) hero  apparu");

        Console.WriteLine("le nom(e) de ce hero est " + nomHero);

        Console.WriteLine("Heresement  le Hero est cool ");
        Console.WriteLine(nomHero + " adopta Mambo");
        Console.WriteLine("mabo joua toute l apres midi avec " + nomHero);
        Console.WriteLine(nomHero + " est mambo sont super amis mitemenp");

    }
}

static bool DoitContinuer(string choix)
{
    return choix != "0";
}

static void FinDuProgramme()
{
    Console.WriteLine("Fin du programme");
    Console.ReadLine();
}

static void LettreParLettre(string phrase)
{
    foreach (char c in phrase)
    {

        Console.Write(c);
        // attendre un temps
        Thread.Sleep(150);
    }
    Console.WriteLine();


    // v2 attendre un temps aléatoire entre 0.1s et 1 s
}
