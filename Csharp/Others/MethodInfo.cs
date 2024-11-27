using System;
using System.Reflection;

namespace Others;

public class MethodInfo_
{
    // MethodInfo, bir sınıfın metodları hakkında bilgi sağlar. Bu nesne ile metod adını, dönüş türünü,
    // parametrelerini öğrenebilir ve metodu çağırabilirsiniz.
    //
    //     Öne Çıkan Özellikler:
    //
    // •	Name: Metodun adını döner.
    // •	ReturnType: Metodun dönüş türünü döner.
    // •	GetParameters(): Metodun parametre bilgilerini döner.

    public void Method()
    {
        Type type = typeof(MyClass2);
        MethodInfo method = type.GetMethod("Greet");

        // Metod bilgilerini yazdır
        Console.WriteLine($"Method: {method.Name}, Return Type: {method.ReturnType}");

        // Metodu çağır
        MyClass2 obj = new MyClass2();
        method.Invoke(obj, new object[] { "World" }); // Çıktı: Hello, World!
    }


}

public class MyClass2
{
    public void Greet(string name) => Console.WriteLine($"Hello, {name}!");
}