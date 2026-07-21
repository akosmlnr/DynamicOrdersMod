using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	public abstract class GenericEquippableItemDefinition<T> : StorableItemDefinition where T : EquippableData
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600408E RID: 16526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0B")]
		public new T EquippableData
		{
			[Token(Token = "0x600408D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600408E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408F")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004090")]
		protected GenericEquippableItemDefinition()
		{
		}
	}
}
