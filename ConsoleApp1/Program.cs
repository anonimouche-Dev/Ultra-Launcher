using System.Diagnostics;
using System.Text.Json;

bool demo = true; //debug mode on = false
await UltraLauncher();

async Task UltraLauncher()
{
    Prompt();
    string choixFonction = ChoisirUneAction();

    if (choixFonction == "1")
    {
        Console.Title = "Histoire";
        Histoire();
    }

    if (choixFonction == "2")
    {
        Console.Title = "Calculatrice";
        Calculatrice();
    }

    if (choixFonction == "3")
    {
        Timer(demo);
    }

    if (choixFonction == "4")
    {
        Console.WriteLine("seconde: ");
        int chrono = 0;
        Console.Title = "Chrono";
        while (true)
        {
            chrono++;
            Console.WriteLine($"seconde:{chrono}");
            Thread.Sleep(1000);
            Console.Clear();
        }
        //FinDuProgramme();
    }
    if (choixFonction == "5")
    {
        Console.Clear();
        LancerLeProgramme();
    }

    if (choixFonction == "6")
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("             ");
    }

    if (choixFonction == "7")
    {
        Console.Clear();
        await AppelApi();
    }
    FinDuProgramme();
}

void LettreParLettre(string phrase)
{
    if (demo)
    {// Random aleatoire = new Random();

        foreach (char c in phrase)
        {
            //int attente = aleatoire.Next(500); //Génère un entier compris entre 0 et 1000        
            Console.Write(c);
            // attendre un temps
            Thread.Sleep(60);
        }
        Console.WriteLine();
    }
    else
    {
        string c = phrase;
        Console.WriteLine(c);
    }
    // v2 attendre un temps aléatoire entre 0.1s et 1 s
}

int LireUnNombre()
{

    Console.WriteLine("Ecrire chiffre pour l'addition");
    string nombreLu = Console.ReadLine();

    int nb1;

    while (!Int32.TryParse(nombreLu, out nb1))

    {
        LettreParLettre($"{nombreLu} n'est pas un nombre entier");
        Console.WriteLine("Ecrire le 2emes chiffre pour l'addition");
        nombreLu = Console.ReadLine();
    }

    return nb1;
}

void Timer(bool demo)
{
    Console.Title = "Timer";
    Console.WriteLine("Choisissez le temps de votre timer, en seconde");
    string TimerTempChoisoire = Console.ReadLine();
    Console.Clear(); int timer1;
    while (!Int32.TryParse(TimerTempChoisoire, out timer1))
    { }

    Thread.Sleep(timer1 * 1_000);

    Console.Beep();
    LettreParLettre("temp ecoulé ");
    Thread.Sleep(500);
    Console.Beep();
    Thread.Sleep(300);
    Console.Beep();
    Thread.Sleep(200);
    Console.Beep();
    Thread.Sleep(900);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Thread.Sleep(90);
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep(); Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep(); Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
    Console.Beep();
}

void Prompt()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Title = "Ultra-launcher";

    X(@"
 /$$   /$$ /$$    /$$$$$$$$ /$$$$$$$   /$$$$$$                                         
| $$  | $$| $$   |__  $$__/| $$__  $$ /$$__  $$                                        
| $$  | $$| $$      | $$   | $$  \ $$| $$  \ $$                                        
| $$  | $$| $$      | $$   | $$$$$$$/| $$$$$$$$                                        
| $$  | $$| $$      | $$   | $$__  $$| $$__  $$                                        
| $$  | $$| $$      | $$   | $$  \ $$| $$  | $$                                        
|  $$$$$$/| $$$$$$$$| $$   | $$  | $$| $$  | $$                                        
 \______/ |________/|__/   |__/  |__/|__/  |__/                                        
                                                                                       
                                                                                       
                                                                                       
 /$$        /$$$$$$  /$$   /$$ /$$   /$$  /$$$$$$  /$$   /$$ /$$$$$$$$ /$$$$$$$        
| $$       /$$__  $$| $$  | $$| $$$ | $$ /$$__  $$| $$  | $$| $$_____/| $$__  $$       
| $$      | $$  \ $$| $$  | $$| $$$$| $$| $$  \__/| $$  | $$| $$      | $$  \ $$       
| $$      | $$$$$$$$| $$  | $$| $$ $$ $$| $$      | $$$$$$$$| $$$$$   | $$$$$$$/       
| $$      | $$__  $$| $$  | $$| $$  $$$$| $$      | $$__  $$| $$__/   | $$__  $$       
| $$      | $$  | $$| $$  | $$| $$\  $$$| $$    $$| $$  | $$| $$      | $$  \ $$       
| $$$$$$$$| $$  | $$|  $$$$$$/| $$ \  $$|  $$$$$$/| $$  | $$| $$$$$$$$| $$  | $$       
|________/|__/  |__/ \______/ |__/  \__/ \______/ |__/  |__/|________/|__/  |__//$$$$$$
                                                                               |______/                                                                                   
");
    Thread.Sleep(2500);
    Console.Clear();
}

static void LancerLeProgramme()
{

    string executablePath = @"C:\git\Ultra-Launcher\game and oters aplication est fichier iniore\consoleGame1\consoleGame1\bin\Debug\net7.0\consoleGame1.exe";

    ProcessStartInfo processStartInfo = new ProcessStartInfo(executablePath);
    processStartInfo.WorkingDirectory = @"C:\git\Ultra-Launcher\game and oters aplication est fichier iniore\consoleGame1\consoleGame1\bin\Debug\net7.0/";

    Process.Start(processStartInfo);
}

async Task AppelApi()
{
    using HttpClient client = new();
    var titres = await ObtenirLesHistoiresAsync(client);
    int numero = 0;

    foreach (var titre in titres)
    {
        Console.WriteLine($"Liste des histoires:");
        Console.WriteLine($"Titre {numero}: {titre}");
    }
    Console.WriteLine();
}

static async Task<List<string>> ObtenirLesHistoiresAsync(HttpClient client)
{
    await using Stream stream =
        await client.GetStreamAsync("https://localhost:7179/Histoires");
    var repositories =
        await JsonSerializer.DeserializeAsync<List<string>>(stream);
    return repositories ?? new();
}

void Calculatrice()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    X(@"
    _____         _      _____ _    _ _            _______ _____  _____ _____ ______ 
  / ____|   /\   | |    / ____| |  | | |        /\|__   __|  __ \|_   _/ ____|  ____|
 | |       /  \  | |   | |    | |  | | |       /  \  | |  | |__) | | || |    | |__   
 | |      / /\ \ | |   | |    | |  | | |      / /\ \ | |  |  _  /  | || |    |  __|  
 | |____ / ____ \| |___| |____| |__| | |____ / ____ \| |  | | \ \ _| || |____| |____ 
  \_____/_/    \_\______\_____|\____/|______/_/    \_\_|  |_|  \_\_____\_____|______| (beta)
                                                                                     
                                                                                      
            ");
    int nb1 = LireUnNombre();
    int nb2 = LireUnNombre();
    int total = nb1 + nb2;
    LettreParLettre($"{nb1} + {nb2} = {total}");
}

void Histoire()
{
    string nomHero = SaisirNomHero();
    string choix = ChoisirUneHistoire(nomHero);

    while (DoitContinuer(choix))
    {
        RaconterUneHistoire(nomHero, choix);
        choix = ChoisirUneHistoire(nomHero);
    }
}

string SaisirNomHero()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("ecrit ton Nom ");
    Console.WriteLine(">");
    return Console.ReadLine();
}

string ChoisirUneHistoire(string nomHero)
{

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Clear();
    X(@"

  _    _ _____  _____ _______ ____ _____ _____  ______ 
 | |  | |_   _|/ ____|__   __/ __ \_   _|  __ \|  ____|
 | |__| | | | | (___    | | | |  | || | | |__) | |__   
 |  __  | | |  \___ \   | | | |  | || | |  _  /|  __|  
 | |  | |_| |_ ____) |  | | | |__| || |_| | \ \| |____ 
 |_|  |_|_____|_____/   |_|  \____/_____|_|  \_\______| ");
    Console.WriteLine("Choisi une histoire " + nomHero);
    Console.WriteLine("0 => Quitter");
    Console.WriteLine("1 => Histoire: le gateau");
    Console.WriteLine("2 => Le chien abandonné");
    return Console.ReadLine();
}

void RaconterUneHistoire(string nomHero, string choix)
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

        Console.ReadLine();
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
        Console.ReadLine();
    }
}

bool DoitContinuer(string choix)
{
    return choix != "0";
}

void FinDuProgramme()
{
    LettreParLettre("Fin du programme");
    Console.ReadLine();
}

void X(string phrase)
{
    // Random aleatoire = new Random();
    int c = 0;
    foreach (char l in phrase)
    {

        c++;
        Console.Write(l);
        // attendre un temps
        if (c % 6 == 0)
            Thread.Sleep(1);

    }
    Console.WriteLine();
}

static string ChoisirUneAction()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Choisie une option ");
    Console.WriteLine("0 => Quitter");
    Console.WriteLine("1 => Histoire");
    Console.WriteLine("2 => Calculatrice");
    Console.WriteLine("3 => Timer Beta ");
    Console.WriteLine("4 => Chrono Beta ");
    Console.WriteLine("5 => jeu  video : en cour de codage ");
    Console.WriteLine("6 => bloc-note  : en cour de codage ");
    Console.WriteLine("7 => api  : en cour de codage ");
    string choixFonction = Console.ReadLine();
    return choixFonction;
}