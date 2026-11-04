partial class Program
{
    
    static void TablaMultiplicar(int numero, int limiteTabla)
    {
        WriteLine($"Tabla de multiplicar del numero {numero} desde 1 hasta el {limiteTabla}");
        WriteLine();
        for(int i = 1; i<= limiteTabla; i++)
        {
            
            WriteLine($"{numero} X {i} = {numero * i}");


        }





    }


}