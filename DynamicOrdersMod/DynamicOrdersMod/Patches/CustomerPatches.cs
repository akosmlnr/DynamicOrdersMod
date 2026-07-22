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
    // ============================================================
    // PROBE 1: Customer.OfferContract PREFIX
    // ============================================================
    [HarmonyPatch(typeof(Customer), "OfferContract")]
    public static class OfferContractPatch
    {
        public static void Prefix(Customer __instance, ContractInfo info)
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
    }

    // ============================================================
    // PROBE 2: Customer.ProcessHandover POSTFIX
    // ============================================================
    [HarmonyPatch(typeof(Customer), "ProcessHandover")]
    public static class ProcessHandoverPatch
    {
        public static void Postfix(
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
    }

    // ============================================================
    // PROBE 3: Contract.InitializeContract POSTFIX
    // ============================================================
    [HarmonyPatch(typeof(Contract), "InitializeContract")]
    public static class InitializeContractPatch
    {
        public static void Postfix(Contract __instance)
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
    }

    // ============================================================
    // PROBE 4: Dealer.ContractedOffered PREFIX
    // ============================================================
    [HarmonyPatch(typeof(Dealer), "ContractedOffered")]
    public static class ContractedOfferedPatch
    {
        public static void Prefix(Dealer __instance, ContractInfo contractInfo, Customer customer)
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
