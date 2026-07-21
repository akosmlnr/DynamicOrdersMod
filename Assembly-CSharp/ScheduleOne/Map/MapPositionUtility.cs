using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000558")]
		private float conversionFactor
		{
			[Token(Token = "0x6001D82")]
			[Address(RVA = "0x4E1290", Offset = "0x4E0490", VA = "0x1804E1290")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001D83")]
			[Address(RVA = "0x4E12B0", Offset = "0x4E04B0", VA = "0x1804E12B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x6242F0", Offset = "0x6234F0", VA = "0x1806242F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x624480", Offset = "0x623680", VA = "0x180624480")]
		public Vector2 GetMapPosition(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x624510", Offset = "0x623710", VA = "0x180624510")]
		[Button]
		public void Recalculate()
		{
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x624670", Offset = "0x623870", VA = "0x180624670")]
		public MapPositionUtility()
		{
		}

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x28")]
		public Transform OriginPoint;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x30")]
		public Transform EdgePoint;

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x38")]
		public float MapDimensions;
	}
}
