﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfBankAccount.ValueObjects
{
    struct Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }
    }
}
