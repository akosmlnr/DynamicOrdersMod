using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	[CreateAssetMenu(fileName = "Sedating", menuName = "Properties/Sedating Property")]
	public class Sedating : Effect
	{
		// Token: 0x060057A5 RID: 22437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x9A3400", Offset = "0x9A2600", VA = "0x1809A3400", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A6")]
		[Address(RVA = "0x9A3490", Offset = "0x9A2690", VA = "0x1809A3490", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A7")]
		[Address(RVA = "0x98F880", Offset = "0x98EA80", VA = "0x18098F880", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A8")]
		[Address(RVA = "0x9A36C0", Offset = "0x9A28C0", VA = "0x1809A36C0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x9A3350", Offset = "0x9A2550", VA = "0x1809A3350", Slot = "8")]
		protected override void ApplyToEmployee(Employee employee)
		{
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x98F850", Offset = "0x98EA50", VA = "0x18098F850", Slot = "9")]
		protected override void ClearFromEmployee(Employee employee)
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Sedating()
		{
		}

		// Token: 0x04003A3E RID: 14910
		[Token(Token = "0x4003A3E")]
		public const float WorkSpeedMultiplier = 0.8f;
	}
}
