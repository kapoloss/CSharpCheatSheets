using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class LinkedList_T_
    {
        //•	Tanım: Çift yönlü bağlantılı liste veri yapısıdır. Her düğüm bir sonraki ve bir önceki düğüme bağlantı içerir.
        //•	Kullanım Alanı: Sık sık ekleme ve çıkarma yapılacaksa.
    }
    
    //     •	AddFirst: Listenin başına eleman ekler.
    //     •	AddLast: Listenin sonuna eleman ekler.
    //     •	AddBefore: Belirtilen bir düğümden önce eleman ekler.
    //     •	AddAfter: Belirtilen bir düğümden sonra eleman ekler.
    //     •	Remove: Belirtilen değere sahip ilk düğümü siler.
    //     •	RemoveFirst: İlk düğümü siler.
    //     •	RemoveLast: Son düğümü siler.
    //     •	Contains: Belirtilen değerin listede olup olmadığını kontrol eder.
    //     •	CopyTo: Liste elemanlarını bir diziye kopyalar.
    //     •	Clear: Listedeki tüm düğümleri temizler.
    //     •	Count: Listedeki toplam eleman sayısını döndürür.
    //     •	First ve Last: Listenin ilk ve son elemanını döndürür.
    

public class LinkedListExample
{
    public static void Main()
    {
        // 1. LinkedList tanımlanır ve elemanlar eklenir.
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10); // 10 sona eklenir
        list.AddLast(20); // 20 sona eklenir
        list.AddLast(30); // 30 sona eklenir
        list.AddFirst(5); // 5 başa eklenir

        // 2. Count özelliği ile eleman sayısını alma
        int count = list.Count; // Eleman sayısı: 4

        // 3. First ve Last ile ilk ve son elemanı alma
        int firstElement = list.First.Value; // İlk eleman: 5
        int lastElement = list.Last.Value;   // Son eleman: 30

        // 4. AddBefore ve AddAfter ile belirli bir düğümden önce/sonra eleman ekleme
        LinkedListNode<int> node20 = list.Find(20); // 20 değerine sahip düğüm bulunur
        list.AddBefore(node20, 15); // 15, 20'den önce eklenir
        list.AddAfter(node20, 25);  // 25, 20'den sonra eklenir

        // 5. Remove ile belirli bir elemanı silme
        list.Remove(10); // 10 silinir

        // 6. RemoveFirst ve RemoveLast ile ilk ve son elemanı silme
        list.RemoveFirst(); // İlk eleman (5) silinir
        list.RemoveLast();  // Son eleman (30) silinir

        // 7. Elemanları gezmek için Foreach kullanma
        foreach (int item in list)
        {
            Console.WriteLine(item); // 15, 20, 25 sırasıyla yazdırılır
        }

        // 8. Contains ile belirli bir elemanın var olup olmadığını kontrol etme
        bool contains20 = list.Contains(20); // true

        // 9. LinkedList'i diziye dönüştürme
        int[] array = new int[list.Count];
        list.CopyTo(array, 0); // LinkedList elemanları array dizisine kopyalandı

        // 10. Clear ile tüm elemanları temizleme
        list.Clear(); // Tüm elemanlar silindi, Count: 0

        // Çıktılar yorum satırında:
        // Count: 4
        // First element: 5
        // Last element: 30
        // Added 15 before 20 and 25 after 20
        // Removed 10
        // Removed first element (5) and last element (30)
        // Elements in LinkedList: 15, 20, 25
        // Contains 20: true
        // LinkedList copied to array: [15, 20, 25]
        // Cleared all elements
    }
}
}