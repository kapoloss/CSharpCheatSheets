using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace GenericCollections
{
    public class ObservableCollection_T_
    {
        // •	Tanım: Verilerdeki değişiklikleri izleyip abone olanlara bildirimde bulunur.
        // •	Kullanım Alanı: UI elementlerinin otomatik olarak güncellenmesi gerektiğinde.
    }
    
    //     •	Add: Koleksiyonun sonuna eleman ekler.
    //     •	Insert: Belirli bir indekse eleman ekler.
    //     •	Remove: Belirli bir elemanı koleksiyondan çıkarır.
    //     •	RemoveAt: Belirtilen indeksteki elemanı koleksiyondan çıkarır.
    //     •	Clear: Tüm elemanları temizler.
    //     •	Count: Koleksiyondaki toplam eleman sayısını döndürür.
    //     •	Contains: Belirtilen değerin koleksiyonda olup olmadığını kontrol eder.
    //     •	IndexOf: Belirtilen elemanın indeksini döndürür.
    


public class ObservableCollectionExample
{
    public static void Main()
    {
        // 1. ObservableCollection tanımlanır ve elemanlar eklenir.
        ObservableCollection<int> numbers = new ObservableCollection<int>();

        // Koleksiyonda bir değişiklik olduğunda tetiklenecek olay
        numbers.CollectionChanged += Numbers_CollectionChanged;

        // 2. Eleman ekleme
        numbers.Add(10); // 10 koleksiyona eklendi
        numbers.Add(20); // 20 koleksiyona eklendi
        numbers.Add(30); // 30 koleksiyona eklendi

        // 3. Count özelliği ile eleman sayısını alma
        int count = numbers.Count; // Eleman sayısı: 3

        // 4. Insert ile belirli bir konuma eleman ekleme
        numbers.Insert(1, 15); // 1. indekse 15 eklendi (10, 15, 20, 30)

        // 5. Contains ile belirli bir elemanın olup olmadığını kontrol etme
        bool contains20 = numbers.Contains(20); // true

        // 6. IndexOf ile belirli bir elemanın indeksini bulma
        int indexOf20 = numbers.IndexOf(20); // 2

        // 7. Remove ile belirli bir elemanı çıkarma
        numbers.Remove(10); // 10 çıkarıldı

        // 8. RemoveAt ile belirli bir indeksteki elemanı çıkarma
        numbers.RemoveAt(1); // 1. indekste bulunan eleman (20) çıkarıldı

        // 9. Elemanları gezmek için Foreach kullanma
        foreach (int item in numbers)
        {
            Console.WriteLine(item); // Çıktı: 15, 30
        }

        // 10. Clear ile tüm elemanları temizleme
        numbers.Clear(); // Tüm elemanlar silindi, Count: 0

        // Çıktılar yorum satırında:
        // Added 10
        // Added 20
        // Added 30
        // Collection count: 3
        // Inserted 15 at index 1
        // Contains 20: true
        // IndexOf 20: 2
        // Removed 10
        // Removed item at index 1 (20)
        // Remaining elements: 15, 30
        // Cleared all elements
    }

    // Koleksiyon değişikliği olduğunda tetiklenen event handler
    private static void Numbers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine("Added " + e.NewItems[0]);
                break;
            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine("Removed " + e.OldItems[0]);
                break;
            case NotifyCollectionChangedAction.Replace:
                Console.WriteLine("Replaced " + e.OldItems[0] + " with " + e.NewItems[0]);
                break;
            case NotifyCollectionChangedAction.Move:
                Console.WriteLine("Moved " + e.OldItems[0]);
                break;
            case NotifyCollectionChangedAction.Reset:
                Console.WriteLine("Cleared all elements");
                break;
        }
    }
}
}