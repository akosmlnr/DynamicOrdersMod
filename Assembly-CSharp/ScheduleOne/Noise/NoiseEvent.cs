using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	public class NoiseEvent
	{
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050D")]
		public bool OriginInSewer
		{
			[Token(Token = "0x6001B6F")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B70")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x613F10", Offset = "0x613110", VA = "0x180613F10")]
		public NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, [Optional] GameObject _source)
		{
		}

		// Token: 0x0400179B RID: 6043
		[Token(Token = "0x400179B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 origin;

		// Token: 0x0400179C RID: 6044
		[Token(Token = "0x400179C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float range;

		// Token: 0x0400179D RID: 6045
		[Token(Token = "0x400179D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ENoiseType type;

		// Token: 0x0400179E RID: 6046
		[Token(Token = "0x400179E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;
	}
}
