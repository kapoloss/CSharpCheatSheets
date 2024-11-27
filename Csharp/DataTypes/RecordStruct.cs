
public class RecordStruct
{
    
    // •	record struct, değer türü (value type) olan bir structın, aynı zamanda record türlerinin
    // özelliklerini taşımasını sağlar.
    // •	Değer eşitliği (value equality) ile çalışır. Bu, iki record structın içerdiği değerler aynıysa,
    // bu iki nesne eşittir anlamına gelir.
    // •	Immutable (değiştirilemez) olma özelliğini varsayılan olarak destekler.
    // •	Stack üzerinde depolanır, bu da performans açısından avantaj sağlar, ancak fazla kopyalama gerektiren
    // durumlarda dikkat edilmesi gerekir.
}

record struct Pointt(int X, int Y);
public record struct Pointt2
{
    public int X { get; set; }
    public int Y { get; set; }

    public int Distance => X * X + Y * Y; // Ek bir özellik.
}

//Record Struct ile Record Class Arasındaki Farklar


// Özellik	                        Record Class	                              Record Struct
// Tür	                            Referans türü (Reference type).	              Değer türü (Value type).
// Depolama Alanı	                Heap üzerinde saklanır.	                      Stack üzerinde saklanır.
// Performans	                    Garbage Collector tarafından yönetilir.	      Daha hızlıdır, ancak kopyalama maliyeti olabilir.
// Eşitlik Türü	                    Değer eşitliği (Value equality).	          Değer eşitliği (Value equality).
// Varsayılan Davranış	            Immutable.	                                  Immutable.
// Kopyalama	                    with anahtar kelimesi ile.	                  with anahtar kelimesi ile.