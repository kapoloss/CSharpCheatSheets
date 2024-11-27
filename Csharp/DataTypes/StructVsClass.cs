namespace ValueTypes
{
    public class StructVsClass
    {
        // Özellik	               struct	                           class
        // Bellek Konumu	       Stack	                           Heap
        // Tip                     Değer Tipi	                       Referans Tipi
        // Kopyalama	           Değerin kendisi kopyalanır	       Referans kopyalanır
        // Varsayılan Yapıcı	   Kullanılamaz	                       Kullanılabilir
        // Miras	               Miras almaz,interface uygular	   Miras alabilir
        // Boş Değer Atama	       Nullable yapılabilir (int?)	       Nullable yapılamaz
        
        
        
        // Ne Zaman struct Kullanılmalı?
        //
        //     •	Küçük ve hafif veri yapıları: Bellekte daha az yer kaplayan basit tipler.
        //     •	Immutable veri: Değişmez özelliklere sahip basit modeller.
        //     •	Örneğin:
        //     •	Matematiksel veri modelleri (ör. Point, Vector).
        //     •	Konfigürasyon veri yapıları.
        //     •	Koordinatlar, renkler, ya da tarihler.
        //     
        //     
        // Kısıtlamalar
        //
        // struct kullanırken dikkat etmeniz gereken bazı kısıtlamalar vardır:
        //     •	Varsayılan Yapıcı Yoktur: Bir struct içinde parametresiz bir yapıcı tanımlayamazsınız. Ancak C# 10 ile birlikte, struct’larda varsayılan değerler desteklenmiştir.
        //     •	Miras Alınamaz: struct başka bir sınıf veya yapıdan miras alamaz, ancak interface uygulayabilir.
        //     •	Boş Değerler: struct, değer tipi olduğu için null değeri alamaz. Ancak Nullable<T> ile kullanılabilir.
        //     •	Değiştirilemezlik: Değişken bir struct nesnesinin bir alanını değiştirmek, beklenmedik sorunlara neden olabilir.
    }
}