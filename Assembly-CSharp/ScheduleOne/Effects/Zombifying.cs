using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	[CreateAssetMenu(fileName = "Zombifying", menuName = "Properties/Zombifying Property")]
	public class Zombifying : Effect
	{
		// Token: 0x060057E9 RID: 22505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E9")]
		[Address(RVA = "0x9A6D70", Offset = "0x9A5F70", VA = "0x1809A6D70", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EA")]
		[Address(RVA = "0x9A6E40", Offset = "0x9A6040", VA = "0x1809A6E40", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EB")]
		[Address(RVA = "0x9A6E80", Offset = "0x9A6080", VA = "0x1809A6E80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0x9A6F10", Offset = "0x9A6110", VA = "0x1809A6F10", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Zombifying()
		{
		}

		// Token: 0x04003A51 RID: 14929
		[Token(Token = "0x4003A51")]
		[FieldOffset(Offset = "0x78")]
		public VODatabase zombieVODatabase;
	}
}
