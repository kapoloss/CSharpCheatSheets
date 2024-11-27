using System;

namespace Delegates_Events
{
    public class MulticastDelegates
    {
        //Bir delegat, birden fazla yönteme işaret edebilir. Bu yöntemler sırayla çağrılır.
        
        public delegate void Notify();

        public void Alert1()
        {
            Console.WriteLine("Alert 1");
        }

        public void Alert2()
        {
            Console.WriteLine("Alert 2");
        }

// Assign multiple methods
        public void Client()
        {
            Notify notify = Alert1;
            notify += Alert2;
            notify(); // Output: Alert 1 \n Alert 2
        }
    }
}