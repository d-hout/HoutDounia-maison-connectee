

public class PanneauControle
{
    public List<Piece> pieces;


    public PanneauControle(List<Piece> piece)
    {
        this.pieces = new List<Piece>();
        foreach (Piece p in pieces)
            this.pieces.Add(p);
    }

    public void AddNewPiece()
    {
        Console.WriteLine("Donner un nom à votre pièce:");
        string room = Console.ReadLine()!;
        Piece p = new Piece(room, new List<Appareil>());
        pieces.Add(p);
        Console.WriteLine("Nouvelle pièce ajoutée avec succès.\nAjouter des appareils à votre pièce:");

        string answer = "oui";
        do
        {
            Console.WriteLine("Choisir le type d'appareil entre: radiateur, seche serviette, chauffe eau");
            string name = Console.ReadLine()!;
            Console.WriteLine("Donner sa température en °C:");
            double temp = Convert.ToDouble(Console.ReadLine()!);
            switch (room)
            {
                case "radiateur": p.appareils.Add(new Radiateur(temp)); break;
                case "seche serviette": p.appareils.Add(new SecheServiette(temp)); break;
                case "chauffe eau": p.appareils.Add(new ChauffeEau(temp)); break;
                default: Console.WriteLine("Error: unkown type"); break;
            }
            Console.WriteLine("Appareil ajoute avec succes.");
            Console.WriteLine("Souhaitez-vous en ajouter un autre? (oui/non)");
            answer = Console.ReadLine()!;
        } while (answer == "oui");

    }

    public override string ToString()
    {
        string description = "";
        description += "\n----- ECRAN DE CONTROLE -----\n";
        for (int i = 0; i < pieces.Count; i++)
            description += pieces[i];

        return description;
    }

}