using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DB4 RID: 3508
	[Token(Token = "0x2000DB4")]
	public class Disclaimer : MonoBehaviour
	{
		// Token: 0x060064FE RID: 25854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0xA718E0", Offset = "0xA70AE0", VA = "0x180A718E0")]
		private void Awake()
		{
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0xA71A20", Offset = "0xA70C20", VA = "0x180A71A20")]
		private void Fade()
		{
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006500")]
		[Address(RVA = "0xA71B10", Offset = "0xA70D10", VA = "0x180A71B10")]
		public Disclaimer()
		{
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006501")]
		[Address(RVA = "0xA71AA0", Offset = "0xA70CA0", VA = "0x180A71AA0")]
		[CompilerGenerated]
		private IEnumerator <Fade>g__Fade|5_0()
		{
			return null;
		}

		// Token: 0x040046CF RID: 18127
		[Token(Token = "0x40046CF")]
		[FieldOffset(Offset = "0x0")]
		public static bool Shown;

		// Token: 0x040046D0 RID: 18128
		[Token(Token = "0x40046D0")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup Group;

		// Token: 0x040046D1 RID: 18129
		[Token(Token = "0x40046D1")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup TextGroup;

		// Token: 0x040046D2 RID: 18130
		[Token(Token = "0x40046D2")]
		[FieldOffset(Offset = "0x30")]
		public float Duration;
	}
}
