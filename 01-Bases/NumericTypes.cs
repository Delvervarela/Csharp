partial class Program
{
    
static void ShowNumericTypes()
{
    
    //int numeroEntero = int.MaxValue; //Si lo dejamos asi poodremos ver el maximo valor que podemos almacenar en la variable
    int numeroEntero = 45;
    double doubleNumber= 3.1416d;
    float floatingNumber = 247f;
    long numeroGrande = 1_234_567_890_123_456_789L; //
    decimal numeroMonetario = 100.50m;

    Console.WriteLine($"Numero entero: {numeroEntero} ");
    Console.WriteLine($"double: {doubleNumber} ");
    Console.WriteLine($"Numero flotante: {floatingNumber} ");
    Console.WriteLine($"Numero grande: {numeroGrande} ");
    Console.WriteLine($"Numero Monetario: {numeroMonetario} ");
    

}


}