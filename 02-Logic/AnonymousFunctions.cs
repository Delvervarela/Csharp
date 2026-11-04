using System.Security.Cryptography.X509Certificates;

partial class Program
{
    
    static void FuncionAnonima()
    {
        

        WriteLine(cuadrado(5));
        WriteLine(lambdaCuadrado(10));
        List<int> numeros = [1, 2, 3, 4, 5];
        var  numerosPar = numeros.Where(n => n % 2 == 0); 
        foreach (var par in numerosPar)
        {
            
            WriteLine(par);


        } 



    }


    static Func<int, int> cuadrado = delegate (int numero)
    {
        
        return numero * numero;

    };

    static Func<int, int> lambdaCuadrado = x => x * x; // Forma Lambda

}