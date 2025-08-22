namespace Kertaus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tervetuloa joukkueen luontiin");

        List<Pelaaja> joukkue = new List<Pelaaja>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Anna pelaajan nimi");
            string? nimi = Console.ReadLine();
            if (!string.IsNullOrEmpty(nimi))
            {
                Pelaaja pelaaja = new Pelaaja(nimi);
                joukkue.Add(pelaaja);

            }
        }
        Console.WriteLine("Joukkueesi:");

        foreach (Pelaaja pelaaja in joukkue)
        {
            Console.WriteLine(pelaaja.Nimi);
        }
    }
}
