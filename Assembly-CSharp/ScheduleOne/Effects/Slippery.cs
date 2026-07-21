using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	[CreateAssetMenu(fileName = "Slippery", menuName = "Properties/Slippery Property")]
	public class Slippery : Effect
	{
		// Token: 0x060057C6 RID: 22470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x9A3CE0", Offset = "0x9A2EE0", VA = "0x1809A3CE0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x9A3D10", Offset = "0x9A2F10", VA = "0x1809A3D10", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x9A3D30", Offset = "0x9A2F30", VA = "0x1809A3D30", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0x9A3D60", Offset = "0x9A2F60", VA = "0x1809A3D60", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Slippery()
		{
		}
	}
}
