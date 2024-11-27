namespace ValueTypes;

public class RecordTypes
{
// 1.	Positional Record:
// •	Daha kısa ve okunabilir bir söz dizimi sunar. Özellikle DTO’larda yaygındır.

    record Person(string Name, int Age)
    {
        public string Name { get; } = Name;
        public int Age { get; } = Age;
    }

    //     2.	Custom Record:
//     •	record türü, normal bir class gibi tanımlanabilir ve özel üyeler eklenebilir.

    record Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}