using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public abstract class UIPopupScreen : UIScreen
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700026A")]
		public string PopupID
		{
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		public virtual void Open(params object[] args)
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		public virtual void Close()
		{
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0xAD77D0", Offset = "0xAD69D0", VA = "0x180AD77D0")]
		protected UIPopupScreen()
		{
		}

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Identifier of the PopupScreen when you called OpenPopupScreen from UIScreenManager")]
		private string popupID;
	}
}
