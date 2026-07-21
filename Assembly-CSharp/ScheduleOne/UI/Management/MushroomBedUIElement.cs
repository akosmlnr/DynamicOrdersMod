using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA7 RID: 3495
	[Token(Token = "0x2000DA7")]
	public class MushroomBedUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064C0 RID: 25792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5F")]
		public MushroomBed AssignedMustroomBed
		{
			[Token(Token = "0x60064BF")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C0")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0xA7B540", Offset = "0xA7A740", VA = "0x180A7B540")]
		public void Initialize(MushroomBed bed)
		{
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0xA7B620", Offset = "0xA7A820", VA = "0x180A7B620", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MushroomBedUIElement()
		{
		}

		// Token: 0x040046A7 RID: 18087
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Image SpawnIcon;

		// Token: 0x040046A8 RID: 18088
		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NoSpawn;

		// Token: 0x040046A9 RID: 18089
		[Token(Token = "0x40046A9")]
		[FieldOffset(Offset = "0x60")]
		public Image Additive1Icon;

		// Token: 0x040046AA RID: 18090
		[Token(Token = "0x40046AA")]
		[FieldOffset(Offset = "0x68")]
		public Image Additive2Icon;

		// Token: 0x040046AB RID: 18091
		[Token(Token = "0x40046AB")]
		[FieldOffset(Offset = "0x70")]
		public Image Additive3Icon;
	}
}
