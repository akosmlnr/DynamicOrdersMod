using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	[CreateAssetMenu(fileName = "Spicy", menuName = "Properties/Spicy Property")]
	public class Spicy : Effect
	{
		// Token: 0x060057D5 RID: 22485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D5")]
		[Address(RVA = "0x9A4560", Offset = "0x9A3760", VA = "0x1809A4560", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D6")]
		[Address(RVA = "0x9A45A0", Offset = "0x9A37A0", VA = "0x1809A45A0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D7")]
		[Address(RVA = "0x9A46E0", Offset = "0x9A38E0", VA = "0x1809A46E0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D8")]
		[Address(RVA = "0x9A4720", Offset = "0x9A3920", VA = "0x1809A4720", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D9")]
		[Address(RVA = "0x98FC30", Offset = "0x98EE30", VA = "0x18098FC30")]
		public Spicy()
		{
		}

		// Token: 0x04003A4F RID: 14927
		[Token(Token = "0x4003A4F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
