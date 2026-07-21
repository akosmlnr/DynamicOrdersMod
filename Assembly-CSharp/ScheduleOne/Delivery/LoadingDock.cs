using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EPOOutline;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Property;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000736")]
	public class LoadingDock : MonoBehaviour, IGUIDRegisterable, ITransitEntity
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600304E RID: 12366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E8")]
		public LandVehicle DynamicOccupant
		{
			[Token(Token = "0x600304D")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600304E")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E9")]
		public LandVehicle StaticOccupant
		{
			[Token(Token = "0x600304F")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003050")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x170007EA")]
		public bool IsInUse
		{
			[Token(Token = "0x6003051")]
			[Address(RVA = "0x7679A0", Offset = "0x766BA0", VA = "0x1807679A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EB")]
		public Guid GUID
		{
			[Token(Token = "0x6003052")]
			[Address(RVA = "0x74BBA0", Offset = "0x74ADA0", VA = "0x18074BBA0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003053")]
			[Address(RVA = "0x74BC30", Offset = "0x74AE30", VA = "0x18074BC30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x74B760", Offset = "0x74A960", VA = "0x18074B760")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007EC")]
		public string Name
		{
			[Token(Token = "0x6003055")]
			[Address(RVA = "0x767A30", Offset = "0x766C30", VA = "0x180767A30", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007ED")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6003056")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003057")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EE")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6003058")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003059")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007EF")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x600305A")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007F0")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600305B")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x170007F1")]
		public bool Selectable
		{
			[Token(Token = "0x600305C")]
			[Address(RVA = "0x4D4760", Offset = "0x4D3960", VA = "0x1804D4760", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F2")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600305D")]
			[Address(RVA = "0x767980", Offset = "0x766B80", VA = "0x180767980", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600305E")]
			[Address(RVA = "0x767AC0", Offset = "0x766CC0", VA = "0x180767AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x0000F000 File Offset: 0x0000D200
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F3")]
		public bool IsDestroyed
		{
			[Token(Token = "0x600305F")]
			[Address(RVA = "0x767990", Offset = "0x766B90", VA = "0x180767990", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003060")]
			[Address(RVA = "0x767AD0", Offset = "0x766CD0", VA = "0x180767AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x766BB0", Offset = "0x765DB0", VA = "0x180766BB0")]
		private void Awake()
		{
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x767830", Offset = "0x766A30", VA = "0x180767830")]
		private void Start()
		{
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x767100", Offset = "0x766300", VA = "0x180767100", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x766CA0", Offset = "0x765EA0", VA = "0x180766CA0")]
		private void RefreshOccupant()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x767160", Offset = "0x766360", VA = "0x180767160")]
		private void SetOccupant(LandVehicle occupant)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
		public void SetStaticOccupant(LandVehicle vehicle)
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x767420", Offset = "0x766620", VA = "0x180767420", Slot = "29")]
		public virtual void ShowOutline(Color color)
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x766C20", Offset = "0x765E20", VA = "0x180766C20", Slot = "30")]
		public virtual void HideOutline()
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x7678A0", Offset = "0x766AA0", VA = "0x1807678A0")]
		public LoadingDock()
		{
		}

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x60")]
		public Property ParentProperty;

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x68")]
		public VehicleDetector VehicleDetector;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x70")]
		public ParkingLot Parking;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x78")]
		public Transform uiPoint;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x80")]
		public Transform[] accessPoints;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x88")]
		public GameObject[] OutlineRenderers;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x90")]
		private Outlinable OutlineEffect;
	}
}
