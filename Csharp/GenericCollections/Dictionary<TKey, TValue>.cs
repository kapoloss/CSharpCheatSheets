using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollections
{
    public class Dictionary_TKey__TValue_
    {
        // •	Tanım: Çoklu iş parçacığı ortamlarında güvenli bir
        // şekilde kullanılabilecek anahtar-değer çiftlerinden oluşan bir koleksiyon.
        
        // •	Kullanım Alanı: Çok iş parçacıklı uygulamalarda veri tutmak için.
    }
    

public class DictionaryExample
{
    public static void Main()
    {
        // 1. Dictionary tanımlanır ve elemanlar eklenir.
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Alice");  // 1 anahtarı ile Alice eklendi
        students.Add(2, "Bob");    // 2 anahtarı ile Bob eklendi
        students.Add(3, "Charlie"); // 3 anahtarı ile Charlie eklendi
        students[4] = "David";     // 4 anahtarı ile David eklendi

        // 2. Count özelliği ile eleman sayısını alma
        int count = students.Count; // Eleman sayısı: 4

        // 3. Dictionary'de eleman olup olmadığını kontrol etme
        bool hasKey2 = students.ContainsKey(2);      // true
        bool hasValueAlice = students.ContainsValue("Alice"); // true

        // 4. TryGetValue ile anahtar değeri bulma
        if (students.TryGetValue(3, out string studentName))
        {
            // studentName = "Charlie" olur
        }

        // 5. Eleman ekleme (Add metodu ile)
        students.Add(5, "Eve"); // 5 anahtarı ile Eve eklendi

        // 6. Eleman silme (Remove metodu ile)
        students.Remove(1); // 1 anahtarındaki Alice silindi

        // 7. Clear ile tüm elemanları silme
        students.Clear(); // Tüm elemanlar silindi, Count: 0

        // 8. Yeniden eleman ekleyelim
        students[1] = "Alice";
        students[2] = "Bob";
        students[3] = "Charlie";
        students[4] = "David";
        students[5] = "Eve";

        // 9. Keys ile tüm anahtarları alma
        ICollection<int> keys = students.Keys; // [1, 2, 3, 4, 5]

        // 10. Values ile tüm değerleri alma
        ICollection<string> values = students.Values; // ["Alice", "Bob", "Charlie", "David", "Eve"]

        // 11. Foreach döngüsü ile her anahtar-değer çiftini gezme
        foreach (KeyValuePair<int, string> kvp in students)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            // Çıktı: Key: 1, Value: Alice
            //        Key: 2, Value: Bob
            //        Key: 3, Value: Charlie
            //        Key: 4, Value: David
            //        Key: 5, Value: Eve
        }

        // 12. Dictionary'yi diziye çevirme
        KeyValuePair<int, string>[] array = new KeyValuePair<int, string>[students.Count];
        students.ToArray().CopyTo(array, 0); // students elemanları array'e kopyalandı

        // 13. Dictionary'yi bir sözlük listesine çevirme
        List<KeyValuePair<int, string>> studentList = new List<KeyValuePair<int, string>>(students);

        // 14. Anahtar ve değeri değiştirme
        students[2] = "Bobby"; // 2 anahtarının değeri "Bob" yerine "Bobby" olarak değiştirildi

        // 15. ContainsKey ve ContainsValue ile arama
        bool containsKey3 = students.ContainsKey(3); // true
        bool containsValueEve = students.ContainsValue("Eve"); // true

        // 16. Dictionary'den anahtara göre eleman çekme
        string name = students[3]; // name = "Charlie"

        // Çıktılar yorum satırında:
        // Count: 4
        // Has key 2: true
        // Has value "Alice": true
        // Found student with ID 3: Charlie
        // Added student with ID 5: Eve
        // Removed student with ID 1
        // Cleared all students
        // Re-added students with IDs 1 to 5
        // Keys: [1, 2, 3, 4, 5]
        // Values: ["Alice", "Bobby", "Charlie", "David", "Eve"]
        // Dictionary copied to array: [KeyValuePair(1, "Alice"), KeyValuePair(2, "Bobby"), ...]
        // Converted to list of KeyValuePair
        // Updated value for key 2 to "Bobby"
        // Contains key 3: true
        // Contains value "Eve": true
        // Student with ID 3: Charlie
    }
}
}