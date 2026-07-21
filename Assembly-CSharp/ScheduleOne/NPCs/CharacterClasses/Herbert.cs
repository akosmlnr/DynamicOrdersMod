using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class Herbert : NPC
	{
		// Token: 0x06004DF6 RID: 19958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x93B5F0", Offset = "0x93A7F0", VA = "0x18093B5F0", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x93B4D0", Offset = "0x93A6D0", VA = "0x18093B4D0")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Herbert()
		{
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x93AA20", Offset = "0x939C20", VA = "0x18093AA20", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x04003678 RID: 13944
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x330")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted;

		// Token: 0x0400367A RID: 13946
		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted;
	}
}
