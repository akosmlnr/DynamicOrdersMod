using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x6891D0", Offset = "0x6883D0", VA = "0x1806891D0")]
		[Button]
		public void Orient()
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x688C20", Offset = "0x687E20", VA = "0x180688C20")]
		[Button]
		public void DrawLines()
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x689670", Offset = "0x688870", VA = "0x180689670")]
		public UtilityPole()
		{
		}

		// Token: 0x04001A96 RID: 6806
		[Token(Token = "0x4001A96")]
		public const float CABLE_CULL_DISTANCE = 100f;

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		public const float CABLE_CULL_DISTANCE_SQR = 10000f;

		// Token: 0x04001A98 RID: 6808
		[Token(Token = "0x4001A98")]
		[FieldOffset(Offset = "0x20")]
		public UtilityPole previousPole;

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x28")]
		public UtilityPole nextPole;

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x30")]
		public bool Connection1Enabled;

		// Token: 0x04001A9B RID: 6811
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x31")]
		public bool Connection2Enabled;

		// Token: 0x04001A9C RID: 6812
		[Token(Token = "0x4001A9C")]
		[FieldOffset(Offset = "0x34")]
		public float LengthFactor;

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform cable1Connection;

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x40")]
		public Transform cable2Connection;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x48")]
		public List<Transform> cable1Segments;

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x50")]
		public List<Transform> cable2Segments;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x58")]
		public Transform Cable1Container;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x60")]
		public Transform Cable2Container;
	}
}
