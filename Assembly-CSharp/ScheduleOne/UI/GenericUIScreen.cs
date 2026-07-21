using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000C4E RID: 3150
	[Token(Token = "0x2000C4E")]
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x00017538 File Offset: 0x00015738
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5E")]
		public bool IsOpen
		{
			[Token(Token = "0x6005C3F")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C40")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x9D91E0", Offset = "0x9D83E0", VA = "0x1809D91E0")]
		private void Awake()
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x9D9550", Offset = "0x9D8750", VA = "0x1809D9550")]
		public void Open()
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x9D9280", Offset = "0x9D8480", VA = "0x1809D9280")]
		public void Close()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x9D94F0", Offset = "0x9D86F0", VA = "0x1809D94F0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x9D9750", Offset = "0x9D8950", VA = "0x1809D9750")]
		public GenericUIScreen()
		{
		}

		// Token: 0x04003E85 RID: 16005
		[Token(Token = "0x4003E85")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string Name;

		// Token: 0x04003E86 RID: 16006
		[Token(Token = "0x4003E86")]
		[FieldOffset(Offset = "0x30")]
		public bool UseExitActions;

		// Token: 0x04003E87 RID: 16007
		[Token(Token = "0x4003E87")]
		[FieldOffset(Offset = "0x34")]
		public int ExitActionPriority;

		// Token: 0x04003E88 RID: 16008
		[Token(Token = "0x4003E88")]
		[FieldOffset(Offset = "0x38")]
		public bool CanExitWithRightClick;

		// Token: 0x04003E89 RID: 16009
		[Token(Token = "0x4003E89")]
		[FieldOffset(Offset = "0x39")]
		public bool ReenableControlsOnClose;

		// Token: 0x04003E8A RID: 16010
		[Token(Token = "0x4003E8A")]
		[FieldOffset(Offset = "0x3A")]
		public bool ReenableInventoryOnClose;

		// Token: 0x04003E8B RID: 16011
		[Token(Token = "0x4003E8B")]
		[FieldOffset(Offset = "0x3B")]
		public bool ReenableEquippingOnClose;

		// Token: 0x04003E8C RID: 16012
		[Token(Token = "0x4003E8C")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onOpen;

		// Token: 0x04003E8D RID: 16013
		[Token(Token = "0x4003E8D")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onClose;
	}
}
