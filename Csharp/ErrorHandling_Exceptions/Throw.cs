using System;

namespace ErrorHandling_Exceptions
{
    public class Throw
    {
        //throw, bir istisnayı fırlatmak için kullanılır.
        //İstisna fırlatıldığında, program akışı durur ve en yakın catch bloğuna geçer.

        public void Method()
        {
            try
            {
                throw new InvalidOperationException("Geçersiz işlem hatası oluştu!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
    
    //RETHROW
    
    //İstisnayı yeniden fırlatmak (rethrow), yakalanan bir istisnayı tekrar fırlatmak anlamına gelir.
    //Bu, genellikle istisnayı bir üst katmana veya başka bir hata işleme mekanizmasına iletmek için yapılır.
    //C#’ta bir istisna catch bloğu içinde yakalandığında,
    //throw anahtar kelimesi kullanılarak aynı istisna tekrar fırlatılabilir.
    
    //Neden Kullanılır?
    
    // 1.	İstisnanın Üst Katmana Taşınması:
    // Bir metotta yakalanan istisna, bu metodu çağıran üst katmana taşınabilir.
    // Bu, özellikle merkezi bir hata işleme mekanizması kullanıldığında faydalıdır.

    public class Sample
    {
        public void MethodA()
        {
            try
            {
                MethodB();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"MethodA'da hata: {ex.Message}");
                throw; // İstisnayı üst katmana taşır
                //throw ifadesi, yakalanan istisnayı yeniden fırlatarak, bu kez MethodA’yı çağıran kodun istisnayı almasını sağlar.
            }
        }

        public void MethodB()
        {
            throw new InvalidOperationException("Hata oluştu.");
        }
    }
    
    // 2.	İstisnanın Orijinal Durumunu Korumak:
    // throw; kullanımı, yakalanan istisnanın stack trace (çağrı yığını) bilgisini korur.
    // Bu, hata kaynağını daha iyi anlamak için önemlidir.
    // Yanlış Kullanım:

    // catch (Exception ex)
    // {
    //     throw ex; // Stack trace sıfırlanır!
    // }
    
    // catch (Exception)
    // {
    //     throw; // Orijinal stack trace korunur
    // }
    
    // 3.	Orijinal İstisnayı Detaylandırmak:
    // Bazı durumlarda, bir istisnayı yakalayıp yeniden fırlatmadan önce daha fazla bilgi eklemek isteyebilirsiniz.
    // Bu durumda, yeni bir istisna oluşturabilirsiniz, ancak orijinal istisnayı “inner exception” olarak saklamanız gerekir.
    
    public class Sample2
    {
        public void Method()
        {
            try
            {
                throw new ArgumentNullException("param");
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException("Bir hata meydana geldi.", ex);
            }
        }
    }
}