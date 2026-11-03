partial class Program
{
        static void Generico()
    {
        
        string [] nombres = {"Juan", "Luis", "Diana", "Victor"};
        int [] numeros = {1, 2, 3};
        WriteLine($"Tamaño de arreglo numerico: {ObtenerLargoArreglos(numeros)}");
        WriteLine($"Tamaño del arreglo de nombres: {ObtenerLargoArreglos(nombres)}");
        Box<int> numeroBox = new Box<int> {Contenido = 50};
        Box<string> stringBox = new Box<string> {Contenido = "Ahora soy texto"};
        numeroBox.Mostrar();
        stringBox.Mostrar();


    }

    //Metodos sin el uso de genericos
    static int ObtenerLargoNumero(int[] array)
    {
        return array.Length;
    }
    static int ObtenerLargoNombre(string[] array)
    {
        return array.Length;
    }

    //Metodo Generico - es la mejor opcion para usar metodos que hacen lo mismo
    static int ObtenerLargoArreglos<T>(T[] array)
    {
        return array.Length;

    }

  

}

class Box<T> //clase generica
{
    
    public T? Contenido {get; set;}


    public void Mostrar()
    {
        WriteLine($"Contenido {Contenido}");
    }

}

//Los genericos nos van a servir para evitar duplicar codigo
//Las clases genericas para trabajar con distintos tipos de datos 