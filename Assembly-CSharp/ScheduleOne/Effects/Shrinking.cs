using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	[CreateAssetMenu(fileName = "Shrinking", menuName = "Properties/Shrinking Property")]
	public class Shrinking : Effect
	{
		// Token: 0x060057C1 RID: 22465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x9A3BE0", Offset = "0x9A2DE0", VA = "0x1809A3BE0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x9A3C30", Offset = "0x9A2E30", VA = "0x1809A3C30", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x9A3C60", Offset = "0x9A2E60", VA = "0x1809A3C60", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x9A3CB0", Offset = "0x9A2EB0", VA = "0x1809A3CB0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Shrinking()
		{
		}

		// Token: 0x04003A4A RID: 14922
		[Token(Token = "0x4003A4A")]
		public const float Scale = 0.8f;

		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		public const float LerpTime = 1f;
	}
}
