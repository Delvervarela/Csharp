using System.Runtime.InteropServices;

partial class Program
{
    
    static void VentaProductoDemo()
    {
        
        Inventario inventario = new();
        Producto laptop = new Producto("Laptop", 1200.99, 5);
        Producto mouse = new Producto("Mouse", 1200.99, 5);
        //inventario.AgregarProducto(laptop);
        //inventario.AgregarProducto(mouse);
        //inventario.MostrarInventario();
        //laptop.Venta(1);
        //inventario.MostrarInventario();
           
             

    }

    static void FlotaBuses()
    {
        Bus trupperBus = new Bus ("Truper", "Ranger", 2015, 74_200.42, 50_000);
        Bus mercedesBus = new Bus ("Mercedes", "8 llantas", 2024, 12_200.42, 100_000);
        Bus macBus = new Bus ("Mac", "Industrial", 2000, 12_200.42, 180_000);

        Flota flota = new();
        flota.AgregarBus(trupperBus);
        flota.AgregarBus(mercedesBus);
        flota.AgregarBus(macBus);
        
        flota.MostrarBuses();
        WriteLine();
        WriteLine("Kilometros despues de manejar 5000 km");
        WriteLine();
        trupperBus.Manejar(5000);
        trupperBus.Manejar(5000);
        trupperBus.Manejar(5000);
        flota.MostrarBuses();


    }


}


class Producto
{
    
    public string? Nombre {get; set;}
    public double Precio {get; set;}
    public int Cantidad {get; set;}


    public Producto(string nombre, double precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }


    public void MostrarInfo()
    {
        
        WriteLine($"Producto: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}");

    }

    public bool Venta(int cantidadVenta)
    {
        if (cantidadVenta <= Cantidad)
        {
            WriteLine($"Venta realizada: {cantidadVenta} unidades de {Nombre}");
            return true;
            
        }
        WriteLine($"No hay cantidad disponible de {Nombre}");
        return false;

    }

}

class Inventario



{
    
    private List<Producto> productos = new List<Producto>();



    public void AgregarProducto( Producto producto)
    {
        productos.Add(producto);

    }

    public void MostrarInventario()
    {
        
        WriteLine("Inventario de productos");
        foreach(var producto in productos)
        {
            
            producto.MostrarInfo();

        }
    }



}

class Bus
{
    
    public string? Marca {get; set;}
    public string? Modelo {get; set;}
    public int Año {get; set;}
    public double Precio {get; set;}
    public double TotalKilometros {get; set;}


    public Bus (string marca, string modelo, int año, double precio, double totalKilometros)
    {
        
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Precio = precio;
        TotalKilometros = totalKilometros;

    } 




    public void Manejar (int Kilometros)
    {
        TotalKilometros = TotalKilometros + Kilometros;

    }




    public string MostrarPrecio()
    {
        return $"El precio del autobus es: {Precio:C}";
    }

}

class Flota
{
  private List<Bus> buses = new List<Bus>(); 

    public void AgregarBus( Bus bus)
    {
        buses.Add(bus);

    }
  public void MostrarBuses()
    {
        foreach (var bus in buses)
        {
            WriteLine($"Marca: {bus.Marca}, Modelo: {bus.Modelo}, Año: {bus.Año}, Precio: {bus.Precio}, Kilómetros: {bus.TotalKilometros}");
        }


        
    }
  


    


}