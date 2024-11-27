using System;

namespace Others;

public class Reflection
{
    //C# dilinde Reflection, uygulama çalışırken tiplerin (types),
    //metodların, özelliklerin ve assembly’lerin (çalıştırılabilir dosyaların) yapısını incelemek
    //ve onlarla etkileşime geçmek için kullanılan bir mekanizmadır.
    //Reflection sayesinde, runtime sırasında bir nesnenin tip bilgilerine erişebilir
    //ve bunlar üzerinde işlemler yapabilirsiniz.
    
        
    // Reflection Nedir?
    //
    // Reflection, genellikle aşağıdaki işlemler için kullanılır:
    // •	Tip (type) bilgisi almak: Örneğin, bir sınıfın hangi özelliklere veya metodlara sahip olduğunu öğrenmek.
    // •	Runtime’da obje yaratmak: Tip adıyla bir obje oluşturmak.
    // •	Özel metod veya özelliklere erişim sağlamak.
    // •	Attribute’ları okumak ve işlemek.

    public void Method()
    {
        Type type = typeof(MyClass);

        Console.WriteLine($"Type: {type.Name}");
        Console.WriteLine("Properties:");
        foreach (var property in type.GetProperties())
        {
            Console.WriteLine($" - {property.Name} ({property.PropertyType})");
        }

        Console.WriteLine("Methods:");
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine($" - {method.Name} (Return Type: {method.ReturnType})");
        }
    }
}

public class MyClass
{
}