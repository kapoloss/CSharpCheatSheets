using System;

namespace ErrorHandling_Exceptions
{
    public class CustomExceptions
    {
        // Bazı durumlarda, standart istisnalar yeterli olmayabilir.
        // Bu gibi durumlarda kendi özel istisna sınıflarınızı tanımlayabilirsiniz.
        //
        // Özel İstisna Tanımlamaları
        //
        // Kendi istisna sınıfınızı tanımlamak için System.Exception sınıfından türeyen bir sınıf oluşturmanız gerekir.
    }
    
    public class CustomException : Exception
    {
        public CustomException() : base() { }

        public CustomException(string message) : base(message) { }

        public CustomException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}