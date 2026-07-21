using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x06005BFE RID: 23550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x9CD270", Offset = "0x9CC470", VA = "0x1809CD270")]
		public void Open(string text)
		{
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x74D910", Offset = "0x74CB10", VA = "0x18074D910")]
		public void Close()
		{
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x9CD330", Offset = "0x9CC530", VA = "0x1809CD330")]
		private void Update()
		{
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x6C53A0", Offset = "0x6C45A0", VA = "0x1806C53A0")]
		public FeedbackFormPopup()
		{
		}

		// Token: 0x04003E45 RID: 15941
		[Token(Token = "0x4003E45")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		// Token: 0x04003E46 RID: 15942
		[Token(Token = "0x4003E46")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoClose;

		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		[FieldOffset(Offset = "0x2C")]
		private float closeTime;
	}
}
