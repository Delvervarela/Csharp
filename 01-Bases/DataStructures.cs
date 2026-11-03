using System.Drawing;

partial class Program
{
    
    static void EstructuraDatos()
    {
        User pedro =new User {nombre = "Pedro", edad= 33 };
        pedro.Greet();
        Point punto = new Point {X= 30, Y=20};
        Console.WriteLine ($"Punto ({punto.X}, {punto.Y})");
        CellPhone nokia = new CellPhone ("Nokia 225", 2024);
        Console.WriteLine(nokia);

    }

}


//Las clases son para objetos que son mas complejos 
class User
{
    public string? nombre {get; set;}

    public int edad {get; set;}


    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {nombre} y tengo una edad de {edad}");

    }

}

//Struct son tipos de valores utilizados para datos mas pequeños y ligeros


//Los stracts para datos que son mas ligeros
struct Punto
{
    public int X { get; set; }
    public int Y { get; set; }

}

//son para datos inmutables
record CellPhone (string Model, int Year);