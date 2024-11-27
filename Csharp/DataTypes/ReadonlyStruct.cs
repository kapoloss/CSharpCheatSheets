using System;

namespace ValueTypes
{
    public class ReadonlyStruct
    {
        // •	readonly struct, yapının tüm üyelerinin immutable (değiştirilemez) olduğunu belirtir.
        // •	Değer türlerinin güvenli bir şekilde paylaşılması ve yanlışlıkla
        // değiştirilmesinin engellenmesi için kullanılır.
        
        // Özellikler
        //
        // •	Alanlar: Tüm alanlar otomatik olarak readonly kabul edilir.
        // •	Performans: Gereksiz kopyalamaları ve değişiklikleri engeller, bu da bellek yönetimini optimize eder.
        // •	Immutable Tasarım: Veri tutarlılığı sağlar.
        
        // Kısıtlamalar
        //
        // •	readonly struct içerisindeki tüm alanlar varsayılan olarak readonly olmalıdır.
        // •	readonly bir yapıda, değişkenlerin yalnızca bir constructor içinde atanması gerekir.
    }
    
    public readonly struct Point2
    {
        public int X { get; }
        public int Y { get; }

        public Point2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceToOrigin() => Math.Sqrt(X * X + Y * Y);
    }
    
    // ref readonly
    //
    // 1. Nedir?
    //
    //     •	Bir değere başvuruyu (ref) sağlar, ancak değerin değiştirilmesini engeller.
    //     •	Özellikle büyük yapıların (örneğin, struct) kopyalanmasını önler, aynı zamanda güvenli
    // bir şekilde erişim sağlar.
    
    

    public readonly struct LargeStruct
    {
        public int A { get; }
        public int B { get; }

        public LargeStruct(int a, int b)
        {
            A = a;
            B = b;
        }
    }

    class Program2
    {
        private static LargeStruct example = new LargeStruct(a: 10, b: 20);

        static ref readonly LargeStruct GetStruct()
        {
            return ref example;
        }

        public static void Main()
        {
            ref readonly LargeStruct large = ref GetStruct();
            Console.WriteLine($"A: {large.A}, B: {large.B}");
        }
    }
}