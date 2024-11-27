using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class Stack_T_
    {
        // •	Tanım: Son giren ilk çıkar (LIFO) prensibiyle çalışan bir veri yapısıdır.
        
        // •	Kullanım Alanı: Bir veri kümesinin son eklenen elemanına hızlı erişim gerektiğinde,
        // örneğin işleme alınacak en güncel öğeyi takip etmek için.
    }
    
    //     •	Push: Yığının en üstüne eleman ekler.
    //     •	Pop: Yığının en üstündeki elemanı çıkarır ve döndürür.
    //     •	Peek: Yığının en üstündeki elemanı çıkarmaz, yalnızca döndürür.
    //     •	Clear: Yığındaki tüm elemanları siler.
    //     •	Count: Yığındaki toplam eleman sayısını döndürür.
    //     •	ToArray: Yığındaki elemanları bir diziye kopyalar.
    //     •	TrimExcess: Yığının kapasitesini optimize eder.
    

    public class StackExample
    {
        public static void Main()
        {
            // 1. Stack tanımlanır ve elemanlar eklenir.
            Stack<int> stack = new Stack<int>();
            stack.Push(10); // 10 yığına eklendi
            stack.Push(20); // 20 yığına eklendi
            stack.Push(30); // 30 yığına eklendi
            stack.Push(40); // 40 yığına eklendi

            // 2. Count özelliği ile eleman sayısını alma
            int count = stack.Count; // Eleman sayısı: 4

            // 3. Peek ile en üstteki elemanı alma (pop yapmadan)
            int topElement = stack.Peek(); // En üstteki eleman: 40 (değişmez)

            // 4. Pop ile en üstteki elemanı çıkarma
            int removedElement = stack.Pop(); // 40 çıkarıldı

            // 5. Clear ile tüm elemanları temizleme
            stack.Clear(); // Tüm elemanlar silindi, Count: 0

            // 6. Tekrar elemanlar ekleyelim
            stack.Push(50);
            stack.Push(60);
            stack.Push(70);
            stack.Push(80);

            // 7. Elemanları gezmek için Foreach kullanma
            foreach (int item in stack)
            {
                Console.WriteLine(item); // 80, 70, 60, 50 sırasıyla yazdırılır (LIFO düzeninde)
            }

            // 8. Stack'i diziye dönüştürme
            int[] array = stack.ToArray(); // Stack elemanları bir diziye kopyalandı

            // 9. Belirli bir kapasite ayarlama (Stack'in kapasitesi değişkendir)
            stack.TrimExcess(); // Kapasite, mevcut eleman sayısına göre optimize edilir

            // Çıktılar yorum satırında:
            // Count: 4
            // Top element (Peek): 40
            // Removed element (Pop): 40
            // Cleared all elements
            // Added elements 50, 60, 70, 80
            // Elements in stack (LIFO order): 80, 70, 60, 50
            // Stack copied to array: [80, 70, 60, 50]
        }
    }
}