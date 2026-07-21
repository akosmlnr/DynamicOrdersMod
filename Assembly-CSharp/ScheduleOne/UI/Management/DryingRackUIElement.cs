using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA4 RID: 3492
	[Token(Token = "0x2000DA4")]
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060064B0 RID: 25776 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064B1 RID: 25777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5C")]
		public DryingRack AssignedRack
		{
			[Token(Token = "0x60064B0")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B1")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0xA71B20", Offset = "0xA70D20", VA = "0x180A71B20")]
		public void Initialize(DryingRack rack)
		{
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0xA71C00", Offset = "0xA70E00", VA = "0x180A71C00", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B4")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DryingRackUIElement()
		{
		}

		// Token: 0x040046A4 RID: 18084
		[Token(Token = "0x40046A4")]
		[FieldOffset(Offset = "0x58")]
		public Image TargetQualityIcon;
	}
}
