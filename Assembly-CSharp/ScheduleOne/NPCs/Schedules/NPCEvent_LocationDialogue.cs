using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	public class NPCEvent_LocationDialogue : NPCEvent
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C94")]
		public new string ActionName
		{
			[Token(Token = "0x6005593")]
			[Address(RVA = "0x97F200", Offset = "0x97E400", VA = "0x18097F200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005594")]
		[Address(RVA = "0x97DC00", Offset = "0x97CE00", VA = "0x18097DC00", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005595")]
		[Address(RVA = "0x97E610", Offset = "0x97D810", VA = "0x18097E610", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x97F130", Offset = "0x97E330", VA = "0x18097F130", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x97E280", Offset = "0x97D480", VA = "0x18097E280", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x97E080", Offset = "0x97D280", VA = "0x18097E080", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x97DF70", Offset = "0x97D170", VA = "0x18097DF70", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x97DBC0", Offset = "0x97CDC0", VA = "0x18097DBC0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559B")]
		[Address(RVA = "0x97DD20", Offset = "0x97CF20", VA = "0x18097DD20", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559C")]
		[Address(RVA = "0x97E670", Offset = "0x97D870", VA = "0x18097E670", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559D")]
		[Address(RVA = "0x97D670", Offset = "0x97C870", VA = "0x18097D670", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x600559E")]
		[Address(RVA = "0x97DDB0", Offset = "0x97CFB0", VA = "0x18097DDB0")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559F")]
		[Address(RVA = "0x97D9E0", Offset = "0x97CBE0", VA = "0x18097D9E0", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A0")]
		[Address(RVA = "0x97EEE0", Offset = "0x97E0E0", VA = "0x18097EEE0", Slot = "45")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void StartAction(NetworkConnection conn)
		{
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A1")]
		[Address(RVA = "0x97DAA0", Offset = "0x97CCA0", VA = "0x18097DAA0", Slot = "46")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A2")]
		[Address(RVA = "0x97F1C0", Offset = "0x97E3C0", VA = "0x18097F1C0")]
		public NPCEvent_LocationDialogue()
		{
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A3")]
		[Address(RVA = "0x97E150", Offset = "0x97D350", VA = "0x18097E150", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A4")]
		[Address(RVA = "0x97E110", Offset = "0x97D310", VA = "0x18097E110", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A5")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A6")]
		[Address(RVA = "0x97ECA0", Offset = "0x97DEA0", VA = "0x18097ECA0")]
		private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A7")]
		[Address(RVA = "0x97E880", Offset = "0x97DA80", VA = "0x18097E880", Slot = "47")]
		protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A8")]
		[Address(RVA = "0x97EB00", Offset = "0x97DD00", VA = "0x18097EB00")]
		private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x97EDB0", Offset = "0x97DFB0", VA = "0x18097EDB0")]
		private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x97EB40", Offset = "0x97DD40", VA = "0x18097EB40")]
		private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x97EB80", Offset = "0x97DD80", VA = "0x18097EB80")]
		private void RpcWriter___Observers_EndAction_2166136261()
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x97E700", Offset = "0x97D900", VA = "0x18097E700", Slot = "48")]
		protected virtual void RpcLogic___EndAction_2166136261()
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x97EAC0", Offset = "0x97DCC0", VA = "0x18097EAC0")]
		private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x97A7C0", Offset = "0x9799C0", VA = "0x18097A7C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04003995 RID: 14741
		[Token(Token = "0x4003995")]
		[FieldOffset(Offset = "0x158")]
		public Transform Destination;

		// Token: 0x04003996 RID: 14742
		[Token(Token = "0x4003996")]
		[FieldOffset(Offset = "0x160")]
		public bool FaceDestinationDir;

		// Token: 0x04003997 RID: 14743
		[Token(Token = "0x4003997")]
		[FieldOffset(Offset = "0x164")]
		public float DestinationThreshold;

		// Token: 0x04003998 RID: 14744
		[Token(Token = "0x4003998")]
		[FieldOffset(Offset = "0x168")]
		public bool WarpIfSkipped;

		// Token: 0x04003999 RID: 14745
		[Token(Token = "0x4003999")]
		[FieldOffset(Offset = "0x16C")]
		[Header("Dialogue Settings")]
		public int GreetingOverrideToEnable;

		// Token: 0x0400399A RID: 14746
		[Token(Token = "0x400399A")]
		[FieldOffset(Offset = "0x170")]
		public int ChoiceToEnable;

		// Token: 0x0400399B RID: 14747
		[Token(Token = "0x400399B")]
		[FieldOffset(Offset = "0x178")]
		public DialogueContainer DialogueOverride;

		// Token: 0x0400399C RID: 14748
		[Token(Token = "0x400399C")]
		[FieldOffset(Offset = "0x180")]
		protected bool IsActionStarted;

		// Token: 0x0400399D RID: 14749
		[Token(Token = "0x400399D")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted;

		// Token: 0x0400399E RID: 14750
		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x182")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted;
	}
}
