partial class Program
{
    
    static void Visibilidad()
    {
        



    }

}

class Jedi
{
    public string campoPublico = "Soy un jedi y mi poder es conocido"; //Todos van a tener acceso desde cualquier parte del programa

    private string campoPrivado = "Mis pensamientos mas profundos son privados"; // solo van a tener acceso los que estan dentro de esta clase

    protected string campoProtegido = "El lado oscuro no debe conocer mis secretos"; //es accesible dentro de esta clase y en clases derivadas


    public int NivelPoder {get; set;}

    public string? LightSaberColor {get; set;}

    public void FuerzaUso()
    {
        WriteLine($"Soy un jedi con un sable de luz {LightSaberColor} y mi nivel de poder es: {NivelPoder}");



    }
    private void Meditar()
    {
        WriteLine($"Estoy en profunda meditacion con la fuerza");

        

    }
    protected void Entreno()
    {
        WriteLine($"Estoy entrenando para convertirme en el mejor jedi");

        

    }

    class Sith : Jedi
    {
        public void MostrarProtegido()
        {
            WriteLine(campoProtegido);
            Entreno();
        }

    }

}