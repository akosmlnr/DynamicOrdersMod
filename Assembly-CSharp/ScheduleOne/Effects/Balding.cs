using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B64 RID: 2916
	[Token(Token = "0x2000B64")]
	[CreateAssetMenu(fileName = "Balding", menuName = "Properties/Balding Property")]
	public class Balding : Effect
	{
		// Token: 0x0600572F RID: 22319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572F")]
		[Address(RVA = "0x98FC50", Offset = "0x98EE50", VA = "0x18098FC50", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005730")]
		[Address(RVA = "0x98FC90", Offset = "0x98EE90", VA = "0x18098FC90", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005731")]
		[Address(RVA = "0x98FCD0", Offset = "0x98EED0", VA = "0x18098FCD0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005732")]
		[Address(RVA = "0x98FD10", Offset = "0x98EF10", VA = "0x18098FD10", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005733")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Balding()
		{
		}
	}
}
