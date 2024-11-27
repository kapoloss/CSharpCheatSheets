using System;

namespace DataTypes
{
    public class ObjectType
    {
        // C# dilinde object, .NET Framework’te yer alan tüm veri türlerinin temel sınıfıdır.
        // System.Object sınıfından türetilir ve bütün veri türleri (value types ve reference types)
        // doğrudan ya da dolaylı olarak object sınıfından miras alır. Bu nedenle, object C# dilinde en temel veri türüdür.
        //
        // object ile İlgili Temel Özellikler:
        //
        // 1.	Tüm Veri Türlerinin Tabanı:
        // •	object, tüm veri türlerinin ortak bir temel sınıfıdır.
        // Hem değer türleri (int, double, struct vb.) hem de referans türleri (class, string, array vb.)
        // object olarak ifade edilebilir.
        // 2.	Boxing ve Unboxing:
        // •	Değer türleri (int, float, bool vb.) bir object referansına atandığında,
        // boxing adı verilen bir işlemle yığın (stack) belleğinden heap belleğine taşınır.
        // •	Bir object referansı tekrar değer türüne dönüştürüldüğünde, unboxing işlemi gerçekleşir.

        public void Method()
        {
            int value = 42;
            object boxedValue = value;  // Boxing
            int unboxedValue = (int)boxedValue;  // Unboxing
        }
        
        // 3.	System.Object’in Metotları:
        // System.Object sınıfı, tüm türler için geçerli olan birkaç metot içerir. En yaygın kullanılanlar şunlardır:
        // •	ToString(): Nesnenin metinsel temsili.
        // •	Equals(object obj): İki nesnenin eşit olup olmadığını belirler.
        // •	GetHashCode(): Nesnenin hash kodunu döndürür.
        // •	GetType(): Nesnenin çalışma zamanındaki türünü döndürür.
        // •	MemberwiseClone(): Nesnenin yüzeysel bir kopyasını oluşturur.
        
        // 4.	Downcasting ve Upcasting:
        // •	object türünden türeyen bir nesneyi, asıl türüne döndürebilirsiniz (downcasting).
        // Ancak bu işlem InvalidCastException hatasına neden olabilir, bu yüzden tür denetimi yapmak önemlidir.

        public void Method2()
        {
            object obj = "Hello, World!";
            if (obj is string str)
            {
                Console.WriteLine(str.ToUpper());
            }
        }
    }
}