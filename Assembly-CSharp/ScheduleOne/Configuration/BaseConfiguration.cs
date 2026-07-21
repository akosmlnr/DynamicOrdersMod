using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Settings.Framework;
using UnityEngine;

namespace ScheduleOne.Configuration
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	public abstract class BaseConfiguration : ScriptableObject
	{
		// Token: 0x0600309A RID: 12442
		[Token(Token = "0x600309A")]
		public abstract void ResetConfigurationToDefault();

		// Token: 0x0600309B RID: 12443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public virtual void ValidateConfiguration()
		{
		}

		// Token: 0x0600309C RID: 12444
		[Token(Token = "0x600309C")]
		public abstract Settings GetSettings();

		// Token: 0x0600309D RID: 12445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		protected BaseConfiguration()
		{
		}

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x18")]
		public Action<BaseConfiguration> OnConfigurationChanged;
	}
}
