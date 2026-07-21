using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000859 RID: 2137
	[Token(Token = "0x2000859")]
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x06003905 RID: 14597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003905")]
		[Address(RVA = "0x7F9E90", Offset = "0x7F9090", VA = "0x1807F9E90")]
		private void Start()
		{
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003906")]
		[Address(RVA = "0x7F9FB0", Offset = "0x7F91B0", VA = "0x1807F9FB0")]
		private void Update()
		{
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003907")]
		[Address(RVA = "0x7F9FB0", Offset = "0x7F91B0", VA = "0x1807F9FB0")]
		private void UpdateCountdown()
		{
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x7F9CF0", Offset = "0x7F8EF0", VA = "0x1807F9CF0")]
		private string FormatTime(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x7FA0D0", Offset = "0x7F92D0", VA = "0x1807FA0D0")]
		public CountdownText()
		{
		}

		// Token: 0x04002A07 RID: 10759
		[Token(Token = "0x4002A07")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04002A08 RID: 10760
		[Token(Token = "0x4002A08")]
		[FieldOffset(Offset = "0x28")]
		[Header("Date Setting")]
		public int Year;

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x2C")]
		public int Month;

		// Token: 0x04002A0A RID: 10762
		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0x30")]
		public int Day;

		// Token: 0x04002A0B RID: 10763
		[Token(Token = "0x4002A0B")]
		[FieldOffset(Offset = "0x34")]
		public int Hour;

		// Token: 0x04002A0C RID: 10764
		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x38")]
		public int Minute;

		// Token: 0x04002A0D RID: 10765
		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x3C")]
		public int Second;

		// Token: 0x04002A0E RID: 10766
		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x40")]
		private DateTime targetPDTDate;
	}
}
