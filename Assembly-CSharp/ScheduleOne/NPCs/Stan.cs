using System;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A43 RID: 2627
	[Token(Token = "0x2000A43")]
	public class Stan : NPC
	{
		// Token: 0x06004A61 RID: 19041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x912F90", Offset = "0x912190", VA = "0x180912F90", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x912AB0", Offset = "0x911CB0", VA = "0x180912AB0")]
		private void Loaded()
		{
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x9129D0", Offset = "0x911BD0", VA = "0x1809129D0")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x912E00", Offset = "0x912000", VA = "0x180912E00")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x912D50", Offset = "0x911F50", VA = "0x180912D50")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x9130E0", Offset = "0x9122E0", VA = "0x1809130E0")]
		public Stan()
		{
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x912D30", Offset = "0x911F30", VA = "0x180912D30", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x912CD0", Offset = "0x911ED0", VA = "0x180912CD0", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x8F3E00", Offset = "0x8F3000", VA = "0x1808F3E00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x330")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x338")]
		public string GreetedVariable;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x340")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x348")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x349")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted;
	}
}
