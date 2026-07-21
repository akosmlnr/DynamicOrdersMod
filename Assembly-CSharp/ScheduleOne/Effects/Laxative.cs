using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B74 RID: 2932
	[Token(Token = "0x2000B74")]
	[CreateAssetMenu(fileName = "Laxative", menuName = "Properties/Laxative Property")]
	public class Laxative : Effect
	{
		// Token: 0x06005787 RID: 22407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005787")]
		[Address(RVA = "0x99D2D0", Offset = "0x99C4D0", VA = "0x18099D2D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005788")]
		[Address(RVA = "0x99D310", Offset = "0x99C510", VA = "0x18099D310", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005789")]
		[Address(RVA = "0x99D350", Offset = "0x99C550", VA = "0x18099D350", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578A")]
		[Address(RVA = "0x99D390", Offset = "0x99C590", VA = "0x18099D390", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578B")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Laxative()
		{
		}
	}
}
