using System.Diagnostics.Contracts;
using System.Dynamic;

public class PepiteOr : Tresor
{
    public double Poids { get; set; }
    public PepiteOr(string couleur, int valeur, double poids) : base(couleur, valeur)
    {
        Poids = poids;
    }

    public string GetIcone()
    {
        return "🟡";
    }
    public override string ToString()
    {
        return base.ToString() + GetIcone() + $"Ce tresor pèse {Poids}";
    }
    

}