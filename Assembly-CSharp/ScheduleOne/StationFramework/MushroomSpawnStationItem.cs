using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008EE RID: 2286
	[Token(Token = "0x20008EE")]
	public class MushroomSpawnStationItem : StationItem
	{
		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A6")]
		public Collider InjectionPortCollider
		{
			[Token(Token = "0x6003D51")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D52")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x82F230", Offset = "0x82E430", VA = "0x18082F230", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x82F450", Offset = "0x82E650", VA = "0x18082F450")]
		public void SetInocculationAmount(float amount)
		{
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x82F430", Offset = "0x82E630", VA = "0x18082F430")]
		public void SetInjectionPortHighlightActive(bool active)
		{
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x817C60", Offset = "0x816E60", VA = "0x180817C60")]
		public MushroomSpawnStationItem()
		{
		}

		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer[] _renderers;

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _materialIndex;

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _injectionPortHighlight;
	}
}
