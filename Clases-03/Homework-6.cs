using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

partial class Program
{
    
    static void EmpleadosInfo()
    {

        List<Empleado> empleados = new List<Empleado>();
        empleados.Add(new LiderEquipo("Carlos", 5000));
        empleados.Add(new Desarrollador("Ana",4000));
        empleados.Add(new LiderEquipo("Laura", 6000));
        empleados.Add(new Desarrollador("Luis", 3500));
        foreach (var empleado in empleados)
        {
            empleado.MostrarInfo();
        }
        
        


    } 

}


class Empleado
{
    
protected string? Nombre {get; set;}
protected double Salario {get; set;}

protected string? Posicion {get; set;}


public Empleado (string nombre, double salario, string posicion )
    {
        Nombre = nombre;
        Salario = salario;
        Posicion = posicion;
    }

    public virtual double CalcularBono() //virtual: nos va a permitir que cuando haya una herencia poder sobrescribir el comportaiento de ese metodo 
    {
        return Salario * 0.05;
    }


    public void MostrarInfo()
    {
        WriteLine($"Empleado: {Nombre}, Cargo: {Posicion}, Salario: {Salario:C}, Bono calculado: {CalcularBono():C} ");

    }


    private List<Empleado> empleados = new List<Empleado>();

    
}


class LiderEquipo : Empleado
{
    
public LiderEquipo(string nombre, double salario) : base (nombre, salario, "Lider Equipo"){}

    public override double CalcularBono()
    {
        return Salario * 0.10;
    }


}

class Desarrollador : Empleado
{
    public Desarrollador (string nombre, double salario) : base (nombre, salario, "Desarrollador"){}

    public override double CalcularBono()
    {
        return Salario * 0.07;
    }

}