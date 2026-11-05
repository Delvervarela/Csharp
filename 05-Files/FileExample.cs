partial class Program
{
    
    static void EjemploArchivos()
    {
        var filePath = "./Anotaciones/linq.txt";
        var contenido = File.ReadAllText("./Anotaciones/linq.txt"); //Esta nos sirve para leer el contenido de un archivo    
        //WriteLine(contenido);

        var lineas = File.ReadAllLines("./Anotaciones/Linq.txt");
        foreach (var linea in lineas)
        {
           // WriteLine(linea);
        }
            //WriteLine(lineas[3]);

       File.Copy(filePath, "./05-Files/Ejemplo de copia.txt", //Para hacer una copia exacta de un archivo
        overwrite: true);


        File.Delete("./05-Files/EjemploEscritura.txt");//Se utiliza para borrar un archivo


    }


}