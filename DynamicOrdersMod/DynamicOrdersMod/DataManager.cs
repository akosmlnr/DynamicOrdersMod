using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using MelonLoader;

namespace DynamicOrdersMod
{
    public static class DataManager
    {
        private static readonly string SaveDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                         "DynamicOrders&EconomyMod");
        private static readonly string SaveFile = Path.Combine(SaveDir, "customerData.json");

        public static Dictionary<string, CustomerBudgetInfo> Budgets { get; private set; }

        public static void Load()
        {
            if (!Directory.Exists(SaveDir)) Directory.CreateDirectory(SaveDir);
            if (File.Exists(SaveFile))
            {
                var json = File.ReadAllText(SaveFile);
                Budgets = JsonConvert.DeserializeObject<Dictionary<string, CustomerBudgetInfo>>(json);
            }
            else
            {
                Budgets = new Dictionary<string, CustomerBudgetInfo>();

                var allCustomers = UnityEngine.Object.FindObjectsOfType<Il2CppScheduleOne.Economy.CustomerData>();
                var allCustomers2 = UnityEngine.Object.FindObjectsOfType<Il2CppScheduleOne.Economy.Customer>();
                foreach (var custData in allCustomers)
                {
                    BudgetManager.AssignBaseBudgets(custData);
                    MelonLogger.Msg(custData);
                }

                foreach (var customerData in allCustomers2)
                {
                    MelonLogger.Msg(customerData);
                }
            }
        }

        public static void Save()
        {
            var json = JsonConvert.SerializeObject(Budgets, Formatting.Indented);
            File.WriteAllText(SaveFile, json);
        }
    }
}
