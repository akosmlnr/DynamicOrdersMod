using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008E7 RID: 2279
	[Token(Token = "0x20008E7")]
	public abstract class ItemModule : MonoBehaviour
	{
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CB9 RID: 15545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000981")]
		public StationItem Item
		{
			[Token(Token = "0x6003CB8")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CB9")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003CBA RID: 15546 RVA: 0x00011880 File Offset: 0x0000FA80
		// (set) Token: 0x06003CBB RID: 15547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000982")]
		public bool IsModuleActive
		{
			[Token(Token = "0x6003CBA")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003CBB")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x8171A0", Offset = "0x8163A0", VA = "0x1808171A0", Slot = "4")]
		public virtual void ActivateModule(StationItem item)
		{
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected ItemModule()
		{
		}
	}
}
