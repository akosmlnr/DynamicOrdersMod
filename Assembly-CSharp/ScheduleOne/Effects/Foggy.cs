using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	[CreateAssetMenu(fileName = "Foggy", menuName = "Properties/Foggy Property")]
	public class Foggy : Effect
	{
		// Token: 0x0600576D RID: 22381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576D")]
		[Address(RVA = "0x99CAD0", Offset = "0x99BCD0", VA = "0x18099CAD0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576E")]
		[Address(RVA = "0x99CB10", Offset = "0x99BD10", VA = "0x18099CB10", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576F")]
		[Address(RVA = "0x99CC20", Offset = "0x99BE20", VA = "0x18099CC20", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005770")]
		[Address(RVA = "0x99CC60", Offset = "0x99BE60", VA = "0x18099CC60", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005771")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Foggy()
		{
		}
	}
}
