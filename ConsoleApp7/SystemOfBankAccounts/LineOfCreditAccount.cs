﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOfBankAccount.Base;

namespace SystemOfBankAccount
{
    class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner, decimal initialBalance) 
            : base(owner, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                MakeWithDrawal(-Balance * 0.07m, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
