using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using LiquidVolumeFX;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003CBE RID: 15550 RVA: 0x00011898 File Offset: 0x0000FA98
		// (set) Token: 0x06003CBF RID: 15551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000983")]
		public float CurrentLiquidLevel
		{
			[Token(Token = "0x6003CBE")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003CBF")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x000118B0 File Offset: 0x0000FAB0
		// (set) Token: 0x06003CC1 RID: 15553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000984")]
		public Color LiquidColor
		{
			[Token(Token = "0x6003CC0")]
			[Address(RVA = "0x58D070", Offset = "0x58C270", VA = "0x18058D070")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003CC1")]
			[Address(RVA = "0x58D230", Offset = "0x58C430", VA = "0x18058D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x8171C0", Offset = "0x8163C0", VA = "0x1808171C0")]
		private void Awake()
		{
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x8177F0", Offset = "0x8169F0", VA = "0x1808177F0")]
		private void Start()
		{
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x817280", Offset = "0x816480", VA = "0x180817280")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x817270", Offset = "0x816470", VA = "0x180817270")]
		private void MinPass()
		{
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x817960", Offset = "0x816B60", VA = "0x180817960")]
		private void UpdateLighting()
		{
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x817430", Offset = "0x816630", VA = "0x180817430")]
		public void SetLiquidLevel(float level, bool debug = false)
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x8173A0", Offset = "0x8165A0", VA = "0x1808173A0")]
		public void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x817AB0", Offset = "0x816CB0", VA = "0x180817AB0")]
		public LiquidContainer()
		{
		}

		// Token: 0x04002C9C RID: 11420
		[Token(Token = "0x4002C9C")]
		[FieldOffset(Offset = "0x34")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Viscosity;

		// Token: 0x04002C9D RID: 11421
		[Token(Token = "0x4002C9D")]
		[FieldOffset(Offset = "0x38")]
		public bool AdjustMurkiness;

		// Token: 0x04002C9E RID: 11422
		[Token(Token = "0x4002C9E")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public LiquidVolume LiquidVolume;

		// Token: 0x04002C9F RID: 11423
		[Token(Token = "0x4002C9F")]
		[FieldOffset(Offset = "0x48")]
		public LiquidVolumeCollider Collider;

		// Token: 0x04002CA0 RID: 11424
		[Token(Token = "0x4002CA0")]
		[FieldOffset(Offset = "0x50")]
		public Transform ColliderTransform_Min;

		// Token: 0x04002CA1 RID: 11425
		[Token(Token = "0x4002CA1")]
		[FieldOffset(Offset = "0x58")]
		public Transform ColliderTransform_Max;

		// Token: 0x04002CA2 RID: 11426
		[Token(Token = "0x4002CA2")]
		[FieldOffset(Offset = "0x60")]
		[Header("Visuals Settings")]
		public float MaxLevel;

		// Token: 0x04002CA3 RID: 11427
		[Token(Token = "0x4002CA3")]
		[FieldOffset(Offset = "0x68")]
		private MeshRenderer liquidMesh;
	}
}
