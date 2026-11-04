partial class Program
{
    
static void Metodos()
    {
        //Constructor por defecto
        Carro carro = new Carro(); //aqui lo que estamos haciendo es crear e instanciar el objeto carro.
        carro.Modelo = "Yaris";
        carro.Año = 2015;
       
       /* WriteLine(carro.MostrarInfo());
        carro.MostrarMensaje();
        carro.MostraMensaje("Cambiando de modelo");
        carro.CambiarModelo("Patrol", 2016);
        WriteLine(carro.MostrarInfo());

        Carro.InformacionGeneral();
*/

    //Un contructor nos sirve para construir y inicializar una instancia de la clase
        Carro carroDeportivo = new Carro("Ferrari", 2020);
        WriteLine(carroDeportivo.MostrarInfo());

    
    //Sintais simplificada
    Carro coleccionCarro = new Carro {Modelo = "Cadillac", Año = 2022};
    WriteLine(coleccionCarro.MostrarInfo());

    //Lista de objetos
    WriteLine("Listado de automoviles: ");
    List<Carro> carros = new()
    {
        
        new Carro() {Modelo = "Duster", Año = 2014},
        new Carro() {Modelo = "Nissan", Año = 2019},
        new Carro() {Modelo = "Mazda", Año = 2018}

    };
        foreach(var carro1 in carros)
        {
            
            WriteLine(carro1.MostrarInfo());

        }


    
    }

    
}

class Carro
{
    
public string? Modelo {get; set;}
public int Año {get; set;}

//Constructor con parametros
public Carro(string modelo, int año)
    {
        Modelo = modelo;
        Año = año;


    }

//constructor vacio para inicializar - Constructor por defecto
    public Carro()
    {
        
    }

    //Destructor (~) se usa la virgulilla para definir al destructor
    ~Carro()
    {
        
        WriteLine("Destructor llamado. Recurso liberado");

    }



//metodo

public void CambiarModelo(string nuevoModelo, int año)
    {
        Modelo = nuevoModelo;
        Año = año;

    }

public string MostrarInfo()
    {
        return $"Automovil: {Modelo}, Año: {Año}";

    }

//Para la clase buses tenemos, 

    //sobrecarga de metodos: 2 metodos que tiene el mismo nombre pero que hacen funciones diferentes.
    public void MostrarMensaje() => WriteLine("Este es un automovil");

    public void MostraMensaje(string mensaje) => WriteLine(mensaje);


    public static void InformacionGeneral ()
    {
        WriteLine("El automovil es uno de los transportes mas utilizados");

    }
}