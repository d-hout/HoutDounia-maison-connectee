public class Pirate
{
    public int Num = 0; 
    public string Prenom { get; }
    public string Nom { get; }

    public Pirate(string prenom, string nom)
    {
        Num++; 
        Prenom = prenom;
        Nom = nom;
    }

    public override string ToString()
    {
        return $"prénom : {Prenom} nom : {Nom} , id = {Num}";
    }
}