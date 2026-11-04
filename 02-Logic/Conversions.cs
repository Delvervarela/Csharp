
partial class Program
{
    
    static void Conversiones()
    {
        
        //Coversiones implicitas: ocurre cuando automaticamente puedes cambiar el tipo de dato sin el riesgo de perdidad de datos

        int numero = 42;
        double numerodecimal = numero;

        WriteLine(numerodecimal);


        //Conversiones explicitas: nosotros le tenemos que indicar que si vamos a hacer la conversion, en este caso puede haber perdida de datos o incompatibilidad entre los tipos

        double numeroDecimalExplicito = 45.5;
        int numeroEntero = (int)numeroDecimalExplicito;
        WriteLine(numeroEntero);



        //Parse

        string texto = "12345";
        int numeroParsed = int.Parse(texto);
        WriteLine(numeroParsed);


        //Convert

        double otroNumeroDecimal = 50.8;
        int numeroCnvertido = Convert.ToInt32(otroNumeroDecimal);
        WriteLine(numeroCnvertido); //lo va a redondear

        int numeroCasteado = (int)otroNumeroDecimal;
        WriteLine(numeroCasteado); //va a truncarlo, es decir que va a borrar la parte decimal
    }


}