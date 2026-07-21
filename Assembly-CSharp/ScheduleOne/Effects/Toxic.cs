using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x2000B86")]
	[CreateAssetMenu(fileName = "Toxic", menuName = "Properties/Toxic Property")]
	public class Toxic : Effect
	{
		// Token: 0x060057DF RID: 22495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0x9A4CF0", Offset = "0x9A3EF0", VA = "0x1809A4CF0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x9A4DB0", Offset = "0x9A3FB0", VA = "0x1809A4DB0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E1")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x9A4F40", Offset = "0x9A4140", VA = "0x1809A4F40", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057E3")]
		[Address(RVA = "0x98FC30", Offset = "0x98EE30", VA = "0x18098FC30")]
		public Toxic()
		{
		}

		// Token: 0x04003A50 RID: 14928
		[Token(Token = "0x4003A50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
