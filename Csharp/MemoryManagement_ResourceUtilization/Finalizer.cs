using System;
using System.Runtime.InteropServices;

namespace MemoryManagement_ResourceUtilization
{
    public class Finalizer
    {
        // Finalizer (Destructor) Nedir ve Ne Yapar?
        //
        // Finalizer, bir sınıfın örneği çöp toplayıcı (Garbage Collector - GC)
        // tarafından bellekten kaldırılmadan önce çağrılan bir metottur.
        // Finalizer, unmanaged kaynakları serbest bırakmak veya özel temizlik işlemleri yapmak için kullanılabilir.
        // Ancak, finalizer manuel olarak çağrılmaz, çöp toplayıcı tarafından nesne yok edilmeden hemen önce çağrılır.
        //
        // C#’da finalizer, ~ClassName() şeklinde tanımlanır ve yalnızca unmanaged kaynakların temizlenmesi
        // gerektiğinde kullanılır.
        
        
        // Finalizer’ın Görevi
        //
        // 1.	Unmanaged Kaynakları Temizlemek:
        // •	Çöp toplayıcı, yönetilen kaynakları (örneğin, string, List<T>) otomatik olarak temizler.
        // Ancak, unmanaged kaynaklar (örneğin, dosya tanıtıcıları, ağ bağlantıları, native bellek) için finalizer kullanılabilir.
        
        // 2.	Yedek Temizlik Mekanizması Sağlamak:
        // •	Eğer Dispose() gibi manuel temizlik yöntemleri kullanılmazsa, finalizer unmanaged kaynakları
        
        // serbest bırakmayı garanti eder.
        // 3.	Deterministik Olmayan Temizlik:
        // •	Finalizer, ne zaman çağrılacağına dair kesin bir zaman garantisi vermez.
        // Çöp toplayıcının ne zaman çalışacağına bağlıdır.
    }
    
    public class UnmanagedResource
    {
        private IntPtr resource;

        public UnmanagedResource()
        {
            // Unmanaged bellek ayırma
            resource = Marshal.AllocHGlobal(100); // 100 baytlık bellek ayır
            Console.WriteLine("Unmanaged resource allocated.");
        }

        ~UnmanagedResource()
        {
            // Finalizer: Unmanaged kaynakları temizle
            if (resource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(resource); // Belleği serbest bırak
                resource = IntPtr.Zero;
                Console.WriteLine("Unmanaged resource cleaned up by finalizer.");
            }
        }
    }

// Kullanım
    void Main()
    {
        var obj = new UnmanagedResource();
        obj = null; // Nesne erişilemez hale geliyor

        // Zorla çöp toplama (sadece test için)
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}