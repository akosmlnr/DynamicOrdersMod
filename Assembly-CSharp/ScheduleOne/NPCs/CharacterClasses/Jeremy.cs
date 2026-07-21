using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Map;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class Jeremy : NPC
	{
		// Token: 0x06004E2A RID: 20010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x93BB80", Offset = "0x93AD80", VA = "0x18093BB80", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x93B7D0", Offset = "0x93A9D0", VA = "0x18093B7D0")]
		private void Loaded()
		{
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x93B6F0", Offset = "0x93A8F0", VA = "0x18093B6F0")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x93B9F0", Offset = "0x93ABF0", VA = "0x18093B9F0")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x93BC70", Offset = "0x93AE70", VA = "0x18093BC70")]
		public Jeremy()
		{
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x912D30", Offset = "0x911F30", VA = "0x180912D30", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x795310", Offset = "0x794510", VA = "0x180795310", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x0400368D RID: 13965
		[Token(Token = "0x400368D")]
		[FieldOffset(Offset = "0x328")]
		public Dealership Dealership;

		// Token: 0x0400368E RID: 13966
		[Token(Token = "0x400368E")]
		[FieldOffset(Offset = "0x330")]
		public List<Jeremy.DealershipListing> Listings;

		// Token: 0x0400368F RID: 13967
		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x338")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x04003690 RID: 13968
		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x340")]
		public string GreetedVariable;

		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x348")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted;

		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x349")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted;

		// Token: 0x02000A9B RID: 2715
		[Token(Token = "0x2000A9B")]
		[Serializable]
		public class DealershipListing
		{
			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x06004E33 RID: 20019 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000C02")]
			public string vehicleName
			{
				[Token(Token = "0x6004E33")]
				[Address(RVA = "0x93A720", Offset = "0x939920", VA = "0x18093A720")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x06004E34 RID: 20020 RVA: 0x00014DC0 File Offset: 0x00012FC0
			[Token(Token = "0x17000C03")]
			public float price
			{
				[Token(Token = "0x6004E34")]
				[Address(RVA = "0x93A680", Offset = "0x939880", VA = "0x18093A680")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E35")]
			[Address(RVA = "0x93A620", Offset = "0x939820", VA = "0x18093A620")]
			public DealershipListing()
			{
			}

			// Token: 0x04003693 RID: 13971
			[Token(Token = "0x4003693")]
			[FieldOffset(Offset = "0x10")]
			public string vehicleCode;
		}
	}
}
