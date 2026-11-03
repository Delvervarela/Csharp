using System.Security.Cryptography;

partial class Program
{
    
    static void Condicionales ()
    {
        
       int edad = 12;


        /*

Los IF nos sirven para que se ejecute un bloque de codigo si se cumple una condicion
*/
        if(edad >=18)
        {
            WriteLine("Es mayor de edad" );
        }

        else
        {
            WriteLine("Es menor de edad");

        }

        //If ternario
        string mensaje = edad >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
        WriteLine(mensaje);

        //multiples condicionales
        int temperatura = 30;

        if(temperatura >35)
        {
            WriteLine("Hace mucho calor");
        }
        else if(temperatura >=20)
        {
            WriteLine("Es agradable");
            
        }
        else
        {
            WriteLine("Hace frio");
        }

        
        
        
        //Switch - forma clasica
        
        int dia =3;

        switch (dia)
        {
            case 1:

            WriteLine("Lunes");
            break;
            
            
            case 2:

            WriteLine("Martes");
            break;
            
            
            case 3:

            WriteLine("Miércoles");
            break;

            default:
            WriteLine("Día no válido");
            break;
            

        }

        
        //Switch con expresiones
        string mensajeDia = dia switch //Esto es un switch pero mas simplificado
        {
            
            1=> "Lunes",
            2=> "Martes",
            3=> "Miercoles",
            _ => "Día no valido" //guion bajo para el default

        };

        WriteLine (mensajeDia);
        

    }


}


