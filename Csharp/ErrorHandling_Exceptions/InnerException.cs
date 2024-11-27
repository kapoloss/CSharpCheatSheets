using System;

namespace ErrorHandling_Exceptions
{
    public class InnerException
    {
        // •	Amaç:
        
        // •	Yeni bir istisna fırlatırken, bu istisnayı tetikleyen orijinal hatayı saklamak ve izlenebilirlik sağlamak.
        // •	Hata zincirinin debug edilmesine yardımcı olmak.
        
        // •	Kullanım Alanı:
        
        // •	Bir istisnayı yakalayıp başka bir özel istisna oluşturduğunuzda,
        // yakalanan orijinal istisnayı innerException olarak geçebilirsiniz.

        public void Method()
        {
            try
            {
                int number = int.Parse("not a number"); // Bu işlem FormatException fırlatır
            }
            catch (FormatException ex)
            {
                throw new CustomException("Bir hata meydana geldi.", ex);
            }
        }
    }
}