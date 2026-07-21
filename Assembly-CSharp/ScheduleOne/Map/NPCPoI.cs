using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;

namespace ScheduleOne.Map
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public class NPCPoI : POI
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055B")]
		public NPC NPC
		{
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9B")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x6297A0", Offset = "0x6289A0", VA = "0x1806297A0", Slot = "5")]
		public override void InitializeUI()
		{
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x6298B0", Offset = "0x628AB0", VA = "0x1806298B0")]
		public void SetNPC(NPC npc)
		{
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x6299D0", Offset = "0x628BD0", VA = "0x1806299D0")]
		public NPCPoI()
		{
		}
	}
}
