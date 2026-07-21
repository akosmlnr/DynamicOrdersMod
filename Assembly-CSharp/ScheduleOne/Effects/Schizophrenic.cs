using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	[CreateAssetMenu(fileName = "Schizophrenic", menuName = "Properties/Schizophrenic Property")]
	public class Schizophrenic : Effect
	{
		// Token: 0x060057A0 RID: 22432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x9A2BE0", Offset = "0x9A1DE0", VA = "0x1809A2BE0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x9A2CC0", Offset = "0x9A1EC0", VA = "0x1809A2CC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x9A3000", Offset = "0x9A2200", VA = "0x1809A3000", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x9A3080", Offset = "0x9A2280", VA = "0x1809A3080", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Schizophrenic()
		{
		}
	}
}
