using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x2000848")]
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x060038C4 RID: 14532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x80D430", Offset = "0x80C630", VA = "0x18080D430")]
		[Button]
		private void Randomize()
		{
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x80D5B0", Offset = "0x80C7B0", VA = "0x18080D5B0")]
		public RoadCracksRandomizer()
		{
		}

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] Cracks;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x28")]
		public int MinCount;

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x2C")]
		public int MaxCount;
	}
}
