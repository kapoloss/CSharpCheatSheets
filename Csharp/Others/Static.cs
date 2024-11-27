namespace Others
{
    public class Static
    {
        //C# dilinde static anahtar kelimesi, bir sınıfın veya üyenin (metot, değişken, özellik, olay vb.)
        //sınıf seviyesinde tanımlanmasını sağlar.
        //Bu, static olarak işaretlenmiş bir üyenin veya sınıfın,
        //örnek oluşturulmasına gerek kalmadan doğrudan sınıf adı üzerinden erişilebileceği anlamına gelir.
        
        // 1.	Instance Gerektirmez:
        // static üyeler, sınıfın herhangi bir örneği oluşturulmadan doğrudan sınıf adı üzerinden çağrılır.
        
        // 2.	Tüm Örneklerle Paylaşılır:
        // static üyeler sınıf düzeyinde tanımlanır ve tüm örnekler tarafından paylaşılır.
        // Bir değişiklik tüm erişimlere yansır.
        
        // 3.	Sadece Static Erişim:
        // static üyeler yalnızca diğer static üyelere doğrudan erişebilir.
        // Örnek üyelere erişim için bir örnek referansı gerekir.
        
        // 4.	Static Constructor:
        // static bir sınıfta veya static üyeler içeren bir sınıfta bir static constructor tanımlanabilir.
        // Bu constructor sınıf ilk kez erişildiğinde çağrılır.
        
        
        //Static ve Non-Static Karşılaştırması:
        
        // Özellik	                    Static	                                     Non-Static
        // Erişim	                    Sınıf adı üzerinden	                         Sınıf örneği üzerinden
        // Bellek Yönetimi	            Tüm uygulama süresi boyunca var olur         Sınıf örneği ile oluşturulup yok edilir
        // Bağımlılık	                Sınıfın örneği gereksizdir	                 Sınıfın örneği gereklidir
        // Kapsam	                    Sınıf düzeyi	                             Örnek düzeyi
    }
}