using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	[CreateAssetMenu(fileName = "Disorienting", menuName = "Properties/Disorienting Property")]
	public class Disorienting : Effect
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x993FB0", Offset = "0x9931B0", VA = "0x180993FB0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005749")]
		[Address(RVA = "0x994090", Offset = "0x993290", VA = "0x180994090", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574A")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574B")]
		[Address(RVA = "0x994310", Offset = "0x993510", VA = "0x180994310", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574C")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Disorienting()
		{
		}
	}
}
