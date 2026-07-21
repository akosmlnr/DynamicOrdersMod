using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200093D RID: 2365
	[Token(Token = "0x200093D")]
	public class ShroomVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06003F87 RID: 16263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x8675B0", Offset = "0x8667B0", VA = "0x1808675B0", Slot = "4")]
		public override void ApplyVisuals(ProductDefinition definition)
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ShroomVisualsSetter()
		{
		}

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ShroomVisualsSetter.MeshMaterialSettings[] _meshes;

		// Token: 0x0200093E RID: 2366
		[Token(Token = "0x200093E")]
		protected enum EShroomMaterialType
		{
			// Token: 0x04002E2D RID: 11821
			[Token(Token = "0x4002E2D")]
			Mushroom,
			// Token: 0x04002E2E RID: 11822
			[Token(Token = "0x4002E2E")]
			Bulk
		}

		// Token: 0x0200093F RID: 2367
		[Token(Token = "0x200093F")]
		[Serializable]
		protected class MeshMaterialSettings
		{
			// Token: 0x06003F89 RID: 16265 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F89")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public MeshMaterialSettings()
			{
			}

			// Token: 0x04002E2F RID: 11823
			[Token(Token = "0x4002E2F")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Mesh;

			// Token: 0x04002E30 RID: 11824
			[Token(Token = "0x4002E30")]
			[FieldOffset(Offset = "0x18")]
			public List<ShroomVisualsSetter.EShroomMaterialType> Materials;
		}
	}
}
