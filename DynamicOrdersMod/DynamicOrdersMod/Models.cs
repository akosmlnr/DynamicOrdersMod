using System;
using System.Collections.Generic;

namespace DynamicOrdersMod
{
    public class Transaction
    {
        public DateTime Timestamp { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
    }

    public class CustomerBudgetInfo
    {
        public string CustomerId { get; set; }
        public float TotalBudget { get; set; }
        public float WillingBudget { get; set; }
        public float FinancialStability { get; set; }
        public List<Transaction> DailyTransactions { get; } = new List<Transaction>();
    }
}
