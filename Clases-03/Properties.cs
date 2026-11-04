partial class Program
{
    static void Propiedades()
    {
        
        Animal animal = new Animal ("Bosque");
        animal.Especies = "Lobo";
        animal.Edad = 5;
        WriteLine($"Vive en el {animal.Habitat}, que animal es: {animal.Especies}, que tiene categoria de: {animal.Categoria}");


    }


}

class Animal
{
    //Propiedades
    public string Especies {get; set;} = "Desconocida"; //valor por defecto
    public string Categoria {get; set;} = "Vertebrado";

    private int edad;

    public int Edad
    {
        
        get{ return edad;}
        set
        {
            if (value < 0)
            {
                
                throw new ArgumentException ("La edad no puede ser negativa");

            }

            edad = value;

        }


    }


    public string Habitat {get;}
     
    public Animal(string habitat)
    {
        Habitat = habitat;

    }

}