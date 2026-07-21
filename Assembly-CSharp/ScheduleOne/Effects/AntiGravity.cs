using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	[CreateAssetMenu(fileName = "AntiGravity", menuName = "Properties/AntiGravity Property")]
	public class AntiGravity : Effect
	{
		// Token: 0x06005723 RID: 22307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005723")]
		[Address(RVA = "0x98F180", Offset = "0x98E380", VA = "0x18098F180", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005724")]
		[Address(RVA = "0x98F1E0", Offset = "0x98E3E0", VA = "0x18098F1E0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005725")]
		[Address(RVA = "0x98F240", Offset = "0x98E440", VA = "0x18098F240", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005726")]
		[Address(RVA = "0x98F2A0", Offset = "0x98E4A0", VA = "0x18098F2A0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005727")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public AntiGravity()
		{
		}

		// Token: 0x04003A2E RID: 14894
		[Token(Token = "0x4003A2E")]
		public const float GravityMultiplier = 0.3f;
	}
}
