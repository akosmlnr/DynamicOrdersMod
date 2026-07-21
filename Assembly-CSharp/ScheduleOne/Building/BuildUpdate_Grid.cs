using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060034D8 RID: 13528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085A")]
		public GameObject GhostModel
		{
			[Token(Token = "0x60034D7")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034D8")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085B")]
		public GridItem BuildableItemClass
		{
			[Token(Token = "0x60034D9")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034DA")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085C")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60034DB")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034DC")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x1700085D")]
		public bool AllowToggleShowTemperatures
		{
			[Token(Token = "0x60034DD")]
			[Address(RVA = "0x78D660", Offset = "0x78C860", VA = "0x18078D660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085E")]
		protected TileIntersection closestIntersection
		{
			[Token(Token = "0x60034DE")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			get
			{
				return null;
			}
			[Token(Token = "0x60034DF")]
			[Address(RVA = "0x78D670", Offset = "0x78C870", VA = "0x18078D670")]
			set
			{
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x78ACF0", Offset = "0x789EF0", VA = "0x18078ACF0", Slot = "5")]
		public virtual void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x78CC10", Offset = "0x78BE10", VA = "0x18078CC10", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x78D3A0", Offset = "0x78C5A0", VA = "0x18078D3A0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x78A7A0", Offset = "0x7899A0", VA = "0x18078A7A0")]
		private void CheckToggleTemperatureDisplay()
		{
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x78AD90", Offset = "0x789F90", VA = "0x18078AD90", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x78C510", Offset = "0x78B710", VA = "0x18078C510")]
		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x78A690", Offset = "0x789890", VA = "0x18078A690")]
		protected void CheckRotation()
		{
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x7893A0", Offset = "0x7885A0", VA = "0x1807893A0")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x78AB30", Offset = "0x789D30", VA = "0x18078AB30")]
		private List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			return null;
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x789830", Offset = "0x788A30", VA = "0x180789830", Slot = "9")]
		protected virtual void CheckIntersections()
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x78D200", Offset = "0x78C400", VA = "0x18078D200")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x78BE10", Offset = "0x78B010", VA = "0x18078BE10", Slot = "10")]
		protected virtual GridItem Place()
		{
			return null;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "11")]
		protected virtual void OnPlacedObjectPreSpawn(GridItem item)
		{
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x78BC80", Offset = "0x78AE80", VA = "0x18078BC80", Slot = "12")]
		protected virtual void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current)
		{
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x78CB50", Offset = "0x78BD50", VA = "0x18078CB50", Slot = "13")]
		protected virtual void SetShowTemperatures(bool show, Property property)
		{
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x78AA60", Offset = "0x789C60", VA = "0x18078AA60")]
		private Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x78A900", Offset = "0x789B00", VA = "0x18078A900")]
		private Grid GetHoveredGrid()
		{
			return null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x78D640", Offset = "0x78C840", VA = "0x18078D640")]
		public BuildUpdate_Grid()
		{
		}

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float detectionRange;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x3C")]
		public LayerMask detectionMask;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x40")]
		public float rotation_Smoothing;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x44")]
		public bool AllowRotation;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		[Header("Temperature")]
		private bool showTemperaturesByDefault;

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x46")]
		[SerializeField]
		private bool allowToggleShowTemperatures;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x47")]
		protected bool _validPosition;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x48")]
		protected Material _currentGhostMaterial;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x50")]
		protected float _rotation;

		// Token: 0x0400267F RID: 9855
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x58")]
		private TileIntersection _closestIntersection;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x60")]
		private float verticalOffset;

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x64")]
		protected bool _showTemperatures;
	}
}
