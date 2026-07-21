using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public class SoilChunk : Clickable
	{
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00011460 File Offset: 0x0000F660
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000950")]
		public float CurrentLerp
		{
			[Token(Token = "0x6003B98")]
			[Address(RVA = "0x4C20F0", Offset = "0x4C12F0", VA = "0x1804C20F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B99")]
			[Address(RVA = "0x6B6F20", Offset = "0x6B6120", VA = "0x1806B6F20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x81DA20", Offset = "0x81CC20", VA = "0x18081DA20", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x81DAD0", Offset = "0x81CCD0", VA = "0x18081DAD0")]
		public void SetLerpedTransform(float _lerp)
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x81DDD0", Offset = "0x81CFD0", VA = "0x18081DDD0", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x81DEB0", Offset = "0x81D0B0", VA = "0x18081DEB0")]
		public void StopLerp()
		{
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x81DF40", Offset = "0x81D140", VA = "0x18081DF40")]
		public SoilChunk()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x81DED0", Offset = "0x81D0D0", VA = "0x18081DED0")]
		[CompilerGenerated]
		private IEnumerator <StartClick>g__Lerp|12_0()
		{
			return null;
		}

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x58")]
		public Transform EndTransform;

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x60")]
		public float LerpTime;

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 localPos_Start;

		// Token: 0x04002BF9 RID: 11257
		[Token(Token = "0x4002BF9")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 localEulerAngles_Start;

		// Token: 0x04002BFA RID: 11258
		[Token(Token = "0x4002BFA")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 localScale_Start;

		// Token: 0x04002BFB RID: 11259
		[Token(Token = "0x4002BFB")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine lerpRoutine;
	}
}
