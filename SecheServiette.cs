

public class SecheServiette : Appareil
{
    public SecheServiette(double temperature) : base(temperature)
    {

    }

    public override void ReglerTemperature()
    {
        Console.WriteLine("Seche-Serviette: Pour secher taper /, pour un boost de température taper $, pour monter taper +, pour descendre taper -, pour passer en mode vacances tapez *");
        char answer = Console.ReadKey().KeyChar;

        switch (answer)
        {
            case '/': Temperature = 35.0; break;
            case '$': Temperature = 27.0; break;
            case '+': ReglageUsine(true, false); break;
            case '-': ReglageUsine(false, true); break;
            default: Console.WriteLine("Error: unkown"); break;
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return ("SECHE-SERVIETTE" + base.ToString());
    }
}