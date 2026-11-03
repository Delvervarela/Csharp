partial class Program
{
    
    static void Loops()
    {
        
        //Bucle while ejecuta el codigo mientra la condicion sea verdadera, si es falsa nunca se ejecutara

        int contador = 1;
        while (contador <= 10)
        {

            //WriteLine($"Iteracion: {contador}");
            contador ++;
        }


            int numero = 0;
        do
        {
           // WriteLine($"Numero: {numero}");
            numero++;

        }while(numero < 3);


        //Bucle for - nos va a servir para cuando sepamos cuantas veces vamos a iterar.
        //inicializacion del bucle-- Condicional-- Incrementador o iterador
        for (int i = 0;              i<= 5;       i++)
        {
            
            WriteLine($"Iteración {i}");
        }


        //Foreach se utiliza para recorrer colecciones como arreglos o listas
        //Arreglo
        string [] frutas = ["Manzana", "Pera", "Mango"];
        foreach (var fruta in frutas )
        {
            WriteLine(fruta);
        }

        // for personalizado
        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }

        //Listas
        List<string> nombres = ["Juan", "Roberto", "Victor"];
        foreach(var nombre in nombres)
        {
            WriteLine(nombre);
        }
            
    }

}
