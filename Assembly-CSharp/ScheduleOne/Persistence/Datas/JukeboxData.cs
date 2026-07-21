using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public class JukeboxData : GridItemData
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x6023A0", Offset = "0x6015A0", VA = "0x1806023A0")]
		public JukeboxData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, Jukebox.JukeboxState state)
		{
		}

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		[FieldOffset(Offset = "0x58")]
		public Jukebox.JukeboxState State;
	}
}
