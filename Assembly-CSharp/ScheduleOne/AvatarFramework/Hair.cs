using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	public class Hair : Accessory
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00010560 File Offset: 0x0000E760
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C8")]
		public bool BlockedByHat
		{
			[Token(Token = "0x6003712")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003713")]
			[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x7F34A0", Offset = "0x7F26A0", VA = "0x1807F34A0")]
		public void SetBlockedByHat(bool blocked)
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x7F3430", Offset = "0x7F2630", VA = "0x1807F3430", Slot = "4")]
		protected virtual void BlockHair()
		{
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x7F34D0", Offset = "0x7F26D0", VA = "0x1807F34D0", Slot = "5")]
		protected virtual void UnBlockHair()
		{
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x7F3540", Offset = "0x7F2740", VA = "0x1807F3540")]
		public Hair()
		{
		}

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] hairToHide;
	}
}
