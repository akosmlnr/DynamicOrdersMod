using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	[CreateAssetMenu(fileName = "Paranoia", menuName = "Properties/Paranoia Property")]
	public class Paranoia : Effect
	{
		// Token: 0x06005796 RID: 22422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005796")]
		[Address(RVA = "0x9A29E0", Offset = "0x9A1BE0", VA = "0x1809A29E0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005797")]
		[Address(RVA = "0x9A2A70", Offset = "0x9A1C70", VA = "0x1809A2A70", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005798")]
		[Address(RVA = "0x9A2B10", Offset = "0x9A1D10", VA = "0x1809A2B10", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005799")]
		[Address(RVA = "0x9A2B70", Offset = "0x9A1D70", VA = "0x1809A2B70", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579A")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Paranoia()
		{
		}
	}
}
