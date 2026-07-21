using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2000925")]
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009D9")]
		public string ConsumeDescription
		{
			[Token(Token = "0x6003F15")]
			[Address(RVA = "0x864080", Offset = "0x863280", VA = "0x180864080")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x170009DA")]
		public float PrepareDuration
		{
			[Token(Token = "0x6003F16")]
			[Address(RVA = "0x8640C0", Offset = "0x8632C0", VA = "0x1808640C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x170009DB")]
		public float EffectsApplyDelay
		{
			[Token(Token = "0x6003F17")]
			[Address(RVA = "0x8640A0", Offset = "0x8632A0", VA = "0x1808640A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x8633D0", Offset = "0x8625D0", VA = "0x1808633D0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x863240", Offset = "0x862440", VA = "0x180863240", Slot = "9")]
		protected virtual void ApplyProductVisuals(ProductItemInstance product)
		{
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x863AF0", Offset = "0x862CF0", VA = "0x180863AF0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x863BC0", Offset = "0x862DC0", VA = "0x180863BC0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x863A00", Offset = "0x862C00", VA = "0x180863A00", Slot = "10")]
		protected virtual void StartPrepare()
		{
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0x863260", Offset = "0x862460", VA = "0x180863260", Slot = "11")]
		protected virtual void CancelPrepare()
		{
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x8632E0", Offset = "0x8624E0", VA = "0x1808632E0", Slot = "12")]
		protected virtual void Consume()
		{
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0x863180", Offset = "0x862380", VA = "0x180863180", Slot = "13")]
		protected virtual void ApplyEffects()
		{
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x863FE0", Offset = "0x8631E0", VA = "0x180863FE0")]
		public Product_Equippable()
		{
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x863A80", Offset = "0x862C80", VA = "0x180863A80")]
		[CompilerGenerated]
		private IEnumerator <Consume>g__ConsumeRoutine|21_0()
		{
			return null;
		}

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public ProductVisualsSetter Visuals;

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x68")]
		public Transform ModelContainer;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x70")]
		private ProductConsumeAnimation consumeAnimation;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x78")]
		private bool isConsumable;

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x7C")]
		private float consumeTime;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[FieldOffset(Offset = "0x80")]
		private bool consumingInProgress;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 defaultModelPosition;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine consumeRoutine;

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x98")]
		private bool mouseUp;
	}
}
