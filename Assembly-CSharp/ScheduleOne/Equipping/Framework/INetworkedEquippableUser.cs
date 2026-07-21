using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Items.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	public interface INetworkedEquippableUser : IEquippableUser
	{
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06004091 RID: 16529
		[Token(Token = "0x17000A0C")]
		NetworkBehaviour NetworkBehaviour
		{
			[Token(Token = "0x6004091")]
			get;
		}

		// Token: 0x06004092 RID: 16530
		[Token(Token = "0x6004092")]
		IEquippedItemHandler EquipLocal(EquippableData equippable);

		// Token: 0x06004093 RID: 16531
		[Token(Token = "0x6004093")]
		IEquippedItemHandler EquipLocal(BaseItemInstance item);

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A0D")]
		Transform ItemHandlerContainer
		{
			[Token(Token = "0x6004094")]
			[Address(RVA = "0x85B9D0", Offset = "0x85ABD0", VA = "0x18085B9D0", Slot = "3")]
			get
			{
				return null;
			}
		}
	}
}
