using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public class ReticleLineUI : MonoBehaviour
	{
		// Token: 0x06005A8C RID: 23180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x9D0900", Offset = "0x9CFB00", VA = "0x1809D0900")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x9D0950", Offset = "0x9CFB50", VA = "0x1809D0950")]
		public void SetSize(float sizeX, float sizeY, float thickness)
		{
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0x9D0880", Offset = "0x9CFA80", VA = "0x1809D0880")]
		public void SetColor(Color lineColor, Color borderColor)
		{
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ReticleLineUI()
		{
		}

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private Image _line;

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _border;
	}
}
