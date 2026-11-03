using System.Reflection;

partial class Program
{
    
    static void ManejarNulos()
    {
        //No nulificable
        string primerNombre = "Carlos";

        //Nulificable
        string? apellido = null;

        Console.WriteLine($"Nombre: {primerNombre}");

        if(apellido != null )  //el != signfica que es diferente de
        {
            Console.WriteLine($"Apellido: {apellido} ");
        }
        
        else
        {
            Console.WriteLine($"Apellido no especificado");
        }

        //Operaador de coalescencia nula ?? Nos permite resumir el codigo que tenemos de la siguiente forma:

        Console.WriteLine($"Apellido = {apellido ?? "Apellido no especificado!"}");

        //Operador de acceso nulo seguro ?. nos permite obtener el metodo o una propiedad de una clase

        string? text = null;
        Console.WriteLine (text?.Length); //Se pone para que corra la siguiente instruccion, en caso de que no lo pongamos no seguira y nos dara un error de excepción
        Console.WriteLine("Sigue ejecutando");


    }


}