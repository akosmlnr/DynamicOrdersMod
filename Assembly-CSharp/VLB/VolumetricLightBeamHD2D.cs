using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	[SelectionBase]
	public class VolumetricLightBeamHD2D : VolumetricLightBeamHD
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public int sortingLayerID
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x4F0940", Offset = "0x4EFB40", VA = "0x1804F0940")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x69EA60", Offset = "0x69DC60", VA = "0x18069EA60")]
			set
			{
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D0")]
		public string sortingLayerName
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x69EA50", Offset = "0x69DC50", VA = "0x18069EA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x69EAF0", Offset = "0x69DCF0", VA = "0x18069EAF0")]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public int sortingOrder
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x69E8F0", Offset = "0x69DAF0", VA = "0x18069E8F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x69EB90", Offset = "0x69DD90", VA = "0x18069EB90")]
			set
			{
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "8")]
		public override Dimensions GetDimensions()
		{
			return Dimensions.Dim3D;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "9")]
		public override bool DoesSupportSorting2D()
		{
			return default(bool);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4F0940", Offset = "0x4EFB40", VA = "0x1804F0940", Slot = "10")]
		public override int GetSortingLayerID()
		{
			return 0;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x69E8F0", Offset = "0x69DAF0", VA = "0x18069E8F0", Slot = "11")]
		public override int GetSortingOrder()
		{
			return 0;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x69E900", Offset = "0x69DB00", VA = "0x18069E900")]
		public VolumetricLightBeamHD2D()
		{
		}

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int m_SortingLayerID;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private int m_SortingOrder;
	}
}
