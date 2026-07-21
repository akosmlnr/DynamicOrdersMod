using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x2000B65")]
	[CreateAssetMenu(fileName = "BrightEyed", menuName = "Properties/BrightEyed Property")]
	public class BrightEyed : Effect
	{
		// Token: 0x06005734 RID: 22324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005734")]
		[Address(RVA = "0x990BE0", Offset = "0x98FDE0", VA = "0x180990BE0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005735")]
		[Address(RVA = "0x990C90", Offset = "0x98FE90", VA = "0x180990C90", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005736")]
		[Address(RVA = "0x990D40", Offset = "0x98FF40", VA = "0x180990D40", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005737")]
		[Address(RVA = "0x990DD0", Offset = "0x98FFD0", VA = "0x180990DD0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005738")]
		[Address(RVA = "0x990E60", Offset = "0x990060", VA = "0x180990E60")]
		public BrightEyed()
		{
		}

		// Token: 0x04003A33 RID: 14899
		[Token(Token = "0x4003A33")]
		[FieldOffset(Offset = "0x78")]
		public Color EyeColor;

		// Token: 0x04003A34 RID: 14900
		[Token(Token = "0x4003A34")]
		[FieldOffset(Offset = "0x88")]
		public float Emission;

		// Token: 0x04003A35 RID: 14901
		[Token(Token = "0x4003A35")]
		[FieldOffset(Offset = "0x8C")]
		public float LightIntensity;
	}
}
