using System.Dynamic;

public class Gemme : Tresor
{
    public string Forme { get; }
    public PepiteOr Poids;
    public double ValeurMarchande { get; set; }

    public Gemme(string couleur, int valeur, string forme, double poid) : base( couleur, valeur)
    {
        Forme = forme;
        ValeurMarchande = Poids * 93;
    }

    public string GetIcone()
    {
        return "💎";
    }
    public override string ToString()
    {
        return base.ToString() + GetIcone() + $" ce trésor vaut {ValeurMarchande}\n et est de forme {Forme}";
    }
    
}