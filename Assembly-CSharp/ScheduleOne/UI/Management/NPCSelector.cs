using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	public class NPCSelector : MonoBehaviour
	{
		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06006447 RID: 25671 RVA: 0x00018AF8 File Offset: 0x00016CF8
		// (set) Token: 0x06006448 RID: 25672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E53")]
		public bool IsOpen
		{
			[Token(Token = "0x6006447")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006448")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006449")]
		[Address(RVA = "0xA7C230", Offset = "0xA7B430", VA = "0x180A7C230")]
		private void Start()
		{
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644A")]
		[Address(RVA = "0xA7C020", Offset = "0xA7B220", VA = "0x180A7C020", Slot = "4")]
		public virtual void Open(string selectionTitle, Type typeRequirement, Action<NPC> _callback)
		{
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644B")]
		[Address(RVA = "0xA7BA60", Offset = "0xA7AC60", VA = "0x180A7BA60", Slot = "5")]
		public virtual void Close(bool returnToClipboard)
		{
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644C")]
		[Address(RVA = "0xA7C380", Offset = "0xA7B580", VA = "0x180A7C380")]
		private void Update()
		{
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600644D")]
		[Address(RVA = "0xA7BE00", Offset = "0xA7B000", VA = "0x180A7BE00")]
		private NPC GetHoveredNPC()
		{
			return null;
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x00018B10 File Offset: 0x00016D10
		[Token(Token = "0x600644E")]
		[Address(RVA = "0xA7BF00", Offset = "0xA7B100", VA = "0x180A7BF00")]
		public bool IsNPCTypeValid(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644F")]
		[Address(RVA = "0xA7BFC0", Offset = "0xA7B1C0", VA = "0x180A7BFC0")]
		public void NPCClicked(NPC npc)
		{
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006450")]
		[Address(RVA = "0xA7BA40", Offset = "0xA7AC40", VA = "0x180A7BA40")]
		private void ClipboardClosed()
		{
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006451")]
		[Address(RVA = "0xA7BDA0", Offset = "0xA7AFA0", VA = "0x180A7BDA0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006452")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NPCSelector()
		{
		}

		// Token: 0x04004652 RID: 18002
		[Token(Token = "0x4004652")]
		public const float SELECTION_RANGE = 5f;

		// Token: 0x04004654 RID: 18004
		[Token(Token = "0x4004654")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04004655 RID: 18005
		[Token(Token = "0x4004655")]
		[FieldOffset(Offset = "0x28")]
		public Color HoverOutlineColor;

		// Token: 0x04004656 RID: 18006
		[Token(Token = "0x4004656")]
		[FieldOffset(Offset = "0x38")]
		private Type TypeRequirement;

		// Token: 0x04004657 RID: 18007
		[Token(Token = "0x4004657")]
		[FieldOffset(Offset = "0x40")]
		private Action<NPC> callback;

		// Token: 0x04004658 RID: 18008
		[Token(Token = "0x4004658")]
		[FieldOffset(Offset = "0x48")]
		private NPC hoveredNPC;

		// Token: 0x04004659 RID: 18009
		[Token(Token = "0x4004659")]
		[FieldOffset(Offset = "0x50")]
		private NPC highlightedNPC;
	}
}
