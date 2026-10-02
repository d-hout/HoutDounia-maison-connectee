public class ChauffeEau : Appareil
{

    public ChauffeEau(double temperature) : base(temperature)
    {

    }

    public override void ReglerTemperature()
    {
        Console.WriteLine("Chauffe-eau: Pour monter taper +, pour descendre taper -, pour passer en mode vacances tapez *");
        char answer = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (answer)
        {
            case '+': ReglageUsine(true, false); break;
            case '-': ReglageUsine(false, true); break;
            case '*': Temperature = 20.0; break;
            default: Console.WriteLine("Error: unkown"); break;
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return ("CHAUFFE-EAU" + base.ToString());
    }
}