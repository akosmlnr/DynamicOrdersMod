using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x06002B8D RID: 11149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x71DA10", Offset = "0x71CC10", VA = "0x18071DA10")]
		private void Awake()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x71DAB0", Offset = "0x71CCB0", VA = "0x18071DAB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x71DB80", Offset = "0x71CD80", VA = "0x18071DB80")]
		public void SetRadius(float rad)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x71DB00", Offset = "0x71CD00", VA = "0x18071DB00")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x71DB50", Offset = "0x71CD50", VA = "0x18071DB50")]
		public void SetColor(Color col)
		{
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ProximityCircle()
		{
		}

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public DecalProjector Circle;

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x28")]
		private bool enabledThisFrame;

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x30")]
		private Material materialInstance;
	}
}
