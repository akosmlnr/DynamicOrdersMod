using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	[CreateAssetMenu(fileName = "Seizure", menuName = "Properties/Seizure Property")]
	public class Seizure : Effect
	{
		// Token: 0x060057AC RID: 22444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x9A38A0", Offset = "0x9A2AA0", VA = "0x1809A38A0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x9A3A40", Offset = "0x9A2C40", VA = "0x1809A3A40", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x9A3B80", Offset = "0x9A2D80", VA = "0x1809A3B80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x9A3BC0", Offset = "0x9A2DC0", VA = "0x1809A3BC0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Seizure()
		{
		}

		// Token: 0x04003A3F RID: 14911
		[Token(Token = "0x4003A3F")]
		public const float CAMERA_JITTER_INTENSITY = 1f;

		// Token: 0x04003A40 RID: 14912
		[Token(Token = "0x4003A40")]
		public const float DURATION_NPC = 60f;

		// Token: 0x04003A41 RID: 14913
		[Token(Token = "0x4003A41")]
		public const float DURATION_PLAYER = 30f;
	}
}
