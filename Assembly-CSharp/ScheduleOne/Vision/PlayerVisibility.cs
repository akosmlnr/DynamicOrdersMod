using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Vision
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public class PlayerVisibility : EntityVisibility
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x5D70C0", Offset = "0x5D62C0", VA = "0x1805D70C0", Slot = "21")]
		public override void Awake()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x5D73C0", Offset = "0x5D65C0", VA = "0x1805D73C0")]
		private void Update()
		{
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x5D6EF0", Offset = "0x5D60F0", VA = "0x1805D6EF0")]
		private void AddFlag_DisobeyingCurfew()
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x5D7350", Offset = "0x5D6550", VA = "0x1805D7350")]
		private void RemoveFlag_DisobeyingCurfew()
		{
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x1700048F")]
		public override float Suspiciousness
		{
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0x5D7540", Offset = "0x5D6740", VA = "0x1805D7540", Slot = "20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x5CE380", Offset = "0x5CD580", VA = "0x1805CE380")]
		public PlayerVisibility()
		{
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x5D7270", Offset = "0x5D6470", VA = "0x1805D7270", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x5D7240", Offset = "0x5D6440", VA = "0x1805D7240", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x5D6F70", Offset = "0x5D6170", VA = "0x1805D6F70", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vision.PlayerVisibility_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040014D6 RID: 5334
		[Token(Token = "0x40014D6")]
		[FieldOffset(Offset = "0x168")]
		private Player player;

		// Token: 0x040014D7 RID: 5335
		[Token(Token = "0x40014D7")]
		[FieldOffset(Offset = "0x170")]
		private bool disobeyingCurfewStateApplied;

		// Token: 0x040014D8 RID: 5336
		[Token(Token = "0x40014D8")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize___EarlyScheduleOne.Vision.PlayerVisibilityAssembly-CSharp.dll_Excuted;

		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		[FieldOffset(Offset = "0x172")]
		private bool NetworkInitialize__LateScheduleOne.Vision.PlayerVisibilityAssembly-CSharp.dll_Excuted;
	}
}
