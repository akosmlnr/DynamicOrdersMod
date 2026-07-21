using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B78 RID: 2936
	[Token(Token = "0x2000B78")]
	[CreateAssetMenu(fileName = "Refreshing", menuName = "Properties/Refreshing Property")]
	public class Refreshing : Effect
	{
		// Token: 0x0600579B RID: 22427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579F")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Refreshing()
		{
		}
	}
}
