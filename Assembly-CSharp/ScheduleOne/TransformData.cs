using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public struct TransformData
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0xAFB7C0", Offset = "0xAFA9C0", VA = "0x180AFB7C0")]
		public TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0xAFB4F0", Offset = "0xAFA6F0", VA = "0x180AFB4F0")]
		public void ApplyToWorldTransform(Transform transform)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0xAFB450", Offset = "0xAFA650", VA = "0x180AFB450")]
		public void ApplyToLocalTransform(Transform transform, bool setScale = true)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0xAFB550", Offset = "0xAFA750", VA = "0x180AFB550")]
		public static TransformData FromTransform(Transform transform)
		{
			return default(TransformData);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0xAFB5E0", Offset = "0xAFA7E0", VA = "0x180AFB5E0")]
		public static TransformData Lerp(TransformData a, TransformData b, float t)
		{
			return default(TransformData);
		}

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Scale;
	}
}
