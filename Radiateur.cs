
public class Radiateur : Appareil
{


    public Radiateur(double temperature) : base(temperature)
    {

    }

    public override void ReglerTemperature() // il s'agit d'une methode de la classe mère appareil donc il faut la redéfinir aussi avec override 
    {
        Console.WriteLine("Radiateur: Pour monter taper +, pour descendre taper -, pour passer en mode vacances tapez *");
        char answer = Console.ReadKey().KeyChar;

        switch (answer)
        {

            case '+': ReglageUsine(true, false); break;
            case '-': ReglageUsine(false, true); break;
            case '*': Temperature = 14.0; break;
            default: Console.WriteLine("Error: unkown"); break;
        }
        Console.WriteLine();
    }
    public override string ToString()
    {
        return ("RADIATEUR" + base.ToString());

    }

}