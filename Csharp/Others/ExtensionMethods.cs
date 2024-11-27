using System;
using System.Collections.Generic;
using System.Linq;

namespace Others;

public class ExtensionMethods
{
    //Extension metotlar, var olan sınıflara ya da yapılara yeni işlevler eklemenizi sağlayan bir C# özelliğidir.
    //Önemli olan, bu işlemi mevcut sınıfın kaynağını değiştirmeden, yeni bir sınıf yazıp o sınıf üzerinden yapmanızdır.
    //Extension metotlar, sınıfları genişletmenin esnek bir yoludur
    //ve özellikle System.String, IEnumerable<T>, DateTime gibi sıklıkla kullanılan sınıfları genişletmek için kullanılır.
    
    // Extension metotları yazarken aşağıdaki kurallar ve detaylar önemlidir:
    // 1.	Statik Sınıf Gerekliliği:
    // •	Extension metotlar sadece statik bir sınıfın içinde tanımlanabilir.
    // 2.	Metot İmzasında this:
    // •	Metot imzasında ilk parametre olarak this anahtar kelimesini kullanırsınız.
    // Bu, hangi sınıfın ya da yapının genişletileceğini belirtir.
    // 3.	Var Olan Sınıfın Bir Parçası Gibi Çalışır:
    // •	Extension metot, genişletilen sınıfın bir parçasıymış gibi çağrılabilir.
    // •	Örneğin, bir string türüne eklediğiniz bir metot doğrudan str.MyExtensionMethod() şeklinde çağrılır.

    public void Method()
    {
        string mySentence = "hello world!";
        string result = mySentence.ToTitleCase(); // Çıktı: "Hello World!"
    }
}

public static class StringExtensions
{
    public static string ToTitleCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return string.Join(" ", input.Split(' ')
            .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
    }
}

// 1.	Statik Sınıf Gerekliliği:
// Extension metotlar her zaman bir statik sınıfta tanımlanmalıdır. Bu, derleyicinin metodu bağlamasını kolaylaştırır.
// 2.	this Parametresi:
// •	this anahtar kelimesi, genişletilen nesneyi temsil eder.

public static class IntExtension
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}

public class Example4
{
    public void Method()
    {
        int value = 4;
        bool result = value.IsEven(); // Çıktı: true
    }
}

//Generic extension

public static class CollectionExtensions
{
    public static T FindFirst<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.FirstOrDefault(predicate);
    }
}


