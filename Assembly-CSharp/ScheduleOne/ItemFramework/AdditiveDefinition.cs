using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	[CreateAssetMenu(fileName = "AdditiveDefinition", menuName = "ScriptableObjects/Item Definitions/AdditiveDefinition", order = 1)]
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B6")]
		public Material DisplayMaterial
		{
			[Token(Token = "0x600267C")]
			[Address(RVA = "0x4B4780", Offset = "0x4B3980", VA = "0x1804B4780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600267D")]
			[Address(RVA = "0x4B52C0", Offset = "0x4B44C0", VA = "0x1804B52C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0000C798 File Offset: 0x0000A998
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B7")]
		public float QualityChange
		{
			[Token(Token = "0x600267E")]
			[Address(RVA = "0x6B9990", Offset = "0x6B8B90", VA = "0x1806B9990")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600267F")]
			[Address(RVA = "0x6B99B0", Offset = "0x6B8BB0", VA = "0x1806B99B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B8")]
		public float YieldMultiplier
		{
			[Token(Token = "0x6002680")]
			[Address(RVA = "0x4E7240", Offset = "0x4E6440", VA = "0x1804E7240")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002681")]
			[Address(RVA = "0x4E73D0", Offset = "0x4E65D0", VA = "0x1804E73D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B9")]
		public float InstantGrowth
		{
			[Token(Token = "0x6002682")]
			[Address(RVA = "0x5256E0", Offset = "0x5248E0", VA = "0x1805256E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002683")]
			[Address(RVA = "0x6B99A0", Offset = "0x6B8BA0", VA = "0x1806B99A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x6B9960", Offset = "0x6B8B60", VA = "0x1806B9960", Slot = "4")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x6B9970", Offset = "0x6B8B70", VA = "0x1806B9970")]
		public AdditiveDefinition()
		{
		}
	}
}
