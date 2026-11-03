using System.Runtime.CompilerServices;

//Las listas son ideales para almacenar y manipular colecciones ordenadas.


partial class Program
{
    static void ListaDiccionario()
    {
        List<string> nombres = new List<string>{"Ana", "Carlos", "Juan"};
        nombres.Add ("Lucia"); //sirve para agregarle elementos a la lista
        Console.WriteLine($"Total de nombres: {nombres.Count}");
        foreach (var nombre in nombres)
        {
            
            Console.WriteLine(nombre);


        }

        nombres.Remove("Ana");
        bool estaPresente = nombres.Contains("Ana");
        Console.WriteLine($"¿Ana esta en la lista? {estaPresente}");


        //Dictionary
        Dictionary<int, string> estudiantes = new Dictionary<int, string>
        {
          {1, "Ana"},  
          {2, "Felipe"},  
          {3, "Elena"}  
        };

        Console.WriteLine($"El estudiante con ID 1 es: {estudiantes [1]}");

         foreach (var estudiante in estudiantes)
         {
            Console.WriteLine($"ID: {estudiante.Key}, Nombre: {estudiante.Value}");
         } 

       

    }


}