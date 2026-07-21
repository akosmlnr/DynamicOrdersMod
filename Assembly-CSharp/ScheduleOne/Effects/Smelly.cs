using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	[CreateAssetMenu(fileName = "Smelly", menuName = "Properties/Smelly Property")]
	public class Smelly : Effect
	{
		// Token: 0x060057CB RID: 22475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0x9A3D80", Offset = "0x9A2F80", VA = "0x1809A3D80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0x9A3DC0", Offset = "0x9A2FC0", VA = "0x1809A3DC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0x9A3EB0", Offset = "0x9A30B0", VA = "0x1809A3EB0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0x9A3EF0", Offset = "0x9A30F0", VA = "0x1809A3EF0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Smelly()
		{
		}
	}
}
