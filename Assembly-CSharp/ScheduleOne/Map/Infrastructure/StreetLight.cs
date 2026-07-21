using System;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000558 RID: 1368
	[Token(Token = "0x2000558")]
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x64C810", Offset = "0x64BA10", VA = "0x18064C810", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x64CAC0", Offset = "0x64BCC0", VA = "0x18064CAC0")]
		private void Start()
		{
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x64CAC0", Offset = "0x64BCC0", VA = "0x18064CAC0")]
		private void UpdateState()
		{
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x64CAA0", Offset = "0x64BCA0", VA = "0x18064CAA0")]
		private void SetState(bool on)
		{
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x64CC20", Offset = "0x64BE20", VA = "0x18064CC20")]
		public StreetLight()
		{
		}

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 PowerOrigin;

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected ToggleableLight _light;

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x28")]
		[Header("Timing")]
		public int StartTime;

		// Token: 0x04001997 RID: 6551
		[Token(Token = "0x4001997")]
		[FieldOffset(Offset = "0x2C")]
		public int EndTime;

		// Token: 0x04001998 RID: 6552
		[Token(Token = "0x4001998")]
		[FieldOffset(Offset = "0x30")]
		private int _startTimeOffset;
	}
}
