using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x2000B6A")]
	[CreateAssetMenu(fileName = "Electrifying", menuName = "Properties/Electrifying Property")]
	public class Electrifying : Effect
	{
		// Token: 0x0600574D RID: 22349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574D")]
		[Address(RVA = "0x995C90", Offset = "0x994E90", VA = "0x180995C90", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574E")]
		[Address(RVA = "0x995CF0", Offset = "0x994EF0", VA = "0x180995CF0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574F")]
		[Address(RVA = "0x995DA0", Offset = "0x994FA0", VA = "0x180995DA0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x995E30", Offset = "0x995030", VA = "0x180995E30", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005751")]
		[Address(RVA = "0x995B70", Offset = "0x994D70", VA = "0x180995B70")]
		public static void ApplyToAvatar(ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005752")]
		[Address(RVA = "0x995D50", Offset = "0x994F50", VA = "0x180995D50")]
		public static void ClearFromAvatar(ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005753")]
		[Address(RVA = "0x98F300", Offset = "0x98E500", VA = "0x18098F300")]
		public Electrifying()
		{
		}

		// Token: 0x04003A36 RID: 14902
		[Token(Token = "0x4003A36")]
		[FieldOffset(Offset = "0x0")]
		private static Color32 EyeColor;
	}
}
