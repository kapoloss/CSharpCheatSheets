using System;

namespace Others
{
    public class Unsafe
    {
        // •	Tanım: unsafe, bir kod bloğunun veya metotun işaretçi kullanmasına izin verir.
        
        // •	Kullanım Amacı: İşaretçilerle çalışma, bellek adreslerine erişim,
        // sabit belleğe erişim ve daha fazla kontrol gerektiren durumlar için kullanılır.
        
        // •	Özellikler:
        
        // •	İşaretçilerle çalışma yalnızca unsafe blok içinde mümkündür.
        // •	Derlemek için projenin “unsafe code” seçeneğinin etkinleştirilmesi gerekir.
        // •	CLR (Common Language Runtime), unsafe kodun güvenliğini garanti etmez; bu nedenle dikkatli kullanılmalıdır.

        public void Method()
        {
            unsafe
            {
                int value = 10;
                int* ptr = &value; // value'nun adresine işaretçi oluşturur
                *ptr = 20;         // İşaretçinin gösterdiği adresin değerini değiştirir
                Console.WriteLine(value); // 20 yazdırılır
            }
        }
        
       
    }
    
}