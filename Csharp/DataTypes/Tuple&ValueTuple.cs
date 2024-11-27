using System;

namespace ValueTypes;

public class Tuple_ValueTuple
{
//      Tuple
//
// •	Tanım: Tuple bir referans tipidir ve nesne olarak kullanılır.

// •	Özellikler:

// •	Bir nesne olduğu için heap üzerinde saklanır.
// •	Performans açısından diğer türlere göre biraz daha yavaştır.
// •	Read-Only yapıdadır; yani, oluşturduktan sonra değerlerini değiştiremezsiniz.
// •	Kullanım kolaylığı sınırlıdır; çünkü elemanlara Item1, Item2 gibi jenerik isimlerle erişilir.

    // Dezavantajlar:
    //
    // •	Daha az performanslıdır (GC yükü oluşturabilir).
    // •	Item1, Item2 gibi anlaşılması zor isimler kullanılır.
    
    
    // ValueTuple
    //
    // •	Tanım: ValueTuple bir değer tipidir ve genellikle performans odaklıdır.
    
    // •	Özellikler:
    
    // •	Struct olarak tanımlandığından stack üzerinde saklanır (daha hızlı).
    // •	Item1, Item2 gibi isimlerin yanında adlandırılmış elemanlar kullanabilirsiniz.
    // •	Immutable değildir, yani değerlerini değiştirebilirsiniz.
    // •	.NET Framework 4.7 ve üzeri sürümlerde veya .NET Core’da desteklenir.


    public void Program()
    {
        //tuple
        Tuple<int, string> person = new Tuple<int, string>(1, "Muhammet");
        Console.WriteLine($"ID: {person.Item1}, Name: {person.Item2}");
        
        //valueTuple
        var person2 = (ID: 1, Name: "Muhammet");
        Console.WriteLine($"ID: {person2.ID}, Name: {person2.Name}");
        
        //valueTuple
        ValueTuple<int, string> person3 = new ValueTuple<int, string>(1, "Muhammet");
        Console.WriteLine($"ID: {person3.Item1}, Name: {person3.Item2}");
        
    }
    
    
    // Özellik	                     Tuple	                     ValueTuple
    // Tip	                         Referans Tipi (Class)	     Değer Tipi (Struct)
    // Performans	                 Yavaş	                     Hızlı
    // Adlandırma	                 Sadece Item1, Item2	     Adlandırılabilir
    // Mutability	                 Değiştirilemez	             Değiştirilebilir
    // Bellek Kullanımı	             Daha fazla (Heap)	         Daha az (Stack)
    
    
    //ValueTuple ile Metot Döndürme:
    public (int ID, string Name) GetPersonValueTuple()
    {
        return (1, "Muhammet");
    }

    //Tuple ile Metot Döndürme:
    public Tuple<int, string> GetPersonTuple()
    {
        return new Tuple<int, string>(1, "Muhammet");
    }

    
}