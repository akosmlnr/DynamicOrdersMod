using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AB2 RID: 2738
	[Token(Token = "0x2000AB2")]
	public class Oscar : NPC
	{
		// Token: 0x06004EB4 RID: 20148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x941350", Offset = "0x940550", VA = "0x180941350", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB5")]
		[Address(RVA = "0x93AA40", Offset = "0x939C40", VA = "0x18093AA40")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x940FA0", Offset = "0x9401A0", VA = "0x180940FA0")]
		private void Loaded()
		{
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x940EC0", Offset = "0x9400C0", VA = "0x180940EC0")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x9411C0", Offset = "0x9403C0", VA = "0x1809411C0")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x940DD0", Offset = "0x93FFD0", VA = "0x180940DD0")]
		public void EnableDeliveries()
		{
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x941510", Offset = "0x940710", VA = "0x180941510")]
		public Oscar()
		{
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004EBB")]
		[Address(RVA = "0x9414A0", Offset = "0x9406A0", VA = "0x1809414A0")]
		[CompilerGenerated]
		private IEnumerator <EnableDeliveries>g__Wait|9_0()
		{
			return null;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x912D30", Offset = "0x911F30", VA = "0x180912D30", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x795310", Offset = "0x794510", VA = "0x180795310", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040036C9 RID: 14025
		[Token(Token = "0x40036C9")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x040036CA RID: 14026
		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0x330")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x040036CB RID: 14027
		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0x338")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0x340")]
		public string GreetedVariable;

		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0x348")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted;

		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0x349")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted;
	}
}
