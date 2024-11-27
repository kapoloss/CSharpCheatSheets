using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_Events
{
    public class Func
    {
        //C#’ta Func bir generic delegate türüdür.
        //Func, bir veya daha fazla parametre alabilen ve bir değer döndüren metotları temsil eder.
        //Temel farkı, Action yalnızca void dönen metotları temsil ederken,
        //Func geriye bir değer dönen metotlar için kullanılır.
        
    }

    public class ProgramFunc
    {
        public void Method()
        {
            // parametresiz func
            Func<string> getGreeting = () => "Hello, World!";
            Console.WriteLine(getGreeting()); // Output: Hello, World!
            
            //parametreli func
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(multiply(6, 7)); // Output: 42
            
            //linq kullanımı
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Func<int, bool> isEven = n => n % 2 == 0;

            var evenNumbers = numbers.Where(isEven);
            foreach (var num in evenNumbers)
                Console.WriteLine(num);
           // Output:
           // 2
           // 4
           
           
        }
    }
}