using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6C RID: 2924
	[Token(Token = "0x2000B6C")]
	[CreateAssetMenu(fileName = "Euphoric", menuName = "Properties/Euphoric Property")]
	public class Euphoric : Effect
	{
		// Token: 0x0600575C RID: 22364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005760")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Euphoric()
		{
		}
	}
}
