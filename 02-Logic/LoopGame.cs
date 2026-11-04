
//Bucle de un "Juego" en el que presionar varias teclas aumentara el contador, con la opcion de salir que nos mostrara el total de las teclas que hemos presionado.

partial class Program
{
    static void LoopGame()
    {
        
        int contador = 0;
        WriteLine("Pulse cualquier letra para aumentar el contador");
        WriteLine("Pulsa ESC para salir ");
        while(true)
        {
            var tecla = ReadKey(true).Key;
            if (tecla == ConsoleKey.Escape)
            {
                WriteLine($"Haz pulsado {contador} teclas antes de salir");
                WriteLine("Programa terminado");
                break;

            }


            contador++;

        }
    
        
    }

    
}