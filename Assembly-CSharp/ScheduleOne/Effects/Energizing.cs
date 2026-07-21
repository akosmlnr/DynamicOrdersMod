using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6B RID: 2923
	[Token(Token = "0x2000B6B")]
	[CreateAssetMenu(fileName = "Energizing", menuName = "Properties/Energizing Property")]
	public class Energizing : Effect
	{
		// Token: 0x06005755 RID: 22357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005755")]
		[Address(RVA = "0x995FC0", Offset = "0x9951C0", VA = "0x180995FC0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005756")]
		[Address(RVA = "0x996060", Offset = "0x995260", VA = "0x180996060", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005757")]
		[Address(RVA = "0x98F880", Offset = "0x98EA80", VA = "0x18098F880", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005758")]
		[Address(RVA = "0x996370", Offset = "0x995570", VA = "0x180996370", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005759")]
		[Address(RVA = "0x995F10", Offset = "0x995110", VA = "0x180995F10", Slot = "8")]
		protected override void ApplyToEmployee(Employee employee)
		{
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x98F850", Offset = "0x98EA50", VA = "0x18098F850", Slot = "9")]
		protected override void ClearFromEmployee(Employee employee)
		{
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Energizing()
		{
		}

		// Token: 0x04003A37 RID: 14903
		[Token(Token = "0x4003A37")]
		public const float SPEED_MULTIPLIER = 1.15f;

		// Token: 0x04003A38 RID: 14904
		[Token(Token = "0x4003A38")]
		public const float WorkSpeedMultiplier = 1.15f;
	}
}
