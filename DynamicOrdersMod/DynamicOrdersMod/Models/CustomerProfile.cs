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
        public string ActiveDeadDropGuid;
        public bool ActiveDeadDropIsPrepaid;
        public bool ActiveDeadDropPendingCompletion;
        public List<PurchaseRecord> PurchaseHistory = new List<PurchaseRecord>();
        private const int MaxHistoryEntries = 50;

        // Cached from EvaluateDelivery for decay calc and dead drop pricing
        public float LastKnownAddiction = 0f;
        // Deferred relationship hit applied when hospitalized customer returns
        public float PendingRelationshipHit = 0f;
        // Cached from GetWeightedRandomProduct for proper tolerance growth
        public string LastRequestedDrugType = "";
        public int LastRequestedQuantity = 0;
        // Overdose grace period: day until which overdose rolls are skipped
        // (prevents immediate re-overdose after hospital release)
        public int OverdoseGraceUntilDay = -1;
        // Anti-double-scale: tracks the last day we scaled for OfferContract.
        // OfferContract fires twice per contract (build + finalize); without this guard,
        // scaling compounds exponentially on the second pass.
        public int LastScaledDay = -1;

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
