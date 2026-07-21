using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	public class ObjectSelector : MonoBehaviour
	{
		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x00018B28 File Offset: 0x00016D28
		// (set) Token: 0x06006454 RID: 25684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E54")]
		public bool IsOpen
		{
			[Token(Token = "0x6006453")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006454")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006455")]
		[Address(RVA = "0xA7DC00", Offset = "0xA7CE00", VA = "0x180A7DC00")]
		private void Start()
		{
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006456")]
		[Address(RVA = "0xA7D550", Offset = "0xA7C750", VA = "0x180A7D550", Slot = "4")]
		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, Property property, ObjectSelector.ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, [Optional] List<Transform> transitLineSources)
		{
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006457")]
		[Address(RVA = "0xA7DF40", Offset = "0xA7D140", VA = "0x180A7DF40")]
		private void UpdateTransitLines()
		{
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006458")]
		[Address(RVA = "0xA7C950", Offset = "0xA7BB50", VA = "0x180A7C950", Slot = "5")]
		public virtual void Close(bool returnToClipboard, bool pushChanges)
		{
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006459")]
		[Address(RVA = "0xA7E2B0", Offset = "0xA7D4B0", VA = "0x180A7E2B0")]
		private void Update()
		{
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645A")]
		[Address(RVA = "0xA7D2A0", Offset = "0xA7C4A0", VA = "0x180A7D2A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645B")]
		[Address(RVA = "0xA7DD50", Offset = "0xA7CF50", VA = "0x180A7DD50")]
		private void UpdateInstructions()
		{
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600645C")]
		[Address(RVA = "0xA7CF50", Offset = "0xA7C150", VA = "0x180A7CF50")]
		private BuildableItem GetHoveredObject()
		{
			return null;
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x00018B40 File Offset: 0x00016D40
		[Token(Token = "0x600645D")]
		[Address(RVA = "0xA7D050", Offset = "0xA7C250", VA = "0x180A7D050")]
		public bool IsObjectTypeValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645E")]
		[Address(RVA = "0xA7D2B0", Offset = "0xA7C4B0", VA = "0x180A7D2B0")]
		public void ObjectClicked(BuildableItem obj)
		{
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645F")]
		[Address(RVA = "0xA7DB90", Offset = "0xA7CD90", VA = "0x180A7DB90")]
		private void SetSelectionOutline(BuildableItem obj, bool on)
		{
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006460")]
		[Address(RVA = "0xA7C930", Offset = "0xA7BB30", VA = "0x180A7C930")]
		private void ClipboardClosed()
		{
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006461")]
		[Address(RVA = "0xA7CEE0", Offset = "0xA7C0E0", VA = "0x180A7CEE0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006462")]
		[Address(RVA = "0xA7E840", Offset = "0xA7DA40", VA = "0x180A7E840")]
		public ObjectSelector()
		{
		}

		// Token: 0x0400465A RID: 18010
		[Token(Token = "0x400465A")]
		public const float SELECTION_RANGE = 5f;

		// Token: 0x0400465C RID: 18012
		[Token(Token = "0x400465C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x0400465D RID: 18013
		[Token(Token = "0x400465D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color HoverOutlineColor;

		// Token: 0x0400465E RID: 18014
		[Token(Token = "0x400465E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color SelectOutlineColor;

		// Token: 0x0400465F RID: 18015
		[Token(Token = "0x400465F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int maxSelectedObjects;

		// Token: 0x04004660 RID: 18016
		[Token(Token = "0x4004660")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BuildableItem> selectedObjects;

		// Token: 0x04004661 RID: 18017
		[Token(Token = "0x4004661")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Type> typeRequirements;

		// Token: 0x04004662 RID: 18018
		[Token(Token = "0x4004662")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04004663 RID: 18019
		[Token(Token = "0x4004663")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<List<BuildableItem>> callback;

		// Token: 0x04004664 RID: 18020
		[Token(Token = "0x4004664")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BuildableItem hoveredObj;

		// Token: 0x04004665 RID: 18021
		[Token(Token = "0x4004665")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BuildableItem highlightedObj;

		// Token: 0x04004666 RID: 18022
		[Token(Token = "0x4004666")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string selectionTitle;

		// Token: 0x04004667 RID: 18023
		[Token(Token = "0x4004667")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool changesMade;

		// Token: 0x04004668 RID: 18024
		[Token(Token = "0x4004668")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Transform> transitSources;

		// Token: 0x04004669 RID: 18025
		[Token(Token = "0x4004669")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TransitLineVisuals> transitLines;

		// Token: 0x0400466A RID: 18026
		[Token(Token = "0x400466A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Property targetProperty;

		// Token: 0x02000D96 RID: 3478
		// (Invoke) Token: 0x06006464 RID: 25700
		[Token(Token = "0x2000D96")]
		public delegate bool ObjectFilter(BuildableItem obj, out string reason);
	}
}
