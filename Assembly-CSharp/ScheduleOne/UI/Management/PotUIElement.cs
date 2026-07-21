using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DAA RID: 3498
	[Token(Token = "0x2000DAA")]
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064CF RID: 25807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E62")]
		public Pot AssignedPot
		{
			[Token(Token = "0x60064CE")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064CF")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D0")]
		[Address(RVA = "0xA7EF80", Offset = "0xA7E180", VA = "0x180A7EF80")]
		public void Initialize(Pot pot)
		{
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0xA7F060", Offset = "0xA7E260", VA = "0x180A7F060", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PotUIElement()
		{
		}

		// Token: 0x040046B0 RID: 18096
		[Token(Token = "0x40046B0")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Image SeedIcon;

		// Token: 0x040046B1 RID: 18097
		[Token(Token = "0x40046B1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NoSeed;

		// Token: 0x040046B2 RID: 18098
		[Token(Token = "0x40046B2")]
		[FieldOffset(Offset = "0x60")]
		public Image Additive1Icon;

		// Token: 0x040046B3 RID: 18099
		[Token(Token = "0x40046B3")]
		[FieldOffset(Offset = "0x68")]
		public Image Additive2Icon;

		// Token: 0x040046B4 RID: 18100
		[Token(Token = "0x40046B4")]
		[FieldOffset(Offset = "0x70")]
		public Image Additive3Icon;
	}
}
