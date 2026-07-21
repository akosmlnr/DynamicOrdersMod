using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	[Serializable]
	public struct DisplaySettings
	{
		// Token: 0x060049E7 RID: 18919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60049E7")]
		[Address(RVA = "0x8F4420", Offset = "0x8F3620", VA = "0x1808F4420")]
		public static List<Resolution> GetResolutions()
		{
			return null;
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x60049E8")]
		[Address(RVA = "0x8F4400", Offset = "0x8F3600", VA = "0x1808F4400")]
		private static uint GetDenominatorSafe(RefreshRate refreshRate)
		{
			return 0U;
		}

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x0")]
		public int ResolutionIndex;

		// Token: 0x0400343D RID: 13373
		[Token(Token = "0x400343D")]
		[FieldOffset(Offset = "0x4")]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x8")]
		public bool VSync;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0xC")]
		public int TargetFPS;

		// Token: 0x04003440 RID: 13376
		[Token(Token = "0x4003440")]
		[FieldOffset(Offset = "0x10")]
		public float UIScale;

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x14")]
		public float CameraBobbing;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x18")]
		public int ActiveDisplayIndex;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x1C")]
		public Settings.EUnitType UnitType;

		// Token: 0x02000A29 RID: 2601
		[Token(Token = "0x2000A29")]
		public enum EDisplayMode
		{
			// Token: 0x04003445 RID: 13381
			[Token(Token = "0x4003445")]
			Windowed,
			// Token: 0x04003446 RID: 13382
			[Token(Token = "0x4003446")]
			FullscreenWindow,
			// Token: 0x04003447 RID: 13383
			[Token(Token = "0x4003447")]
			ExclusiveFullscreen
		}
	}
}
