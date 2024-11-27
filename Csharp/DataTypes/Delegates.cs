using System;

namespace Delegates_Events
{
    public class Delegates
    {
        //Delegatlar, C# dilinde yöntemleri parametre olarak iletmek,
        //geri çağırma işlevleri tanımlamak ve olay tabanlı programlama yapmak için kullanılan güçlü bir yapıdır.
        //Bir delegat, belirli bir yöntem imzasını eşleştirir, yani aynı parametre türleri ve
        //dönüş türüne sahip herhangi bir yöntemi referans edebilir.
    }
    
    // Define a delegate with a specific signature
    public delegate int MathOperation(int a, int b);

// A compatible method
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

// Using the delegate

internal class Program4
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            MathOperation operation = calculator.Add; // Assign Add method to delegate
            Console.WriteLine(operation(5, 3)); // Output: 8
            operation = calculator.Multiply;    // Reassign to Multiply method
            Console.WriteLine(operation(5, 3)); // Output: 15
        }
    }
}