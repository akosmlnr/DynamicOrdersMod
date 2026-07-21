using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	[Serializable]
	public class RaymarchingQuality
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x1700009A")]
		public int uniqueID
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x1700009B")]
		public bool hasValidUniqueID
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x69BEB0", Offset = "0x69B0B0", VA = "0x18069BEB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700009C")]
		public static RaymarchingQuality defaultInstance
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x69BE60", Offset = "0x69B060", VA = "0x18069BE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x69BDF0", Offset = "0x69AFF0", VA = "0x18069BDF0")]
		private RaymarchingQuality(int uniqueID)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x69BC90", Offset = "0x69AE90", VA = "0x18069BC90")]
		public static RaymarchingQuality New()
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x69BBD0", Offset = "0x69ADD0", VA = "0x18069BBD0")]
		public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			return null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x69BB70", Offset = "0x69AD70", VA = "0x18069BB70")]
		private static bool HasRaymarchingQualityWithSameUniqueID(RaymarchingQuality[] values, int id)
		{
			return default(bool);
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x18")]
		public int stepCount;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _UniqueID;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x0")]
		private static RaymarchingQuality ms_DefaultInstance;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		private const int kRandomUniqueIdMinRange = 4;
	}
}
