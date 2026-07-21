using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Management
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	public abstract class ConfigField
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A4")]
		public EntityConfiguration ParentConfig
		{
			[Token(Token = "0x6001FF0")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FF1")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x63CB40", Offset = "0x63BD40", VA = "0x18063CB40")]
		public ConfigField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001FF3 RID: 8179
		[Token(Token = "0x6001FF3")]
		public abstract bool IsValueDefault();
	}
}
