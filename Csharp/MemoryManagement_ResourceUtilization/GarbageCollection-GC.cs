using System;

namespace MemoryManagement_ResourceUtilization
{
    public class GarbageCollection_GC
    {
        // Çöp Toplayıcı, .NET Framework’ün bellek yönetiminden sorumlu olan mekanizmadır.
        // Yönetilen kodda, bellek ayırma ve serbest bırakma işlemleri otomatik olarak gerçekleştirilir.
        // Ancak unmanaged kaynaklar (örneğin, dosya tanıtıcıları, pencere kolları) GC tarafından yönetilmez.
        //
        //     GC Nasıl Çalışır?
        //
        // 1.	Kullanılmayan Nesneleri Belirleme:
        
        // GC, bir nesneye erişimin olmadığını veya bu nesnenin yaşam döngüsünün sona erdiğini belirlediğinde,
        // o nesneyi serbest bırakır.
        
        // 2.	Belleği Geri Kazanma:
        
        // Çöp toplama işlemi sırasında, kullanılmayan nesnelerin belleği serbest bırakılır
        // ve tekrar kullanılabilir hale getirilir.
        
        // 3.	Nesnelerin Finalizer’ını Çağırma (Opsiyonel):
        
        // Eğer bir nesne bir finalizer tanımlamışsa (~ClassName()), GC bu finalizer’ı çağırarak nesne temizleme işlemini tamamlar.
        
        
        // GC’nin Nesne Yaşam Döngüsü (Generation Model):
        //
        // GC, nesneleri yaşam döngülerine göre 3 farklı nesil (generation) olarak sınıflandırır:
        // •	Generation 0: Yeni nesneler.
        // •	Generation 1: Kısa ömürlü nesnelerden hayatta kalanlar.
        // •	Generation 2: Uzun ömürlü nesneler (örneğin, statik veriler).
        //
        // Bu model, performansı artırır çünkü kısa ömürlü nesneler (Generation 0) daha sık temizlenirken,
        // uzun ömürlü nesneler daha az incelenir.
        
        ////////// GC.Collect()
        //
        //GC.Collect() yöntemi, çöp toplama işlemini manuel olarak başlatır.
        //Ancak, bu yöntem dikkatli kullanılmalıdır çünkü gereksiz çağrılar performansı olumsuz etkileyebilir.

        public void Method()
        {
            GC.Collect(); // Çöp toplama işlemini zorla başlatır.
        }
        
        // Ne Zaman Kullanılmalı?
        // •	Çok fazla unmanaged kaynağın kullanımda olduğu durumlarda.
        // •	Performansın kritik olduğu yerlerde, belleği kontrol altında tutmak için.
        
        // GC.SuppressFinalize()
        //
        // GC.SuppressFinalize() yöntemi, bir nesne için finalizer çağrısını devre dışı bırakır.
        // Bu, genellikle bir nesne zaten temizlendiyse ve finalizer’ın çağrılmasını istemiyorsak kullanılır.
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Yönetilen kaynakları temizle.
            }

            // Unmanaged kaynakları temizle.

            // Finalizer'ın çağrılmasını engelle.
            GC.SuppressFinalize(this);
        }
        
        // Neden Kullanılır?
        // •	Finalizer çağrılarının gereksiz performans yükünü azaltır.
        // •	Yönetilen kaynaklar temizlendiğinde, çöp toplayıcıya nesneyi atlamasını söyler.

    }
}