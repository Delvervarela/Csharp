//Las tuplas nos sirven para devolver varios valores de una funcion
// son estructuras de datos ligeros que nos permiten enpaquetar multiples valores en un solo objeto.
// son utiles cuando nosotros necesitamos devolver mas de un resultado sin definir una clase o una estructura personalizada.


partial class Program
{
    
    static void Tuplas()
    {
        (int, string) miTupla = (42, "Hola"); // asi se define una tupla
        WriteLine ($"Numero: {miTupla.Item1}, texto: {miTupla.Item2}"); //asi se manda a llamar una tupla
        

        (int numero, string texto) miOtraTupla = (33, "Nombrado"); // asi se define una tupla
        WriteLine ($"Numero: {miOtraTupla.numero}, texto: {miOtraTupla.texto}"); //asi se manda a llamar una tupla
        
            var resultadoOperacion = Operacion(20, 10);
            WriteLine($"Suma: {resultadoOperacion.suma}, Resta: {resultadoOperacion.sustraccion}");
    

         (int suma, int sustraccion) = Operacion (25, 15);
         WriteLine ($"Suma: {suma}, Resta: {sustraccion}"); 
    
    }

    static (int suma, int sustraccion) Operacion (int a, int b)
    {
        
        return(a+b, a-b);

    }

}