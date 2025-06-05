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

if (cislo == 1)
{
    if (File.Exists("Instagram.txt"))
    {
        string obsahinstagram = File.ReadAllText("instagram.txt");
        Console.WriteLine("Vaše ůdaje pro Instagram jsou: " + obsahinstagram);
        Console.WriteLine("Chcete přepsat vaše údaje? A/N");
        string volbaI = Console.ReadLine();
        string volbaII = Console.ReadLine();

        if (volbaI == "A")
        {
            Console.WriteLine("Zadejte nové heslo");

        }
        
    }
    else
    {
        Console.WriteLine("Zadej heslo pro IG: ");
        string hesloIG = Console.ReadLine();
        File.WriteAllText("instagram.txt", hesloIG);
        Console.WriteLine("vaše Heslo bylo změněno!");
    }

}
