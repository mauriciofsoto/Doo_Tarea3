public class Persona
{
    public string Nombre;
    public int Edad;
    public string Documento;

    // Constructor
    public Persona(string nombre, int edad, string documento)
    {
        Nombre = nombre;
        Edad = edad;
        Documento = documento;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y mi DNI es {Documento}.");
    }

    public void CumplirAnios()
    {
        Edad++;
        Console.WriteLine($"{Nombre} ha cumplido años. Ahora tiene {Edad} años.");
    }
}

public class Auto
{
    public string Marca;
    public string Modelo;
    public Persona Dueno;

    // Constructor
    public Auto(string marca, string modelo, Persona dueno)
    {
        Marca = marca;
        Modelo = modelo;
        Dueno = dueno;
    }

    public void Arrancar()
    {
        Console.WriteLine($"El auto {Marca} {Modelo} ha arrancado.");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Auto: {Marca} {Modelo}");
        Console.WriteLine($"Dueño: {Dueno.Nombre}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Lucía", 30, "12345678");
        Auto auto1 = new Auto("Toyota", "Corolla", persona1);

        persona1.Presentarse();
        persona1.CumplirAnios();

        auto1.Arrancar();
        auto1.MostrarInformacion();
    }
}
