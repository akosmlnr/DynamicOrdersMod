using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	public class NPCSignal_UseVendingMachine : NPCSignal
	{
		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CAA")]
		public new string ActionName
		{
			[Token(Token = "0x600566F")]
			[Address(RVA = "0x99F6E0", Offset = "0x99E8E0", VA = "0x18099F6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005670")]
		[Address(RVA = "0x99F6E0", Offset = "0x99E8E0", VA = "0x18099F6E0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005671")]
		[Address(RVA = "0x9A0800", Offset = "0x99FA00", VA = "0x1809A0800", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005672")]
		[Address(RVA = "0x99FE00", Offset = "0x99F000", VA = "0x18099FE00", Slot = "34")]
		public override void MinPassed()
		{
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005673")]
		[Address(RVA = "0x99EAC0", Offset = "0x99DCC0", VA = "0x18099EAC0", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005674")]
		[Address(RVA = "0x99FA90", Offset = "0x99EC90", VA = "0x18099FA90", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005675")]
		[Address(RVA = "0x99F050", Offset = "0x99E250", VA = "0x18099F050", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005676")]
		[Address(RVA = "0x9820B0", Offset = "0x9812B0", VA = "0x1809820B0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6005677")]
		[Address(RVA = "0x99FBA0", Offset = "0x99EDA0", VA = "0x18099FBA0")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005678")]
		[Address(RVA = "0x99F710", Offset = "0x99E910", VA = "0x18099F710")]
		private VendingMachine GetTargetMachine()
		{
			return null;
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005679")]
		[Address(RVA = "0x9A09C0", Offset = "0x99FBC0", VA = "0x1809A09C0", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567A")]
		[Address(RVA = "0x9A0330", Offset = "0x99F530", VA = "0x1809A0330")]
		[ObserversRpc(RunLocally = true)]
		public void Purchase()
		{
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x600567B")]
		[Address(RVA = "0x99F570", Offset = "0x99E770", VA = "0x18099F570")]
		private bool CheckItem()
		{
			return default(bool);
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567C")]
		[Address(RVA = "0x99FD60", Offset = "0x99EF60", VA = "0x18099FD60")]
		private void ItemWasStolen()
		{
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567D")]
		[Address(RVA = "0x99F560", Offset = "0x99E760", VA = "0x18099F560")]
		public NPCSignal_UseVendingMachine()
		{
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600567E")]
		[Address(RVA = "0x9A0950", Offset = "0x99FB50", VA = "0x1809A0950")]
		[CompilerGenerated]
		private IEnumerator <Purchase>g__Purchase|16_0()
		{
			return null;
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567F")]
		[Address(RVA = "0x9A02A0", Offset = "0x99F4A0", VA = "0x1809A02A0", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005680")]
		[Address(RVA = "0x9A0280", Offset = "0x99F480", VA = "0x1809A0280", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005681")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005682")]
		[Address(RVA = "0x9A06F0", Offset = "0x99F8F0", VA = "0x1809A06F0")]
		private void RpcWriter___Observers_Purchase_2166136261()
		{
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005683")]
		[Address(RVA = "0x9A0450", Offset = "0x99F650", VA = "0x1809A0450")]
		public void RpcLogic___Purchase_2166136261()
		{
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005684")]
		[Address(RVA = "0x9A06B0", Offset = "0x99F8B0", VA = "0x1809A06B0")]
		private void RpcReader___Observers_Purchase_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005685")]
		[Address(RVA = "0x99E770", Offset = "0x99D970", VA = "0x18099E770", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039DD RID: 14813
		[Token(Token = "0x40039DD")]
		private const float destinationThreshold = 1f;

		// Token: 0x040039DE RID: 14814
		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x150")]
		public VendingMachine MachineOverride;

		// Token: 0x040039DF RID: 14815
		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0x158")]
		private VendingMachine TargetMachine;

		// Token: 0x040039E0 RID: 14816
		[Token(Token = "0x40039E0")]
		[FieldOffset(Offset = "0x160")]
		private Coroutine purchaseCoroutine;

		// Token: 0x040039E1 RID: 14817
		[Token(Token = "0x40039E1")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x040039E2 RID: 14818
		[Token(Token = "0x40039E2")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_UseVendingMachineAssembly-CSharp.dll_Excuted;
	}
}
