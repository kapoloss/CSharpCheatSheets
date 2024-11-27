using System;
using System.Reflection;

namespace Others;

public class PropertyInfo_
{
    // PropertyInfo, bir sınıfın özelliklerine (properties) ait bilgilere erişimi temsil eder.
    // Bir PropertyInfo nesnesi üzerinden bir özelliğin türünü, değerini alabilir veya ayarlayabilirsiniz.
    //
    //     Öne Çıkan Özellikler:
    //
    // •	Name: Özellik adı.
    // •	PropertyType: Özelliğin tipi.
    // •	CanRead, CanWrite: Özelliğin okunabilir veya yazılabilir olduğunu kontrol eder.

    public void Method()
    {
        Type type = typeof(MyClass);
        PropertyInfo[] properties = type.GetProperties();

        foreach (var property in properties)
        {
            Console.WriteLine($"Property: {property.Name}, Type: {property.PropertyType}");
        }
    }
}