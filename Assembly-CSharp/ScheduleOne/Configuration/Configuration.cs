using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core.Settings.Framework;

namespace ScheduleOne.Configuration
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	public abstract class Configuration<T> : BaseConfiguration where T : Settings
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FA")]
		public T Settings
		{
			[Token(Token = "0x600309E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600309F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FB")]
		private T DefaultSettings
		{
			[Token(Token = "0x60030A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030A1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A2")]
		public override void ValidateConfiguration()
		{
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A3")]
		public override void ResetConfigurationToDefault()
		{
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030A4")]
		public override Settings GetSettings()
		{
			return null;
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A5")]
		public void ApplySettings(T newSettings)
		{
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A6")]
		private static void ApplyOverwrites(T from, T to)
		{
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A7")]
		protected Configuration()
		{
		}
	}
}
