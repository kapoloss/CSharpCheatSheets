using System;

namespace ValueTypes
{
    public class Enum
{
// 1.	Sabit Değerler: enum içindeki her bir değer sabittir ve program boyunca değiştirilemez.
// 2.	Varsayılan Tip: enum üyelerinin varsayılan tipi int’tir, ancak farklı bir temel tip belirtilebilir.
// 3.	Sayısal Değerler: Her enum üyesi bir tamsayı değere sahiptir (varsayılan olarak sıfırdan başlar ve sırayla artar).
// 4.	Temel Tipi Değiştirme: Varsayılan tamsayı tip yerine byte, sbyte, short, ushort, int, uint, long, veya ulong
// kullanılabilir.

    enum Days
    {
        Monday,    // 0
        Tuesday,   // 1
        Wednesday, // 2
        Thursday,  // 3
        Friday,    // 4
        Saturday,  // 5
        Sunday     // 6
    }
    
    enum Days2
    {
        Monday = 1,
        Tuesday,       // 2
        Wednesday = 5,
        Thursday,      // 6
        Friday = 10,
        Saturday,      // 11
        Sunday         // 12
    }
    
    enum Permissions : byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public void Access()
    {
        Days today = Days.Wednesday;
        Console.WriteLine(today);             // Wednesday
        Console.WriteLine((int)today);        // 2
    }
    
    [Flags]
    enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public void Access2()
    {
        // Kullanımı
        FileAccess access = FileAccess.Read | FileAccess.Write;
        Console.WriteLine(access);                 // Read, Write
        Console.WriteLine((int)access);            // 3
        Console.WriteLine(access.HasFlag(FileAccess.Write)); // True
    }
    
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    public void Access3()
    {
        foreach (Colors color in System.Enum.GetValues(typeof(Colors)))
        {
            Console.WriteLine($"Color: {color}");
        }
         // Çıktı:
         // Color: Red
         // Color: Green
         // Color: Blue
    }
    
    enum Severity
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public void Access4()
    {
        // Sayısal değeri Enum'a dönüştürmek
        int level = 2;
        Severity severity = (Severity)level;
        Console.WriteLine(severity); // Medium

// Enum'u sayısal değere dönüştürmek
        int numericValue = (int)Severity.High;
        Console.WriteLine(numericValue); // 3
    }

    

}
}