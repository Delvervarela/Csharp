using System.Globalization;

partial class Program
{
    
    static void ConversionDateTime()
    {
        
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo ("es-ES");


        int amigos = int.Parse("101");
        double costo = 25.38;
        DateTime cumpleaños = DateTime.Parse("2 de Marzo 2025");
        WriteLine($"Tengo {amigos} amigos para invitar a mi fiesta de cumpleaños");
        WriteLine($"La fiesta se llevara a cabo el {cumpleaños}");
        WriteLine($"fecha en formato largo: {cumpleaños:D}"); // el :D es para que nos de el dia de la fecha.
        WriteLine($"El costo de la entrada sera de {costo:C}");
    }


}