using System;


public class NullableReferenceTypes
{
    //C# dilinde Nullable Reference Types (NRT), referans türlerinin null olabilme
    //durumunu daha iyi kontrol etmeyi sağlayan bir özelliktir. Bu özellik sayesinde,
    //potansiyel null referans hataları daha derinlemesine analiz edilebilir ve kod güvenilirliği artırılabilir. 
    
    
    // ? Operatörü: Nullable Reference
    //
    // ? operatörü, bir referans türünün null olabileceğini belirtir. Bu, türü işaret ederek derleyiciye,
    // bu değişkenin null olma ihtimaline karşı dikkatli olunması gerektiğini söyler.

    public void Method()
    {
        string? nullableString = null;// null olabilen string

        // null kontrolü olmadan erişim hataya yol açabilir:
        Console.WriteLine(nullableString.Length); // Derleyici hata verir.

        // Güvenli kullanım:
        if (nullableString != null)
        {
            Console.WriteLine(nullableString.Length);
        }
    }

    // ! Operatörü: Null Forgiving
    //
    // ! operatörü, “null forgiving” olarak adlandırılır ve derleyiciye,
    // bir referansın kesinlikle null olmadığını bildirir.
    // Bu, genellikle nullable türlerle çalışırken null kontrolünün sizin tarafınızdan garanti edildiği durumlarda kullanılır.

    public void Method2()
    {
        string? nullableString = "GetNullableString()";

        if (nullableString != null)
        {
            // Derleyici uyarısını bastırmak için:
            Console.WriteLine(nullableString!.Length);
        }
    }
}