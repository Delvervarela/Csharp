using System.Security.Cryptography.X509Certificates;

partial class Program
{
    
    static void TypeDifference()
    {
        
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine ($"X: {x}, Y: {y}");


        Person persona1 = new Person {nombre = "Carlos"};
        Person persona2 = persona1;
        persona2.nombre = "Alicia";
        Console.WriteLine ($"Persona1.name {persona1.nombre}");


    }



    class Person
    {
        
        public string? nombre {get; set;}


    }

}