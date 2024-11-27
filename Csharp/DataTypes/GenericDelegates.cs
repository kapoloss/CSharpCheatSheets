using System;

namespace Delegates_Events
{
    public class GenericDelegates
    {
        //Delegatları tür bağımsız çalıştırmak için generic olarak tanımlayabilirsiniz:
    }
    
    public delegate T Operation<T >(T a, T b);

    public class GenericCalculator<T>
    {
        private Operation<T> _operation;

        public void SetOperation(Operation<T> operation)
        {
            _operation = operation;
        }

        public T Execute(T a, T b)
        {
            return _operation(a, b);
        }
    }

// Usage

internal class Program5
    {
        public static void Main(string[] args)
        {
            GenericCalculator<int> intCalculator = new GenericCalculator<int>();
            intCalculator.SetOperation((x, y) => x + y);
            Console.WriteLine(intCalculator.Execute(3, 4)); // Output: 7

            GenericCalculator<string> stringCalculator = new GenericCalculator<string>();
            stringCalculator.SetOperation((a, b) => a + b);
            Console.WriteLine(stringCalculator.Execute("Hello, ", "World!")); // Output: Hello, World!
        }
    }
}