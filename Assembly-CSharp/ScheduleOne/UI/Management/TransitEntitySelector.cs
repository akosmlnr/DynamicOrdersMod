using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D9C RID: 3484
	[Token(Token = "0x2000D9C")]
	public class TransitEntitySelector : MonoBehaviour
	{
		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x0600647E RID: 25726 RVA: 0x00018B70 File Offset: 0x00016D70
		// (set) Token: 0x0600647F RID: 25727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E55")]
		public bool IsOpen
		{
			[Token(Token = "0x600647E")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600647F")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006480")]
		[Address(RVA = "0xA84B50", Offset = "0xA83D50", VA = "0x180A84B50")]
		private void Start()
		{
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006481")]
		[Address(RVA = "0xA84390", Offset = "0xA83590", VA = "0x180A84390", Slot = "4")]
		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, [Optional] List<Transform> transitLineSources, bool selectingDestination = true)
		{
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006482")]
		[Address(RVA = "0xA84E90", Offset = "0xA84090", VA = "0x180A84E90")]
		private void UpdateTransitLines()
		{
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006483")]
		[Address(RVA = "0xA83990", Offset = "0xA82B90", VA = "0x180A83990", Slot = "5")]
		public virtual void Close(bool returnToClipboard, bool pushChanges)
		{
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006484")]
		[Address(RVA = "0xA852B0", Offset = "0xA844B0", VA = "0x180A852B0")]
		private void Update()
		{
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006485")]
		[Address(RVA = "0xA84190", Offset = "0xA83390", VA = "0x180A84190")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006486")]
		[Address(RVA = "0xA84CA0", Offset = "0xA83EA0", VA = "0x180A84CA0")]
		private void UpdateInstructions()
		{
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006487")]
		[Address(RVA = "0xA83EE0", Offset = "0xA830E0", VA = "0x180A83EE0")]
		private ITransitEntity GetHoveredObject()
		{
			return null;
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00018B88 File Offset: 0x00016D88
		[Token(Token = "0x6006488")]
		[Address(RVA = "0xA83FE0", Offset = "0xA831E0", VA = "0x180A83FE0")]
		public bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006489")]
		[Address(RVA = "0xA841A0", Offset = "0xA833A0", VA = "0x180A841A0")]
		public void ObjectClicked(ITransitEntity obj)
		{
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648A")]
		[Address(RVA = "0xA84A50", Offset = "0xA83C50", VA = "0x180A84A50")]
		private void SetSelectionOutline(ITransitEntity obj, bool on)
		{
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648B")]
		[Address(RVA = "0xA7C930", Offset = "0xA7BB30", VA = "0x180A7C930")]
		private void ClipboardClosed()
		{
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648C")]
		[Address(RVA = "0xA7CEE0", Offset = "0xA7C0E0", VA = "0x180A7CEE0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648D")]
		[Address(RVA = "0xA85770", Offset = "0xA84970", VA = "0x180A85770")]
		public TransitEntitySelector()
		{
		}

		// Token: 0x04004684 RID: 18052
		[Token(Token = "0x4004684")]
		public const float SELECTION_RANGE = 5f;

		// Token: 0x04004686 RID: 18054
		[Token(Token = "0x4004686")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04004687 RID: 18055
		[Token(Token = "0x4004687")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color HoverOutlineColor;

		// Token: 0x04004688 RID: 18056
		[Token(Token = "0x4004688")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color SelectOutlineColor;

		// Token: 0x04004689 RID: 18057
		[Token(Token = "0x4004689")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int maxSelectedObjects;

		// Token: 0x0400468A RID: 18058
		[Token(Token = "0x400468A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ITransitEntity> selectedObjects;

		// Token: 0x0400468B RID: 18059
		[Token(Token = "0x400468B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Type> typeRequirements;

		// Token: 0x0400468C RID: 18060
		[Token(Token = "0x400468C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TransitEntitySelector.ObjectFilter objectFilter;

		// Token: 0x0400468D RID: 18061
		[Token(Token = "0x400468D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<List<ITransitEntity>> callback;

		// Token: 0x0400468E RID: 18062
		[Token(Token = "0x400468E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ITransitEntity hoveredObj;

		// Token: 0x0400468F RID: 18063
		[Token(Token = "0x400468F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ITransitEntity highlightedObj;

		// Token: 0x04004690 RID: 18064
		[Token(Token = "0x4004690")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string selectionTitle;

		// Token: 0x04004691 RID: 18065
		[Token(Token = "0x4004691")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool changesMade;

		// Token: 0x04004692 RID: 18066
		[Token(Token = "0x4004692")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Transform> transitSources;

		// Token: 0x04004693 RID: 18067
		[Token(Token = "0x4004693")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TransitLineVisuals> transitLines;

		// Token: 0x04004694 RID: 18068
		[Token(Token = "0x4004694")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool selectDestination;

		// Token: 0x02000D9D RID: 3485
		// (Invoke) Token: 0x0600648F RID: 25743
		[Token(Token = "0x2000D9D")]
		public delegate bool ObjectFilter(ITransitEntity obj, out string reason);
	}
}
