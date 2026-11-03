using System.Globalization;

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
    Console.Write("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
    DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine()!);
    TimeSpan diferencia = DateTime.Now - fechaNacimiento;
    Console.WriteLine($"Faltan {diferencia.Days} dias para su proximo cumpleaños.");

    //Aqui se puede calcular pero no correctamente.

    }


    static void DiasHastaProximoCumpleaños()
    {
        
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(" ¿Cuando es su proximo cumpleaños? ");
    Console.WriteLine("----------------------------------------");   

    Console.WriteLine("¿Cual es su fecha de nacimiento (dd/mm/yyyy)?"); //Siempre WriteLine
    string fechaNacimientoString = Console.ReadLine()!;  //Se guarda en una variable de tipo string
    DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    DateTime fechaActual = DateTime.Now.Date; //Esto es para decirle que queremos la fecha de hoy pero sin hora
    DateTime proximoCumpleaños = new DateTime(fechaActual.Year,  fechaNacimiento.Month, fechaNacimiento.Day); //Aqui vamos a obtener el año de la fecha actual, pero el mes y dia de la fecha de naciemineto para hacer el calculo.
    if (proximoCumpleaños < fechaActual )
        {
            proximoCumpleaños = proximoCumpleaños.AddYears(1); //Se pone la condicional para asegurarse de que no llegue a haber una confusión

        }

    int diasRestantes = (proximoCumpleaños - fechaActual).Days;
    Console.WriteLine ($"Faltan {diasRestantes} días para tu proximo cumpleaños");



    }


}
