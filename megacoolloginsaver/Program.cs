using System;
using System.IO;
using System.Drawing;

Console.WriteLine("SaveMyLogin (your login saver)");
Console.WriteLine("..............................");
Console.WriteLine();
Console.WriteLine("Vyber aplikaci");
Console.WriteLine("1. Instagram");
Console.WriteLine("2. Youtube");
Console.WriteLine("3. Steam");
Console.WriteLine("4. ČSFD");

string cisloText = Console.ReadLine();
int cislo = Convert.ToInt32(cisloText);

string nazevSouboru = "";
string nazevAplikace = "";

if (cislo == 1)
{
    nazevSouboru = "instagram.txt";
    nazevAplikace = "Instagram";
}
else if (cislo == 2)
{
    nazevSouboru = "youtube.txt";
    nazevAplikace = "YouTube";
}
else if (cislo == 3)
{
    nazevSouboru = "steam.txt";
    nazevAplikace = "Steam";
}
else if (cislo == 4)
{
    nazevSouboru = "csfd.txt";
    nazevAplikace = "ČSFD";
}
else
{
    Console.WriteLine("Neplatná volba.");
    return;
}

if (File.Exists(nazevSouboru))
{
    string obsah = File.ReadAllText(nazevSouboru);
    Console.WriteLine("Vaše údaje pro " + nazevAplikace + " jsou: " + obsah);
    Console.WriteLine("Chcete přepsat vaše údaje? A/N");
    string volba = Console.ReadLine();

    if (volba.ToUpper() == "A")
    {
        Console.WriteLine("Zadejte nové heslo:");
        string noveHeslo = Console.ReadLine();
        File.WriteAllText(nazevSouboru, noveHeslo);
        Console.WriteLine("Vaše heslo bylo úspěšně změněno!");
    }
    else
    {
        Console.WriteLine("Heslo zůstává nezměněno.");
    }
}
else
{
    Console.WriteLine("Zadej heslo pro " + nazevAplikace + ":");
    string noveHeslo = Console.ReadLine();
    File.WriteAllText(nazevSouboru, noveHeslo);
    Console.WriteLine("Vaše heslo bylo uloženo.");
}