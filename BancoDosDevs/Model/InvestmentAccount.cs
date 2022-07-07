using System;

namespace BancoDosDevs.Model
{
    public class InvestmentAccount : BankAccount
    {
        public string TypeOfInvestor { get; set; }
        public string TypeOfInvestment { get; set; }
    }
}