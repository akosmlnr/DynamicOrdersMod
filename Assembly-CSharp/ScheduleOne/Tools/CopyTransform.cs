using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000845 RID: 2117
	[Token(Token = "0x2000845")]
	public class CopyTransform : MonoBehaviour
	{
		// Token: 0x060038BB RID: 14523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x7F9CB0", Offset = "0x7F8EB0", VA = "0x1807F9CB0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BC")]
		[Address(RVA = "0x7F9CD0", Offset = "0x7F8ED0", VA = "0x1807F9CD0")]
		private void Update()
		{
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x7F9CC0", Offset = "0x7F8EC0", VA = "0x1807F9CC0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x7F9920", Offset = "0x7F8B20", VA = "0x1807F9920")]
		private void Copy()
		{
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x7F9CE0", Offset = "0x7F8EE0", VA = "0x1807F9CE0")]
		public CopyTransform()
		{
		}

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x20")]
		public Transform Target;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x28")]
		public CopyTransform.EUpdateMode UpdateMode;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x2C")]
		public bool CopyPosition;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x2D")]
		public bool CopyRotation;

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x2E")]
		public bool CopyScale;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 GlobalPositionOffset;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 LocalPositionOffset;

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 RotationOffset;

		// Token: 0x02000846 RID: 2118
		[Token(Token = "0x2000846")]
		public enum EUpdateMode
		{
			// Token: 0x040029C8 RID: 10696
			[Token(Token = "0x40029C8")]
			Update,
			// Token: 0x040029C9 RID: 10697
			[Token(Token = "0x40029C9")]
			LateUpdate,
			// Token: 0x040029CA RID: 10698
			[Token(Token = "0x40029CA")]
			FixedUpdate
		}
	}
}
