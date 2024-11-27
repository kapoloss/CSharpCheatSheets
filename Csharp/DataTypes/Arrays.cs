using System;

public class Arrays
{
// 1.	Sabit Boyut: Array’in boyutu tanımlandıktan sonra değiştirilemez.
// 2.	Tip Güvenliği: Array yalnızca belirli bir veri türündeki elemanları tutabilir.
// 3.	Sıralı Saklama: Elemanlar bellek üzerinde sıralı olarak saklanır.


//      Array’in Tanımlanması

    public void Method()
    {
        //Statik Tanımlama
        int[] numbers = new int[5]; // 5 elemanlı bir int array oluşturur.
        
        //Dinamik Tanımlama
        int[] numbers2 = { 1, 2, 3, 4, 5 }; // Doğrudan değerler atanarak array oluşturulur.
        
        //Çok Boyutlu Array
        int[,] matrix = new int[3, 3]; // 3x3 boyutunda iki boyutlu bir array.
        
        //Jagged Array (Düzensiz Diziler)
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6 };
        
        
        
        //Array Özellikleri ve Metotları
        
        //	•	Length: Array’in toplam eleman sayısını döner.
        int[] numbers3 = { 1, 2, 3, 4 };
        Console.WriteLine(numbers.Length); // 4
        
        
        //	•	Rank: Array’in boyut sayısını döner.
        int[,] matrixx = new int[3, 3];
        Console.WriteLine(matrixx.Rank); // 2
        
        //	•	Sort: Array elemanlarını sıralar.
        int[] numbers4 = { 3, 1, 4, 2 };
        Array.Sort(numbers); // numbers = {1, 2, 3, 4}
        
        
        //	•	Reverse: Array elemanlarını ters çevirir.
        int[] numbers5 = { 1, 2, 3, 4 };
        Array.Reverse(numbers); // numbers = {4, 3, 2, 1}
        
        
        //	•	IndexOf: Belirli bir elemanın indeksini döner.
        int[] numbers6 = { 1, 2, 3, 4 };
        int index = Array.IndexOf(numbers, 3); // index = 2
        
        
        //	•	Clear: Array’in elemanlarını sıfırlar.
        int[] numbers7 = { 1, 2, 3, 4 };
        Array.Clear(numbers, 0, 2); // İlk 2 elemanı sıfırla
    }


    //Array ve List Farkı
    
    
    // Özellik	                   Array	             List
    // Boyut	                   Sabit	             Dinamik
    // Tip Güvenliği	           Var	                 Var
    // Performans	               Daha hızlı	         Daha esnek
    // Ek Özellikler	           Sınırlı	             Çok fazla metot ve özellik
}
