using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x2000B83")]
	[CreateAssetMenu(fileName = "Sneaky", menuName = "Properties/Sneaky Property")]
	public class Sneaky : Effect
	{
		// Token: 0x060057D0 RID: 22480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D0")]
		[Address(RVA = "0x9A4120", Offset = "0x9A3320", VA = "0x1809A4120", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D1")]
		[Address(RVA = "0x9A4160", Offset = "0x9A3360", VA = "0x1809A4160", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D2")]
		[Address(RVA = "0x9A4390", Offset = "0x9A3590", VA = "0x1809A4390", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x9A43D0", Offset = "0x9A35D0", VA = "0x1809A43D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D4")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Sneaky()
		{
		}

		// Token: 0x04003A4C RID: 14924
		[Token(Token = "0x4003A4C")]
		public const float SPEED_MULTIPLIER = 0.85f;

		// Token: 0x04003A4D RID: 14925
		[Token(Token = "0x4003A4D")]
		public const float FOOTSTEP_VOL_MULTIPLIER = 0.4f;

		// Token: 0x04003A4E RID: 14926
		[Token(Token = "0x4003A4E")]
		[FieldOffset(Offset = "0x78")]
		private VisibilityAttribute visibilityAttribute;
	}
}
