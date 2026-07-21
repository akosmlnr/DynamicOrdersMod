using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Product;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200094A RID: 2378
	[Token(Token = "0x200094A")]
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x000121F8 File Offset: 0x000103F8
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EB")]
		public bool IsDrinking
		{
			[Token(Token = "0x6003FB2")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FB3")]
			[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x8522B0", Offset = "0x8514B0", VA = "0x1808522B0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x8521C0", Offset = "0x8513C0", VA = "0x1808521C0")]
		public void Drink()
		{
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x851D90", Offset = "0x850F90", VA = "0x180851D90")]
		public void ApplyEffects()
		{
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x8523E0", Offset = "0x8515E0", VA = "0x1808523E0")]
		public Equippable_Cuke()
		{
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x852240", Offset = "0x851440", VA = "0x180852240")]
		[CompilerGenerated]
		private IEnumerator <Drink>g__DrinkRoutine|17_0()
		{
			return null;
		}

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x64")]
		[Header("Settings")]
		public float BaseEnergyGain;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x68")]
		public float MinEnergyGain;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x6C")]
		public float ConsecutiveReduction;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x70")]
		public float HealthGain;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x74")]
		public float AnimationDuration;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x78")]
		public bool ClearDrugEffects;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x80")]
		public ProductDefinition PseudoProduct;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x88")]
		[Header("References")]
		public Animation OpenAnim;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x90")]
		public Animation DrinkAnim;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController OpenSound;

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0xA0")]
		public AudioSourceController SlurpSound;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0xA8")]
		public TrashItem TrashPrefab;
	}
}
