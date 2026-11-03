partial class Program
{
    static void Operadores()
    {
        
            
            
            
            int numero = 100;
            

            bool esPar = numero % 2 == 0;


            bool esMayorQue = numero > 10;

        if (esPar && esMayorQue)
        {
            
            Console.WriteLine($"El numero {numero} es par y es mayor que 10 ");
        }

        else if (!esPar && esMayorQue )
        {
            Console.WriteLine($"El numero {numero} es impar y es mayor que 10");


        }
        else
        {
            Console.WriteLine($"El numero {numero} no cumple con las condiciones");
        }


        //Operador Ternario (?:)

        int edad = 21;
        string categoria = edad > 18 ? "Adulto" : "Menor";
        Console.WriteLine(categoria);

    }



        static void CalculadorEdad()
    {
        
        



    }




}