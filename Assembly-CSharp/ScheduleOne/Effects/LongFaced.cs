using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	[CreateAssetMenu(fileName = "LongFaced", menuName = "Properties/LongFaced Property")]
	public class LongFaced : Effect
	{
		// Token: 0x06005778 RID: 22392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005778")]
		[Address(RVA = "0x99D9C0", Offset = "0x99CBC0", VA = "0x18099D9C0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005779")]
		[Address(RVA = "0x99DA00", Offset = "0x99CC00", VA = "0x18099DA00", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577A")]
		[Address(RVA = "0x99DB00", Offset = "0x99CD00", VA = "0x18099DB00", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577B")]
		[Address(RVA = "0x99DB40", Offset = "0x99CD40", VA = "0x18099DB40", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577C")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public LongFaced()
		{
		}
	}
}
