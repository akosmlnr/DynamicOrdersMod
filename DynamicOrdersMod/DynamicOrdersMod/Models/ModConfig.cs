using System;
using System.Collections.Generic;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class GeneralConfig
    {
        public bool Enabled = true;
        public bool DebugLogging = false;
        public int ConfigVersion = 1;
        /// <summary>
        /// When true, dead drops and wholesale are available for ALL buyers regardless of
        /// relationship, tolerance, or deal count. Also bypasses dead drop cooldown.
        /// For TESTING ONLY — set to false for normal gameplay.
        /// </summary>
        public bool DebugUnlockAllFeatures = false;
    }

    [Serializable]
    public class ScalingConfig
    {
        public float AddictionWeight = 2.0f;
        public float RelationshipWeight = 0.5f;
        public float ToleranceWeight = 1.5f;
        public float RandomVariability = 0.2f;
        public float BingeOrderChance = 0.05f;
        public float BingeOrderMultiplier = 2.5f;
    }

    [Serializable]
    public class ToleranceConfig
    {
        public float GainPerDelivery = 0.01f;
        public float DailyDecayBase = 0.002f;
        public float SatisfactionPenaltyScale = 0.5f;
        public bool QualityExpectationShift = true;
    }

    [Serializable]
    public class DeadDropConfig
    {
        public bool Enabled = true;
        public float MinRelationship = 0.4f;
        public float QuantityThreshold = 3.0f;
        public float PrepaidChance = 0.5f;
        public float AsyncPremiumMin = 0.10f;
        public float AsyncPremiumMax = 0.20f;
        public float TheftChance = 0.03f;
        public float NonPaymentChance = 0.08f;
        public float PoliceInterceptBaseChance = 0.02f;
        public int TheftCooldownDays = 7;
        public float SuccessRelationshipBonus = 0.05f;
        public float HeatDecayPerDay = 0.1f;
        public bool ShowHeatOnMap = true;
        public bool DiscoveryQuestEnabled = true;
        public int DiscoveryLocationsCount = 5;
    }

    [Serializable]
    public class DiscountTier
    {
        public int MinDeals;
        public float DiscountPercent;
    }

    [Serializable]
    public class PricingConfig
    {
        public List<DiscountTier> DiscountTiers = new List<DiscountTier>
        {
            new DiscountTier { MinDeals = 5, DiscountPercent = 0.05f },
            new DiscountTier { MinDeals = 15, DiscountPercent = 0.12f },
            new DiscountTier { MinDeals = 50, DiscountPercent = 0.20f },
            new DiscountTier { MinDeals = 100, DiscountPercent = 0.30f }
        };
        public float MarketFluctuationRange = 0.15f;
        public float AddictionPricePremium = 0.10f;
    }

    [Serializable]
    public class WholesaleConfig
    {
        public bool Enabled = true;
        public float MinRelationship = 0.7f;
        public int MinCompletedDeals = 20;
        public float MinTolerance = 0.5f;
        public float WeeklyRevenueCut = 0.30f;
        public float BulkOrderMultiplier = 7.0f;
    }

    [Serializable]
    public class IntRange
    {
        public int Min;
        public int Max;
    }

    [Serializable]
    public class EventsConfig
    {
        public float PoliceCrackdownChancePerWeek = 0.02f;
        public IntRange CrackdownDurationDays = new IntRange { Min = 3, Max = 5 };
        public float CrackdownOrderReduction = 0.5f;
        public float CrackdownDeadDropRiskMultiplier = 3.0f;
        public float SupplyShortageChancePerWeek = 0.05f;
        public IntRange ShortageDurationDays = new IntRange { Min = 5, Max = 7 };
        public float ShortageOrderReduction = 0.6f;
        public float ShortagePriceIncrease = 0.40f;
    }

    [Serializable]
    public class OverdoseConfig
    {
        public float BaseChance = 0.002f;
        public float MaxChance = 0.05f;
        public IntRange HospitalizationDays = new IntRange { Min = 5, Max = 10 };
        public float HospitalRelationshipDecay = 0.02f;
        public float ReleaseRelationshipHit = 0.3f;
        public float SecondOverdoseRelationshipHit = 0.8f;
        public int SecondOverdoseRefusalDays = 14;
        public bool ThirdOverdosePermanentRefusal = true;
    }

    [Serializable]
    public class ModConfig
    {
        public GeneralConfig General = new GeneralConfig();
        public ScalingConfig Scaling = new ScalingConfig();
        public ToleranceConfig Tolerance = new ToleranceConfig();
        public DeadDropConfig DeadDrop = new DeadDropConfig();
        public PricingConfig Pricing = new PricingConfig();
        public WholesaleConfig Wholesale = new WholesaleConfig();
        public EventsConfig Events = new EventsConfig();
        public OverdoseConfig Overdose = new OverdoseConfig();
    }
}