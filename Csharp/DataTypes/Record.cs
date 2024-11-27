
public class Record
{
//     •	record, C# 9.0 ile tanıtılmıştır ve C# 10.0 ile daha fazla yetenek kazanmıştır.
//     •	class ve struct gibi bir türdür, ancak asıl amacı veriyi temsil etmektir.
//     •	Immutable özelliklere sahiptir, yani bir kez oluşturulduktan sonra nesne üzerinde
// değişiklik yapılamaz (ancak mutable kullanılabilir).
//     •	Değer eşitliği (value equality) temellidir; bu, iki nesnenin aynı verilere sahip
// olması durumunda eşit kabul edilmesi anlamına gelir.

    // Avantajları
    //
    // •	Kısalık ve okunabilirlik: Özellikle Positional Recordlar, kodun daha temiz ve kısa olmasını sağlar.
    // •	Değer eşitliği: Karmaşık eşitlik kontrolleri yazmanıza gerek kalmaz.
    // •	Immutable yapı: Verilerin değiştirilemez olması güvenliği artırır.
    // •	Kopyalama kolaylığı: with anahtar kelimesi ile değişiklik yapmak zahmetsizdir.
    // •	Gelişmiş ToString: Hızlı hata ayıklama ve daha iyi loglama sağlar.
}