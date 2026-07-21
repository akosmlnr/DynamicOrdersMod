using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x2000D6B")]
	public class AssignedWorkerDisplay : MonoBehaviour
	{
		// Token: 0x0600637C RID: 25468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637C")]
		[Address(RVA = "0xA55C40", Offset = "0xA54E40", VA = "0x180A55C40")]
		public void Set(NPC npc)
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AssignedWorkerDisplay()
		{
		}

		// Token: 0x040045AE RID: 17838
		[Token(Token = "0x40045AE")]
		[FieldOffset(Offset = "0x20")]
		public Image Icon;

		// Token: 0x040045AF RID: 17839
		[Token(Token = "0x40045AF")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI NameLabel;
	}
}
