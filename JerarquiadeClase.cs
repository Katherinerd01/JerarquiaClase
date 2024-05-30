using System;

public class Animal
{
    public string Nombre { get; set; }

    public virtual void HacerSonido()  
    {
        Console.WriteLine($"{Nombre} hace un sonido.");
    }
}

public class Perro : Animal  
{
    public override void HacerSonido() 
    {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}

public class Gato : Animal  
{
    public override void HacerSonido()  
    {
        Console.WriteLine($"{Nombre} está maullando.");
    }
}

public class Humano
{
    private string nombre; 

    public string Nombre  
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                throw new Exception("El nombre no puede estar vacío.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro perro = new Perro { Nombre = "Popi" };
        Gato gato = new Gato { Nombre = "Pelusa" };
        Humano humano = new Humano { Nombre = "Alexander" };

        perro.HacerSonido();
        gato.HacerSonido();

        Console.WriteLine($"El nombre del humano es {humano.Nombre}.");
    }
}
