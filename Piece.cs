

public class Piece // on ne la defini pas comme classe abstraite aucune methode abstraite étant definie ici 
{

    public List<Appareil> appareils; // il faut passer l'attribut en public pour poivoir l'utiliser dans la classe PanneauControl car ce n'est pas une classe heritiere de Piece
    public string? Nom { get; private set; }


    public Piece(string nom, List<Appareil> appareils)
    {
        Nom = nom;
        this.appareils = new List<Appareil>();
        foreach (Appareil a in appareils)
            this.appareils.Add(a);
    }

    public void AddApp(Appareil app)
    {
        appareils.Add(app);
    }



    public override string ToString()
    {
        string description = "\n* ";
        description += Nom;
        for (int i = 0; i < appareils.Count; i++)
            description += "\n\t- " + appareils[i];

        return description;
    }
}

