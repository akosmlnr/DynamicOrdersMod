using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C3D RID: 3133
	[Token(Token = "0x2000C3D")]
	public class DropdownUI : Dropdown
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06005BDA RID: 23514 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005BDB RID: 23515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Action OnOpen
		{
			[Token(Token = "0x6005BDA")]
			[Address(RVA = "0x9CCF20", Offset = "0x9CC120", VA = "0x1809CCF20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005BDB")]
			[Address(RVA = "0x9CCFD0", Offset = "0x9CC1D0", VA = "0x1809CCFD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x9CCEC0", Offset = "0x9CC0C0", VA = "0x1809CCEC0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x9CCE80", Offset = "0x9CC080", VA = "0x1809CCE80", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x9CCED0", Offset = "0x9CC0D0", VA = "0x1809CCED0")]
		public DropdownUI()
		{
		}
	}
}
