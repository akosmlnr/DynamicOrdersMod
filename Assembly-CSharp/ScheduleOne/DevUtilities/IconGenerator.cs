using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x06004901 RID: 18689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x8F61C0", Offset = "0x8F53C0", VA = "0x1808F61C0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x8F6310", Offset = "0x8F5510", VA = "0x1808F6310")]
		[Button]
		public void GenerateIcon()
		{
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x8F65D0", Offset = "0x8F57D0", VA = "0x1808F65D0")]
		public Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			return null;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x8F6AF0", Offset = "0x8F5CF0", VA = "0x1808F6AF0")]
		public Texture2D GetTexture(Transform model)
		{
			return null;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x8F7000", Offset = "0x8F6200", VA = "0x1808F7000")]
		public IconGenerator()
		{
		}

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x28")]
		public int IconSize;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x30")]
		public string OutputPath;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x38")]
		public bool ModifyLighting;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Registry Registry;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x48")]
		public Camera CameraPosition;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x50")]
		public Transform MainContainer;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x58")]
		public Transform ItemContainer;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Canvas;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x68")]
		public List<IconGenerator.PackagingVisuals> Visuals;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x70")]
		public UniversalRendererData rendererData;

		// Token: 0x020009F8 RID: 2552
		[Token(Token = "0x20009F8")]
		[Serializable]
		public class PackagingVisuals
		{
			// Token: 0x06004906 RID: 18694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004906")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public PackagingVisuals()
			{
			}

			// Token: 0x040033B2 RID: 13234
			[Token(Token = "0x40033B2")]
			[FieldOffset(Offset = "0x10")]
			public string PackagingID;

			// Token: 0x040033B3 RID: 13235
			[Token(Token = "0x40033B3")]
			[FieldOffset(Offset = "0x18")]
			public MultiTypeVisualsSetter ProductVisuals;

			// Token: 0x040033B4 RID: 13236
			[Token(Token = "0x40033B4")]
			[FieldOffset(Offset = "0x20")]
			public Transform TopLevelTransform;
		}
	}
}
