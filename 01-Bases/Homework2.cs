partial class Program
{
    
    static void DiasDeVida()
    {
        
        DateTime fechaNacimiento = new DateTime (1983, 3, 2);
        TimeSpan diferencia = DateTime.Now - fechaNacimiento;
        Console.WriteLine ($"Has vivido {diferencia.Days} dias.");




    }





    static void DaysUntilNextBirthday()
    {

    Console.WriteLine("----------------------------------------");
    Console.WriteLine(" ¿Cuando es su proximo cumpleaños? ");
    Console.WriteLine("----------------------------------------");    
    Console.Write("Ingrese su fecha de nacimiento");
    DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine()!);
    TimeSpan diferencia = DateTime.Now - fechaNacimiento;
    Console.WriteLine($"Faltan {diferencia.Days} dias para su proximo cumpleaños.");



    }




}
