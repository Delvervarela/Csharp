partial class Program
{
    static string? monto;
    static void ManejarExcepciones()
    {

        try
        {
        //int numero = 10;
        //int resultado = numero / 0;

        

        Write("Ingrese un monto: ");
        monto = ReadLine();
        if(string.IsNullOrEmpty(monto)) return;
        if (double.TryParse(monto, out double valorMonto))

            {
        //double valorMonto = double.Parse(monto);
        WriteLine($"El monto que introdujiste es el siguiente: {valorMonto:C}");

            }
            else
            {
                WriteLine("No se pudo convertir el texto a numero");

            }

            ValidarEdad(16);

        }

        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Error: Divisón por cero");

        }
        catch (FormatException) when (monto?.Contains ("L") == true)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("No es necesario usar el simbolo de 'L'");

        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;   
            WriteLine(ex.Message);
        }
        finally
        {
            Console.ResetColor();
            Write("Esto simpre se ejecutara cuando hay errores");

        }

        
        


    }


    static void ValidarEdad (int edad)
    {
        if(edad < 18)
        {
            
            throw new ArgumentException ("La edad debe ser mayor a 18");
        }
    }

}