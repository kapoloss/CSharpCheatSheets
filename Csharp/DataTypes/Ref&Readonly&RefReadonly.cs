namespace ValueTypes
{
    public class Ref_Readonly_RefReadonly
    {
        // •	ref struct:
        // •	Stack üzerinde çalışır, heap’te bellek tahsisi yapmaz.
        // •	Yüksek performans sağlar.
        // •	readonly struct:
        // •	Immutable yapılar, veri tutarlılığını artırır.
        // •	Özellikle büyük yapılar için gereksiz kopyalamaları önler.
        // •	ref readonly:
        // •	Büyük yapıların kopyalanmasını engeller.
        // •	Veriyi yalnızca okunabilir hale getirir.
        
        
        
        // Özellik	                   ref struct	             readonly struct	         ref readonly
        // Bellek Konumu	           Sadece stack	             Stack veya heap	         Stack veya heap
        // Immutable	               Değil	                 Evet	                     Evet
        // Değiştirilebilirlik	       Değiştirilebilir	         Değiştirilemez	             Değiştirilemez
        // Lambda Desteği	           Desteklenmez	             Desteklenir	             Desteklenir
        // Performans	               Yüksek	                 Orta	                     Yüksek
    }
}