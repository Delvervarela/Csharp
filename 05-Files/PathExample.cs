partial class Program
{
    
    static void EjemploRuta()
    {

        //En este ejercicio nos sirvio para ver la informacion del archivo linq de forma detallada.
        
        var rutaArchivo = "./Anotaciones/LINQ.txt";
        var nombreArchivo = Path.GetFileName(rutaArchivo);
        WriteLine($"Nombre del archivo: {nombreArchivo}");
        var extensionArchivo = Path.GetExtension(rutaArchivo);
        WriteLine($"Extension del archivo: {extensionArchivo}");
        var nombreDirectorio = Path.GetDirectoryName(rutaArchivo);
        WriteLine($"Nombre del directorio: {nombreDirectorio}");
        var combinacionRuta = Path.Combine("C:", "User", "Documentos", "LINQ.txt");
        WriteLine($"Ruta Combinada: {combinacionRuta}");
        var fullRutaArchivo = Path.GetFullPath(rutaArchivo);
        WriteLine($"Ruta completa del archivo: {fullRutaArchivo}");
        





    }


}