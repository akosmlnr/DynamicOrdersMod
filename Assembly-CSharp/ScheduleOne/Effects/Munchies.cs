using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	[CreateAssetMenu(fileName = "Munchies", menuName = "Properties/Munchies Property")]
	public class Munchies : Effect
	{
		// Token: 0x06005791 RID: 22417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005791")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005792")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005793")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005794")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005795")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Munchies()
		{
		}
	}
}
