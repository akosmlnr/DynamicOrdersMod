using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class VisionCone : NetworkBehaviour
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x17000499")]
		protected float effectiveRange
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x5E5D90", Offset = "0x5E4F90", VA = "0x1805E5D90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x5E0940", Offset = "0x5DFB40", VA = "0x1805E0940", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x5E32E0", Offset = "0x5E24E0", VA = "0x1805E32E0")]
		private void PlayerSpawned(Player plr)
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x5E3280", Offset = "0x5E2480", VA = "0x1805E3280")]
		private void OnEnable()
		{
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x5E3220", Offset = "0x5E2420", VA = "0x1805E3220")]
		private void OnDisable()
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x5E5A50", Offset = "0x5E4C50", VA = "0x1805E5A50", Slot = "20")]
		protected virtual void VisionUpdate()
		{
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x5E44A0", Offset = "0x5E36A0", VA = "0x1805E44A0", Slot = "21")]
		protected virtual void UpdateEvents(float tickTime)
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x5E4F70", Offset = "0x5E4170", VA = "0x1805E4F70", Slot = "22")]
		protected virtual void UpdateVision(float tickTime)
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x5E0E80", Offset = "0x5E0080", VA = "0x1805E0E80", Slot = "23")]
		public virtual void EventReachedZero(VisionEvent _event)
		{
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x5E0DB0", Offset = "0x5DFFB0", VA = "0x1805E0DB0", Slot = "24")]
		public virtual void EventHalfNoticed(VisionEvent _event)
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x5E0B40", Offset = "0x5DFD40", VA = "0x1805E0B40", Slot = "25")]
		public virtual void EventFullyNoticed(VisionEvent _event)
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x5E4110", Offset = "0x5E3310", VA = "0x1805E4110")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x5E3A60", Offset = "0x5E2C60", VA = "0x1805E3A60", Slot = "26")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x5E04F0", Offset = "0x5DF6F0", VA = "0x1805E04F0")]
		public void AddSightableOfInterest(ISightable s)
		{
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x5E3BC0", Offset = "0x5E2DC0", VA = "0x1805E3BC0")]
		public void RemoveSightableOfInterest(ISightable s)
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x5E4340", Offset = "0x5E3540", VA = "0x1805E4340")]
		public void SetSightableStateEnabled(ISightable sightable, EVisualState state, bool enabled)
		{
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x5E3540", Offset = "0x5E2740", VA = "0x1805E3540")]
		[Button]
		public void PrintSightableStates()
		{
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x5E2780", Offset = "0x5E1980", VA = "0x1805E2780", Slot = "27")]
		public virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, [Optional] LandVehicle vehicleToIgnore)
		{
			return default(bool);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x5E0F80", Offset = "0x5E0180", VA = "0x1805E0F80")]
		public VisionEvent GetEvent(ISightable target, EntityVisualState state)
		{
			return null;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x5E2600", Offset = "0x5E1800", VA = "0x1805E2600")]
		public bool IsPlayerVisible(Player player)
		{
			return default(bool);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x5E2600", Offset = "0x5E1800", VA = "0x1805E2600")]
		public bool WasSightableVisibleThisFrame(ISightable sightable)
		{
			return default(bool);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x5E2F30", Offset = "0x5E2130", VA = "0x1805E2F30")]
		public bool IsTargetVisible(ISightable target)
		{
			return default(bool);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x5E2510", Offset = "0x5E1710", VA = "0x1805E2510")]
		public float GetPlayerVisibility(Player player)
		{
			return 0f;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x5E26B0", Offset = "0x5E18B0", VA = "0x1805E26B0")]
		public bool IsPlayerVisible(Player player, out VisionCone.SightableData data)
		{
			return default(bool);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x5E4270", Offset = "0x5E3470", VA = "0x1805E4270", Slot = "28")]
		public virtual void SetNoticePlayerCrimes(Player player, bool active)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x5E3210", Offset = "0x5E2410", VA = "0x1805E3210")]
		private void OnDie()
		{
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x5E0990", Offset = "0x5DFB90", VA = "0x1805E0990")]
		public void ClearEvents()
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x5E1C80", Offset = "0x5E0E80", VA = "0x1805E1C80")]
		private Vector3[] GetFrustumVertices()
		{
			return null;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x5E1080", Offset = "0x5E0280", VA = "0x1805E1080")]
		private Plane[] GetFrustumPlanes()
		{
			return null;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x5E5B20", Offset = "0x5E4D20", VA = "0x1805E5B20")]
		public VisionCone()
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x5E3130", Offset = "0x5E2330", VA = "0x1805E3130", Slot = "29")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x5E3110", Offset = "0x5E2310", VA = "0x1805E3110", Slot = "30")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x5E30D0", Offset = "0x5E22D0", VA = "0x1805E30D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x5E3FB0", Offset = "0x5E31B0", VA = "0x1805E3FB0")]
		private void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x5E3D20", Offset = "0x5E2F20", VA = "0x1805E3D20")]
		public void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x5E3DB0", Offset = "0x5E2FB0", VA = "0x1805E3DB0")]
		private void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x5E3E40", Offset = "0x5E3040", VA = "0x1805E3E40")]
		private void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x5E3C80", Offset = "0x5E2E80", VA = "0x1805E3C80", Slot = "31")]
		public virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x5E3D40", Offset = "0x5E2F40", VA = "0x1805E3D40")]
		private void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x5E0580", Offset = "0x5DF780", VA = "0x1805E0580", Slot = "32")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vision.VisionCone_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001508")]
		public const float VISION_UPDATE_INTERVAL = 0.1f;

		// Token: 0x04001509 RID: 5385
		[Token(Token = "0x4001509")]
		public const float MinVisionDelta = 0.075f;

		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x400150A")]
		private const float ExclamationSoundCooldown = 1f;

		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x400150B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TimeOnLastExclamationSound;

		// Token: 0x0400150C RID: 5388
		[Token(Token = "0x400150C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float UniversalAttentivenessScale;

		// Token: 0x0400150D RID: 5389
		[Token(Token = "0x400150D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float UniversalMemoryScale;

		// Token: 0x0400150E RID: 5390
		[Token(Token = "0x400150E")]
		public const float HorizontalFOV = 135f;

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		public const float VerticalFOV = 100f;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		public const float Range = 25f;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		public const float MinorWidth = 3f;

		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		public const float MinorHeight = 1.5f;

		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Transform VisionOrigin;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Vision Settings")]
		public AnimationCurve VisionFalloff;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public LayerMask VisibilityBlockingLayers;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[Range(0f, 2f)]
		public float RangeMultiplier;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[FormerlySerializedAs("StatesOfInterest")]
		[Header("Interest settings")]
		public List<VisionCone.StateContainer> DefaultStatesOfInterest;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Notice Settings")]
		public float Attentiveness;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float Memory;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Header("Sound Settings")]
		public bool UseTremoloSound;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		[Header("Worldspace Icons")]
		public bool WorldspaceIconsEnabled;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public WorldspacePopup QuestionMarkPopup;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public WorldspacePopup ExclamationPointPopup;

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioSourceController ExclamationSound;

		// Token: 0x04001520 RID: 5408
		[Token(Token = "0x4001520")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public VisionCone.EventStateChange onVisionEventStarted;

		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001521")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public VisionCone.EventStateChange onVisionEventHalf;

		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001522")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public VisionCone.EventStateChange onVisionEventFull;

		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001523")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public VisionCone.EventStateChange onVisionEventExpired;

		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected List<ISightable> sightablesOfInterest;

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected Dictionary<ISightable, VisionCone.SightableData> sightableDatas;

		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x4001526")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected Dictionary<ISightable, Dictionary<EVisualState, VisionCone.StateContainer>> stateSettings;

		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x4001527")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected List<VisionEvent> activeVisionEvents;

		// Token: 0x04001528 RID: 5416
		[Token(Token = "0x4001528")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected List<VisionEvent> cachedVisionEvents;

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected NPC npc;

		// Token: 0x0400152A RID: 5418
		[Token(Token = "0x400152A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected bool noticeGeneralCrime;

		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected List<ISightable> sightablesSeenThisFrame;

		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected List<ISightable> toRemove;

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted;

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		private bool NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted;

		// Token: 0x020003BA RID: 954
		[Token(Token = "0x20003BA")]
		public enum EEventLevel
		{
			// Token: 0x04001530 RID: 5424
			[Token(Token = "0x4001530")]
			Start,
			// Token: 0x04001531 RID: 5425
			[Token(Token = "0x4001531")]
			Half,
			// Token: 0x04001532 RID: 5426
			[Token(Token = "0x4001532")]
			Full,
			// Token: 0x04001533 RID: 5427
			[Token(Token = "0x4001533")]
			Zero
		}

		// Token: 0x020003BB RID: 955
		[Token(Token = "0x20003BB")]
		[Serializable]
		public class StateContainer
		{
			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x06001829 RID: 6185 RVA: 0x00009B40 File Offset: 0x00007D40
			[Token(Token = "0x1700049A")]
			public float RequiredNoticeTime
			{
				[Token(Token = "0x6001829")]
				[Address(RVA = "0x5D89E0", Offset = "0x5D7BE0", VA = "0x1805D89E0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x5D8960", Offset = "0x5D7B60", VA = "0x1805D8960")]
			public VisionCone.StateContainer GetCopy()
			{
				return null;
			}

			// Token: 0x0600182B RID: 6187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x5D89D0", Offset = "0x5D7BD0", VA = "0x1805D89D0")]
			public StateContainer()
			{
			}

			// Token: 0x04001534 RID: 5428
			[Token(Token = "0x4001534")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EVisualState state;

			// Token: 0x04001535 RID: 5429
			[Token(Token = "0x4001535")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool Enabled;

			// Token: 0x04001536 RID: 5430
			[Token(Token = "0x4001536")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0.5f, 4f)]
			public float NoticeTimeMultiplier;
		}

		// Token: 0x020003BC RID: 956
		[Token(Token = "0x20003BC")]
		public class SightableData
		{
			// Token: 0x0600182C RID: 6188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SightableData()
			{
			}

			// Token: 0x04001537 RID: 5431
			[Token(Token = "0x4001537")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ISightable Sightable;

			// Token: 0x04001538 RID: 5432
			[Token(Token = "0x4001538")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VisionDelta;

			// Token: 0x04001539 RID: 5433
			[Token(Token = "0x4001539")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float TimeVisible;
		}

		// Token: 0x020003BD RID: 957
		// (Invoke) Token: 0x0600182E RID: 6190
		[Token(Token = "0x20003BD")]
		public delegate void EventStateChange(VisionEventReceipt _event);
	}
}
