using System;

namespace Others
{
    public class Stackalloc
    {
        // •	Tanım: stackalloc, yığın (stack) üzerinde sabit boyutlu bir bellek bloğu ayırır.
        
        // •	Kullanım Amacı: Küçük, sabit boyutlu veri yapıları için hız avantajı sağlar.
        // Bellek yönetimi yığın tabanlı olduğundan daha hızlıdır ve GC’nin dışında çalışır.
        
        // •	Özellikler:
        // •	Yalnızca Span<T> veya işaretçilerle kullanılabilir.
        // •	Bellek yığın üzerinde ayrılır, blok dışına çıkıldığında otomatik olarak serbest bırakılır.

        public void Method()
        {
            unsafe
            {
                int* ptr = stackalloc int[5]; // Yığın üzerinde 5 tamsayı için yer ayırır
                for (int i = 0; i < 5; i++)
                {
                    ptr[i] = i * 10; // Değer atar
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(ptr[i]); // 0, 10, 20, 30, 40 yazdırır
                }
            }
        }
    }
}