using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Quests;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class NPCSignal_WaitForDelivery : NPCSignal
	{
		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CAD")]
		public new string ActionName
		{
			[Token(Token = "0x600568C")]
			[Address(RVA = "0x9A1020", Offset = "0x9A0220", VA = "0x1809A1020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600568D RID: 22157 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CAE")]
		private DeliveryLocation Location
		{
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x9A1FB0", Offset = "0x9A11B0", VA = "0x1809A1FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600568E")]
		[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980")]
		public void SetContract(Contract contract)
		{
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600568F")]
		[Address(RVA = "0x9A0A30", Offset = "0x99FC30", VA = "0x1809A0A30", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005690")]
		[Address(RVA = "0x9A1A70", Offset = "0x9A0C70", VA = "0x1809A1A70", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005691")]
		[Address(RVA = "0x9A1020", Offset = "0x9A0220", VA = "0x1809A1020", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005692")]
		[Address(RVA = "0x9A1C60", Offset = "0x9A0E60", VA = "0x1809A1C60", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005693")]
		[Address(RVA = "0x9A1580", Offset = "0x9A0780", VA = "0x1809A1580", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005694")]
		[Address(RVA = "0x9A12A0", Offset = "0x9A04A0", VA = "0x1809A12A0", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005695")]
		[Address(RVA = "0x9A0F90", Offset = "0x9A0190", VA = "0x1809A0F90")]
		private void EnsureNPCHasEnoughCash()
		{
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005696")]
		[Address(RVA = "0x9A17F0", Offset = "0x9A09F0", VA = "0x1809A17F0", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005697")]
		[Address(RVA = "0x9A0A90", Offset = "0x99FC90", VA = "0x1809A0A90")]
		private void CheckWarp()
		{
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005698")]
		[Address(RVA = "0x9A1050", Offset = "0x9A0250", VA = "0x1809A1050", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005699")]
		[Address(RVA = "0x9A1A90", Offset = "0x9A0C90", VA = "0x1809A1A90", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569A")]
		[Address(RVA = "0x9A0ED0", Offset = "0x9A00D0", VA = "0x1809A0ED0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569B")]
		[Address(RVA = "0x9A1BC0", Offset = "0x9A0DC0", VA = "0x1809A1BC0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x600569C")]
		[Address(RVA = "0x9A1130", Offset = "0x9A0330", VA = "0x1809A1130")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569D")]
		[Address(RVA = "0x9A1E90", Offset = "0x9A1090", VA = "0x1809A1E90", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569E")]
		[Address(RVA = "0x99F560", Offset = "0x99E760", VA = "0x18099F560")]
		public NPCSignal_WaitForDelivery()
		{
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569F")]
		[Address(RVA = "0x9A17D0", Offset = "0x9A09D0", VA = "0x1809A17D0", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x9A17B0", Offset = "0x9A09B0", VA = "0x1809A17B0", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x9A0A00", Offset = "0x99FC00", VA = "0x1809A0A00", Slot = "45")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCSignal_WaitForDelivery_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040039E6 RID: 14822
		[Token(Token = "0x40039E6")]
		public const float DestinationThreshold = 1.5f;

		// Token: 0x040039E7 RID: 14823
		[Token(Token = "0x40039E7")]
		public const float WalkSpeedMultiplier = 1.25f;

		// Token: 0x040039E8 RID: 14824
		[Token(Token = "0x40039E8")]
		[FieldOffset(Offset = "0x150")]
		private Contract contract;

		// Token: 0x040039E9 RID: 14825
		[Token(Token = "0x40039E9")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted;

		// Token: 0x040039EA RID: 14826
		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted;
	}
}
