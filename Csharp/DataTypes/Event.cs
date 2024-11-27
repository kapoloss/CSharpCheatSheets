using System;

namespace Delegates_Events
{
    public class Event
    {
        //event, bir sınıfın, olay (event) meydana geldiğinde dış dünyaya bildirim göndermesine
        //olanak tanıyan bir özellik olarak kullanılır.
        //Genelde olay odaklı programlamada (event-driven programming) çok sık kullanılır
        //ve özellikle kullanıcı etkileşimi veya belirli bir durumun meydana gelmesi üzerine çalışır.
    }
    
    public class MyEventPublisher
    {
        // 1. Adım: Event için bir delegate tanımlıyoruz.
        public delegate void MyEventHandler(string message);

        // 2. Adım: Event'i tanımlıyoruz.
        public event MyEventHandler MyEvent;

        // 3. Adım: Event'i tetikleyen bir metod oluşturuyoruz.
        public void TriggerEvent(string message)
        {
            if (MyEvent != null) // Event'e abone olan herhangi bir metod varsa
            {
                MyEvent(message); // Event'i tetikleyerek tüm abonelere mesajı iletiriz.
            }
        }
    }
    
    public class MyEventSubscriber
    {
        public void OnMyEventOccurred(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }

    public class Program
    {
        public static void Main()
        {
            MyEventPublisher publisher = new MyEventPublisher();
            MyEventSubscriber subscriber = new MyEventSubscriber();

            // Event'e abone oluyoruz.
            publisher.MyEvent += subscriber.OnMyEventOccurred;

            // Event'i tetikliyoruz.
            publisher.TriggerEvent("Hello World!");
        
            // Çıktı: Event received: Hello World!
        }
    }
}