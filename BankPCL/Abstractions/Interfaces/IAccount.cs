﻿using System;
using System.Collections.Generic;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IAccount
    {
        IPerson Owner { get; set; }

        string ID { get; set; }
        
        double? Balance { get; set; }
        double? Loan { get; set; }

        event EventHandler ReceiveMoneyListeners;
        event EventHandler ReceiveLoanListeners;

        void SendMoney(double amount, string accountID);
        void ReceiveMoney(double amount, IAccount sender);

        void RequestLoan(double amount);
        void ReceiveLoan(double amount, double interest);

        void PayLoan(double amount);
    }
}
