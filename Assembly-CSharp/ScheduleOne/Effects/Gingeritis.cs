using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2000B70")]
	[CreateAssetMenu(fileName = "Gingeritis", menuName = "Properties/Gingeritis Property")]
	public class Gingeritis : Effect
	{
		// Token: 0x06005772 RID: 22386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005772")]
		[Address(RVA = "0x99CD50", Offset = "0x99BF50", VA = "0x18099CD50", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005773")]
		[Address(RVA = "0x99CE50", Offset = "0x99C050", VA = "0x18099CE50", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005774")]
		[Address(RVA = "0x99CF50", Offset = "0x99C150", VA = "0x18099CF50", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x99CF90", Offset = "0x99C190", VA = "0x18099CF90", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Gingeritis()
		{
		}

		// Token: 0x04003A3A RID: 14906
		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 Color;
	}
}
