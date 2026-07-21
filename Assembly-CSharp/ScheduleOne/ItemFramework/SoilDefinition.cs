using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	[CreateAssetMenu(fileName = "SoilDefinition", menuName = "ScriptableObjects/Item Definitions/SoilDefinition", order = 1)]
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x6CD080", Offset = "0x6CC280", VA = "0x1806CD080")]
		public SoilDefinition()
		{
		}

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[FieldOffset(Offset = "0xB8")]
		public SoilDefinition.ESoilQuality SoilQuality;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[FieldOffset(Offset = "0xC0")]
		public Material DrySoilMat;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[FieldOffset(Offset = "0xC8")]
		public Material WetSoilMat;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0xD0")]
		public Color ParticleColor;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0xE0")]
		public int Uses;

		// Token: 0x02000615 RID: 1557
		[Token(Token = "0x2000615")]
		public enum ESoilQuality
		{
			// Token: 0x04001E30 RID: 7728
			[Token(Token = "0x4001E30")]
			Basic,
			// Token: 0x04001E31 RID: 7729
			[Token(Token = "0x4001E31")]
			Premium
		}
	}
}
