partial class Program
{
    
static void ShowTime ()
    {
        
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime nowWeekAgo = DateTime.Now.AddDays(-7);
        DateTime  customDate = new DateTime(2026, 12, 24);
        



        DayOfWeek weekday = now.DayOfWeek;

        Console.WriteLine($"Fecha y hora actual: {now}");
        Console.WriteLine($"Fecha actual: {today}");
        Console.WriteLine($"Hace una semana la fecha era: {nowWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha personalizada: {customDate}");
        Console.WriteLine($"Dia de la semana: {weekday}");


    }



}
