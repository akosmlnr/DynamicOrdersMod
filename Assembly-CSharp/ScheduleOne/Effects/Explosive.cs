using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	[CreateAssetMenu(fileName = "Explosive", menuName = "Properties/Explosive Property")]
	public class Explosive : Effect
	{
		// Token: 0x06005761 RID: 22369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005761")]
		[Address(RVA = "0x99C920", Offset = "0x99BB20", VA = "0x18099C920", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005762")]
		[Address(RVA = "0x99C960", Offset = "0x99BB60", VA = "0x18099C960", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005763")]
		[Address(RVA = "0x99C9A0", Offset = "0x99BBA0", VA = "0x18099C9A0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005764")]
		[Address(RVA = "0x99C9E0", Offset = "0x99BBE0", VA = "0x18099C9E0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005765")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Explosive()
		{
		}
	}
}
