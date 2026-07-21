using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x592680", Offset = "0x591880", VA = "0x180592680")]
		private void Awake()
		{
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x592710", Offset = "0x591910", VA = "0x180592710")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SkateboardEffects()
		{
		}

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x20")]
		private Skateboard skateboard;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TrailRenderer[] Trails;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x30")]
		private float trailsOpacity;
	}
}
