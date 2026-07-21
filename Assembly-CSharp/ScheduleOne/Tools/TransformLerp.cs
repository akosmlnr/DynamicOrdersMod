using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	[Serializable]
	public class TransformLerp
	{
		// Token: 0x060039FB RID: 14843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x80F560", Offset = "0x80E760", VA = "0x18080F560")]
		public void SetLerpValue(float lerpValue)
		{
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x80F850", Offset = "0x80EA50", VA = "0x18080F850")]
		public TransformLerp()
		{
		}

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _transform;

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _min;

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _max;

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[SerializeField]
		private bool _lerpPosition;

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _lerpRotation;

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _lerpScale;

		// Token: 0x04002ABD RID: 10941
		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _disableOnZero;

		// Token: 0x04002ABE RID: 10942
		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0x2C")]
		private float _currentLerpValue;
	}
}
