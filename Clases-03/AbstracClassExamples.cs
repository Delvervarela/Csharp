partial class Program
{
    static void ClaseAbstractaEjemplo()
    {
        
        HomeAppliance miLavadora = new Lavadora {Marca = "Samsung"};
        HomeAppliance miMicroondas = new Microondas {Marca = "DG"};
        miLavadora.MostrarMarca();
        miLavadora.Encender();
        miMicroondas.MostrarMarca();
        miMicroondas.Encender();

    }

}

abstract class HomeAppliance{
    
    public string? Marca {get; set;}
    public abstract void Encender();

    public void MostrarMarca()
    {
        WriteLine($"La marca de electrodomesticos {Marca}");
    }

}

class Lavadora : HomeAppliance
{

    public override void Encender()
    {
        WriteLine("La lavadora a inicializado el ciclo de lavado");
    }

}

class Microondas : HomeAppliance
{
    
    public override void Encender()
    {
        WriteLine("El microondas esta calentando la comida");
    }

}