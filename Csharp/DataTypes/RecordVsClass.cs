using System;

namespace ValueTypes;

public class RecordVsClass
{
//  	Eşitlik Kontrolü:

// •	class referans eşitliğine dayanır (aynı bellekteki nesneler eşittir).
// •	record değer eşitliğine dayanır (içerik aynı ise eşittir).
}

class PersonClass
{
    public string Name { get; set; }
}

record PersonRecord(string Name)
{
    public string Name { get; } = Name;
}

public class Main
{

    public void Method()
    {
        var class1 = new PersonClass { Name = "John" };
        var class2 = new PersonClass { Name = "John" };

        var record1 = new PersonRecord("John");
        var record2 = new PersonRecord("John");

        Console.WriteLine(class1 == class2); // False (referans eşitliği)
        Console.WriteLine(record1 == record2); // True (değer eşitliği)
    }
}
//	Immutable Varsayılanları:

//•	record türündeki özellikler varsayılan olarak immutabledır (init-only). Yani, sadece nesne oluşturulurken atanabilir.

record Person(string Name, int Age)
{
    public string Name { get; } = Name;
    public int Age { get; set; } = Age;
}

public class Main2
{

    public void Method()
    {
        var person = new Person("John", 30);
        //person.Name = "Jane"; // Hata: 'Name' özelliği yalnızca init sırasında atanabilir.
    }
}

//  Built-in Copy Mechanism (Kopyalama Mekanizması):
//•	record türleri, mevcut bir nesnenin kopyasını kolayca oluşturmak için with ifadesini destekler.

public class Main3
{

    public void Method()
    {
        var person = new Person("John", 30);
        var newPerson = person with { Age = 31 }; // Yeni bir nesne oluşturur.
        Console.WriteLine(newPerson); // Output: Person { Name = John, Age = 31 }
    }
}

//      ToString Override:
// •	record türü, otomatik olarak bir ToString() metodu sağlar ve bu, nesnenin tüm özelliklerini içeren bir string döndürür.


public class Main4
{

    public void Method()
    {
        var person = new Person("John", 30);
        Console.WriteLine(person); // Output: Person { Name = John, Age = 30 }
    }
}





