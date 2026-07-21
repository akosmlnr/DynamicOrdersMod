using Il2CppScheduleOne.Economy;
using System;

namespace DynamicOrdersMod
{
    public static class BudgetManager
    {
        // Called from CustomerData.Standards postfix to set up base budgets
        public static void AssignBaseBudgets(CustomerData customer)
        {
            // use the Unity instance ID as our “key”
            string key = customer.GetInstanceID().ToString();

            // if we already have a budget for this object, skip it
            if (DataManager.Budgets.ContainsKey(key))
                return;

            // pull the single Standards value (quality expectation)
            float Standards = (float)customer.Standards;

            // derive your fields
            float totalBudget = Standards * 100f;
            float financialStability = Standards;
            float willingBudget = totalBudget * financialStability;

            var info = new CustomerBudgetInfo
            {
                CustomerId = key,              // now a string of the instance ID
                TotalBudget = totalBudget,
                FinancialStability = financialStability,
                WillingBudget = willingBudget
            };

            DataManager.Budgets[key] = info;
        }


        // Called at the end of each in-game day to clear & persist transactions
        public static void RefreshDailyTransactions()
        {
            foreach (var info in DataManager.Budgets.Values)
                info.DailyTransactions.Clear();
            DataManager.Save();
        }

        // Example helper when a customer spends something
        public static void RecordTransaction(string customerId, float amount, string desc)
        {
            if (DataManager.Budgets.TryGetValue(customerId, out var info))
            {
                info.DailyTransactions.Add(new Transaction
                {
                    Timestamp = DateTime.Now,
                    Amount = amount,
                    Description = desc
                });
            }
        }
    }
}
