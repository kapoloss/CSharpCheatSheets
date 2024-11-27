namespace MemoryManagement_ResourceUtilization
{
    public class Using
    {
        //using bloğu, IDisposable arayüzünü uygulayan nesneler için kaynak yönetimini otomatikleştirir.
        //Bu blok, nesne yaşam döngüsünü sınırlayarak kaynağın garanti edilen bir noktada serbest bırakılmasını sağlar.

        public void Method()
        {
            using (var resource = new Example("output.txt"))
            {
                resource.Write("Some data");
            }
            // resource.Dispose() otomatik olarak çağrılır.
        }
        
        // •	Kaynakları manuel olarak serbest bırakma gereksinimini ortadan kaldırır.
        // •	Daha temiz ve güvenilir bir kod sağlar.
        // •	Hata durumlarında bile kaynaklar serbest bırakılır.
    }
}