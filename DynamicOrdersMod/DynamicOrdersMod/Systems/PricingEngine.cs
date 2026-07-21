using System;
using System.Collections.Generic;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Systems
{
    /// <summary>
    /// Pure-math pricing engine. No game API calls, no allocations on hot paths.
    /// All methods are deterministic given the same inputs (except market fluctuation).
    /// </summary>
    public static class PricingEngine
    {
        [ThreadStatic]
        private static System.Random _rng;
        private static System.Random Rng => _rng ?? (_rng = new System.Random());

        /// <summary>
        /// Returns the loyalty discount multiplier for a customer based on their
        /// successful deal count. E.g. returns 0.95 for a 5% discount.
        /// Tiers are evaluated highest-first; the first matching tier wins.
        /// </summary>
        public static float GetLoyaltyDiscount(int successfulDeals, PricingConfig config)
        {
            if (config?.DiscountTiers == null || config.DiscountTiers.Count == 0)
                return 1f;

            float bestDiscount = 0f;
            for (int i = 0; i < config.DiscountTiers.Count; i++)
            {
                var tier = config.DiscountTiers[i];
                if (successfulDeals >= tier.MinDeals && tier.DiscountPercent > bestDiscount)
                    bestDiscount = tier.DiscountPercent;
            }

            return 1f - bestDiscount;
        }

        /// <summary>
        /// Calculates the final per-unit price a customer pays.
        /// Formula: basePrice * loyaltyMultiplier * (1 + addictionPremium * addiction)
        ///          * (1 + marketNoise) * eventModifier
        /// </summary>
        public static float CalculateCustomerPrice(
            float basePrice,
            float addiction,
            int successfulDeals,
            PricingConfig pricingConfig,
            List<ActiveEvent> activeEvents,
            string drugType,
            float shortagePriceIncrease)
        {
            if (basePrice <= 0f) return basePrice;

            float loyaltyMult = GetLoyaltyDiscount(successfulDeals, pricingConfig);

            // Addiction premium: highly addicted customers tolerate higher prices
            float addictionMult = 1f + (pricingConfig.AddictionPricePremium * Math.Min(addiction, 1f));

            // Market fluctuation: random noise each time this is called
            float marketNoise = (float)(Rng.NextDouble() * 2.0 - 1.0)
                                * pricingConfig.MarketFluctuationRange;
            float marketMult = 1f + marketNoise;

            // Event modifiers (supply shortage raises prices, crackdown lowers demand/prices)
            float eventMult = GetEventPriceModifier(activeEvents, drugType, shortagePriceIncrease);

            float finalPrice = basePrice * loyaltyMult * addictionMult * marketMult * eventMult;

            if (finalPrice < 1f) finalPrice = 1f;

            return finalPrice;
        }

        /// <summary>
        /// Calculates the per-unit wholesale price.
        /// Wholesale customers receive a discount equal to the revenue cut,
        /// reflecting the volume-based nature of the arrangement.
        /// </summary>
        public static float CalculateWholesaleUnitPrice(float basePrice, WholesaleConfig config)
        {
            if (basePrice <= 0f) return basePrice;

            // Wholesale discount: the player keeps (1 - WeeklyRevenueCut) per unit
            // but sells in BulkOrderMultiplier quantities, making it profitable overall
            float wholesaleMult = 1f - config.WeeklyRevenueCut;
            return basePrice * wholesaleMult;
        }

        /// <summary>
        /// Computes the total wholesale deal value.
        /// </summary>
        public static float CalculateWholesaleTotal(
            float basePrice,
            int baseQuantity,
            WholesaleConfig config)
        {
            float unitPrice = CalculateWholesaleUnitPrice(basePrice, config);
            int wholesaleQty = (int)(baseQuantity * config.BulkOrderMultiplier);
            return unitPrice * wholesaleQty;
        }

        /// <summary>
        /// Returns the combined event price modifier for a given drug type.
        /// SupplyShortage on the matching drug increases prices.
        /// PoliceCrackdown has no direct price effect (handled by order reduction).
        /// </summary>
        public static float GetEventPriceModifier(
            List<ActiveEvent> activeEvents,
            string drugType,
            float shortagePriceIncrease)
        {
            if (activeEvents == null || activeEvents.Count == 0)
                return 1f;

            float modifier = 1f;

            for (int i = 0; i < activeEvents.Count; i++)
            {
                var evt = activeEvents[i];
                if (evt.Type == ActiveEventType.SupplyShortage
                    && string.Equals(evt.DrugType, drugType, StringComparison.OrdinalIgnoreCase))
                {
                    // Supply shortage drives prices up
                    modifier *= 1f + shortagePriceIncrease;
                }
            }

            return modifier;
        }
    }
}