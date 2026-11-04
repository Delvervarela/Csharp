//Partial es para que se una la clase program en una sola

partial class Program
{
    
        static void PruebaClase()
    {
        
        Vehiculo honda = new Vehiculo();
        honda.Marca = "Honda";
        honda.Modelo = "Civic";
        honda.Año = 2021;

        Vehiculo toyota = new Vehiculo {Marca = "Toyota", Modelo = "Corolla", Año = 2021};


        Vehiculo renault = new Vehiculo("Renault", "Duster", 2025);

        honda.MostrarInfo();
        toyota.MostrarInfo();
        renault.MostrarInfo();




    }


}

class Vehiculo
{
    //Propiedades
    public string? Marca {get; set;}
    public string? Modelo {get; set;}
    public int Año {get; set;}


    //Metodo Constructor: se ejecuta en cuanto se hace la instancia de la clase

        public Vehiculo (string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public Vehiculo()
    {
        
    }

    //Metodos
    public void MostrarInfo()
    {
        
        WriteLine($"Este vehiculo es un {Marca} {Modelo} del año {Año}");

    }



    

}