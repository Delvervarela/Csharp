using BetterConsoles.Tables;
namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;
    
    public void ListTasks()
    {
      
      ForegroundColor = ConsoleColor.DarkCyan;
      WriteLine("------Lista de tareas------");
      foreach (var task in Tasks)
      {
        WriteLine();
        WriteLine("{0,-8} {1,-35} {2, -15}", "id", "Descripción", "Completado");
        WriteLine(new string('-', 58));
        WriteLine("{0,-8} {1,-35} {2, -15}", task.Id, task.Description, task.Completed);
        
      }



    }

    }
  }
