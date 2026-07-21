using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Configuration
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	public class ConfigurationService : PersistentSingleton<ConfigurationService>
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007FC")]
		public BaseConfiguration[] Configurations
		{
			[Token(Token = "0x60030AC")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x75FD00", Offset = "0x75EF00", VA = "0x18075FD00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x75FDA0", Offset = "0x75EFA0", VA = "0x18075FDA0")]
		private void ResetConfigurations()
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x60030AF")]
		public bool TryGetConfiguration<T>(out T configuration) where T : BaseConfiguration
		{
			return default(bool);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x75FE10", Offset = "0x75F010", VA = "0x18075FE10")]
		public bool TryGetConfiguration(string configurationName, out BaseConfiguration configuration)
		{
			return default(bool);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B1")]
		public void GetConfigurationAndListenForChanges<T>(Action<BaseConfiguration> onConfigChanged) where T : BaseConfiguration
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B2")]
		public void UnsubscribeFromConfigurationChanges<T>(Action<BaseConfiguration> onConfigChanged) where T : BaseConfiguration
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x75FF40", Offset = "0x75F140", VA = "0x18075FF40")]
		public ConfigurationService()
		{
		}

		// Token: 0x040023D5 RID: 9173
		[Token(Token = "0x40023D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BaseConfiguration[] _configurations;
	}
}
