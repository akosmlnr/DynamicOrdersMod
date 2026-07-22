using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using DynamicOrdersMod.Core;

namespace DynamicOrdersMod.Patches
{
    /// <summary>
    /// PROBE BUILD — testing which Harmony signatures actually bind in this
    /// MelonLoader/Il2Cpp environment.
    ///
    /// Each patch below logs "[probe] <MethodName> FIRED" when it executes.
    /// That's the ground truth — if the line appears, the patch works.
    /// If it doesn't appear despite deals happening, the patch didn't bind
    /// (even if the diagnostic says BOUND).
    ///
    /// After this build is tested, we'll know which scenario we're in:
    ///   A: All 4 fire        -> full features possible
    ///   B: Contract/Dealer only -> dead drops work, overdose uses proxy
    ///   C: Only Contract     -> dead drops via InitializeContract, limited overdose
    ///   D: None fire         -> polish current side-channel approach
    /// </summary>
    public static class CustomerPatches
    {
        // ============================================================
        // PROBE 1: Customer.OfferContract PREFIX
        // Simplest possible Customer method signature.
        // If this binds, ANY Customer method can be patched.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "OfferContract")]
        [HarmonyPrefix]
        static void OfferContractProbePrefix(Customer __instance, ContractInfo info)
        {
            try
            {
                string guid = "?";
                try { guid = __instance?.NPC?.GUID.ToString() ?? "?"; } catch { }
                MelonLogger.Msg($"[DOM] [probe] Customer.OfferContract PREFIX FIRED cust={DebugLog.Short(guid)} info_payment={info?.Payment ?? 0:F2}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DOM] [probe] OfferContract error: {ex.Message}");
            }
        }

        // ============================================================
        // PROBE 2: Customer.ProcessHandover POSTFIX
        // Complex signature with List<ItemInstance> — the prize.
        // If this binds, we get real item data for overdose potency.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "ProcessHandover")]
        [HarmonyPostfix]
        static void ProcessHandoverProbePostfix(
            Customer __instance,
            HandoverScreen.EHandoverOutcome outcome,
            Contract contract,
            List<ItemInstance> items,
            bool handoverByPlayer,
            bool giveBonuses)
        {
            try
            {
                string guid = "?";
                try { guid = __instance?.NPC?.GUID.ToString() ?? "?"; } catch { }
                int itemCount = items?.Count ?? 0;
                MelonLogger.Msg($"[DOM] [probe] Customer.ProcessHandover POSTFIX FIRED cust={DebugLog.Short(guid)} outcome={outcome} items={itemCount}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DOM] [probe] ProcessHandover error: {ex.Message}");
            }
        }

        // ============================================================
        // PROBE 3: Contract.InitializeContract POSTFIX
        // Contract extends Quest (MonoBehaviour, NOT NetworkBehaviour).
        // Better binding odds than Customer. Access state via __instance.
        // ============================================================
        [HarmonyPatch(typeof(Contract), "InitializeContract")]
        [HarmonyPostfix]
        static void InitializeContractProbePostfix(Contract __instance)
        {
            try
            {
                string deliveryLoc = "?";
                try { deliveryLoc = __instance?.DeliveryLocation?.GUID.ToString() ?? "?"; } catch { }
                MelonLogger.Msg($"[DOM] [probe] Contract.InitializeContract POSTFIX FIRED delivery_loc={deliveryLoc} payment={__instance?.Payment ?? 0:F2}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DOM] [probe] InitializeContract error: {ex.Message}");
            }
        }

        // ============================================================
        // PROBE 4: Dealer.ContractedOffered PREFIX
        // Dealer extends NPC. Tests whether Dealer methods bind.
        // ============================================================
        [HarmonyPatch(typeof(Dealer), "ContractedOffered")]
        [HarmonyPrefix]
        static void ContractedOfferedProbePrefix(Dealer __instance, ContractInfo contractInfo, Customer customer)
        {
            try
            {
                string custGuid = "?";
                try { custGuid = customer?.NPC?.GUID.ToString() ?? "?"; } catch { }
                MelonLogger.Msg($"[DOM] [probe] Dealer.ContractedOffered PREFIX FIRED cust={DebugLog.Short(custGuid)} payment={contractInfo?.Payment ?? 0:F2}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DOM] [probe] ContractedOffered error: {ex.Message}");
            }
        }
    }
}
