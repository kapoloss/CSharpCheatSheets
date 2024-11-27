using System;

namespace Delegates_Events
{
    public class DelegateCallbacks
    {
        //Delegatlar, belirli işlemler tamamlandığında geri çağırma yöntemi olarak kullanılabilir.
        
        public delegate void ResultHandler(int result);

        public void Calculate(int x, int y, MathOperation operation, ResultHandler callback)
        {
            int result = operation(x, y);
            callback(result);
        }

// Define a callback method
        public void PrintResult(int result)
        {
            Console.WriteLine("Result is: " + result);
        }


        public void Client()
        {
            // Using the callback
            Calculate(10, 5, (a, b) => a + b, PrintResult); // Output: Result is: 15
        }
    }
    
    
}