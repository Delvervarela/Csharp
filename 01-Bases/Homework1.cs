partial class Program
{
    static void ReporteVentas()
    {
        
        string producto = "Laptop";
        int cantidadVendida = 3;
        double precioUnitario = 750.99;
        double totalVenta = cantidadVendida * precioUnitario;

        Console.WriteLine($"Se vendieron {cantidadVendida} {producto} a {precioUnitario:C} que dio un total de {totalVenta:C}");


    }





}


//Tarea 2 - Calculadora de salario

partial class Program
{
    
    static void CalculadoraSalario()
    {
        
        string nombre = "Teddy";
        int horasTrabajadas = 12;
        double salarioHora = 20d;
        double totalSalario = horasTrabajadas * salarioHora;

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Calculadora de Salario");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Ingrese su nombre: {nombre}");
        Console.WriteLine($"Ingrese el total de las horas trabajadas: {horasTrabajadas}");
        Console.WriteLine($"Ingrese su salario por hora: {salarioHora:C}");
        Console.WriteLine($"El salario de Teddy es: {totalSalario:C}");
     








    }


     static void SalarioCalculadora()
    {
        

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("        Calculadora de Salario");
        Console.WriteLine("----------------------------------------");
        Console.Write("Ingrese su nombre: ");
        string? nombre = Console.ReadLine();
        Console.Write("Ingrese el total de horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine()!); // ! = es que se le permite que el valor sea nulo.
        Console.Write("Ingrese el salario por hora: ");
        double salarioHora = double.Parse(Console.ReadLine()!);
        double totalSalario = horasTrabajadas * salarioHora;
        Console.WriteLine($"El salario de {nombre} es : {totalSalario:C}");

        // el double.parse nos sirve para convertir a double un string


    }




}