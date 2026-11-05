partial class Program
{
    
    static void EjemploEscrituraArchivo()
    {
        //Este ejercicio sirve para crear un nuevo archivo y sobreescribirlo si se desea.   
        var rutaArchivo = "./Anotaciones/Serialización.txt";
        var contenido = "La deserializacion es operacion inversa, convertir cadena en objeto";
        var streamWriter = new StreamWriter(rutaArchivo, //dejamos la linea asi para crear o sobrescribir el archivo
        append: true);//esta linea es por si queremos agregar contenido al documento
        streamWriter.WriteLine(contenido);
        //streamWriter.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));
        streamWriter.Dispose();
        WriteLine("Archivo creado exitosamente");          //Dispose:






    }


}