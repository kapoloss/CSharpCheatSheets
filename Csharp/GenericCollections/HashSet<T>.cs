using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class HashSet_T_
    {
        // •	Tanım: Benzersiz elemanlardan oluşan sırasız bir koleksiyon. Aynı elemandan birden fazla içermez.
        
        // •	Kullanım Alanı: Bir veri kümesinin benzersiz öğelerini tutmak için.
    }
    
    //     •    Add: Eleman ekler.
    //     •	Remove: Belirli bir elemanı siler.
    //     •	Clear: Tüm elemanları siler.
    //     •	Contains: Elemanın kümede olup olmadığını kontrol eder.
    //     •	IntersectWith: İki HashSet arasındaki ortak elemanları alır.
    //     •	UnionWith: İki HashSet’in birleşimini alır.
    //     •	ExceptWith: İlk HashSet’te olup ikinci HashSet’te olmayan elemanları alır.
    //     •	SymmetricExceptWith: İki HashSet’te yalnızca birinde bulunan elemanları alır.
    //     •	IsSubsetOf ve IsSupersetOf: Alt küme ve kapsayan küme kontrolü yapar.
    //     •	SetEquals: İki HashSet’in aynı elemanlara sahip olup olmadığını kontrol eder.
    //     •	CopyTo: HashSet’i diziye kopyalar.

    
    public class HashSetExample
    {
         public static void Main()
    {
        // 1. HashSet tanımlanır ve elemanlar eklenir.
        HashSet<int> numbers = new HashSet<int>();
        numbers.Add(10); // 10 eklendi
        numbers.Add(20); // 20 eklendi
        numbers.Add(30); // 30 eklendi
        numbers.Add(40); // 40 eklendi
        numbers.Add(20); // 20 zaten mevcut olduğundan eklenmez (HashSet benzersiz elemanlar içerir)

        // 2. Count özelliği ile eleman sayısını alma
        int count = numbers.Count; // Eleman sayısı: 4

        // 3. Contains ile belirli bir elemanın var olup olmadığını kontrol etme
        bool contains30 = numbers.Contains(30); // true

        // 4. Remove ile belirli bir elemanı silme
        bool removed10 = numbers.Remove(10); // 10 silindi, işlem başarılı: true

        // 5. Clear ile tüm elemanları temizleme
        numbers.Clear(); // Tüm elemanlar silindi, Count: 0

        // 6. Tekrar elemanlar ekleyelim
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // 7. Bir koleksiyon ile kesişim (IntersectWith)
        HashSet<int> otherNumbers = new HashSet<int> { 30, 40, 50, 60, 70 };
        numbers.IntersectWith(otherNumbers); // Sadece her iki set'te de bulunan elemanlar kalır: [30, 40, 50]

        // 8. Birleşim (UnionWith) işlemi
        numbers.UnionWith(new HashSet<int> { 60, 70 }); // [30, 40, 50, 60, 70]

        // 9. Fark (ExceptWith) işlemi
        numbers.ExceptWith(new HashSet<int> { 50, 60 }); // [30, 40, 70]

        // 10. Simetrik fark (SymmetricExceptWith) işlemi
        numbers.SymmetricExceptWith(new HashSet<int> { 40, 80 }); // [30, 70, 80]

        // 11. IsSubsetOf ile alt küme kontrolü
        bool isSubset = new HashSet<int> { 30, 70 }.IsSubsetOf(numbers); // true

        // 12. IsSupersetOf ile kapsayan küme kontrolü
        bool isSuperset = numbers.IsSupersetOf(new HashSet<int> { 30, 70 }); // true

        // 13. SetEquals ile iki kümenin eşit olup olmadığını kontrol etme
        bool isEqual = numbers.SetEquals(new HashSet<int> { 30, 70, 80 }); // true

        // 14. Elemanları gezmek için Foreach kullanma
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // 30, 70, 80 (şu anki elemanlar)
        }

        // 15. HashSet'i diziye dönüştürme
        int[] array = new int[numbers.Count];
        numbers.CopyTo(array); // numbers elemanları array dizisine kopyalandı

        // 16. Belirli bir aralıktaki elemanları diziye kopyalama
        int[] arrayWithRange = new int[2];
        numbers.CopyTo(arrayWithRange, 0, 2); // İlk 2 eleman arrayWithRange dizisine kopyalandı

        // Çıktılar yorum satırında:
        // Count: 4
        // Contains 30: true
        // Removed 10: true
        // Cleared all elements
        // After IntersectWith otherNumbers: [30, 40, 50]
        // After UnionWith {60, 70}: [30, 40, 50, 60, 70]
        // After ExceptWith {50, 60}: [30, 40, 70]
        // After SymmetricExceptWith {40, 80}: [30, 70, 80]
        // IsSubsetOf {30, 70}: true
        // IsSupersetOf {30, 70}: true
        // SetEquals {30, 70, 80}: true
        // Elements in HashSet: 30, 70, 80
        // HashSet copied to array: [30, 70, 80]
        // HashSet first 2 elements copied to arrayWithRange: [30, 70]
    }
    }
}