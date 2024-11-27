using System;

namespace ErrorHandling_Exceptions
{
    public class TryCatchFinally
    {
        //Hata yönetimi, bir uygulamanın beklenmedik durumlarla karşılaşması halinde sağlıklı
        //bir şekilde çalışmaya devam etmesini sağlamak için kullanılan bir yöntemdir.
        //İstisna (exception) ise bu tür beklenmedik durumları temsil eder ve
        //programın normal akışını bozan hataları yakalamak için kullanılır.
        
        
        
        // try
        //
        //     try bloğu, hata oluşma ihtimali olan kodun çalıştırıldığı bölümdür.
        //     Bu blok içerisinde hata meydana gelirse kontrol, uygun bir catch bloğuna geçer.
        //
        // catch
        //
        //     catch bloğu, try bloğunda oluşan hatayı yakalar ve ele alır.
        //     Yakalanan hatanın türüne göre işlemler yapılabilir.
        //
        //finally
        //
        //     finally bloğu, hata oluşup oluşmamasına bakılmaksızın her zaman çalıştırılır.
        //     Genellikle kaynakları serbest bırakmak veya cleanup işlemleri yapmak için kullanılır.
    }
    
    try
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine(numbers[5]); // IndexOutOfRangeException fırlatır
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Hata: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("İşlem tamamlandı.");
    }
}