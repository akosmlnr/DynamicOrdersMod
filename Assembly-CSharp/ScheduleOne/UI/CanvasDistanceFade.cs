using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C1A RID: 3098
	[Token(Token = "0x2000C1A")]
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x06005AE6 RID: 23270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0x9C1E00", Offset = "0x9C1000", VA = "0x1809C1E00")]
		public void LateUpdate()
		{
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0x9C2030", Offset = "0x9C1230", VA = "0x1809C2030")]
		public CanvasDistanceFade()
		{
		}

		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[FieldOffset(Offset = "0x28")]
		public float MinDistance;

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxDistance;
	}
}
