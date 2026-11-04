partial class Program
{
    
    //Una funcion es un bloque de codigo reutilizable que realiza una tarea en especifico

    static double CalcularArea(double ancho, double altura)
    {
        return ancho * altura;



    }

        static string EvaluarNumero(int numero)
    {
        if(numero > 0)
        return "Positivo";

        else if (numero < 0)
        return "Negativo";

        else
        return "Cero";

    }

    static void Funciones()
    {
        
   var area = CalcularArea (4.5, 2.23);
   WriteLine($"El area es: {area}");
    var evaluarnumero = EvaluarNumero (-45);
    WriteLine ($"El numero evaluado es: {evaluarnumero}");


    }

}