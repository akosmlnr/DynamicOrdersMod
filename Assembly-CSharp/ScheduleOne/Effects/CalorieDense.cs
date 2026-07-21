using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	[CreateAssetMenu(fileName = "CalorieDense", menuName = "Properties/CalorieDense Property")]
	public class CalorieDense : Effect
	{
		// Token: 0x0600573E RID: 22334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573E")]
		[Address(RVA = "0x991190", Offset = "0x990390", VA = "0x180991190", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573F")]
		[Address(RVA = "0x991210", Offset = "0x990410", VA = "0x180991210", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005740")]
		[Address(RVA = "0x991290", Offset = "0x990490", VA = "0x180991290", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005741")]
		[Address(RVA = "0x9912F0", Offset = "0x9904F0", VA = "0x1809912F0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005742")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public CalorieDense()
		{
		}
	}
}
