using System;
using System.IO;

namespace MemoryManagement_ResourceUtilization
{
    public class IDisposable_
    {
        //IDisposable, bir nesneyle ilişkili unmanaged kaynakları temizlemek için kullanılan bir arayüzdür.
        //Bu arayüz, bellek dışında diğer kaynakların (örneğin, dosyalar, ağ bağlantıları, grafik nesneleri gibi)
        //serbest bırakılmasını sağlar.
        
        //	•	Dispose() yöntemi, unmanaged kaynakları serbest bırakmak için kullanılan bir mekanizma sağlar.
        //  •	IDisposable’ı uygulayan sınıflar, unmanaged kaynaklarını manuel olarak temizlemek için bu yöntemi kullanır.
    }
    

    class Example : IDisposable
    {
        private StreamWriter writer;

        public Example(string filePath)
        {
            writer = new StreamWriter(filePath);
        }

        public void Write(string message)
        {
            writer.WriteLine(message);
        }

        public void Dispose()
        {
            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }
        }
        
        public void Method()
        {
            // Kullanım
            using (var example = new Example("output.txt"))
            {
                example.Write("Hello, world!");
            }
            
            // Bu kodda:
            //     •	Dispose() metodu unmanaged kaynakları temizler.
            //     •	using bloğu, nesne kapsamdan çıktığında otomatik olarak Dispose() yöntemini çağırır.
        }
    }
    
    
}