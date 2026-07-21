using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x06005DF8 RID: 24056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DF8")]
		[Address(RVA = "0xA09090", Offset = "0xA08290", VA = "0x180A09090", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0xA09200", Offset = "0xA08400", VA = "0x180A09200")]
		private void Update()
		{
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DFA")]
		[Address(RVA = "0xA09100", Offset = "0xA08300", VA = "0x180A09100")]
		public void SetOpen(float openness)
		{
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0xA09390", Offset = "0xA08590", VA = "0x180A09390")]
		public EyelidOverlay()
		{
		}

		// Token: 0x04004070 RID: 16496
		[Token(Token = "0x4004070")]
		public const float MaxTiredOpenAmount = 0.625f;

		// Token: 0x04004071 RID: 16497
		[Token(Token = "0x4004071")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoUpdate;

		// Token: 0x04004072 RID: 16498
		[Token(Token = "0x4004072")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float Open;

		// Token: 0x04004073 RID: 16499
		[Token(Token = "0x4004073")]
		[FieldOffset(Offset = "0x30")]
		public float Closed;

		// Token: 0x04004074 RID: 16500
		[Token(Token = "0x4004074")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Upper;

		// Token: 0x04004075 RID: 16501
		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Lower;

		// Token: 0x04004076 RID: 16502
		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x48")]
		public Canvas Canvas;

		// Token: 0x04004077 RID: 16503
		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float CurrentOpen;

		// Token: 0x04004078 RID: 16504
		[Token(Token = "0x4004078")]
		[FieldOffset(Offset = "0x58")]
		public FloatSmoother OpenMultiplier;
	}
}
