using System;
using System.Collections.Generic;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class PurchaseRecord
    {
        public int Day;
        public string DrugType;
        public int Quantity;
        public float TotalSpent;
    }

    [Serializable]
    public class CustomerProfile
    {
        public string CustomerGuid;
        public float Tolerance;
        public float ScalingMultiplier;
        public int LifetimeDeals;
        public int SuccessfulDeals;
        public int FailedDeals;
        public bool IsWholesale;
        public int WholesaleWeeksActive;
        public int OverdoseCount;
        public int LastOverdoseDay;
        public bool IsHospitalized;
        public int HospitalReleaseDay;
        public int LastOverdoseRefusalDay;
        public List<string> DiscoveredDeadDrops = new List<string>();
        public int LastDeadDropFailDay;
        public List<PurchaseRecord> PurchaseHistory = new List<PurchaseRecord>();
        private const int MaxHistoryEntries = 50;

        public void RecordPurchase(int day, string drugType, int quantity, float totalSpent)
        {
            PurchaseHistory.Add(new PurchaseRecord
            {
                Day = day, DrugType = drugType, Quantity = quantity, TotalSpent = totalSpent
            });
            LifetimeDeals++;
            if (PurchaseHistory.Count > MaxHistoryEntries)
                PurchaseHistory.RemoveAt(0);
        }

        public void RecordSuccess() => SuccessfulDeals++;
        public void RecordFailure() => FailedDeals++;
    }
}
