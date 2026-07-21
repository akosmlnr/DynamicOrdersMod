using System;
using Il2CppDummyDll;

namespace ScheduleOne.Property
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public class MotelRoom : Property
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x59CF10", Offset = "0x59C110", VA = "0x18059CF10", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x59CF70", Offset = "0x59C170", VA = "0x18059CF70")]
		private void UpdateVariables()
		{
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "56")]
		public override bool CanDeliverToProperty()
		{
			return default(bool);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x59D890", Offset = "0x59CA90", VA = "0x18059D890")]
		public MotelRoom()
		{
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x595E00", Offset = "0x595000", VA = "0x180595E00", Slot = "58")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x595DD0", Offset = "0x594FD0", VA = "0x180595DD0", Slot = "59")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x595D20", Offset = "0x594F20", VA = "0x180595D20", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[FieldOffset(Offset = "0x250")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted;

		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		[FieldOffset(Offset = "0x251")]
		private bool NetworkInitialize__LateScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted;
	}
}
