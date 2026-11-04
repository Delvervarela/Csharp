//Hacer calculadora de un factorial

partial class Program
{
    

    static void CalcularFactorial(int numero)
    {
        WriteLine($"Factorial del numero {numero} desde el 1 hasta el {numero} ");
        WriteLine();
        for(int i = 1; i <= numero; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}"); //se va a utilizar la funcion factorial de C#
        }

        WriteLine();
        


    }

    static int Factorial(int numero)
    {
        
        int resultado = 1;
        for(int i = 1; i <= numero; i++ )
        {
            
            resultado *= i;
        }


        return resultado;




    }




}
