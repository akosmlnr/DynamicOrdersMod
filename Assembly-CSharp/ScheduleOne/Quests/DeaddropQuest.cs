using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Quests
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	public class DeaddropQuest : Quest
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000419")]
		public DeadDrop Drop
		{
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x57F850", Offset = "0x57EA50", VA = "0x18057F850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x57F8B0", Offset = "0x57EAB0", VA = "0x18057F8B0", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x580070", Offset = "0x57F270", VA = "0x180580070")]
		public void SetDrop(DeadDrop drop)
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x57FFB0", Offset = "0x57F1B0", VA = "0x18057FFB0", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x57FEE0", Offset = "0x57F0E0", VA = "0x18057FEE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x57FB30", Offset = "0x57ED30", VA = "0x18057FB30", Slot = "39")]
		public override void End()
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x580200", Offset = "0x57F400", VA = "0x180580200", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x580300", Offset = "0x57F500", VA = "0x180580300", Slot = "54")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x57FBC0", Offset = "0x57EDC0", VA = "0x18057FBC0", Slot = "55")]
		public override SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x5803A0", Offset = "0x57F5A0", VA = "0x1805803A0")]
		public DeaddropQuest()
		{
		}

		// Token: 0x0400126D RID: 4717
		[Token(Token = "0x400126D")]
		[FieldOffset(Offset = "0x0")]
		public static List<DeaddropQuest> DeaddropQuests;
	}
}
