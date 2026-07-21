using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BAA RID: 2986
	[Token(Token = "0x2000BAA")]
	public class SkyOverrideEnclosure : WorldEnclosure
	{
		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x000167A0 File Offset: 0x000149A0
		[Token(Token = "0x17000CD1")]
		public int Priority
		{
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0x494480", Offset = "0x493680", VA = "0x180494480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CD2")]
		public SkySettings SkySettings
		{
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x9B5650", Offset = "0x9B4850", VA = "0x1809B5650")]
		public SkyOverrideEnclosure()
		{
		}

		// Token: 0x04003B0B RID: 15115
		[Token(Token = "0x4003B0B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Higher priority overrides will take precedence over lower ones")]
		[Header("Settings")]
		private int _priority;

		// Token: 0x04003B0C RID: 15116
		[Token(Token = "0x4003B0C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SkySettings _skySettings;
	}
}
