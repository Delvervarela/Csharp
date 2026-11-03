partial class Program
{
    
    static void Arreglos()
    {
        
        int[]  numeros = new int[5];
        numeros [0] = 1;
        numeros [2] = 1;
      


        //Directa 
        int [] arregloNumeros = [5, 10, 15, 20, 25, 30];


        //indices 
        Console.WriteLine($"Primer elemento: {arregloNumeros [0]}");
        Console.WriteLine($"Segundo elemento: {arregloNumeros [2]}");

    //Tamaño del arreglo
            Console.WriteLine($"El numero de elementos es: {arregloNumeros.Length}");


    //Consejo: si no necesitamos agregar y eliminar elementos dinamicamente, deberiamos usar arreglos porque el uso de memoria es mas eficiente


        //Desde el final de arreglo ^ es decir que en vez del primer elemento queremos el ultimo elemento.
        Console.WriteLine($"Ultimo elemento: {arregloNumeros [^1]}");
        Console.WriteLine($"Penultimo elemento: {arregloNumeros [^2]}");


        //Rangos para obtener subarreglos

        int [] primerosTres = arregloNumeros [..3];
        int [] desde2Adelante = arregloNumeros [2..];
        foreach(var numero in desde2Adelante)
        {Console.WriteLine(numero);};

        foreach(var numero in primerosTres)
        {Console.WriteLine(numero);};
        



        
    
    

    }


}