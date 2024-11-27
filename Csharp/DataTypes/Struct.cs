using System;

namespace ValueTypes
{
    public class Struct
    {
        // struct, değer tipi bir veri yapısıdır. Değer tipi, bellekte stack üzerinde depolanır.
        
        //     •	Değer tipleri, doğrudan veriyi taşır ve bir değişkenden diğerine kopyalandığında,
        // verinin kendisi kopyalanır (referansı değil).
        //     •	Bir struct, class gibi üyeler içerebilir: alanlar (fields), özellikler (properties),
        // yöntemler (methods), ve sabitler (constants).
        //     •	struct varsayılan olarak immutable (değiştirilemez) olmasa da,
        // genellikle immutable yapılara uygun şekilde tasarlanır.
        //     •	struct bir class değildir; bu nedenle bazı kısıtlamalar vardır.
    }
    
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}