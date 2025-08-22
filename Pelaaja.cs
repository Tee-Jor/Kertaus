namespace Kertaus;

public class Pelaaja
{
    public string Nimi { get; private set; }
    public int Pisteet { get; private set; }


    public Pelaaja(string nimi)
    {
        this.Nimi = nimi;
        this.Pisteet = 0;
    }

    
}