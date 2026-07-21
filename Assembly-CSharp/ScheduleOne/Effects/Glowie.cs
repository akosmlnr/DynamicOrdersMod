using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B72 RID: 2930
	[Token(Token = "0x2000B72")]
	[CreateAssetMenu(fileName = "Glowie", menuName = "Properties/Glowie Property")]
	public class Glowie : Effect
	{
		// Token: 0x0600577D RID: 22397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577D")]
		[Address(RVA = "0x99D020", Offset = "0x99C220", VA = "0x18099D020", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577E")]
		[Address(RVA = "0x99D070", Offset = "0x99C270", VA = "0x18099D070", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577F")]
		[Address(RVA = "0x99D0C0", Offset = "0x99C2C0", VA = "0x18099D0C0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005780")]
		[Address(RVA = "0x99D100", Offset = "0x99C300", VA = "0x18099D100", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005781")]
		[Address(RVA = "0x98FC30", Offset = "0x98EE30", VA = "0x18098FC30")]
		public Glowie()
		{
		}

		// Token: 0x04003A3B RID: 14907
		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x78")]
		[ColorUsage(true, true)]
		[SerializeField]
		public Color GlowColor;
	}
}
