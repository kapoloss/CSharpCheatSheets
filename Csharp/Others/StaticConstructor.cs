using System;

namespace Others
{
    public class StaticConstructor
    {
        // •	Sınıf ilk kez kullanıldığında (örneğin, bir static üyesine erişildiğinde) yalnızca bir kez çalıştırılır.
        // •	Parametre almaz.
        // •	Genellikle static üyeleri başlatmak için kullanılır.
    }
    
    public class Logger
    {
        public static string LogDirectory;

        static Logger()
        {
            LogDirectory = "/logs";
        }
    }

// Kullanım

internal class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Logger.LogDirectory);
        }
    }
}