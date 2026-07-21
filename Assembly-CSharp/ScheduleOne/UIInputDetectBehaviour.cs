using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	public class UIInputDetectBehaviour : MonoBehaviour
	{
		// Token: 0x06000BB8 RID: 3000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xAD2170", Offset = "0xAD1370", VA = "0x180AD2170")]
		public void Initialize(Action<float> action, float holdThreshold, float repeat)
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0xAD21B0", Offset = "0xAD13B0", VA = "0x180AD21B0")]
		public void ResetData()
		{
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xAD20A0", Offset = "0xAD12A0", VA = "0x180AD20A0")]
		public void DoUpdate(float value)
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xAD21C0", Offset = "0xAD13C0", VA = "0x180AD21C0")]
		public UIInputDetectBehaviour()
		{
		}

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x20")]
		private float initialHoldThreshold;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x24")]
		private float repeatInterval;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x28")]
		private float timer;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x2C")]
		private bool wasPressedLastFrame;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x30")]
		private Action<float> onAction;
	}
}
