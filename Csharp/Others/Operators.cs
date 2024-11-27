using System;

namespace Others;

public class Operators
{
// 1. Aritmetik Operatörler
//
// Sayısal değerler üzerinde matematiksel işlemler yapmak için kullanılır.
//
// Operatör   Anlamı            Kullanım Örneği    Açıklama
// +          Toplama           a + b              İki sayıyı toplar.
// -          Çıkarma           a - b              İki sayı arasında fark alır.
// *          Çarpma            a * b              İki sayıyı çarpar.
// /          Bölme             a / b              İlk sayıyı ikinciye böler.
// %          Mod (Kalan)       a % b              Bölme işleminden kalanı döndürür.

// 2. Karşılaştırma Operatörleri
//
// İki değeri karşılaştırmak için kullanılır.
//
// Operatör   Anlamı             Kullanım Örneği    Açıklama
// ==         Eşit mi?          a == b             İki değerin eşit olup olmadığını kontrol eder.
// !=         Eşit değil mi?    a != b             İki değerin eşit olmadığını kontrol eder.
// >          Büyük mü?         a > b              İlk değerin ikinci değerden büyük olup olmadığını kontrol eder.
// <          Küçük mü?         a < b              İlk değerin ikinci değerden küçük olup olmadığını kontrol eder.
// >=         Büyük eşit mi?    a >= b             İlk değerin ikinci değerden büyük veya eşit olup olmadığını kontrol eder.
// <=         Küçük eşit mi?    a <= b             İlk değerin ikinci değerden küçük veya eşit olup olmadığını kontrol eder.

// 3. Mantıksal Operatörler
//
// Mantıksal işlemleri gerçekleştirmek için kullanılır.
//
// Operatör   Anlamı             Kullanım Örneği    Açıklama
// &&         Ve (AND)          a && b             Her iki koşul da doğruysa true döner.
// ||         Veya (OR)         a || b             Koşullardan biri doğruysa true döner.
// !          Değil (NOT)       !a                 Koşulun tersini döner (true -> false).

// 4. Atama Operatörleri
//
// Değerleri değişkenlere atamak için kullanılır.
//
// Operatör   Anlamı             Kullanım Örneği    Açıklama
// =          Atama             a = b              Sağdaki değeri soldaki değişkene atar.
// +=         Toplayarak atama  a += b             a = a + b işlemi yapar.
// -=         Çıkararak atama   a -= b             a = a - b işlemi yapar.
// *=         Çarparak atama    a *= b             a = a * b işlemi yapar.
// /=         Bölerek atama     a /= b             a = a / b işlemi yapar.
// %=         Mod alarak atama  a %= b             a = a % b işlemi yapar.

// 5. Bit Düzeyi Operatörleri
//
// Binary düzeyde işlemler yapmak için kullanılır.
//
// Operatör   Anlamı             Kullanım Örneği    Açıklama
// &          Ve (AND)          a & b              Bit düzeyinde AND işlemi yapar.
// |          Veya (OR)         a | b              Bit düzeyinde OR işlemi yapar.
// ^          XOR               a ^ b              Bit düzeyinde XOR işlemi yapar.
// ~          Değil (NOT)       ~a                 Bit düzeyinde NOT işlemi yapar.
// <<         Sola kaydırma     a << 2             Bitleri sola kaydırır.
// >>         Sağa kaydırma     a >> 2             Bitleri sağa kaydırır.

// 6. Diğer Operatörler
//
// Özel görevler için kullanılır.
//
// Operatör   Anlamı             Kullanım Örneği    Açıklama
// ?.         Null kontrolü     a?.b               Null değilse üyeye erişim sağlar.
// ??         Null birleşim     a ?? b             Null ise alternatif bir değer döner.
// is         Tür kontrolü      a is string        Değişken belirtilen türde mi diye kontrol eder.
// as         Tür dönüştürme    a as string        Tür dönüştürme işlemi yapar.

// typeof
//
// •	Amaç: Derleme zamanında bir türün Type nesnesini alır.
// •	Kullanım Alanı: Reflection (yansıma) kullanarak bir türün bilgisine erişmek için kullanılır.

    void Method7(){Type type = typeof(int);
    Console.WriteLine(type.FullName); // System.Int32
    }

    //  sizeof
    //
    // •	Amaç: Bir türün bellekte kapladığı alanı bayt (byte) cinsinden alır.
    // •	Kullanım Alanı: Özellikle unmanaged (yönetilmeyen) kodda ve performans kritikleri yapılırken kullanılır.
    // •	Kısıtlama: Yalnızca predefined value types (önceden tanımlı değer türleri) ile kullanılabilir.
    
    int size = sizeof(int); // 4
    
    // checked
    //
    // •	Amaç: Sayısal taşmaları (overflow) denetler. Sayısal işlemlerde taşma olursa bir hata (exception) fırlatır.
    // •	Kullanım Alanı: Kritik aritmetik işlemlerde, taşma durumlarının önemli olduğu yerlerde kullanılır.
    
    //int result = checked(2147483647 + 1); // OverflowException
    
    //  unchecked
    //
    // •	Amaç: Sayısal taşmaları (overflow) göz ardı eder ve hata fırlatılmasını engeller.
    // •	Kullanım Alanı: Taşmanın sorun teşkil etmediği yerlerde veya optimize kodlarda kullanılır.
    
    int result = unchecked(2147483647 + 1); // Negatif sonuç: -2147483648

}


 class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Operators Examples\n");

            // 1. Aritmetik Operatörler
            Console.WriteLine("1. Aritmetik Operatörler:");
            int a = 10, b = 3;
            Console.WriteLine($"Toplama (+): {a} + {b} = {a + b}");
            Console.WriteLine($"Çıkarma (-): {a} - {b} = {a - b}");
            Console.WriteLine($"Çarpma (*): {a} * {b} = {a * b}");
            Console.WriteLine($"Bölme (/): {a} / {b} = {a / b}");
            Console.WriteLine($"Mod (%): {a} % {b} = {a % b}\n");

            // 2. Karşılaştırma Operatörleri
            Console.WriteLine("2. Karşılaştırma Operatörleri:");
            Console.WriteLine($"Eşit mi (==): {a} == {b} => {a == b}");
            Console.WriteLine($"Eşit değil mi (!=): {a} != {b} => {a != b}");
            Console.WriteLine($"Büyük mü (>): {a} > {b} => {a > b}");
            Console.WriteLine($"Küçük mü (<): {a} < {b} => {a < b}");
            Console.WriteLine($"Büyük eşit mi (>=): {a} >= {b} => {a >= b}");
            Console.WriteLine($"Küçük eşit mi (<=): {a} <= {b} => {a <= b}\n");

            // 3. Mantıksal Operatörler
            Console.WriteLine("3. Mantıksal Operatörler:");
            bool x = true, y = false;
            Console.WriteLine($"Ve (&&): {x} && {y} => {x && y}");
            Console.WriteLine($"Veya (||): {x} || {y} => {x || y}");
            Console.WriteLine($"Değil (!): !{x} => {!x}\n");

            // 4. Atama Operatörleri
            Console.WriteLine("4. Atama Operatörleri:");
            int c = 5;
            Console.WriteLine($"Başlangıç değeri: c = {c}");
            c += 2; Console.WriteLine($"c += 2 => {c}");
            c -= 1; Console.WriteLine($"c -= 1 => {c}");
            c *= 3; Console.WriteLine($"c *= 3 => {c}");
            c /= 2; Console.WriteLine($"c /= 2 => {c}");
            c %= 3; Console.WriteLine($"c %= 3 => {c}\n");

            // 5. Birleştirme Operatörleri
            Console.WriteLine("5. Birleştirme Operatörleri:");
            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"Birleştirme (+): {str1} + {str2} => {str1 + " " + str2}\n");

            // 6. Artırma ve Azaltma Operatörleri
            Console.WriteLine("6. Artırma ve Azaltma Operatörleri:");
            int d = 5;
            Console.WriteLine($"Başlangıç değeri: d = {d}");
            Console.WriteLine($"Artırma (d++): {d++} => {d}");
            Console.WriteLine($"Azaltma (--d): {--d} => {d}\n");

            // 7. Bit Düzeyi Operatörler
            Console.WriteLine("7. Bit Düzeyi Operatörler:");
            int e = 5, f = 3; // Binary: 0101 & 0011
            Console.WriteLine($"Ve (&): {e} & {f} => {e & f}");
            Console.WriteLine($"Veya (|): {e} | {f} => {e | f}");
            Console.WriteLine($"XOR (^): {e} ^ {f} => {e ^ f}");
            Console.WriteLine($"NOT (~): ~{e} => {~e}");
            Console.WriteLine($"Sola Kaydırma (<<): {e} << 1 => {e << 1}");
            Console.WriteLine($"Sağa Kaydırma (>>): {e} >> 1 => {e >> 1}\n");

            // 8. Üyelik ve Erişim Operatörleri
            Console.WriteLine("8. Üyelik ve Erişim Operatörleri:");
            string[] arr = { "Apple", "Banana", "Cherry" };
            Console.WriteLine($"Dizinin 1. elemanı: arr[0] => {arr[0]}\n");

            // 9. Diğer Operatörler
            Console.WriteLine("9. Diğer Operatörler:");
            object obj = "Hello";
            Console.WriteLine($"Tür kontrolü (is): obj is string => {obj is string}");
            Console.WriteLine($"Tür dönüştürme (as): obj as string => {(obj as string)}");
            Console.WriteLine($"Null birleşim (??): obj ?? \"Default\" => {obj ?? "Default"}");
        }
    }