using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	[CreateAssetMenu(fileName = "UmbrellaData", menuName = "ScheduleOne/Equipping/Umbrella")]
	public class EquippableUmbrellaData : EquippableData
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x84FCF0", Offset = "0x84EEF0", VA = "0x18084FCF0")]
		public EquippableUmbrellaData()
		{
		}

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x38")]
		public Gradient CanopyColor;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x40")]
		[Header("Canopy Decal")]
		public Texture2D CanopyDecal;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x48")]
		public Color CanopyDecalColor;
	}
}
