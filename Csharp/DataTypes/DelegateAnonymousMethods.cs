using System;

namespace Delegates_Events
{
    public class Delegate_with_Anonymous_Methods
    {
        //Delegatlara, anonim yöntemler veya lambda ifadeleri atanabilir:

        public void Main()
        {
            MathOperation operation = delegate(int x, int y) {
                return x - y;
            };
            Console.WriteLine(operation(10, 3)); // Output: 7

// Lambda expression for the same delegate
            operation = (x, y) => x * y;
            Console.WriteLine(operation(4, 5)); // Output: 20
        }
    }
}