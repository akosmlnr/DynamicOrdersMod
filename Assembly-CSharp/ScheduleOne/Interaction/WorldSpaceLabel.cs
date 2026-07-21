using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200060E RID: 1550
	[Token(Token = "0x200060E")]
	public class WorldSpaceLabel
	{
		// Token: 0x06002663 RID: 9827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x6D24D0", Offset = "0x6D16D0", VA = "0x1806D24D0")]
		public WorldSpaceLabel(string _text, Vector3 _position)
		{
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x6D2110", Offset = "0x6D1310", VA = "0x1806D2110")]
		public void RefreshDisplay()
		{
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x6D2010", Offset = "0x6D1210", VA = "0x1806D2010")]
		public void Destroy()
		{
		}

		// Token: 0x04001E09 RID: 7689
		[Token(Token = "0x4001E09")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04001E0A RID: 7690
		[Token(Token = "0x4001E0A")]
		[FieldOffset(Offset = "0x18")]
		public Color32 color;

		// Token: 0x04001E0B RID: 7691
		[Token(Token = "0x4001E0B")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform rect;

		// Token: 0x04001E0E RID: 7694
		[Token(Token = "0x4001E0E")]
		[FieldOffset(Offset = "0x38")]
		public Text textComp;

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x40")]
		public bool active;
	}
}
