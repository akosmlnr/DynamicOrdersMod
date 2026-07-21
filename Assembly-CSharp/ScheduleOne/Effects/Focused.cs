using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6E RID: 2926
	[Token(Token = "0x2000B6E")]
	[CreateAssetMenu(fileName = "Focused", menuName = "Properties/Focused Property")]
	public class Focused : Effect
	{
		// Token: 0x06005766 RID: 22374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005766")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005767")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005768")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005769")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576A")]
		[Address(RVA = "0x99CA20", Offset = "0x99BC20", VA = "0x18099CA20", Slot = "8")]
		protected override void ApplyToEmployee(Employee employee)
		{
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576B")]
		[Address(RVA = "0x98F850", Offset = "0x98EA50", VA = "0x18098F850", Slot = "9")]
		protected override void ClearFromEmployee(Employee employee)
		{
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576C")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Focused()
		{
		}

		// Token: 0x04003A39 RID: 14905
		[Token(Token = "0x4003A39")]
		public const float WorkSpeedMultiplier = 1.3f;
	}
}
