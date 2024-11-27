using System;

namespace ErrorHandling_Exceptions
{
    public class When
    {
        //C# 6.0 ile gelen when anahtar kelimesi, istisna filtreleri oluşturmak için kullanılır.
        //Bu filtreler, bir istisnanın yalnızca belirli koşullar altında yakalanmasını sağlar.

        public void Method()
        {
            try
            {
                int number = 10;
                int divisor = 0;

                int result = number / divisor; // DivideByZeroException
            }
            catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
            {
                Console.WriteLine("Sıfıra bölme hatası yakalandı.");
            }
        }
    }
}