using System;

public class Singleton
{
    
    private static Singleton _instance;

  
    private Singleton() { }

   
    public static Singleton Instance
    {
        get
        {
           
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

   
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Singleton logger = Singleton.Instance;

       
        logger.Log("This is a log message.");
        logger.Log("Singleton pattern ensures only one instance of this class.");

      
        Singleton anotherLogger = Singleton.Instance;
        Console.WriteLine($"Is both instances the same? {object.ReferenceEquals(logger, anotherLogger)}");

       
        Console.ReadLine();
    }
}
