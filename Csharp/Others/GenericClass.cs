using System;

namespace Others;

public class GenericClass
{
    //Generic sınıflar, tür bağımsız bir şekilde veri depolamak ve işlemek için kullanılan sınıflardır.
    //C#’da generic sınıflar, birden fazla türle çalışabilecek şekilde tanımlanır.
    //Bu, tür bağımsızlığı sağlar ve tür güvenliğini korur.

    //Generic sınıflar, belirli bir tür veya türler yerine bir “tip parametresi” kullanır.
    //Bu parametre genellikle T harfi ile gösterilir, ancak anlamlı isimler de kullanılabilir (örneğin, TKey, TValue).

    public void Method()
    {
        MyGenericClass<int> intInstance = new MyGenericClass<int>(42);
        Console.WriteLine(intInstance.GetValue()); // Çıktı: 42

        MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello");
        Console.WriteLine(stringInstance.GetValue()); // Çıktı: Hello
    }
}

public class MyGenericClass<T>
{
    private T _value;

    public MyGenericClass(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }

    public void SetValue(T value)
    {
        _value = value;
    }
}

//Generic türlerin varsayılan değerlerini almak için default anahtar kelimesi kullanılır.
//Bu, referans türleri için null, değer türleri için 0 veya false döndürür.

public class GenericClass<T>
{
    public T GetDefaultValue()
    {
        return default(T);
    }
}