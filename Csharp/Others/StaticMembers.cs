using System;

namespace Others
{
    public class StaticMembers
    {
    }
    
    // 1. Static Fields (Alanlar):
    //
    // •	Tüm örnekler arasında paylaşılan, sınıfa özgü değişkenlerdir.
    // •	Örnek oluşturulmadan sınıf adı üzerinden erişilir.
    
    public class Counter
    {
        public static int TotalCount = 0;

        public void Increment()
        {
            TotalCount++;
        }
    }

// Kullanım

internal class Program5
    {
        public static void Main(string[] args)
        {
            Counter.TotalCount = 10;
        }
    }

    // 2. Static Properties (Özellikler):
    //
    //     •	static alanlar için getter ve setter metodları sağlar.2. Static Properties (Özellikler):
    //
    //     •	static alanlar için getter ve setter metodları sağlar.
    
    public class Configuration
    {
        private static string _appName;

        public static string AppName
        {
            get { return _appName; }
            set { _appName = value; }
        }
    }

// Kullanım

internal class Program6
    {
        public static void Main(string[] args)
        {
            Configuration.AppName = "My Application";
        }
    }


    // 3. Static Methods (Metotlar):
    //
    //     •	Sınıf örneğine ihtiyaç duymadan çağrılabilir.
    //     •	Çoğunlukla genel işlemler için kullanılır.
    
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

// Kullanım

internal class Program3
    {
        public static void Main(string[] args)
        {
            int sum = Calculator.Add(3, 5);
        }
    }


    // 4. Static Events (Olaylar):
    //
    //     •	Sınıf düzeyinde olayları tanımlamak için kullanılır.
    
    public class Alarm
    {
        public static event Action OnAlarmTriggered;

        public static void TriggerAlarm()
        {
            OnAlarmTriggered?.Invoke();
        }
    }

// Kullanım

internal class Program4
    {
        public static void Main(string[] args)
        {
            Alarm.OnAlarmTriggered += () => Console.WriteLine("Alarm Triggered!");
            Alarm.TriggerAlarm();
        }
    }
}