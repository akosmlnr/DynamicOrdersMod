using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	[CreateAssetMenu(fileName = "ThoughtProvoking", menuName = "Properties/ThoughtProvoking Property")]
	public class ThoughtProvoking : Effect
	{
		// Token: 0x060057DA RID: 22490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DA")]
		[Address(RVA = "0x9A4BF0", Offset = "0x9A3DF0", VA = "0x1809A4BF0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DB")]
		[Address(RVA = "0x9A4C30", Offset = "0x9A3E30", VA = "0x1809A4C30", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DC")]
		[Address(RVA = "0x9A4C70", Offset = "0x9A3E70", VA = "0x1809A4C70", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DD")]
		[Address(RVA = "0x9A4CB0", Offset = "0x9A3EB0", VA = "0x1809A4CB0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DE")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public ThoughtProvoking()
		{
		}
	}
}
