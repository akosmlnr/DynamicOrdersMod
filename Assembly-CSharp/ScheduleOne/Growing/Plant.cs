using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	public abstract class Plant : MonoBehaviour
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000943")]
		public Pot Pot
		{
			[Token(Token = "0x6003B30")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B31")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x00011310 File Offset: 0x0000F510
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000944")]
		public float NormalizedGrowthProgress
		{
			[Token(Token = "0x6003B32")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B33")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x17000945")]
		public bool IsFullyGrown
		{
			[Token(Token = "0x6003B34")]
			[Address(RVA = "0x819EB0", Offset = "0x8190B0", VA = "0x180819EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x00011340 File Offset: 0x0000F540
		// (set) Token: 0x06003B36 RID: 15158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000946")]
		public float YieldMultiplier
		{
			[Token(Token = "0x6003B35")]
			[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B36")]
			[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x00011358 File Offset: 0x0000F558
		// (set) Token: 0x06003B38 RID: 15160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000947")]
		public float QualityLevel
		{
			[Token(Token = "0x6003B37")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B38")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000948")]
		public PlantGrowthStage FinalGrowthStage
		{
			[Token(Token = "0x6003B39")]
			[Address(RVA = "0x819E70", Offset = "0x819070", VA = "0x180819E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x818FD0", Offset = "0x8181D0", VA = "0x180818FD0", Slot = "4")]
		public virtual void Initialize(NetworkObject pot, float growthProgress)
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x8191E0", Offset = "0x8183E0", VA = "0x1808191E0", Slot = "5")]
		public virtual void MinPass(int mins)
		{
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x818930", Offset = "0x817B30", VA = "0x180818930")]
		public void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication)
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x819AE0", Offset = "0x818CE0", VA = "0x180819AE0", Slot = "6")]
		public virtual void SetNormalizedGrowthProgress(float progress)
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x819C90", Offset = "0x818E90", VA = "0x180819C90", Slot = "7")]
		protected virtual void UpdateVisuals()
		{
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x819950", Offset = "0x818B50", VA = "0x180819950", Slot = "8")]
		public virtual void SetHarvestableActive(int index, bool active)
		{
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x819390", Offset = "0x818590", VA = "0x180819390")]
		private void OnFullyHarvested()
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x819180", Offset = "0x818380", VA = "0x180819180")]
		public bool IsHarvestableActive(int index)
		{
			return default(bool);
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x818D30", Offset = "0x817F30", VA = "0x180818D30")]
		private void GrowthDone()
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x8189C0", Offset = "0x817BC0", VA = "0x1808189C0")]
		private List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			return null;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x819C50", Offset = "0x818E50", VA = "0x180819C50")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x819840", Offset = "0x818A40", VA = "0x180819840")]
		private void ResizeCollider()
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x818C10", Offset = "0x817E10", VA = "0x180818C10", Slot = "9")]
		public virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x818C70", Offset = "0x817E70", VA = "0x180818C70")]
		public PlantData GetPlantData()
		{
			return null;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x819D90", Offset = "0x818F90", VA = "0x180819D90")]
		protected Plant()
		{
		}

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		public const float BaseQualityLevel = 0.5f;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform VisualsContainer;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x40")]
		public PlantGrowthStage[] GrowthStages;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x48")]
		public Collider Collider;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController SnipSound;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController DestroySound;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x60")]
		public ParticleSystem FullyGrownParticles;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x68")]
		public Transform HarvestLabelPositionTransform;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x70")]
		[Header("Settings")]
		public SeedDefinition SeedDefinition;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x78")]
		public int GrowthTime;

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x7C")]
		public int BaseYieldQuantity;

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		[FieldOffset(Offset = "0x80")]
		public string HarvestTarget;

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x88")]
		public float MinColliderScale;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0x8C")]
		public float ColliderScaleThreshold;

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x90")]
		[Header("Trash")]
		public TrashItem PlantScrapPrefab;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public List<int> ActiveHarvestables;

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0xA0")]
		public Action onFullyHarvested;
	}
}
