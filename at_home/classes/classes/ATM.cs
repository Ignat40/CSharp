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
            
            if (withdrawMoney > Balance)
            {
                Console.WriteLine("Not enough money in account");
            }
            else
            {
                Balance -= withdrawMoney;
            }

            return Balance;

        }
        public void DisplayMoney(BankAccount bankAccount)
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}