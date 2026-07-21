using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	[CreateAssetMenu(fileName = "Lethal", menuName = "Properties/Lethal Property")]
	public class Lethal : Effect
	{
		// Token: 0x0600578C RID: 22412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578C")]
		[Address(RVA = "0x99D3D0", Offset = "0x99C5D0", VA = "0x18099D3D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578D")]
		[Address(RVA = "0x99D4D0", Offset = "0x99C6D0", VA = "0x18099D4D0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578E")]
		[Address(RVA = "0x99D710", Offset = "0x99C910", VA = "0x18099D710", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578F")]
		[Address(RVA = "0x99D7D0", Offset = "0x99C9D0", VA = "0x18099D7D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005790")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Lethal()
		{
		}

		// Token: 0x04003A3C RID: 14908
		[Token(Token = "0x4003A3C")]
		public const float HEALTH_DRAIN_PLAYER = 15f;

		// Token: 0x04003A3D RID: 14909
		[Token(Token = "0x4003A3D")]
		public const float HEALTH_DRAIN_NPC = 15f;
	}
}
