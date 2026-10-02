
// NB: Il n'y a aucun controle des saisies pour ne pas allourdir ce code qui a une pure vocation pedagogique

Console.WriteLine("\n*** INITIALISATION AVEC CREATION DU SALON ***");
Radiateur radSalon1 = new Radiateur(19.5);
Radiateur radSalon2 = new Radiateur(19.5);

List<Appareil> radSalon = new List<Appareil>();

radSalon.Add(radSalon1);
radSalon.Add(radSalon2);

Piece salon = new Piece("SALON", radSalon);

List<Piece> maison = new List<Piece>();
maison.Add(salon);

PanneauControle pc = new PanneauControle(maison);
Console.WriteLine(pc);

Console.WriteLine("\n*** AJOUTER UNE PIECE ***");
pc.AddNewPiece();

Console.WriteLine(pc);

Console.WriteLine("\n*** CONTROLE DE TEMPERATURE ***");

Console.WriteLine("SALON:");
foreach (Appareil a in pc.pieces[0].appareils)
    a.ReglerTemperature();

Console.WriteLine("2e PIECE");
foreach (Appareil a in pc.pieces[1].appareils)
    a.ReglerTemperature();

Console.WriteLine(pc);
Console.WriteLine();

