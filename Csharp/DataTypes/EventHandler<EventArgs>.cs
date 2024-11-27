using System;

namespace Delegates_Events
{
    public class EventHandler_EventArgs_
    {
        //C#’da eventlerde genelde EventHandler delegate’i kullanılır.
        //Bu delegate, bir event tetiklendiğinde çağrılacak metodların object sender,
        //EventArgs e imzasını almasını gerektirir.
    }
    
    //     •	TransactionOccurred adlı bir event tanımladık. Bu event, EventHandler<TransactionEventArgs> türünde olup,
    // TransactionEventArgs türünde veri gönderir.
    //     •	Deposit ve Withdraw metodları, işlemi gerçekleştirir ve ardından
    // TransactionOccurred event’ini tetikleyerek abone olanlara işlem bilgisini gönderir.
    //     •	OnTransactionOccurred metodunda ?.Invoke ile event’i çağırarak, event’e abone olan metodları tetikleriz.

    
    public class TransactionEventArgs : EventArgs
    {
        public string TransactionType { get; }
        public decimal Amount { get; }

        public TransactionEventArgs(string transactionType, decimal amount)
        {
            TransactionType = transactionType;
            Amount = amount;
        }
    }
    
    public class ATM
    {
        public event EventHandler<TransactionEventArgs> TransactionOccurred;

        private decimal balance;

        public ATM(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");

            // Event'i tetikleyerek abone olanlara bilgi gönderiyoruz.
            OnTransactionOccurred("Deposit", amount);
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {balance:C}");

                // Event'i tetikleyerek abone olanlara bilgi gönderiyoruz.
                OnTransactionOccurred("Withdraw", amount);
            }
        }

        protected virtual void OnTransactionOccurred(string transactionType, decimal amount)
        {
            // Event tetikleme işlemi (eğer abone varsa)
            TransactionOccurred?.Invoke(this, new TransactionEventArgs(transactionType, amount));
        }
    }
    
    public class TransactionLogger
    {
        public void OnTransactionOccurred(object sender, TransactionEventArgs e)
        {
            Console.WriteLine($"Transaction Occurred: {e.TransactionType} of {e.Amount:C}");
        }
    }
    
    public class Programm
    {
        public static void Main()
        {
            // ATM ve Logger oluşturuyoruz
            ATM atm = new ATM(500);
            TransactionLogger logger = new TransactionLogger();

            // Logger'ın OnTransactionOccurred metodunu ATM'in event'ine bağlıyoruz.
            atm.TransactionOccurred += logger.OnTransactionOccurred;

            // İşlemler gerçekleştiriliyor
            atm.Deposit(150);
            atm.Withdraw(100);
            atm.Withdraw(600);  // Yetersiz bakiye durumunu kontrol etmek için
        }
    }
}