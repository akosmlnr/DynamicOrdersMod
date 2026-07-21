using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000933 RID: 2355
	[Token(Token = "0x2000933")]
	[Serializable]
	public class ShroomAppearanceSettings
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x00012108 File Offset: 0x00010308
		// (set) Token: 0x06003F48 RID: 16200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		public Color32 PrimaryColor
		{
			[Token(Token = "0x6003F47")]
			[Address(RVA = "0x43D220", Offset = "0x43C420", VA = "0x18043D220")]
			[CompilerGenerated]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6003F48")]
			[Address(RVA = "0x48AD80", Offset = "0x489F80", VA = "0x18048AD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06003F49 RID: 16201 RVA: 0x00012120 File Offset: 0x00010320
		// (set) Token: 0x06003F4A RID: 16202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DF")]
		public Color32 SecondaryColor
		{
			[Token(Token = "0x6003F49")]
			[Address(RVA = "0x496FC0", Offset = "0x4961C0", VA = "0x180496FC0")]
			[CompilerGenerated]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6003F4A")]
			[Address(RVA = "0x6BB860", Offset = "0x6BAA60", VA = "0x1806BB860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x00012138 File Offset: 0x00010338
		// (set) Token: 0x06003F4C RID: 16204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		public bool HasSpots
		{
			[Token(Token = "0x6003F4B")]
			[Address(RVA = "0x4956E0", Offset = "0x4948E0", VA = "0x1804956E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F4C")]
			[Address(RVA = "0x693AE0", Offset = "0x692CE0", VA = "0x180693AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x00012150 File Offset: 0x00010350
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E1")]
		public Color32 SpotsColor
		{
			[Token(Token = "0x6003F4D")]
			[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500")]
			[CompilerGenerated]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6003F4E")]
			[Address(RVA = "0x4A0510", Offset = "0x49F710", VA = "0x1804A0510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x865270", Offset = "0x864470", VA = "0x180865270")]
		public ShroomAppearanceSettings(Color32 primary, Color32 secondary, bool hasSpots, Color32 spotsColor)
		{
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ShroomAppearanceSettings()
		{
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x82AB20", Offset = "0x829D20", VA = "0x18082AB20")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color32 DefaultPrimaryColor;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color32 DefaultSecondaryColor;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Color32 DefaultSpotsColor;
	}
}
