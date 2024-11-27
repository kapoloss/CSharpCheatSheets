using System;


public class DynamicTypes
{
    // Dynamic Tip Nedir?
    //
    //     C# dilinde, dynamic anahtar kelimesi, derleme zamanında tür kontrolü yapılmayan ve
    // türü çalışma zamanında belirlenen bir türü temsil eder.
    // Bu, C# dilinde tip güvenliğinin geçici olarak devre dışı bırakılmasını sağlar.
    
    // •	dynamic ile bildirilen bir değişken, herhangi bir türde veri tutabilir.
    // •	Ancak, bu türle ilgili tüm işlemler çalışma zamanında kontrol edilir.
    // Eğer işlem, çalışma zamanında geçerli değilse, bir RuntimeBinderException hatası fırlatılır.
    
    
    // Dynamic Tipin Kullanım Alanları
    //
    // 1.	COM Nesneleri ile Çalışma:
    // •	dynamic, özellikle Office uygulamalarına veya diğer COM bileşenlerine erişim sağlamak için kullanılır.
    // Bu tür nesneler genellikle derleme zamanında tür bilgisi sağlamaz.
    // 2.	Reflection (Yansıma):
    //     •	Derleme zamanında türü bilinmeyen objeler üzerinde çalışma zamanında işlemler yapmak için kullanılır.
    // 3.	Zayıf Türlü API’lerle Çalışma:
    // •	JSON, XML veya diğer dinamik veri yapılarından gelen verilere erişim için faydalıdır.
    // 4.	Esnek Kod Yazımı:
    // •	Dinamik bir yapı oluştururken veya tür güvenliğinin kritik olmadığı yerlerde daha esnek kod yazmak için
    // kullanılabilir.
    
    
    // Dynamic Anahtar Kelimesinin Özellikleri
    //
    // 1.	Tür Denetimi Çalışma Zamanında Yapılır:
    // •	dynamic değişkenlerle yapılan tüm işlemler çalışma zamanında kontrol edilir. Örneğin:

    public void Method()
    {
        dynamic dyn = 5;
        Console.WriteLine(dyn + 10); // Çalışma zamanında "15" sonucunu üretir.
        dyn = "Hello";
        Console.WriteLine(dyn.Length); // Çalışma zamanında geçerli bir işlem.
    }
    
    // 2.	Tür Dönüşümü Gerekmez:
    // •	Tür dönüşümüne gerek kalmadan herhangi bir türe atanabilir:

    public void Method2()
    {
        dynamic dyn = 42;
        int number = dyn; // Geçerli
    }
    
    // 3.	Tür Belirsizliğinde Esneklik:
    // •	Derleme zamanında tür bilgisi olmayan nesnelerle çalışırken hata almadan kod yazabilirsiniz:

    public void Method3()
    {
        dynamic obj = GetUnknownObject(); // Türü çalışma zamanında belirlenecek.
        obj.DoSomething(); // Derleyici hata vermez.
    }

    private dynamic GetUnknownObject()
    {
        throw new NotImplementedException();
    }
    
    // 4.	Tür Güvenliğinin Dezavantajları:
    // •	Yanlış işlem yapıldığında çalışma zamanı hatalarına neden olabilir:

    public void Method4()
    {
        dynamic dyn = "Hello";
        Console.WriteLine(dyn + 5); // Çalışma zamanında hata fırlatır.
    }
    
    
    // dynamic ile object Arasındaki Fark
    //
    // •	object:
    // •	Derleme zamanında her tür kabul edilir ancak, türler arasında dönüşüm yapılırken açık bir tür dönüşümü gerektirir.
    // •	Türü kontrol etmek için is, as gibi işlemler kullanılır.
    
    // •	dynamic:
    // •	Tür dönüşümüne gerek olmadan farklı türlere atanabilir.
    // •	Tür kontrolleri çalışma zamanında yapılır.

    public void Method5()
    {
        object obj = 10;
        int number = (int)obj; // Tür dönüşümü gerekli.
        
        dynamic dyn = 10;
        int number2 = dyn; // Tür dönüşümü gerekmez.
    }
}