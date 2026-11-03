partial class Program
{
    static void variables()
    {
        int edad = 25;
        string nombre = "Juan";
        bool esEstudiante = true;

        Console.WriteLine($"Nombre: {nombre} tiene una edad {edad} es estudiante {esEstudiante}"); //Cuando colocamos el signo $ nos permite colocar varias variables dentro de una misma respuesta, a eso tambien le llaman interpolacion

    }
}


partial class Program
{
    static void Estudiante()
    {
        int edad = 12;
        string nombre = "Roberto";
        string apellido = "Gonzalez";
        bool esEstudiante = false;

        Console.WriteLine($"Nombre: {nombre} {apellido} tiene una edad {edad} es estudiante {esEstudiante}"); //Cuando colocamos el signo $ nos permite colocar varias variables dentro de una misma respuesta, a eso tambien le llaman interpolacion

    }
}




