using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Money;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	public class NPCSignal_UseATM : NPCSignal
	{
		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CA7")]
		public new string ActionName
		{
			[Token(Token = "0x6005655")]
			[Address(RVA = "0x99E7C0", Offset = "0x99D9C0", VA = "0x18099E7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x99E7C0", Offset = "0x99D9C0", VA = "0x18099E7C0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x99F390", Offset = "0x99E590", VA = "0x18099F390", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005658")]
		[Address(RVA = "0x99EB80", Offset = "0x99DD80", VA = "0x18099EB80", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005659")]
		[Address(RVA = "0x99EAC0", Offset = "0x99DCC0", VA = "0x18099EAC0", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x99E7F0", Offset = "0x99D9F0", VA = "0x18099E7F0", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x99F050", Offset = "0x99E250", VA = "0x18099F050", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565C")]
		[Address(RVA = "0x9820B0", Offset = "0x9812B0", VA = "0x1809820B0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x600565D")]
		[Address(RVA = "0x99E900", Offset = "0x99DB00", VA = "0x18099E900")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565E")]
		[Address(RVA = "0x99F520", Offset = "0x99E720", VA = "0x18099F520", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600565F")]
		[Address(RVA = "0x99EF30", Offset = "0x99E130", VA = "0x18099EF30")]
		[ObserversRpc(RunLocally = true)]
		public void Purchase()
		{
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005660")]
		[Address(RVA = "0x99F560", Offset = "0x99E760", VA = "0x18099F560")]
		public NPCSignal_UseATM()
		{
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005661")]
		[Address(RVA = "0x99F4B0", Offset = "0x99E6B0", VA = "0x18099F4B0")]
		[CompilerGenerated]
		private IEnumerator <Purchase>g__Purchase|14_0()
		{
			return null;
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x99EAF0", Offset = "0x99DCF0", VA = "0x18099EAF0", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005663")]
		[Address(RVA = "0x99EAD0", Offset = "0x99DCD0", VA = "0x18099EAD0", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005664")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005665")]
		[Address(RVA = "0x99F280", Offset = "0x99E480", VA = "0x18099F280")]
		private void RpcWriter___Observers_Purchase_2166136261()
		{
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005666")]
		[Address(RVA = "0x99F060", Offset = "0x99E260", VA = "0x18099F060")]
		public void RpcLogic___Purchase_2166136261()
		{
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005667")]
		[Address(RVA = "0x99F240", Offset = "0x99E440", VA = "0x18099F240")]
		private void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005668")]
		[Address(RVA = "0x99E770", Offset = "0x99D970", VA = "0x18099E770", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039D5 RID: 14805
		[Token(Token = "0x40039D5")]
		private const float destinationThreshold = 2f;

		// Token: 0x040039D6 RID: 14806
		[Token(Token = "0x40039D6")]
		[FieldOffset(Offset = "0x150")]
		public ATM ATM;

		// Token: 0x040039D7 RID: 14807
		[Token(Token = "0x40039D7")]
		[FieldOffset(Offset = "0x158")]
		private Coroutine purchaseCoroutine;

		// Token: 0x040039D8 RID: 14808
		[Token(Token = "0x40039D8")]
		[FieldOffset(Offset = "0x160")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted;

		// Token: 0x040039D9 RID: 14809
		[Token(Token = "0x40039D9")]
		[FieldOffset(Offset = "0x161")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseATMAssembly-CSharp.dll_Excuted;
	}
}
