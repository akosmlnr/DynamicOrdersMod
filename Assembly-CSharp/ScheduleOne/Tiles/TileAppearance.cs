using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129C")]
		[Address(RVA = "0xB29FF0", Offset = "0xB291F0", VA = "0x180B29FF0")]
		public void Awake()
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x690E80", Offset = "0x690080", VA = "0x180690E80")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129E")]
		[Address(RVA = "0xB2A020", Offset = "0xB29220", VA = "0x180B2A020")]
		public void SetColor(ETileColor col)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TileAppearance()
		{
		}

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected MeshRenderer tileMesh;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[SerializeField]
		protected Material mat_White;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Material mat_Blue;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Material mat_Red;
	}
}
