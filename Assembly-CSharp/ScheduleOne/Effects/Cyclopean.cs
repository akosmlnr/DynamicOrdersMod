using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	[CreateAssetMenu(fileName = "Cyclopean", menuName = "Properties/Cyclopean Property")]
	public class Cyclopean : Effect
	{
		// Token: 0x06005743 RID: 22339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005743")]
		[Address(RVA = "0x9913F0", Offset = "0x9905F0", VA = "0x1809913F0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005744")]
		[Address(RVA = "0x991430", Offset = "0x990630", VA = "0x180991430", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005745")]
		[Address(RVA = "0x991470", Offset = "0x990670", VA = "0x180991470", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x9914B0", Offset = "0x9906B0", VA = "0x1809914B0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Cyclopean()
		{
		}
	}
}
