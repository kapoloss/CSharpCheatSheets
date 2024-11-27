using System;
using System.Collections.Concurrent;

namespace GenericCollections
{
    public class ConcurrentDictionary_TKey__TValue_
    {
        // •	Tanım: Çoklu iş parçacığı ortamlarında güvenli bir şekilde kullanılabilecek anahtar-değer
        // çiftlerinden oluşan bir koleksiyon.
        
        // •	Kullanım Alanı: Çok iş parçacıklı uygulamalarda veri tutmak için.
        
        // •	Özellikler ve Metodlar: Dictionary ile benzer özellikler taşır ancak eşzamanlılık için optimize edilmiştir.
    }
    
    //     •	TryAdd: Belirli bir anahtar ve değeri güvenli bir şekilde ekler,
    // eğer anahtar zaten varsa ekleme işlemi başarısız olur.
    //     •	TryGetValue: Belirli bir anahtara sahip değeri güvenli bir şekilde döndürür.
    //     •	ContainsKey: Belirli bir anahtarın var olup olmadığını kontrol eder.
    //     •	AddOrUpdate: Belirli bir anahtarı günceller veya anahtar yoksa ekler.
    //     •	TryUpdate: Belirli bir anahtarın mevcut değerini kontrol ederek güvenli bir şekilde günceller.
    //     •	TryRemove: Belirli bir anahtarı güvenli bir şekilde siler.
    //     •	GetOrAdd: Belirtilen anahtar mevcutsa değerini döndürür, yoksa yeni bir anahtar-değer çifti ekler.
    //     •	Clear: ConcurrentDictionary sınıfında doğrudan bir Clear metodu bulunmaz,
    // ancak tüm elemanları silmek için yeni bir nesne atanabilir.
   


    public class ConcurrentDictionaryExample
{
    public static void Main()
    {
        // 1. ConcurrentDictionary tanımlanır ve elemanlar eklenir.
        ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();
        dictionary.TryAdd(1, "One");   // Anahtar: 1, Değer: "One" eklendi
        dictionary.TryAdd(2, "Two");   // Anahtar: 2, Değer: "Two" eklendi
        dictionary.TryAdd(3, "Three"); // Anahtar: 3, Değer: "Three" eklendi

        // 2. Count özelliği ile eleman sayısını alma
        int count = dictionary.Count; // Eleman sayısı: 3

        // 3. TryGetValue ile belirli bir anahtarın değerini güvenli bir şekilde alma
        if (dictionary.TryGetValue(2, out string valueForKey2))
        {
            Console.WriteLine($"Value for key 2: {valueForKey2}"); // Çıktı: "Value for key 2: Two"
        }

        // 4. ContainsKey ile belirli bir anahtarın var olup olmadığını kontrol etme
        bool hasKey3 = dictionary.ContainsKey(3); // true

        // 5. Eleman güncelleme veya ekleme (AddOrUpdate)
        dictionary.AddOrUpdate(2, "Two Updated", (key, oldValue) => "Two Updated"); // 2 anahtarındaki değer güncellenir
        dictionary.AddOrUpdate(4, "Four", (key, oldValue) => oldValue);             // 4 anahtarı yoksa eklenir

        // 6. TryUpdate ile belirli bir anahtarın değerini güncelleme
        bool updated = dictionary.TryUpdate(3, "Three Updated", "Three"); // 3 anahtarının değeri "Three" ise "Three Updated" ile güncellenir

        // 7. TryRemove ile belirli bir anahtarın elemanını silme
        bool removed = dictionary.TryRemove(1, out string removedValue); // 1 anahtarına sahip eleman silinir

        // 8. Elemanları gezmek için Foreach kullanma
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            // Çıktı: Key: 2, Value: Two Updated
            //        Key: 3, Value: Three Updated
            //        Key: 4, Value: Four
        }

        // 9. GetOrAdd ile bir anahtar mevcutsa değerini döndürme, yoksa yeni bir anahtar-değer çifti ekleme
        string valueForKey5 = dictionary.GetOrAdd(5, "Five"); // Anahtar 5 yoksa eklenir, mevcutsa değeri döner

        // 10. Clear işlemi ConcurrentDictionary'de mevcut değildir, ancak tüm elemanları silmek için yeni bir nesne atanabilir
        dictionary = new ConcurrentDictionary<int, string>(); // Tüm elemanlar silinmiş gibi olur
        
        
        // Çıktılar yorum satırında:
        // Count: 3
        // Value for key 2: Two
        // ContainsKey(3): true
        // Updated value for key 2 to "Two Updated" and added key 4 with "Four"
        // TryUpdate key 3: Success
        // Removed key 1 with value "One"
        // Remaining elements after updates and removes:
        //   Key: 2, Value: Two Updated
        //   Key: 3, Value: Three Updated
        //   Key: 4, Value: Four
        // GetOrAdd for key 5: Five
        // Cleared all elements by reinitializing the dictionary
    }
}
}