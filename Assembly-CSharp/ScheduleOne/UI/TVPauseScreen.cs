using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.TV;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C0E RID: 3086
	[Token(Token = "0x2000C0E")]
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x00016FF8 File Offset: 0x000151F8
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1E")]
		public bool IsPaused
		{
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0x9D0FE0", Offset = "0x9D01E0", VA = "0x1809D0FE0")]
		private void Awake()
		{
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0x9D10B0", Offset = "0x9D02B0", VA = "0x1809D10B0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0x9D1120", Offset = "0x9D0320", VA = "0x1809D1120")]
		public void Pause()
		{
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x9D1150", Offset = "0x9D0350", VA = "0x1809D1150")]
		public void Resume()
		{
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x9D1080", Offset = "0x9D0280", VA = "0x1809D1080")]
		public void Back()
		{
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TVPauseScreen()
		{
		}

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x28")]
		public TVApp App;
	}
}
