using System;
using System.Collections.Generic;
using SystemOfBankAccount.ValueObjects;

namespace SystemOfBankAccount
{
    class BankAccount
    {
        private List<Transaction> _allTransaction = new List<Transaction>();
        private static int s_accountNumberSeed = 1000000000;
        public NumberOfBankAccount Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransaction)
                    balance += item.Amount;
                return balance;
            }
        }

        public BankAccount(string owner, decimal initialBalance)
        {
            Number = new NumberOfBankAccount(s_accountNumberSeed);
            s_accountNumberSeed++;
            Owner = owner;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            var deposit = new Transaction(amount, date, note);
            _allTransaction.Add(deposit);
        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            if (Balance - amount <= 0)
                throw new InvalidOperationException("Not sufficient rubls for this withdrawal");
            _allTransaction.Add(new Transaction(-amount,date,note));
        }
    }
}
