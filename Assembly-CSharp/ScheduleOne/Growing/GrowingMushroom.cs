using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	public class GrowingMushroom : MonoBehaviour
	{
		// Token: 0x06003B25 RID: 15141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x816740", Offset = "0x815940", VA = "0x180816740")]
		public void Initialize(ShroomColony parentColony, int alignmentIndex)
		{
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x816770", Offset = "0x815970", VA = "0x180816770")]
		public void SetGrowthPercent(float percent)
		{
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x816310", Offset = "0x815510", VA = "0x180816310")]
		[Button]
		public void Harvest()
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x816930", Offset = "0x815B30", VA = "0x180816930")]
		public GrowingMushroom()
		{
		}

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		private const float CapExpansionThreshold = 0.5f;

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float LateralScaleMultiplier;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public float VerticalScaleMultiplier;

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float MaxCapExpansion;

		// Token: 0x04002BB7 RID: 11191
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _modelContainer;

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkinnedMeshRenderer[] _meshRenderers;

		// Token: 0x04002BB9 RID: 11193
		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioSourceController _harvestSound;

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x48")]
		private ShroomColony _parentColony;

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x50")]
		private int _alignmentIndex;
	}
}
