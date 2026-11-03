partial class Program
{
    
static void ShowStringType()
{
    string nombre = "Alex";
    string mensaje = "Hola " + nombre;
    string mensajeInterpolado = $"Hola {nombre}"; 

    Console.WriteLine(mensaje);
    Console.WriteLine(mensajeInterpolado);
    Console.WriteLine($"tu nombre tiene: {nombre.Length} palabras"); //para saber la cantidad de letras que tiene la palabra
    Console.WriteLine($"Tu nombre en mayusculas es: {nombre.ToUpper()}");
    Console.WriteLine($"Tu nombre en minusculas es: {nombre.ToLower()}");


    int number = 13;
    Console.WriteLine (number);
    bool isString = true;
    Console.WriteLine(isString);



}


}