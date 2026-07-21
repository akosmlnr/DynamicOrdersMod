using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	[CreateAssetMenu(fileName = "Jennerising", menuName = "Properties/Jennerising Property")]
	public class Jennerising : Effect
	{
		// Token: 0x06005782 RID: 22402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005782")]
		[Address(RVA = "0x99D1D0", Offset = "0x99C3D0", VA = "0x18099D1D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005783")]
		[Address(RVA = "0x99D210", Offset = "0x99C410", VA = "0x18099D210", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005784")]
		[Address(RVA = "0x99D250", Offset = "0x99C450", VA = "0x18099D250", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005785")]
		[Address(RVA = "0x99D290", Offset = "0x99C490", VA = "0x18099D290", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005786")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Jennerising()
		{
		}
	}
}
