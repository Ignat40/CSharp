using System.Security.Cryptography;
using ClassesExercises;

namespace ATM
{
    class BankAccount
    {
        public string? AccountNumber;
        public string? AccountHolder;
        public double Balance;

        public BankAccount(string accNum, string accHolder, double balance)
        {
            AccountHolder = accHolder;
            AccountNumber = accNum;
            Balance = balance;
        }
        public double Deposit(double depositMoney)
        {
            double newBalance = Balance + depositMoney;
            return newBalance;
        }
        public double Withdraw(double withdrawMoney)
        {
            double newBalance = Balance - withdrawMoney;
            return newBalance;
        }
        public void DisplayMoney(BankAccount bankAccount)
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            BankAccount bankAccount = new("LK1J23H4HFQ", "Rumen Ognqnow", 15000);
            bankAccount.DisplayMoney(bankAccount);
            Console.WriteLine($"{bankAccount.Deposit(1000)}");
            Console.WriteLine($"{bankAccount.Withdraw(3943)}");
        }
    }
}