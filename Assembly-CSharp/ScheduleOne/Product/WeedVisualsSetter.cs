using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public class WeedVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06003F8A RID: 16266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x86C420", Offset = "0x86B620", VA = "0x18086C420", Slot = "4")]
		public override void ApplyVisuals(ProductDefinition definition)
		{
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x86C7E0", Offset = "0x86B9E0", VA = "0x18086C7E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WeedVisualsSetter()
		{
		}

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x28")]
		public WeedVisualsSetter.MeshMaterialSettings[] Meshes;

		// Token: 0x02000941 RID: 2369
		[Token(Token = "0x2000941")]
		[Serializable]
		public class MeshMaterialSettings
		{
			// Token: 0x06003F8D RID: 16269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F8D")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public MeshMaterialSettings()
			{
			}

			// Token: 0x04002E32 RID: 11826
			[Token(Token = "0x4002E32")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Mesh;

			// Token: 0x04002E33 RID: 11827
			[Token(Token = "0x4002E33")]
			[FieldOffset(Offset = "0x18")]
			public List<WeedAppearanceSettings.EWeedAppearanceType> Materials;
		}
	}
}
