using System;

namespace Others
{
    public class Fixed
    {
        // •	Tanım: fixed, yönetilen (managed) bellekte bir nesnenin taşınmasını engeller.
        
        // •	Kullanım Amacı: Çöp toplayıcı (GC) tarafından bellek taşınmasını önlemek için kullanılır.
        // Bu, işaretçilerin güvenilir adreslere erişmesini sağlar.
        
        // •	Özellikler:
        // •	Yönetilen tiplerden (string, array) sabit bir bellek adresi almak için kullanılır.
        // •	Sabitleme işlemi fixed bloğunda geçerlidir; blok dışına çıkıldığında bellek serbest bırakılır.

        public void Method()
        {
            unsafe
            {
                int[] numbers = { 1, 2, 3, 4 };
                fixed (int* ptr = numbers) // numbers dizisini sabitler
                {
                    Console.WriteLine(*ptr); // İlk elemanı yazdırır (1)
                    Console.WriteLine(*(ptr + 1)); // İkinci elemanı yazdırır (2)
                } // Burada sabitleme sona erer, GC bellek taşımaya devam edebilir
            }
        }
        
    }
    
   
}