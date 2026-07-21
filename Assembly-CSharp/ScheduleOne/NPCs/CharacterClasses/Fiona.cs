using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class Fiona : NPC
	{
		// Token: 0x06004DC6 RID: 19910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x93AB20", Offset = "0x939D20", VA = "0x18093AB20", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC7")]
		[Address(RVA = "0x93AA40", Offset = "0x939C40", VA = "0x18093AA40")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x00014D90 File Offset: 0x00012F90
		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x93AAD0", Offset = "0x939CD0", VA = "0x18093AAD0")]
		public bool ShopChoiceValid(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Fiona()
		{
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x93AA20", Offset = "0x939C20", VA = "0x18093AA20", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x0400365F RID: 13919
		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x04003660 RID: 13920
		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x330")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04003661 RID: 13921
		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted;

		// Token: 0x04003662 RID: 13922
		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted;
	}
}
