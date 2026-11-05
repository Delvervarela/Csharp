using System.ComponentModel.Design;

partial class Program
{
    static void Linq()
    {
        
        List<int> numeros = [1, 2, 3, 4, 5, 6];
        List<int> numerosPares = [];

        foreach (var numero in numeros)
        {
            if(numero % 2 ==0)
            {
                numerosPares.Add(numero);

            }
        }

        //sintaxis de consulta
        var numeroParQuery = from num in numeros
                             where num % 2 == 0
                             select num;

        //Sintaxis de metodos
        var metodoNumeroPar = numeros.Where(n => n%2 ==0);
        foreach (var numero in metodoNumeroPar)
        {
            //WriteLine(numero);
        }

        //Consultas simples


List<MarvelPersonajes> personajes = new List<MarvelPersonajes>
{
  new MarvelPersonajes { Nombre = "Peter Parker", Alias = "Spider-Man", Equipo = "Avengers" },
  new MarvelPersonajes { Nombre = "Tony Stark", Alias = "Iron Man", Equipo = "Avengers" },
  new MarvelPersonajes { Nombre = "Steve Rogers", Alias = "Captain America", Equipo = "Avengers" },
  new MarvelPersonajes { Nombre = "Natasha Romanoff", Alias = "Black Widow", Equipo = "Avengers" },
  new MarvelPersonajes { Nombre = "T'Challa", Alias = "Black Panther", Equipo = "Wakanda" },
  new MarvelPersonajes { Nombre = "Stephen Strange", Alias = "Doctor Strange", Equipo = "Defenders" }
 };

   WriteLine("Personajes que pertenecen a los Avengers");
   var avengersQuery = from P in personajes
                      where P.Equipo == "Avengers"
                      select $"{P.Alias} {P.Nombre}";
   
        var metodoAvengers = personajes.Where(P => P.Equipo == "Avengers");
        foreach (var personaje in personajes)
        {
            //WriteLine($"Personaje: {personaje.Alias},  Nombre real: {personaje.Nombre}");
        }

        var upperCaseNombresQuery = from p in personajes
                                    select p.Nombre?.ToUpper();
        

        var upperCaseNombresMetodo = personajes.Select(p => p.Nombre?.ToUpper());
        WriteLine("Los nombres en mayuscula");
        foreach (var nombre in upperCaseNombresMetodo)
        {
            //WriteLine(nombre);
        }


        var sortedQuery = from p in personajes
        orderby p.Nombre 
        select p.Nombre;

        var sortedMetodo = personajes.OrderByDescending(p => p.Nombre);
        WriteLine("Ordenar los nombres de manera descendente");
        foreach (var personaje in sortedMetodo)
        {
            //WriteLine(personaje.Nombre);
        }

        var primerasTresQuery = (from p in personajes select p). First();
        WriteLine(primerasTresQuery.Nombre);
        var primerasTresMetodo = personajes.Take(3);
        WriteLine("Obteniendo los primeros 3"); 
        foreach (var personaje in primerasTresMetodo)
        {
           WriteLine (personaje.Nombre);
        }




    }

}

class MarvelPersonajes
{
    
    public string? Nombre {get; set;}
    public string? Alias {get; set;}
    public string? Equipo {get; set;}


}