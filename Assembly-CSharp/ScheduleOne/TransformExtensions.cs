using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	public static class TransformExtensions
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0xAFB890", Offset = "0xAFAA90", VA = "0x180AFB890")]
		public static TransformData GetWorldTransformData(this Transform transform)
		{
			return default(TransformData);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0xAFB7F0", Offset = "0xAFA9F0", VA = "0x180AFB7F0")]
		public static TransformData GetLocalTransformData(this Transform transform)
		{
			return default(TransformData);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0xAFB930", Offset = "0xAFAB30", VA = "0x180AFB930")]
		public static void SetLocalTransformData(this Transform transform, TransformData data, bool setScale = true)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0xAFB9D0", Offset = "0xAFABD0", VA = "0x180AFB9D0")]
		public static void SetWorldTransformData(this Transform transform, TransformData data)
		{
		}
	}
}
