using System;
using SystemOfBankAccount.Base;

namespace SystemOfBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new InterestEarningAccount("asdasd", 1000);
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial Balance.");
            var account2 = new LineOfCreditAccount("asd", 3000);
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial Balance.");
            account1.MakeDeposit(100m, DateTime.Now, "Maked deposit");
            account1.MakeDeposit(1500m, DateTime.Now, "Maked deposit");
            account1.MakeWithDrawal(600m, DateTime.Now, "Maked drawal");
            Console.WriteLine($"Account {account1.Number.Value} have {account1.Balance} rubls.");
            Console.WriteLine(account1.GetAccountHistory());

            try
            {
                account1.MakeWithDrawal(20000m, DateTime.Now, "text");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message, e.ParamName);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }
        }
    }
}