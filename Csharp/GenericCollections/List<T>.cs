using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class List_T_
    {
        //•	Tanım: Bir dizinin aksine, dinamik olarak genişleyebilen sıralı veri koleksiyonudur.
        //Eleman ekleyip çıkarıldığında kapasitesi otomatik olarak güncellenir.
        
        //•	Kullanım Alanı: Dinamik uzunlukta bir diziye ihtiyaç duyulduğunda.
    }
    
	// 1.	Add(T item): Listenin sonuna bir eleman ekler.
	// 2.	AddRange(IEnumerable collection): Koleksiyon içindeki tüm elemanları listeye ekler.
	// 3.	AsReadOnly(): Listeyi yalnızca okunabilir bir koleksiyon olarak döndürür.
	// 4.	BinarySearch(T item): Listede belirtilen elemanı ikili arama algoritması ile bulur. Liste sıralı olmalıdır.
	// 5.	Clear(): Listedeki tüm elemanları kaldırır.
	// 6.	Contains(T item): Elemanın listede olup olmadığını kontrol eder.
	// 7.	ConvertAll(Converter<T, TOutput> converter): Listedeki her elemanı başka bir tipe dönüştürür.
	// 8.	CopyTo(T[] array): Listeyi belirtilen diziye kopyalar.
	// 9.	Exists(Predicate match): Belirli bir koşulu sağlayan bir elemanın listede olup olmadığını kontrol eder.
	// 10.	Find(Predicate match): Belirli bir koşulu sağlayan ilk elemanı döndürür.
	// 11.	FindAll(Predicate match): Belirli bir koşulu sağlayan tüm elemanları döndürür.
	// 12.	FindIndex(Predicate match): Belirli bir koşulu sağlayan ilk elemanın indeksini döndürür.
	// 13.	FindLast(Predicate match): Belirli bir koşulu sağlayan son elemanı döndürür.
	// 14.	FindLastIndex(Predicate match): Belirli bir koşulu sağlayan son elemanın indeksini döndürür.
	// 15.	ForEach(Action action): Listedeki her eleman için belirli bir işlemi gerçekleştirir.
	// 16.	GetRange(int index, int count): Belirtilen aralıktaki elemanları döndürür.
	// 17.	IndexOf(T item): Elemanın ilk bulunduğu indeksi döndürür.
	// 18.	Insert(int index, T item): Belirtilen indekse eleman ekler.
	// 19.	InsertRange(int index, IEnumerable collection): Belirtilen indekse koleksiyon ekler.
	// 20.	LastIndexOf(T item): Elemanın listede son görüldüğü indeksi döndürür.
	// 21.	Remove(T item): İlk bulunan elemanı siler.
	// 22.	RemoveAll(Predicate match): Belirli bir koşulu sağlayan tüm elemanları siler.
	// 23.	RemoveAt(int index): Belirtilen indeksteki elemanı siler.
	// 24.	RemoveRange(int index, int count): Belirtilen aralıktaki elemanları siler.
	// 25.	Reverse(): Listedeki elemanların sırasını ters çevirir.
	// 26.	Sort(): Listedeki elemanları sıralar.
	// 27.	Sort(Comparison comparison): Belirli bir karşılaştırma fonksiyonu ile listeyi sıralar.
	// 28.	ToArray(): Listeyi bir dizi olarak döndürür.
	// 29.	TrimExcess(): Kapasiteyi eleman sayısına göre azaltır.
	// 30.	TrueForAll(Predicate match): Listedeki tüm elemanların belirtilen koşulu sağlayıp sağlamadığını kontrol eder.

public class ListExample
{
    public static void Main()
    {
        // 1. List tanımlanır ve elemanlar eklenir.
        List<int> numbers = new List<int>();
        numbers.Add(10); // Listeye 10 eklendi
        numbers.Add(20); // Listeye 20 eklendi
        numbers.Add(30); // Listeye 30 eklendi
        numbers.Add(40); // Listeye 40 eklendi
        numbers.AddRange(new int[] { 50, 60 }); // 50 ve 60 listeye eklendi

        // 2. Capacity ve Count özelliklerini kullanma
        int capacity = numbers.Capacity; // Kapasite: başlangıçta varsayılan bir değerdir
        int count = numbers.Count; // Eleman sayısı: 6

        // 3. AsReadOnly() ile salt okunur bir liste oluşturma
        var readOnlyNumbers = numbers.AsReadOnly();

        // 4. BinarySearch ile eleman arama (önce listeyi sıralıyoruz)
        numbers.Sort();
        int index = numbers.BinarySearch(30); // 30 elemanı sıralı listede aranır, index: 2

        // 5. Clear ile listeyi temizleme
        numbers.Clear(); // Tüm elemanlar silindi, Count: 0

        // 6. Listeye tekrar eleman ekleyelim
        numbers.AddRange(new int[] { 10, 20, 30, 40, 50, 60 });

        // 7. Contains ile eleman var mı kontrol etme
        bool contains30 = numbers.Contains(30); // true

        // 8. ConvertAll ile her elemanı dönüştürme
        List<string> stringNumbers = numbers.ConvertAll(num => num.ToString()); // ["10", "20", "30", "40", "50", "60"]

        // 9. CopyTo ile listeyi diziye kopyalama
        int[] array = new int[numbers.Count];
        numbers.CopyTo(array); // numbers elemanları array dizisine kopyalandı

        // 10. Exists ile koşula göre eleman var mı kontrol etme
        bool existsAbove50 = numbers.Exists(num => num > 50); // true (60 var)

        // 11. Find ile belirli bir koşulu sağlayan ilk elemanı bulma
        int firstAbove30 = numbers.Find(num => num > 30); // İlk 40'ı bulur

        // 12. FindAll ile belirli bir koşulu sağlayan tüm elemanları bulma
        List<int> above30 = numbers.FindAll(num => num > 30); // [40, 50, 60]

        // 13. FindIndex ile belirli bir koşulu sağlayan ilk elemanın indeksini bulma
        int firstIndexAbove30 = numbers.FindIndex(num => num > 30); // 3

        // 14. FindLast ile belirli bir koşulu sağlayan son elemanı bulma
        int lastAbove30 = numbers.FindLast(num => num > 30); // 60

        // 15. FindLastIndex ile belirli bir koşulu sağlayan son elemanın indeksini bulma
        int lastIndexAbove30 = numbers.FindLastIndex(num => num > 30); // 5

        // 16. ForEach ile tüm elemanları işleme
        numbers.ForEach(num => Console.Write(num + " ")); // 10 20 30 40 50 60

        // 17. GetRange ile belirli bir aralıktaki elemanları alma
        List<int> range = numbers.GetRange(1, 3); // [20, 30, 40]

        // 18. IndexOf ile belirli bir elemanın indeksini bulma
        int indexOf20 = numbers.IndexOf(20); // 1

        // 19. Insert ile belirli bir indekse eleman ekleme
        numbers.Insert(2, 25); // Liste: [10, 20, 25, 30, 40, 50, 60]

        // 20. InsertRange ile belirli bir indekse koleksiyon ekleme
        numbers.InsertRange(4, new int[] { 35, 37 }); // Liste: [10, 20, 25, 30, 35, 37, 40, 50, 60]

        // 21. LastIndexOf ile elemanın son görüldüğü indeksi bulma
        int lastIndexOf60 = numbers.LastIndexOf(60); // 8

        // 22. Remove ile ilk bulunan elemanı silme
        numbers.Remove(25); // 25 silindi, Liste: [10, 20, 30, 35, 37, 40, 50, 60]

        // 23. RemoveAll ile belirli koşulu sağlayan tüm elemanları silme
        numbers.RemoveAll(num => num > 50); // 60 ve üzerindeki elemanlar silindi

        // 24. RemoveAt ile belirli bir indeksteki elemanı silme
        numbers.RemoveAt(0); // İlk eleman silindi, Liste: [20, 30, 35, 37, 40, 50]

        // 25. RemoveRange ile belirli bir aralıktaki elemanları silme
        numbers.RemoveRange(2, 2); // Liste: [20, 30, 50]

        // 26. Reverse ile elemanların sırasını ters çevirme
        numbers.Reverse(); // Liste: [50, 30, 20]

        // 27. Sort ile listeyi sıralama
        numbers.Sort(); // Liste: [20, 30, 50]

        // 28. ToArray ile listeyi diziye çevirme
        int[] numbersArray = numbers.ToArray(); // [20, 30, 50]

        // 29. TrimExcess ile kapasiteyi eleman sayısına göre azaltma
        numbers.TrimExcess(); // Kapasite, mevcut eleman sayısına göre düzenlendi

        // 30. TrueForAll ile tüm elemanların koşulu sağlayıp sağlamadığını kontrol etme
        bool allAbove10 = numbers.TrueForAll(num => num > 10); // true

        // Çıktılar yorum satırında:
        // Capacity: başlangıç değeri (örneğin 4), artırıldıkça otomatik artar.
        // Count: 6
        // Contains 30: true
        // Converted list to string: ["10", "20", "30", "40", "50", "60"]
        // Copied array: [10, 20, 30, 40, 50, 60]
        // Exists element above 50: true
        // First element above 30: 40
        // Elements above 30: [40, 50, 60]
        // First index of element above 30: 3
        // Last element above 30: 60
        // Last index of element above 30: 5
        // List after Insert and InsertRange: [10, 20, 25, 30, 35, 37, 40, 50, 60]
        // LastIndexOf 60: 8
        // List after RemoveAll (>50): [20, 30, 35, 37, 40]
        // Array converted: [20, 30, 50]
        // TrueForAll above 10: true
    }
}
}