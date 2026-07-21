using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.NPCs;

namespace ScheduleOne.Management
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public interface IUsable
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x170005C4")]
		bool IsInUse
		{
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x6732F0", Offset = "0x6724F0", VA = "0x1806732F0", Slot = "0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x170005C5")]
		bool IsUsedByLocalPlayer
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x6733C0", Offset = "0x6725C0", VA = "0x1806733C0", Slot = "1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002071 RID: 8305
		// (set) Token: 0x06002072 RID: 8306
		[Token(Token = "0x170005C6")]
		NetworkObject NPCUserObject
		{
			[Token(Token = "0x6002071")]
			get;
			[Token(Token = "0x6002072")]
			set;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002073 RID: 8307
		// (set) Token: 0x06002074 RID: 8308
		[Token(Token = "0x170005C7")]
		NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6002073")]
			get;
			[Token(Token = "0x6002074")]
			set;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170005C8")]
		string UserName
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x673480", Offset = "0x672680", VA = "0x180673480", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x673260", Offset = "0x672460", VA = "0x180673260", Slot = "7")]
		bool IsInUseByNPC(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06002077 RID: 8311
		[Token(Token = "0x6002077")]
		void SetPlayerUser(NetworkObject playerObject);

		// Token: 0x06002078 RID: 8312
		[Token(Token = "0x6002078")]
		void SetNPCUser(NetworkObject playerObject);
	}
}
