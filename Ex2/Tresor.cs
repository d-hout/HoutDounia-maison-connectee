public class Tresor
{
    public string Couleur { get; }
    public int Valeur { get; }
    public Tresor(string couleur, int valeur)
    {
        Valeur = valeur;
        Couleur = couleur;
    }

    public override string ToString()
    {
        return $"Ce trésor de couleur {Couleur} vaut {Valeur} euros";
    }
}