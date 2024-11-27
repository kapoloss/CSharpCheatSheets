using System;

namespace Delegates_Events
{
    public class Action
    {
        //C#’ta Actions genel olarak callback mekanizmalarını yönetmek için kullanılan bir delegate türüdür.
        //System.Action türü, bir metodu temsil eder ve bir delegate’e benzer şekilde çalışır.
        //Ancak Action’lar, yalnızca geriye void dönen metotları temsil eder.
        //Parametre alabilir veya hiç parametre almayabilir.
    }
    

    class Program2
    {
        static void Main(string[] args)
        {
            System.Action action = SayHello;
            action();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
        }
        
        static void Main2(string[] args)
        {
            Action<int, int> addNumbers = (a, b) => Console.WriteLine($"Sum: {a + b}");
            addNumbers(5, 10);
        }
    }
    

    class Program3
    {
        static event System.Action OnGameStart;

        static void Main(string[] args)
        {
            OnGameStart += StartGame;
            OnGameStart?.Invoke();
        }

        static void StartGame()
        {
            Console.WriteLine("Game has started!");
        }
    }
}