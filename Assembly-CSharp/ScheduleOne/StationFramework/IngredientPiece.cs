using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	[RequireComponent(typeof(Draggable))]
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003CA6 RID: 15526 RVA: 0x00011850 File Offset: 0x0000FA50
		// (set) Token: 0x06003CA7 RID: 15527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097D")]
		public float CurrentDissolveAmount
		{
			[Token(Token = "0x6003CA6")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003CA7")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097E")]
		public LiquidContainer CurrentLiquidContainer
		{
			[Token(Token = "0x6003CA8")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CA9")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x816DB0", Offset = "0x815FB0", VA = "0x180816DB0")]
		private void Start()
		{
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x817100", Offset = "0x816300", VA = "0x180817100")]
		private void Update()
		{
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x816DA0", Offset = "0x815FA0", VA = "0x180816DA0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x816EB0", Offset = "0x8160B0", VA = "0x180816EB0")]
		private void UpdateDrag()
		{
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x816A50", Offset = "0x815C50", VA = "0x180816A50")]
		private void CheckLiquid()
		{
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x816BE0", Offset = "0x815DE0", VA = "0x180816BE0")]
		public void DissolveAmount(float amount, bool showParticles = true)
		{
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x817180", Offset = "0x816380", VA = "0x180817180")]
		public IngredientPiece()
		{
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x816E40", Offset = "0x816040", VA = "0x180816E40")]
		[CompilerGenerated]
		private IEnumerator <DissolveAmount>g__DissolveParticlesRoutine|22_0()
		{
			return null;
		}

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		public const float LIQUID_FRICTION = 100f;

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform ModelContainer;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem DissolveParticles;

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public bool DetectLiquid;

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x41")]
		public bool DisableInteractionInLiquid;

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 2f)]
		public float LiquidFrictionMultiplier;

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		[FieldOffset(Offset = "0x48")]
		private Draggable draggable;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x50")]
		private float defaultDrag;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine dissolveParticleRoutine;
	}
}
