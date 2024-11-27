using System;
using System.Linq;

namespace DataTypes;

public class AnonymousTypes
{
    // Anonim türler (anonymous types), C#’da bir sınıf tanımlamadan hızlıca veri grupları oluşturmak için kullanılan,
    // yalnızca okunabilir (read-only) özelliklere sahip, adlandırılmamış veri yapılarıdır.
    // Çoğunlukla LINQ sorguları ve basit veri nesneleri oluşturmak için kullanılırlar.
    //
    //     Anonim türler, derleyici tarafından otomatik olarak tanımlanan bir sınıfın instance’ını oluşturur.
    // Ancak, bu sınıfın adı yoktur ve türü var anahtar kelimesi ile tanımlanır.
    
    // Özellikler
    //
    // 1.	Sınıf Tanımı Gerekmez:
    // •	Anonim türler bir sınıf tanımlamadan özellikleri ve değerlerini belirtmenizi sağlar.
    // 2.	Sadece Okunabilir (Immutable):
    // •	Özellikler yalnızca nesne oluşturulurken atanabilir, sonradan değiştirilemez.
    // 3.	Derleyici Tabanlı:
    // •	Derleyici, tanımlanan anonim türlere otomatik olarak benzersiz bir sınıf adı ve yapı sağlar.
    // 4.	Referans Türüdür:
    // •	Anonim türler bir referans türüdür ve System.Object’ten türetilir.

    public void Method()
    {
        var person = new { Name = "John", Age = 30 };

        Console.WriteLine(person.Name); // Output: John
        Console.WriteLine(person.Age);  // Output: 30
        
        // •	Anonim türler genellikle LINQ sorgularında projeksiyon (seçim) işlemleri için kullanılır.
        
        var people = new[]
        {
            new { Name = "John", Age = 30 },
            new { Name = "Jane", Age = 25 }
        };

        var adults = people.Where(p => p.Age > 18)
            .Select(p => new { p.Name, IsAdult = true });

        foreach (var person2 in adults)
        {
            Console.WriteLine($"{person2.Name} is an adult: {person2.IsAdult}");
        }
    }
    
    // Kurallar
    //
    // 1.	var Zorunludur:
    // •	Anonim türün türü yoktur, bu nedenle yalnızca var ile atanabilir:
    // 2.	Sadece Özellikler:
    // •	Anonim türler yalnızca özellik içerir; metod tanımlanamaz.
    // 3.	Immutable (Değiştirilemez):
    // •	Özellikler oluşturulduktan sonra değiştirilemez:
    // 4.	Birden Fazla Anonim Tür:
    // •	Aynı özelliklere ve değerlere sahip anonim türler derleyici tarafından eşit kabul edilir.
    
    
    // Sınırlamaları
    //
    // 1.	Uzun Süreli Kullanım İçin Uygun Değil:
    // •	Kodun okunabilirliğini zorlaştırabilir ve uzun süreli kullanımda tip güvenliği sağlamak zordur.
    // •	Yerine, genellikle adlandırılmış sınıflar tercih edilir.
    // 2.	Metot Parametresi Olarak Kullanılamaz:
    // •	Anonim türler doğrudan bir metotun parametresi olamaz:

    void Test(object obj) { } // Bu şekilde boxing yapılabilir.
    
    // 3.	Dinamik veya Zor Dönüşüm İşlemleri Gerektirebilir:
    // •	Türün adı olmadığından dönüşüm yaparken sorun yaşanabilir.
}