partial class Program
{
    

    public static void Herencia()
    {
        
        HowgartsEstudiante estudiante = new HowgartsEstudiante() {Nombre = "Harry Potter", Casa = "Gryffindor"};
        HowgartsProfesor profesor = new HowgartsProfesor()
        {
          Nombre= "Severus Snape", Materia = "Posiones"  
        };

        estudiante.Saludar();
        estudiante.MostrarCasa();
        profesor.Saludar();
        profesor.MiMateria();
        


    }



}

class Personaje
{
    
    public string? Nombre {get; set;}


    public virtual void Saludar() //virtual: nos va a permitir que cuando haya una herencia poder sobrescribir el comportaiento de ese metodo 
        {
        WriteLine($"Hola, soy {Nombre}");


    }
}

class HowgartsEstudiante: Personaje // Herencia, el de la derecha es el padre y la izquierda el hijo.
{
    
    public string? Casa {get; set;}

    public override void Saludar()
    {
        WriteLine($"Hola, soy {Nombre} y soy estudiante");
    }

    public void MostrarCasa()
    {
        WriteLine($"Pertenezco a la casa  {Casa} en Hogarts");

    }

}

class HowgartsProfesor: Personaje // Herencia, el de la derecha es el padre y la izquierda el hijo.
{
     public override void Saludar()
    {
        WriteLine($"Hola, soy {Nombre} y soy profesor");
    }
    public string? Materia {get; set;}

    public void MiMateria()
    {
        WriteLine($"Enseño {Materia} en Hogarts");

    }

}