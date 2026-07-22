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
        /// Deterministic seed from customer GUID + day.
        /// Ensures all multiplayer clients compute identical scaled quantities
        /// for the same customer on the same day.
        /// </summary>
        public static int HashToSeed(string guid, int day)
        {
            if (string.IsNullOrEmpty(guid)) return day * 2654435761;
            int hash = 5381;
            for (int i = 0; i < guid.Length; i++)
                hash = ((hash << 5) + hash) ^ guid[i];
            return hash ^ (day * 2654435761);
        }

        /// <summary>
        /// HOT PATH: Returns scaled quantity.
        /// Uses seed when provided for deterministic multiplayer sync,
        /// otherwise falls back to thread-static RNG (single-player path).
        /// </summary>
        public static int CalculateScaledQuantity(
            int baseQuantity,
            float currentAddiction,
            float normalizedRelationship,
            float tolerance,
            ScalingConfig config,
            int seed = -1)
        {
            if (baseQuantity <= 0) return baseQuantity;

            float addictionBonus = currentAddiction * config.AddictionWeight;
            float relationshipBonus = normalizedRelationship * config.RelationshipWeight;
            float toleranceBonus = tolerance * config.ToleranceWeight;

            // Use seeded RNG when provided (deterministic for multiplayer),
            // otherwise fall back to thread-static RNG (single-player path).
            double rnd1, rnd2;
            if (seed >= 0)
            {
                var seeded = new System.Random(seed);
                rnd1 = seeded.NextDouble();
                rnd2 = seeded.NextDouble();
            }
            else
            {
                rnd1 = Rng.NextDouble();
                rnd2 = Rng.NextDouble();
            }

            float variability = (float)(rnd1 * 2.0 - 1.0) * config.RandomVariability;
            bool isBinge = rnd2 < config.BingeOrderChance;
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