using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	public class NPCEvent_CartelGoonExit : NPCEvent_StayInBuilding
	{
		// Token: 0x06005540 RID: 21824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005540")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005541")]
		[Address(RVA = "0x97A590", Offset = "0x979790", VA = "0x18097A590", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005542")]
		[Address(RVA = "0x97A300", Offset = "0x979500", VA = "0x18097A300", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005543")]
		[Address(RVA = "0x97A270", Offset = "0x979470", VA = "0x18097A270", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005544")]
		[Address(RVA = "0x97A500", Offset = "0x979700", VA = "0x18097A500", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005545")]
		[Address(RVA = "0x97A170", Offset = "0x979370", VA = "0x18097A170")]
		private void FindExitBuilding()
		{
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005546")]
		[Address(RVA = "0x97A140", Offset = "0x979340", VA = "0x18097A140", Slot = "45")]
		protected override void EnterBuilding(int doorIndex)
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005547")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCEvent_CartelGoonExit()
		{
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005548")]
		[Address(RVA = "0x97A440", Offset = "0x979640", VA = "0x18097A440", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005549")]
		[Address(RVA = "0x97A3F0", Offset = "0x9795F0", VA = "0x18097A3F0", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554A")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "47")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCEvent_CartelGoonExit_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x180")]
		public CartelGoon Goon;

		// Token: 0x04003977 RID: 14711
		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_CartelGoonExitAssembly-CSharp.dll_Excuted;

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_CartelGoonExitAssembly-CSharp.dll_Excuted;
	}
}
