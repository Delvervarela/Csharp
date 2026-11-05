partial class Program
{
    
    static void EjemploDirectorio()
    {
        
        var directorioPath = "./05-Files";
        //Directory.CreateDirectory($"{directorioPath}/DirEjemplo/OtroDir"); //ste nos sirve para crear uno o varios directorios 

        if (Directory.Exists($"{directorioPath}//DirEjemplo/OtroDir"))//Este nos sirve para validar que el directorio existe en caso de que tengamos dudas
        {
            WriteLine("El directorio ya existe");

        }

        Directory.Delete($"{directorioPath}//DirEjemplo", recursive : true); //Nos sirve para borrar directorios
            //El recursive true, nos sirve para forzar el borrado del directorio.

    }


}