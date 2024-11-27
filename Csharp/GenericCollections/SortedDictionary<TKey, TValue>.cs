using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class SortedDictionary_TKey__TValue_
    {
        // •	Tanım: Dictionary gibi anahtar-değer çifti tutar ancak SortedList gibi anahtara göre sıralı çalışır.
        // •	Kullanım Alanı: Dictionary performansı istenirken sıralama gerektiğinde.
    }
    
    //     •	Add: Anahtar ve değer çifti ekler. Elemanlar anahtara göre otomatik olarak sıralanır.
    //     •	Count: Listedeki toplam eleman sayısını döndürür.
    //     •	ContainsKey: Belirtilen anahtarın listede olup olmadığını kontrol eder.
    //     •	ContainsValue: Belirtilen değerin listede olup olmadığını kontrol eder.
    //     •	Remove: Belirli bir anahtara sahip elemanı siler.
    //     •	Keys: Tüm anahtarları sıralı bir koleksiyon olarak döndürür.
    //     •	Values: Tüm değerleri sıralı bir koleksiyon olarak döndürür.
    //     •	TryGetValue: Belirtilen anahtara sahip değeri güvenli bir şekilde döndürür.
    //     •	Clear: Listedeki tüm elemanları temizler.
    
    
public class SortedDictionaryExample
{
    public static void Main()
    {
        // 1. SortedDictionary tanımlanır ve elemanlar eklenir.
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
        sortedDictionary.Add(3, "Three"); // Anahtar: 3, Değer: "Three" eklendi
        sortedDictionary.Add(1, "One");   // Anahtar: 1, Değer: "One" eklendi
        sortedDictionary.Add(4, "Four");  // Anahtar: 4, Değer: "Four" eklendi
        sortedDictionary.Add(2, "Two");   // Anahtar: 2, Değer: "Two" eklendi

        // 2. Count özelliği ile eleman sayısını alma
        int count = sortedDictionary.Count; // Eleman sayısı: 4

        // 3. Elemanları anahtara göre sıralı olarak erişme
        foreach (KeyValuePair<int, string> kvp in sortedDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            // Çıktı: Key: 1, Value: One
            //        Key: 2, Value: Two
            //        Key: 3, Value: Three
            //        Key: 4, Value: Four
        }

        // 4. ContainsKey ile belirli bir anahtarın var olup olmadığını kontrol etme
        bool hasKey2 = sortedDictionary.ContainsKey(2); // true

        // 5. ContainsValue ile belirli bir değerin var olup olmadığını kontrol etme
        bool hasValueFive = sortedDictionary.ContainsValue("Five"); // false

        // 6. Anahtara göre elemanı alma
        string valueForKey3 = sortedDictionary[3]; // "Three" döner

        // 7. Remove ile belirli bir anahtarın elemanını silme
        sortedDictionary.Remove(1); // Anahtar 1'e sahip eleman ("One") silindi

        // 8. Keys ile tüm anahtarları alma
        ICollection<int> keys = sortedDictionary.Keys; // [2, 3, 4]

        // 9. Values ile tüm değerleri alma
        ICollection<string> values = sortedDictionary.Values; // ["Two", "Three", "Four"]

        // 10. TryGetValue ile anahtarın değerini güvenli bir şekilde alma
        if (sortedDictionary.TryGetValue(3, out string result))
        {
            Console.WriteLine($"Value for key 3: {result}"); // Çıktı: "Value for key 3: Three"
        }

        // 11. Clear ile tüm elemanları temizleme
        sortedDictionary.Clear(); // Tüm elemanlar silindi, Count: 0

        // Çıktılar yorum satırında:
        // Count: 4
        // Keys and values in sorted order:
        //   Key: 1, Value: One
        //   Key: 2, Value: Two
        //   Key: 3, Value: Three
        //   Key: 4, Value: Four
        // ContainsKey(2): true
        // ContainsValue("Five"): false
        // Value for key 3: Three
        // Removed element with key 1
        // Remaining keys: [2, 3, 4]
        // Remaining values: ["Two", "Three", "Four"]
        // Cleared all elements
    }
}
}