using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>, IPostSleepEvent
	{
		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x00017C58 File Offset: 0x00015E58
		// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBE")]
		public bool IsRunning
		{
			[Token(Token = "0x6005ECF")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005ED0")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x00017C70 File Offset: 0x00015E70
		// (set) Token: 0x06005ED2 RID: 24274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBF")]
		public int Order
		{
			[Token(Token = "0x6005ED1")]
			[Address(RVA = "0x6A20F0", Offset = "0x6A12F0", VA = "0x1806A20F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005ED2")]
			[Address(RVA = "0x6C1170", Offset = "0x6C0370", VA = "0x1806C1170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0xA10900", Offset = "0xA0FB00", VA = "0x180A10900")]
		public void QueueUnlocked(EMapRegion _region)
		{
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0xA10990", Offset = "0xA0FB90", VA = "0x180A10990", Slot = "9")]
		public void StartEvent()
		{
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0xA10840", Offset = "0xA0FA40", VA = "0x180A10840")]
		public void EndEvent()
		{
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0xA110C0", Offset = "0xA102C0", VA = "0x180A110C0")]
		public RegionUnlockedCanvas()
		{
		}

		// Token: 0x0400412F RID: 16687
		[Token(Token = "0x400412F")]
		[FieldOffset(Offset = "0x30")]
		public Animation OpenCloseAnim;

		// Token: 0x04004130 RID: 16688
		[Token(Token = "0x4004130")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI RegionLabel;

		// Token: 0x04004131 RID: 16689
		[Token(Token = "0x4004131")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI RegionDescription;

		// Token: 0x04004132 RID: 16690
		[Token(Token = "0x4004132")]
		[FieldOffset(Offset = "0x48")]
		public Image RegionImage;

		// Token: 0x04004133 RID: 16691
		[Token(Token = "0x4004133")]
		[FieldOffset(Offset = "0x50")]
		public UIScreen UIScreen;

		// Token: 0x04004134 RID: 16692
		[Token(Token = "0x4004134")]
		[FieldOffset(Offset = "0x58")]
		private EMapRegion region;
	}
}
