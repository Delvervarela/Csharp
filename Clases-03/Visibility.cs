partial class Program
{
    
    static void Visibilidad()
    {
        Jedi jedi = new Jedi();
        jedi.PoderNivel = 5000;
        jedi.SableColor = "Azul";

        //jedi.FuerzaUso();
        //WriteLine(jedi.campoPublico);
        //WriteLine(jedi.campoPrivado);
        //WriteLine(jedi.campoProtegido);
        //jedi.RevelarSecretos();

        Sith sith = new Sith();
        sith.PoderNivel = 4000;
        sith.SableColor = "Rojo";
        sith.FuerzaUso();
        //sith.MostrarProtegido();


    }

}

interface IFuerzaUso
{
    int PoderNivel {get; set;}
    string? SableColor {get; set;}

    void FuerzaUso();

}

class Jedi:IFuerzaUso
{
    public string campoPublico = "Soy un jedi y mi poder es conocido"; //Todos van a tener acceso desde cualquier parte del programa

    private string campoPrivado = "Mis pensamientos mas profundos son privados"; // solo van a tener acceso los que estan dentro de esta clase

    protected string campoProtegido = "El lado oscuro no debe conocer mis secretos"; //es accesible dentro de esta clase y en clases derivadas


    public int PoderNivel {get; set;}

    public string? SableColor {get; set;}

    public void FuerzaUso()
    {
        WriteLine($"Soy un jedi con un sable de luz {SableColor} y mi nivel de poder es: {PoderNivel}");



    }
    private void Meditar()
    {
        WriteLine($"Estoy en profunda meditacion con la fuerza");

        

    }
    protected void Entreno()
    {
        WriteLine($"Estoy entrenando para convertirme en el mejor jedi");

        

    }

    public void RevelarSecretos()
    {
        
        WriteLine(campoProtegido);
        WriteLine(campoPrivado);
        Meditar();

    }


}

class Sith : Jedi, IFuerzaUso
    {

        public new void FuerzaUso()
    {
        WriteLine($"Soy un Sith con un sable de luz {SableColor} y mi nivel de poder es: {PoderNivel}");
    }
        public void MostrarProtegido()
        {
            WriteLine(campoProtegido);
            Entreno();
        }

    }

