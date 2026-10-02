

public abstract class Appareil
{
    protected double temperature;  

    public double Temperature
    {

        get { return temperature; }
        set
        {
            if (value >= 60)
                temperature = 6;
            else if (value <= 14)
                temperature = 14;
            else temperature = value;
        }

    }

    public Appareil(double temperature)
    {
        Temperature = temperature; // la propriété n'est pas correctement attribuée 
    }

    public void ReglageUsine(bool up, bool down)
    {
        if (up) Temperature += 0.5;
        else if (down) Temperature -= 0.5;

    }

    public abstract void ReglerTemperature(); // on ne defini pas la methode ici elle sera redéfinifine dans la classe heritière donc pas d'accolades et il faut mettre abstract c'est une methode abstraite 
    

    


    public override string ToString()
    {
        string description = "";
        description += ": " + Temperature;
        return description;
    }
}