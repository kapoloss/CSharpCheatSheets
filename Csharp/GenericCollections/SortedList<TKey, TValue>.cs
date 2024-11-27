using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class SortedList_TKey__TValue_
    {
        // •	Tanım: Anahtar-değer çiftlerini anahtara göre sıralı olarak tutar.
        // •	Kullanım Alanı: Hem sıralı hem de anahtar-değer tabanlı bir yapı gerektiğinde.
    }
    
    //     •	Add: Anahtar ve değer çifti ekler. Elemanlar anahtara göre otomatik olarak sıralanır.
    //     •	Count: Listedeki toplam eleman sayısını döndürür.
    //     •	ContainsKey: Belirtilen anahtarın listede olup olmadığını kontrol eder.
    //     •	ContainsValue: Belirtilen değerin listede olup olmadığını kontrol eder.
    //     •	Remove: Belirli bir anahtara sahip elemanı siler.
    //     •	RemoveAt: Belirtilen indeksteki elemanı siler.
    //     •	Keys: Tüm anahtarları sıralı bir koleksiyon olarak döndürür.
    //     •	Values: Tüm değerleri sıralı bir koleksiyon olarak döndürür.
    //     •	TryGetValue: Belirtilen anahtara sahip değeri güvenli bir şekilde döndürür.
    //     •	Clear: Listedeki tüm elemanları temizler.
    

public class SortedListExample
{
    public static void Main()
    {
        // 1. SortedList tanımlanır ve elemanlar eklenir.
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three"); // Anahtar: 3, Değer: "Three" eklendi
        sortedList.Add(1, "One");   // Anahtar: 1, Değer: "One" eklendi
        sortedList.Add(4, "Four");  // Anahtar: 4, Değer: "Four" eklendi
        sortedList.Add(2, "Two");   // Anahtar: 2, Değer: "Two" eklendi

        // 2. Count özelliği ile eleman sayısını alma
        int count = sortedList.Count; // Eleman sayısı: 4

        // 3. Elemanları anahtara göre sıralı olarak erişme
        foreach (KeyValuePair<int, string> kvp in sortedList)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            // Çıktı: Key: 1, Value: One
            //        Key: 2, Value: Two
            //        Key: 3, Value: Three
            //        Key: 4, Value: Four
        }

        // 4. ContainsKey ile belirli bir anahtarın var olup olmadığını kontrol etme
        bool hasKey2 = sortedList.ContainsKey(2); // true

        // 5. ContainsValue ile belirli bir değerin var olup olmadığını kontrol etme
        bool hasValueFive = sortedList.ContainsValue("Five"); // false

        // 6. Anahtara göre elemanı alma
        string valueForKey3 = sortedList[3]; // "Three" döner

        // 7. Remove ile belirli bir anahtarın elemanını silme
        sortedList.Remove(1); // Anahtar 1'e sahip eleman ("One") silindi

        // 8. RemoveAt ile belirli bir indeksteki elemanı silme
        sortedList.RemoveAt(0); // İlk eleman (Anahtar 2, Değer "Two") silindi

        // 9. Keys ile tüm anahtarları alma
        IList<int> keys = sortedList.Keys; // [3, 4]

        // 10. Values ile tüm değerleri alma
        IList<string> values = sortedList.Values; // ["Three", "Four"]

        // 11. TryGetValue ile anahtarın değerini güvenli bir şekilde alma
        if (sortedList.TryGetValue(3, out string result))
        {
            Console.WriteLine($"Value for key 3: {result}"); // Çıktı: "Value for key 3: Three"
        }

        // 12. Clear ile tüm elemanları temizleme
        sortedList.Clear(); // Tüm elemanlar silindi, Count: 0

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
        // Removed element at index 0 (key 2)
        // Remaining keys: [3, 4]
        // Remaining values: ["Three", "Four"]
        // Cleared all elements
    }
}
}