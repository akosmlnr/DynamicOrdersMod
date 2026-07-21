using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	public class MotionEvent
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x806DF0", Offset = "0x805FF0", VA = "0x180806DF0")]
		public void Update(Vector3 newPosition)
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x806F30", Offset = "0x806130", VA = "0x180806F30")]
		public MotionEvent()
		{
		}

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0x10")]
		public List<Action> Actions;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 LastUpdatedDistance;
	}
}
