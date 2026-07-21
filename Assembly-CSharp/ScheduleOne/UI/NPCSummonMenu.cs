using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C72 RID: 3186
	[Token(Token = "0x2000C72")]
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x00017748 File Offset: 0x00015948
		// (set) Token: 0x06005D38 RID: 23864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7E")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D37")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D38")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x9E3C80", Offset = "0x9E2E80", VA = "0x1809E3C80", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x9E35F0", Offset = "0x9E27F0", VA = "0x1809E35F0")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0x9E3680", Offset = "0x9E2880", VA = "0x1809E3680")]
		public void Open(List<NPC> npcs, Action<NPC> _callback)
		{
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x9E33A0", Offset = "0x9E25A0", VA = "0x1809E33A0")]
		public void Close()
		{
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x9E3640", Offset = "0x9E2840", VA = "0x1809E3640")]
		public void NPCSelected(NPC npc)
		{
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0x9E3D70", Offset = "0x9E2F70", VA = "0x1809E3D70")]
		public NPCSummonMenu()
		{
		}

		// Token: 0x04003FAF RID: 16303
		[Token(Token = "0x4003FAF")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003FB0 RID: 16304
		[Token(Token = "0x4003FB0")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003FB1 RID: 16305
		[Token(Token = "0x4003FB1")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform EntryContainer;

		// Token: 0x04003FB2 RID: 16306
		[Token(Token = "0x4003FB2")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform[] Entries;

		// Token: 0x04003FB3 RID: 16307
		[Token(Token = "0x4003FB3")]
		[FieldOffset(Offset = "0x50")]
		private Action<NPC> callback;
	}
}
