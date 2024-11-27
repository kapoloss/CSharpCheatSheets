namespace Others
{
    public class StaticClass
    {
        // Bir sınıf static olarak tanımlanabilir. Bu durumda:
        // •	Sınıf yalnızca static üyeler içerebilir.
        // •	Örneklenemez.
        // •	Çoğunlukla yardımcı (utility/helper) sınıflar için kullanılır.
    }
    
    public static class MathHelper
    {
        public static double Pi = 3.14159;

        public static double Square(double number)
        {
            return number * number;
        }
    }

// Kullanım

internal class Program
    {
        public static void Main(string[] args)
        {
            double result = MathHelper.Square(5);
        }
    }
}