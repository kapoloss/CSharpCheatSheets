using System;

namespace ValueTypes
{
    public class RefStruct
    {
        // Nedir?
        //
        // •	ref struct, bir yapının yalnızca stack üzerinde depolanmasını zorunlu kılar.
        // •	Heap’te saklanamaz, bu da bellek tahsisini ve çöp toplayıcı (Garbage Collector) baskısını azaltır.
        // •	Yüksek performans gerektiren durumlarda kullanılır (örneğin, Span<T> yapısı).
        
        
        // Kısıtlamalar
        //
        // ref struct’lar bazı sınırlamalarla birlikte gelir:
        // 1.	Boxing yapılamaz: ref struct türleri, object veya interface’lere dönüştürülemez.
        // 2.	Heap’te saklanamaz:
        // •	Field (Alan): Bir sınıfın veya başka bir struct’ın alanı olamaz.
        // •	Closure: Lambda ifadeleri veya async metotlarda kullanılamaz.
        // 3.	readonly ile kullanımı: ref struct, immutable yapılara uygun hale getirilebilir.
        
        // Kullanım Alanları
        //
        // •	Yüksek performanslı veri işleme (örneğin, metin işleme, dizi manipülasyonu).
        // •	Span<T> ve ReadOnlySpan<T>: Bellek içi veri üzerinde dilimleme (slicing) işlemleri yapmak
        // için yaygın olarak kullanılır.
        
        //Struct Vs Ref Struct
        
        // •	Normal struct:
        // •	Bir struct nesnesi stack üzerinde depolanır ancak bir sınıfın alanı olarak tanımlanırsa veya bir
        // koleksiyonun parçası olarak kullanılırsa, bu durumda heap üzerinde depolanabilir.
        // •	Örneğin, bir sınıf (class) içindeki bir struct alanı heap’te tutulur.
        // •	ref struct:
        // •	ref struct, yalnızca stack üzerinde depolanabilir.
        // •	ref struct bir sınıfın alanı olamaz, bir List<T> gibi koleksiyonlara dahil edilemez veya heap’te
        // herhangi bir şekilde depolanamaz.
        // •	Bu, heap tahsisini zorlamak yerine her zaman stack kullanımını garantiler, dolayısıyla bellek
        // performansı artırılır.
    }
    
    public ref struct RefExample
    {
        public int Value;

        public RefExample(int value)
        {
            Value = value;
        }

        public void Increment()
        {
            Value++;
        }
    }

    class Program
    {
        public static void Main()
        {
            RefExample example = new RefExample(10);
            example.Increment();
            Console.WriteLine(example.Value); // 11
        }
    }
}