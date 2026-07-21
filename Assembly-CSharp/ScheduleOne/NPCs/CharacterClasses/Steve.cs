using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	public class Steve : NPC
	{
		// Token: 0x06004F2E RID: 20270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x944710", Offset = "0x943910", VA = "0x180944710", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x93AA40", Offset = "0x939C40", VA = "0x18093AA40")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Steve()
		{
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x93AA20", Offset = "0x939C20", VA = "0x18093AA20", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003709 RID: 14089
		[Token(Token = "0x4003709")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x0400370A RID: 14090
		[Token(Token = "0x400370A")]
		[FieldOffset(Offset = "0x330")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x0400370B RID: 14091
		[Token(Token = "0x400370B")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted;

		// Token: 0x0400370C RID: 14092
		[Token(Token = "0x400370C")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted;
	}
}
