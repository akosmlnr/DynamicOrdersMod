using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DAC RID: 3500
	[Token(Token = "0x2000DAC")]
	public class StorageUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064D9 RID: 25817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E64")]
		public PlaceableStorageEntity AssignedEntity
		{
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064D9")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DA")]
		[Address(RVA = "0xA833C0", Offset = "0xA825C0", VA = "0x180A833C0")]
		public void Initialize(PlaceableStorageEntity entity)
		{
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0xA834F0", Offset = "0xA826F0", VA = "0x180A834F0", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DC")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StorageUIElement()
		{
		}

		// Token: 0x040046B8 RID: 18104
		[Token(Token = "0x40046B8")]
		[FieldOffset(Offset = "0x58")]
		public Image Icon;
	}
}
