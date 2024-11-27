using System;
using System.Collections.Generic;

namespace Others;

public class Target_TypedNewExpressions
{
    //C# 9.0 ile birlikte gelen Target-Typed New Expressions, bir değişkenin türünü açıkça belirtmek yerine,
    //türün bağlamdan (context) çıkarılmasını sağlar. Bu özellik, kodun daha okunabilir ve daha kısa yazılmasını sağlar.
    
    //new() ifadesi, atandığı yerin türü zaten belirliyse o türü doğrudan kullanmanıza olanak tanır.
    //Bu durum, özellikle uzun tür isimlerini tekrar yazmaktan kaçınmak istediğinizde kullanışlıdır.

    public void Method()
    {
        // Normal kullanım (C# 8.0 öncesi)
        List<string> names = new List<string>();

        // Target-Typed New (C# 9.0 ve sonrası)
        List<string> names2 = new();
    }
    
    // 1. Bağlamdan Tür Çıkarsama
    //
    // new() ifadesi, aşağıdaki durumlarda kullanılabilir:
    // •	Yerel değişkenler:
    // Tür, değişkenin bildiriminden anlaşılır.

    public void Method2()
    {
        Dictionary<int, string> dictionary = new();
    }
    
    // •	Dönüş türü:
    // Bir metodun dönüş türü belliyse, return new(); kullanılabilir.
    
    public List<int> GetNumbers()
    {
        return new(); // Dönüş türü List<int>
    }
    
    // •	Lambda ifadelerinde:
    // Lambda dönüş türü çıkarılabiliyorsa, new() kullanılabilir.

    public void Method3()
    {
        Func<List<int>> createList = () => new();
    }
    
    // •	Property atamaları:
    // Bir property’si zaten tanımlıysa, tür tekrar edilmeden new() kullanılabilir.
    
    public List<int> Numbers { get; set; } = new();
    
    // 2. Nesne Başlatıcılarla Kullanım
    //
    // new() ifadesi nesne başlatıcılarla birlikte de kullanılabilir.

    public void Method4()
    {
        var person = new Person
        {
            Name = "John",
            Age = 30
        };
    }
    
    // 3. Genel (Generic) Türlerle Kullanım
    //
    // Generic türlerde de new() kullanılabilir. Tür parametresi çıkarılır.

    public void Method5()
    {
        List<List<int>> nestedList = new();
        Dictionary<int, List<string>> complexDict = new();
    }
}

public class Person
{
    public string Name
    { get; set; }

    public int Age { get; set; }
}