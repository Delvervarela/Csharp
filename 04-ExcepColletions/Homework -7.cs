partial class Program
{
    static void SalesAnalysis()
    {

        try
        {
            List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };
    
    
// 1. Filtrar y mostrar las ventas con monto superior a 1000.
    var montoSuperior = sales.Where(s => s.Amount > 1000 );
    WriteLine("Ventas con monto mayor a 1000");
    foreach (var sale in montoSuperior)
    {
        WriteLine($"Producto {sale.Product}, Categoria: {sale.Category}, Monto: {sale.Amount:C}");
    }

// 2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.

var ventasCategoria = sales.GroupBy(s => s.Category).Select(g => new {categoria = g.Key, montoTotal = g.Sum(s => s.Amount)});
WriteLine();
WriteLine("Total de ventas por categoria;");
foreach (var grupos in ventasCategoria)
{
    WriteLine($"Categoria: {grupos.categoria}, Total ventas: {grupos.montoTotal:C}");
}

// 3. Manejar excepciones en caso de errores al procesar los datos.

        }


        catch (Exception ex)
        {
            
            WriteLine($"Error a procesar las ventas: {ex.Message}");


        }
        
    
    
    
    
    
    
    
    }


}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}

