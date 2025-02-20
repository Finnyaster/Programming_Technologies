using System;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("asdasd", 1000);
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial Balance.");
            var account2 = new BankAccount("asd", 3000);
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial Balance.");
            account1.MakeDeposit(100m, DateTime.Now, "awd");
            account1.MakeDeposit(1500m, DateTime.Now, "awd");
            account1.MakeWithDrawal(600m, DateTime.Now, "awd");
            Console.WriteLine($"Account {account1.Number.Value} have {account1.Balance} rubls.");
        }
    }
}