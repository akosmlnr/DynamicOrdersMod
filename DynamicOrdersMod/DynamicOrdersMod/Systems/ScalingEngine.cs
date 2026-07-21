using System;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Systems
{
    public static class ScalingEngine
    {
        [ThreadStatic]
        private static System.Random _rng;
        private static System.Random Rng => _rng ?? (_rng = new System.Random());

        /// <summary>
        /// HOT PATH: No allocations. Returns scaled quantity.
        /// </summary>
        public static int CalculateScaledQuantity(
            int baseQuantity,
            float currentAddiction,
            float normalizedRelationship,
            float tolerance,
            ScalingConfig config)
        {
            if (baseQuantity <= 0) return baseQuantity;

            float addictionBonus = currentAddiction * config.AddictionWeight;
            float relationshipBonus = normalizedRelationship * config.RelationshipWeight;
            float toleranceBonus = tolerance * config.ToleranceWeight;

            float variability = (float)(Rng.NextDouble() * 2.0 - 1.0) * config.RandomVariability;
            bool isBinge = Rng.NextDouble() < config.BingeOrderChance;
            float bingeMult = isBinge ? config.BingeOrderMultiplier : 1f;

            float multiplier = (1f + addictionBonus + relationshipBonus + toleranceBonus)
                              * (1f + variability) * bingeMult;
            float scaled = baseQuantity * multiplier;

            if (scaled < 1f) scaled = 1f;
            if (scaled > 1000f) scaled = 1000f;

            return (int)scaled;
        }

        /// <summary>
        /// Computes the cached scaling multiplier. Called from EndSleep.
        /// </summary>
        public static float ComputeScalingMultiplier(
            float currentAddiction,
            float normalizedRelationship,
            float tolerance,
            ScalingConfig config)
        {
            float bonus = currentAddiction * config.AddictionWeight
                        + normalizedRelationship * config.RelationshipWeight
                        + tolerance * config.ToleranceWeight;
            return 1f + bonus;
        }
    }
}