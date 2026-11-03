partial class Program
{
    static void InventoryManager()
    {
        
        string[] producto = ["Monitor", "Mouse", "Teclado"];
        int [] cantidad = [10, 25, 30];
        double [] precios = [250.75, 20.58, 45.00];

        Console.WriteLine("-----------------------");
        Console.WriteLine ("         Menú         ");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Bienvenido al menú, elija una opción");
        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");
        int opcion = int.Parse(Console.ReadLine()!);
        if (opcion ==1)
        {
            
                Console.WriteLine("-----------------------");
                Console.WriteLine("Inventario de productos");
                Console.WriteLine("-----------------------");
                for (int i=0; i < producto.Length; i++)
                {
                    Console.WriteLine($"Producto: {producto[i]}, Cantidad disponible: {cantidad [i]}, Precio: {precios [i]:C}");

                }

                Console.WriteLine("\nIngrese el producto que desea comprar:");
                string? productoBuscado = Console.ReadLine();
                Console.WriteLine ("Ingrese la cantidad que desea comprar: ");
                int cantidadComprar = int.Parse(Console.ReadLine()!);
                for(int i=0; i < producto.Length; i++)
                {
                    if (producto [i].Equals(productoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        if(cantidadComprar <= cantidad [i])
                        {
                            double total = cantidadComprar * precios [i];
                            cantidad [i] -= cantidadComprar;
                            Console.WriteLine ($"Compra exitosa. El total a pagar es: {total:C}");
                            Console.WriteLine($"La cantidad restante del producto es: {cantidad[i]}");
                        }
                        
                        else
                        {
                            
                            Console.WriteLine ("No hay suficiente cantidad del producto disponible");
                        }


                    }

                }


        }

        else if (opcion == 2)
        {
            
            Console.WriteLine ("Muchas gracias por su visita, que tenga buen dia.");

        }

        else
        {
            Console.WriteLine("Opción invalida");
        }
        






    }


}