using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	[CreateAssetMenu(fileName = "TropicThunder", menuName = "Properties/TropicThunder Property")]
	public class TropicThunder : Effect
	{
		// Token: 0x060057E4 RID: 22500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x9A5010", Offset = "0x9A4210", VA = "0x1809A5010", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x9A5050", Offset = "0x9A4250", VA = "0x1809A5050", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E6")]
		[Address(RVA = "0x9A5090", Offset = "0x9A4290", VA = "0x1809A5090", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E7")]
		[Address(RVA = "0x9A50D0", Offset = "0x9A42D0", VA = "0x1809A50D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E8")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public TropicThunder()
		{
		}
	}
}
