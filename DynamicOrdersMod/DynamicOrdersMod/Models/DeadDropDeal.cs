using System;

namespace DynamicOrdersMod.Models
{
    /// <summary>
    /// Tracks an active dead drop deal created by the mod (intercepts TryGenerateContract).
    /// Resolved at the deal window close by reading the dead drop's storage contents.
    /// </summary>
    [Serializable]
    public class DeadDropDeal
    {
        // Identity
        public string DealId;
        public string CustomerGuid;

        // Delivery target
        public string DropGuid;

        // Contract terms (what the customer ordered)
        public string ExpectedProductID;
        public string DrugType;            // EDrugType name for event matching
        public int ExpectedQuality;        // EQuality enum int value
        public int ExpectedQuantity;

        // Payment
        public float Payment;              // full contract value if delivered as agreed
        public bool IsPrepaid;             // true = customer paid upfront

        // Timing
        public int CreatedDay;
        public int WindowDay;              // day by which delivery must be made

        // Resolution
        public bool IsResolved;
        public string Result;              // "pending"/"success"/"partial"/"no_delivery"/"theft"/"police"/"nonpayment"/"expired"
        public float ActualPayment;        // what the player actually received
        public int ResolvedDay;
    }
}
