using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x0600652B RID: 25899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652B")]
		[Address(RVA = "0xA802B0", Offset = "0xA7F4B0", VA = "0x180A802B0")]
		public void Awake()
		{
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652C")]
		[Address(RVA = "0xA80510", Offset = "0xA7F710", VA = "0x180A80510")]
		public void Refresh()
		{
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652D")]
		[Address(RVA = "0xA80690", Offset = "0xA7F890", VA = "0x180A80690")]
		public void SetDisplayedSave(int index, SaveInfo info)
		{
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x00018C30 File Offset: 0x00016E30
		[Token(Token = "0x600652E")]
		[Address(RVA = "0xA805F0", Offset = "0xA7F7F0", VA = "0x180A805F0")]
		private float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			return 0f;
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00018C48 File Offset: 0x00016E48
		[Token(Token = "0x600652F")]
		[Address(RVA = "0xA80CF0", Offset = "0xA7FEF0", VA = "0x180A80CF0")]
		public static float ToSingle(double value)
		{
			return 0f;
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006530")]
		[Address(RVA = "0xA80450", Offset = "0xA7F650", VA = "0x180A80450")]
		private string GetTimeLabel(int hours)
		{
			return null;
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006531")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SaveDisplay()
		{
		}

		// Token: 0x04004701 RID: 18177
		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public RectTransform[] Slots;
	}
}
