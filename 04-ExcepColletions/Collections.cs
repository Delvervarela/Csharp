partial class Program
{
    
    static void Colecciones()
    {

        List<string> nombres = ["Luis", "Pedro", "Pablo"];  //Nos sirve para hacer una lista dinamica de elementos
        nombres.Add("Ana");
        //MostrarNombres(nombres);
        //WriteLine("Despues de remover a luis");
        nombres.Remove("Luis");
        //MostrarNombres(nombres);


        Dictionary<int, String> estudiantes = new() //Nos sirve para almacenar pares de clave-valor
        {

            {1, "Ana"},
            {2, "Carlos"},
            {3, "Pablo"}

        };

        estudiantes.Add(4, "Roberto");
        //MostrarEstudiante(estudiantes);
        //WriteLine("Despues de remover a ana");
        estudiantes.Remove(1);
        //MostrarEstudiante(estudiantes);


        HashSet<string> usuarios = ["Luis", "Pedro", "Pablo"];  //En este podemos almacenar elementos unicos, es decir que no pueden haber duplicados.
        usuarios.Add("Melisa");
        usuarios.Add("Maria");
        usuarios.Add("Luis");
        foreach(var usuario in usuarios)
        {
            WriteLine(usuario);


        }


    }

    private static void MostrarEstudiante(Dictionary<int, string> estudiantes)
    {
        foreach (var estudiante in estudiantes)
        {
            WriteLine($"Id: {estudiante.Key}, Estudiante: {estudiante.Value}");

        }
    }

    private static void MostrarNombres(List<string> nombres)
    {
        foreach (var nombre in nombres)
        {

            WriteLine(nombre);

        }
    }
}