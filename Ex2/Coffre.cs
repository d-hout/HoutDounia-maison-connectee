public class Coffre
{
    public int NbItem { get; }
    public double ValeurTot { get; }

    public bool EstVide { get; set; }

    public Coffre(int nbItem, double valeurTot, bool estVide)
    {
        NbItem = nbItem;
        ValeurTot = valeurTot;
        EstVide = estVide; 
    }

    public override string ToString()
    {
        return base.ToString() + $"🧰 ({NbItem})";
    }
}