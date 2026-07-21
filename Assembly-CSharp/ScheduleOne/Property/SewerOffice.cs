using System;
using Il2CppDummyDll;

namespace ScheduleOne.Property
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	public class SewerOffice : Property
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x5AC2D0", Offset = "0x5AB4D0", VA = "0x1805AC2D0", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x5AC4B0", Offset = "0x5AB6B0", VA = "0x1805AC4B0")]
		public void OnPasscodeCorrect()
		{
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "49")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x5AC420", Offset = "0x5AB620", VA = "0x1805AC420")]
		public string GetDefaultSaveFileFullPath()
		{
			return null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x5AC4E0", Offset = "0x5AB6E0", VA = "0x1805AC4E0")]
		public SewerOffice()
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x595E00", Offset = "0x595000", VA = "0x180595E00", Slot = "58")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x595DD0", Offset = "0x594FD0", VA = "0x180595DD0", Slot = "59")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x5AC1B0", Offset = "0x5AB3B0", VA = "0x1805AC1B0", Slot = "61")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.SewerOffice_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400135E RID: 4958
		[Token(Token = "0x400135E")]
		private const string DefaultSaveFilePath = "DefaultSave\\Properties\\Sewer Office.json";

		// Token: 0x0400135F RID: 4959
		[Token(Token = "0x400135F")]
		[FieldOffset(Offset = "0x250")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.SewerOfficeAssembly-CSharp.dll_Excuted;

		// Token: 0x04001360 RID: 4960
		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0x251")]
		private bool NetworkInitialize__LateScheduleOne.Property.SewerOfficeAssembly-CSharp.dll_Excuted;
	}
}
