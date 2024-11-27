using System;

namespace ErrorHandling_Exceptions
{
    public class Built_inExceptions
    {
        //1. Temel İstisna Sınıfları
        
        //     İstisna Adı	                                Açıklama
        //     Exception	                           Tüm istisnaların temel sınıfıdır. Genel hatalar için kullanılabilir
        //                                             ancak spesifik türler tercih edilmelidir.
        
        //     SystemException	                       Sistem düzeyindeki hataların temel sınıfıdır.
        //                                             Uygulama tarafından türetilen hatalar için kullanılmaz.
        
        //     ApplicationException	                   Uygulama düzeyinde özel istisnalar için kullanılan temel sınıf.
        //                                             Ancak yeni projelerde nadiren kullanılır.
        
        
        // 2. Genel Kullanılan Hazır İstisnalar
        
        // a) Programlama Hatalarıyla İlgili İstisnalar
        
        
        //     İstisna Adı	                           Açıklama
        
        //     ArgumentException	                   Bir metoda geçersiz bir argüman gönderildiğinde fırlatılır.
        //     ArgumentNullException	               Bir metoda null bir argüman gönderildiğinde fırlatılır.
        //     ArgumentOutOfRangeException	           Argümanın izin verilen değer aralığında olmaması durumunda fırlatılır.
        //     InvalidOperationException	           Yöntem çağrısının mevcut nesne durumu için geçersiz olduğu durumlarda fırlatılır.
        //     NotSupportedException	               Belirli bir işlemin desteklenmediğini belirtmek için kullanılır.
        //     IndexOutOfRangeException	               Dizi ya da koleksiyonun geçersiz bir indeksine erişilmeye çalışıldığında fırlatılır.
        //     NullReferenceException	               Bir nesne referansı null olduğunda erişim yapılmaya çalışılırsa fırlatılır.
        //     DivideByZeroException	               Bir sayının sıfıra bölünmeye çalışılması durumunda fırlatılır.
        //     StackOverflowException	               Metotların birbirini sürekli çağırması sonucu bellek sınırının aşılması durumunda fırlatılır.
        //     FormatException	                       Verinin beklenmeyen bir formatta olması durumunda fırlatılır.
        
        
        //b) Kaynak Yönetimi ve IO ile İlgili İstisnalar
        
        //     İstisna Adı	                           Açıklama
        
        //     IOException	                           Giriş/Çıkış (IO) işlemleri sırasında meydana gelen genel hataları temsil eder.
        //     FileNotFoundException	               Belirtilen dosya bulunamadığında fırlatılır.
        //     DirectoryNotFoundException	           Belirtilen dizin bulunamadığında fırlatılır.
        //     UnauthorizedAccessException	           Bir dosya veya dizine erişim izni olmadığında fırlatılır.
        //     PathTooLongException	                   Bir dosya veya dizin yolunun maksimum uzunluğu aştığı durumlarda fırlatılır.
        //     EndOfStreamException	                   Akışın (stream) sonunda veri okunmaya çalışıldığında fırlatılır.
        
        
        //c) Koleksiyonlarla İlgili İstisnalar
        
        //     İstisna Adı	                           Açıklama
        //     KeyNotFoundException	                   Bir koleksiyonda belirtilen anahtar bulunamadığında fırlatılır (örneğin, Dictionary).
        //     InvalidCastException	                   Yanlış türde bir nesneye tür dönüştürme yapılmaya çalışıldığında fırlatılır.
        
        //d) Çoklu İş Parçacığı (Threading) ile İlgili İstisnalar 
        
        
        //     İstisna Adı	                           Açıklama
        //     ThreadAbortException	                   Bir iş parçacığı sonlandırılmaya çalışıldığında fırlatılır.
        //     SynchronizationLockException	           Bir Monitor kilidi (lock) olmayan bir nesne üzerinde çağrıldığında fırlatılır.
        //     TaskCanceledException	               İptal edilen bir görev (Task) için fırlatılır.
        
    }
}