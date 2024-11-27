using System;
using System.Runtime.InteropServices;

namespace MemoryManagement_ResourceUtilization
{
    public class UnmanagedResources
    {
        //Unmanaged kaynaklar, .NET Runtime’ın (CLR - Common Language Runtime) çöp toplayıcısı
        //(Garbage Collector - GC) tarafından otomatik olarak yönetilmeyen kaynaklardır.
        //Bu kaynaklar genellikle işletim sistemi veya dış bir API tarafından sağlanır ve
        //uygulama geliştiricisinin bu kaynakları manuel olarak serbest bırakması gerekir.
        
        
        // Neden Unmanaged Kaynaklar Özel İşlem Gerektirir?
        //
        // 1.	Çöp Toplayıcının Kontrolü Dışında Olmaları:
        // Çöp toplayıcı yalnızca yönetilen belleği izler ve temizler. Ancak unmanaged kaynaklar çöp toplayıcının
        // radarında değildir. Bu nedenle, geliştirici bu kaynakları manuel olarak serbest bırakmak zorundadır.
        
        // 2.	Kaynak Sızıntısı Riski:
        // Unmanaged kaynaklar serbest bırakılmazsa sistem kaynaklarında tükenme veya kilitlenme gibi ciddi
        // sorunlar yaşanabilir.
        
        
        // Unmanaged Kaynakları Manuel Olarak Yönetme
        //
        //     Eğer bir sınıf unmanaged kaynak kullanıyorsa, şu yöntemleri kullanarak kaynak yönetimi sağlamalısınız:
        
        // 1.	Dispose Metodu:
        // Kaynağı manuel olarak serbest bırakmak için.
        
        // 2.	Finalize (Destructor):
        //     Çöp toplama sırasında kaynakları serbest bırakmak için yedek bir yöntem.

    }
    
    public class UnmanagedResourceHandler : IDisposable
    {
        private IntPtr unmanagedPointer; // Unmanaged bellek kaynağı
        private bool disposed = false;

        public UnmanagedResourceHandler()
        {
            // Unmanaged bellek ayırma
            unmanagedPointer = Marshal.AllocHGlobal(100); // 100 baytlık bellek ayır
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Finalizer'ı devre dışı bırak
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Yönetilen kaynakları temizle (eğer varsa).
                }

                // Unmanaged kaynakları serbest bırak
                if (unmanagedPointer != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(unmanagedPointer);
                    unmanagedPointer = IntPtr.Zero;
                }

                disposed = true;
            }
        }

        ~UnmanagedResourceHandler()
        {
            Dispose(false); // Finalizer'da yalnızca unmanaged kaynakları temizle
        }
    }
}