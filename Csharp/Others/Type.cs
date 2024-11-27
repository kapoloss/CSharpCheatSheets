using System;

namespace Others;

public class Type_
{
    // Type, bir sınıfın, yapının veya diğer türlerin meta verilerini temsil eder. Bu nesne üzerinden bir türün tüm bilgilerine erişebilirsiniz.
    //
    //     Öne Çıkan Özellikler:
    //
    // •	Name: Türün adını döner.
    // •	Namespace: Türün içinde bulunduğu namespace’i döner.
    // •	IsClass, IsValueType: Türün bir sınıf mı yoksa bir değer türü mü olduğunu kontrol eder.
    // •	GetProperties(), GetMethods(), GetFields(): Türe ait özellik, metod ve alanları döner.

    public void Method()
    {
        Type type = typeof(String); // String türünün Type nesnesini al
        Console.WriteLine(type.Name); // Çıktı: String
        Console.WriteLine(type.Namespace); // Çıktı: System

        Type customType = typeof(MyClass); // Kullanıcı tanımlı bir sınıf
        Console.WriteLine(customType.IsClass); // Çıktı: true
    }
}