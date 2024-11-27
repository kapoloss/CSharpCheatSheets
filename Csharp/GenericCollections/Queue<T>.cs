using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class Queue_T_
    {
        // •	Tanım: İlk giren ilk çıkar (FIFO) prensibiyle çalışan bir veri yapısıdır.
        
        // •	Kullanım Alanı: Bir sırayla işlenen görevlerde, işlem sırasını korumak için.
    }
    
    //     •	Enqueue: Kuyruğun sonuna eleman ekler.
    //     •	Dequeue: Kuyruğun başındaki elemanı çıkarır ve döndürür.
    //     •	Peek: Kuyruğun başındaki elemanı çıkarmaz, yalnızca döndürür.
    //     •	Clear: Kuyruktaki tüm elemanları siler.
    //     •	Count: Kuyruktaki toplam eleman sayısını döndürür.
    //     •	ToArray: Kuyruktaki elemanları bir diziye kopyalar.
    //     •	TrimExcess: Kuyruğun kapasitesini optimize eder.
    

    public class QueueExample
    {
        public static void Main()
        {
            // 1. Queue tanımlanır ve elemanlar eklenir.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10); // 10 kuyruğa eklendi
            queue.Enqueue(20); // 20 kuyruğa eklendi
            queue.Enqueue(30); // 30 kuyruğa eklendi
            queue.Enqueue(40); // 40 kuyruğa eklendi

            // 2. Count özelliği ile eleman sayısını alma
            int count = queue.Count; // Eleman sayısı: 4

            // 3. Peek ile en öndeki elemanı alma (dequeue yapmadan)
            int frontElement = queue.Peek(); // En öndeki eleman: 10 (değişmez)

            // 4. Dequeue ile en öndeki elemanı çıkarma
            int removedElement = queue.Dequeue(); // 10 çıkarıldı

            // 5. Clear ile tüm elemanları temizleme
            queue.Clear(); // Tüm elemanlar silindi, Count: 0

            // 6. Tekrar elemanlar ekleyelim
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Enqueue(80);

            // 7. Elemanları gezmek için Foreach kullanma
            foreach (int item in queue)
            {
                Console.WriteLine(item); // 50, 60, 70, 80 sırasıyla yazdırılır
            }

            // 8. Queue'yu diziye dönüştürme
            int[] array = queue.ToArray(); // Queue elemanları bir diziye kopyalandı

            // 9. Belirli bir kapasite ayarlama (Queue'nin kapasitesi değişkendir)
            queue.TrimExcess(); // Kapasite, mevcut eleman sayısına göre optimize edilir

            // Çıktılar yorum satırında:
            // Count: 4
            // Front element (Peek): 10
            // Removed element (Dequeue): 10
            // Cleared all elements
            // Added elements 50, 60, 70, 80
            // Elements in queue: 50, 60, 70, 80
            // Queue copied to array: [50, 60, 70, 80]
        }
    }
}