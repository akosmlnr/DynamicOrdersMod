using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	public class NPCEvent_LocationBasedAction : NPCEvent
	{
		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C93")]
		public new string ActionName
		{
			[Token(Token = "0x6005577")]
			[Address(RVA = "0x97DA70", Offset = "0x97CC70", VA = "0x18097DA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005578")]
		[Address(RVA = "0x97C720", Offset = "0x97B920", VA = "0x18097C720", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005579")]
		[Address(RVA = "0x97D010", Offset = "0x97C210", VA = "0x18097D010", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557A")]
		[Address(RVA = "0x97D950", Offset = "0x97CB50", VA = "0x18097D950", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557B")]
		[Address(RVA = "0x97CDA0", Offset = "0x97BFA0", VA = "0x18097CDA0", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557C")]
		[Address(RVA = "0x97CBA0", Offset = "0x97BDA0", VA = "0x18097CBA0", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x97CA90", Offset = "0x97BC90", VA = "0x18097CA90", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x97C6E0", Offset = "0x97B8E0", VA = "0x18097C6E0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x97C840", Offset = "0x97BA40", VA = "0x18097C840", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x97D070", Offset = "0x97C270", VA = "0x18097D070", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x97D670", Offset = "0x97C870", VA = "0x18097D670", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x97C8D0", Offset = "0x97BAD0", VA = "0x18097C8D0")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x97D9E0", Offset = "0x97CBE0", VA = "0x18097D9E0", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005584")]
		[Address(RVA = "0x97D700", Offset = "0x97C900", VA = "0x18097D700", Slot = "45")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected virtual void StartAction(NetworkConnection conn)
		{
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005585")]
		[Address(RVA = "0x97C5A0", Offset = "0x97B7A0", VA = "0x18097C5A0", Slot = "46")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x97DA40", Offset = "0x97CC40", VA = "0x18097DA40")]
		public NPCEvent_LocationBasedAction()
		{
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x97CC70", Offset = "0x97BE70", VA = "0x18097CC70", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x97CC30", Offset = "0x97BE30", VA = "0x18097CC30", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x97D430", Offset = "0x97C630", VA = "0x18097D430")]
		private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x97D130", Offset = "0x97C330", VA = "0x18097D130", Slot = "47")]
		protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x97D290", Offset = "0x97C490", VA = "0x18097D290")]
		private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x97D540", Offset = "0x97C740", VA = "0x18097D540")]
		private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558E")]
		[Address(RVA = "0x97D2D0", Offset = "0x97C4D0", VA = "0x18097D2D0")]
		private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x97D310", Offset = "0x97C510", VA = "0x18097D310")]
		private void RpcWriter___Observers_EndAction_2166136261()
		{
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x97D100", Offset = "0x97C300", VA = "0x18097D100", Slot = "48")]
		protected virtual void RpcLogic___EndAction_2166136261()
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x97D230", Offset = "0x97C430", VA = "0x18097D230")]
		private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x97A7C0", Offset = "0x9799C0", VA = "0x18097A7C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0400398C RID: 14732
		[Token(Token = "0x400398C")]
		[FieldOffset(Offset = "0x158")]
		public Transform Destination;

		// Token: 0x0400398D RID: 14733
		[Token(Token = "0x400398D")]
		[FieldOffset(Offset = "0x160")]
		public bool FaceDestinationDir;

		// Token: 0x0400398E RID: 14734
		[Token(Token = "0x400398E")]
		[FieldOffset(Offset = "0x164")]
		public float DestinationThreshold;

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0x168")]
		public bool WarpIfSkipped;

		// Token: 0x04003990 RID: 14736
		[Token(Token = "0x4003990")]
		[FieldOffset(Offset = "0x169")]
		public bool IsActionStarted;

		// Token: 0x04003991 RID: 14737
		[Token(Token = "0x4003991")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onStartAction;

		// Token: 0x04003992 RID: 14738
		[Token(Token = "0x4003992")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onEndAction;

		// Token: 0x04003993 RID: 14739
		[Token(Token = "0x4003993")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted;

		// Token: 0x04003994 RID: 14740
		[Token(Token = "0x4003994")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted;
	}
}
