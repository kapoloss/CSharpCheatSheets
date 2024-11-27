using System;

namespace Others;

public class PatternMatching
{
    //Pattern Matching C# dilinde veri türlerine ve verilere göre daha güçlü ve okunabilir bir şekilde işlem yapmamızı sağlar.
    //Özellikle switch ifadelerinde, is operatöründe ve when ile koşul eklemelerinde bu özellikler sıkça kullanılır. 
}

//1. switch İfadeleri ile Pattern Matching

//C# 7.0 ve sonrası, switch ifadelerine yeni bir yaklaşım kazandırdı.
//Artık sadece sabit değerlere değil, türlere ve koşullara göre de kontrol yapabilirsiniz.

public class Example
{
    public void Method()
    {
        object data = "Hello, world!";

        switch (data)
        {
            case int number:
                Console.WriteLine($"It's an integer: {number}");
                break;
            case string text:
                Console.WriteLine($"It's a string: {text}");
                break;
            case null:
                Console.WriteLine("It's null.");
                break;
            default:
                Console.WriteLine("It's an unknown type.");
                break;
        }
    }
}


//Örnek 2: Koşullarla Birlikte Kullanım (when)

//case bloklarında belirli bir koşul sağlandığında çalışacak bir yapı ekleyebilirsiniz.

public class Example2
{
    public void Method()
    {
        object data = 42;

        switch (data)
        {
            case int number when number > 0:
                Console.WriteLine($"It's a positive integer: {number}");
                break;
            case int number when number < 0:
                Console.WriteLine($"It's a negative integer: {number}");
                break;
            case null:
                Console.WriteLine("It's null.");
                break;
            default:
                Console.WriteLine("It's an unknown type.");
                break;
        }
    }
}

// 2. is Operatörü ile Pattern Matching
//
// is operatörü, bir değişkenin belirli bir türe sahip olup olmadığını kontrol eder.
// Ayrıca, tür kontrolü başarılıysa bir değişkene atayarak doğrudan kullanmanıza olanak tanır.

public class Example3
{
    public void Method()
    {
        object data = 42;

        if (data is int number && number > 0)
        {
            Console.WriteLine($"Positive integer: {number}");
        }
    }
}