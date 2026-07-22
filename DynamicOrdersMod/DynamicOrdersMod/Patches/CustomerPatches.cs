using HarmonyLib;

namespace DynamicOrdersMod.Patches
{
    /// <summary>
    /// Previously held Harmony patches for Customer methods (OfferContract, ContractAccepted,
    /// ProcessHandover, CurrentContractEnded, RpcLogic___ChangeAddiction_431000436) and
    /// Contract.Complete.
    ///
    /// DIAGNOSTIC FINDING: All customer-related Harmony patches silently failed to bind
    /// in this MelonLoader/Il2Cpp environment. PatchProcessor.GetPatchInfo reported
    /// prefixes=0 postfixes=0 for every target method (Customer.OfferContract,
    /// Customer.ContractAccepted, Customer.ProcessHandover, Customer.CurrentContractEnded,
    /// Customer.RpcLogic___ChangeAddiction_431000436, Contract.Complete). Only patches on
    /// non-Customer types (SaveManager.Save) successfully bound.
    ///
    /// ROOT CAUSE: MelonLoader's Il2Cpp interop does not reliably attach Harmony patches
    /// to methods on Customer (a NetworkBehaviour with many RPC-generated stubs and
    /// native-only call sites). Even though AccessTools.Method finds the methods (hence
    /// "BOUND" in the diagnostic), the PatchClassProcessor silently skips attaching the
    /// prefix/postfix when parameter signatures don't exactly match the il2cpp-resolved
    /// signature (especially for ref/out params, List<T> types, and virtual dispatch).
    ///
    /// ARCHITECTURE PIVOT: All customer-related hooks moved to UnityEvent subscriptions
    /// in Core/ModEntry.cs and Core/DynamicEconomyCore.cs. The events used are:
    ///   - Customer.onCustomerUnlocked (static Action<Customer>) — entry point for per-customer subscription
    ///   - Customer.onContractAssigned (UnityEvent<Contract>) — scaling + dead drop interception
    ///   - Customer.onDealCompleted (UnityEvent) — tolerance growth + overdose roll
    ///   - Contract.onComplete (UnityEvent) — per-contract completion observability
    ///   - Contract.onQuestEnd (UnityEvent<EQuestState>) — failure/expiration tracking
    ///
    /// UnityEvents bypass Harmony entirely and fire from native code regardless of caller
    /// language, making them strictly more reliable for this game.
    ///
    /// This file is kept as an empty placeholder for future use (e.g. if a future MelonLoader
    /// version fixes the binding issue, or for patches on non-Customer types).
    /// </summary>
    public static class CustomerPatches
    {
        // Intentionally empty. See class-level doc comment.
    }
}
