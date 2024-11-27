using System;

namespace Others
{
    public class Pointer
    {
        // •	Tanım: İşaretçi (pointer), bir değişkenin bellek adresini tutar.
        
        // •	Temel İşlemler:
        // •	*: İşaretçinin gösterdiği adresin değerine erişmek için kullanılır.
        // •	&: Bir değişkenin bellek adresini almak için kullanılır.
        // •	->: Yapıların ve sınıfların işaretçilerle erişimi için kullanılır.
        // •	[]: İşaretçi üzerinden dizi benzeri erişim sağlar.

        public void Method()
        {
            unsafe
            {
                int value = 42;
                int* ptr = &value;
                Console.WriteLine(*ptr); // 42
                *ptr = 50;
                Console.WriteLine(value); // 50
            }
        }
    }
}