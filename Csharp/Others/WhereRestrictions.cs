using System;

namespace Others;

public class WhereRestrictions
{
    //where anahtar kelimesi, tür parametrelerine kısıtlamalar eklemek için kullanılır.
    //Bu kısıtlamalar, generic türlerin belirli bir özellik veya davranış sergilemesini sağlar.

    // Örnek Kısıtlamalar:
    // 1.	where T : struct
    //     T sadece bir değer tipi olabilir (ör. int, float, bool).
    // 2.	where T : class
    //     T sadece bir referans tipi olabilir (ör. string, bir class, bir interface).
    // 3.	where T : new()
    //     T varsayılan bir constructor’a sahip olmalıdır.
    // 4.	where T : <base class>
    //     T belirtilen bir sınıfı veya interface’i miras almalıdır.
    // 5.	Birden Fazla Kısıtlama:
    //     where T : class, new() gibi birden fazla kısıtlama eklenebilir.
}
public class Repository<T> where T : class, new()
{
    public T CreateInstance()
    {
        return new T();
    }
}

public class DataProcessor<T, U>
    where T : class
    where U : struct
{
    public void Process(T item, U value)
    {
        Console.WriteLine($"Processing {item} with value {value}");
    }
}