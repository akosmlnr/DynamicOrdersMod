using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB8 RID: 3256
	[Token(Token = "0x2000CB8")]
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x06005F28 RID: 24360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F28")]
		[Address(RVA = "0xA08F70", Offset = "0xA08170", VA = "0x180A08F70")]
		public void Update()
		{
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F29")]
		[Address(RVA = "0xA09060", Offset = "0xA08260", VA = "0x180A09060")]
		public DestroyUIAtBounds()
		{
		}

		// Token: 0x04004177 RID: 16759
		[Token(Token = "0x4004177")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Rect;

		// Token: 0x04004178 RID: 16760
		[Token(Token = "0x4004178")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 MinBounds;

		// Token: 0x04004179 RID: 16761
		[Token(Token = "0x4004179")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 MaxBounds;
	}
}
