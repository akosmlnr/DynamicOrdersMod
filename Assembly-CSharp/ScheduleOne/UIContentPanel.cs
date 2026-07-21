using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public class UIContentPanel : UIPanel
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xA05C60", Offset = "0xA04E60", VA = "0x180A05C60", Slot = "12")]
		protected override void DetectInput()
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xA05E60", Offset = "0xA05060", VA = "0x180A05E60", Slot = "13")]
		protected override bool Navigate(Vector2 navDir)
		{
			return default(bool);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xA06800", Offset = "0xA05A00", VA = "0x180A06800")]
		public UIContentPanel()
		{
		}

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Tooltip("Default is ImmediateDirection. ImmediatelyDirection is suitable if selectables are placed in grid format. NearestDirectionAndDistance is suitable for non-grid format")]
		private UIPanel.UINavigationType uiPanelNavigationType;
	}
}
