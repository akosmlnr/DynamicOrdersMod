using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	[CreateAssetMenu(fileName = "Athletic", menuName = "Properties/Athletic Property")]
	public class Athletic : Effect
	{
		// Token: 0x06005728 RID: 22312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005728")]
		[Address(RVA = "0x98F3C0", Offset = "0x98E5C0", VA = "0x18098F3C0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005729")]
		[Address(RVA = "0x98F460", Offset = "0x98E660", VA = "0x18098F460", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572A")]
		[Address(RVA = "0x98F880", Offset = "0x98EA80", VA = "0x18098F880", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572B")]
		[Address(RVA = "0x98F900", Offset = "0x98EB00", VA = "0x18098F900", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572C")]
		[Address(RVA = "0x98F310", Offset = "0x98E510", VA = "0x18098F310", Slot = "8")]
		protected override void ApplyToEmployee(Employee employee)
		{
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572D")]
		[Address(RVA = "0x98F850", Offset = "0x98EA50", VA = "0x18098F850", Slot = "9")]
		protected override void ClearFromEmployee(Employee employee)
		{
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572E")]
		[Address(RVA = "0x98FC30", Offset = "0x98EE30", VA = "0x18098FC30")]
		public Athletic()
		{
		}

		// Token: 0x04003A2F RID: 14895
		[Token(Token = "0x4003A2F")]
		public const float SPEED_MULTIPLIER = 1.3f;

		// Token: 0x04003A30 RID: 14896
		[Token(Token = "0x4003A30")]
		public const float NPC_SPEED_MULTIPLIER = 1.8f;

		// Token: 0x04003A31 RID: 14897
		[Token(Token = "0x4003A31")]
		public const float WorkSpeedMultiplier = 1.05f;

		// Token: 0x04003A32 RID: 14898
		[Token(Token = "0x4003A32")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
