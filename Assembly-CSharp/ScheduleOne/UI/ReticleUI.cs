using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	public class ReticleUI : MonoBehaviour
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00016FE0 File Offset: 0x000151E0
		// (set) Token: 0x06005A91 RID: 23185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1D")]
		public float Alpha
		{
			[Token(Token = "0x6005A90")]
			[Address(RVA = "0x9D0FA0", Offset = "0x9D01A0", VA = "0x1809D0FA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005A91")]
			[Address(RVA = "0x9D0FC0", Offset = "0x9D01C0", VA = "0x1809D0FC0")]
			set
			{
			}
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x9D0C20", Offset = "0x9CFE20", VA = "0x1809D0C20")]
		private void Awake()
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x9D0C70", Offset = "0x9CFE70", VA = "0x1809D0C70")]
		private void OnValidate()
		{
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0x9D0C90", Offset = "0x9CFE90", VA = "0x1809D0C90")]
		public void Set(float spreadAngle)
		{
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x9D0D70", Offset = "0x9CFF70", VA = "0x1809D0D70")]
		private void Update()
		{
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x9D0B10", Offset = "0x9CFD10", VA = "0x1809D0B10")]
		private void ApplyLineSizes()
		{
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x9D0A30", Offset = "0x9CFC30", VA = "0x1809D0A30")]
		private void ApplyColors()
		{
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x9D0F50", Offset = "0x9D0150", VA = "0x1809D0F50")]
		public ReticleUI()
		{
		}

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private ReticleLineUI[] _lineUI;

		// Token: 0x04003D07 RID: 15623
		[Token(Token = "0x4003D07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x04003D08 RID: 15624
		[Token(Token = "0x4003D08")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		[SerializeField]
		private float _lineLength;

		// Token: 0x04003D09 RID: 15625
		[Token(Token = "0x4003D09")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _lineThickness;

		// Token: 0x04003D0A RID: 15626
		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _borderThickness;

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color _lineColor;

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _borderColor;

		// Token: 0x04003D0D RID: 15629
		[Token(Token = "0x4003D0D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _minGap;

		// Token: 0x04003D0E RID: 15630
		[Token(Token = "0x4003D0E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _lerpSpeed;

		// Token: 0x04003D0F RID: 15631
		[Token(Token = "0x4003D0F")]
		[FieldOffset(Offset = "0x64")]
		private float _radius;

		// Token: 0x04003D10 RID: 15632
		[Token(Token = "0x4003D10")]
		[FieldOffset(Offset = "0x68")]
		private float _currentRadius;

		// Token: 0x04003D11 RID: 15633
		[Token(Token = "0x4003D11")]
		[FieldOffset(Offset = "0x6C")]
		private float _lastSpreadAngle;
	}
}
