using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B66 RID: 2918
	[Token(Token = "0x2000B66")]
	[CreateAssetMenu(fileName = "CalmingProperty", menuName = "Properties/Calming Property")]
	public class Calming : Effect
	{
		// Token: 0x06005739 RID: 22329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005739")]
		[Address(RVA = "0x990E80", Offset = "0x990080", VA = "0x180990E80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573A")]
		[Address(RVA = "0x990EC0", Offset = "0x9900C0", VA = "0x180990EC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573B")]
		[Address(RVA = "0x991020", Offset = "0x990220", VA = "0x180991020", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573C")]
		[Address(RVA = "0x991060", Offset = "0x990260", VA = "0x180991060", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573D")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Calming()
		{
		}
	}
}
