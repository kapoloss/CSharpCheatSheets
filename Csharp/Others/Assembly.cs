using System;
using System.Reflection;
using UnityEngine;

namespace Others;

public class Assembly_
{
    // Assembly, bir veya daha fazla tip içeren bir derlemedir. Çalışan uygulamanın içindeki veya dışındaki assembly’ler hakkında bilgi alabilirsiniz.
    //
    //     Öne Çıkan Özellikler:
    //
    // •	FullName: Assembly’nin tam adını döner.
    // •	GetTypes(): Assembly içindeki tüm türleri döner.
    // •	Location: Assembly’nin fiziksel konumunu döner.

    public void Method()
    {
        // Yüklenen assembly'yi al
        Assembly assembly = Assembly.GetExecutingAssembly();

        // Assembly bilgilerini yazdır
        Console.WriteLine($"Assembly Name: {assembly.FullName}");
        Console.WriteLine($"Location: {assembly.Location}");

        // Assembly'deki tüm türleri al
        Type[] types = assembly.GetTypes();
        foreach (var type in types)
        {
            Console.WriteLine($"Type: {type.Name}");
        }
    }
    
}