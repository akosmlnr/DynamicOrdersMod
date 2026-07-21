using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	[RequireComponent(typeof(RectTransform))]
	public class UISelectable : UITrigger, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x73A010", Offset = "0x739210", VA = "0x18073A010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027A")]
		public UIPanel ParentPanel
		{
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700027B")]
		public Text Label
		{
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x1700027C")]
		public bool AllowTriggerSubmitWithInputDescriptors
		{
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x1700027D")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0xADFDC0", Offset = "0xADEFC0", VA = "0x180ADFDC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0xADF120", Offset = "0xADE320", VA = "0x180ADF120")]
		internal IReadOnlyList<InputDescriptor> GetInputDescriptors()
		{
			return null;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0xADEE20", Offset = "0xADE020", VA = "0x180ADEE20", Slot = "8")]
		protected override void Awake()
		{
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0xADF420", Offset = "0xADE620", VA = "0x180ADF420", Slot = "18")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0xADF560", Offset = "0xADE760", VA = "0x180ADF560", Slot = "19")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0xADF7D0", Offset = "0xADE9D0", VA = "0x180ADF7D0", Slot = "20")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0xADF9D0", Offset = "0xADEBD0", VA = "0x180ADF9D0", Slot = "13")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0xADF0E0", Offset = "0xADE2E0", VA = "0x180ADF0E0", Slot = "21")]
		protected virtual bool DeselectOnPointerExit()
		{
			return default(bool);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0xADF5F0", Offset = "0xADE7F0", VA = "0x180ADF5F0", Slot = "14")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0xADFC30", Offset = "0xADEE30", VA = "0x180ADFC30", Slot = "16")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0xADF3F0", Offset = "0xADE5F0", VA = "0x180ADF3F0", Slot = "17")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0xADFB00", Offset = "0xADED00", VA = "0x180ADFB00", Slot = "9")]
		internal override void OnReset()
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0")]
		internal void SetParentPanel(UIPanel panel)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0xADF170", Offset = "0xADE370", VA = "0x180ADF170")]
		internal bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0xADFCA0", Offset = "0xADEEA0", VA = "0x180ADFCA0")]
		private void SetSelectedImageVisible(bool visible)
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0xADFD30", Offset = "0xADEF30", VA = "0x180ADFD30")]
		public UISelectable()
		{
		}

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		private List<InputDescriptor> inputDescriptors;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Support default A to fire the button click event even if there are inputDescriptors")]
		[SerializeField]
		private bool allowTriggerSubmitWithInputDescriptors;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("A gameobject that will show when selected. Only shown when in Controller mode")]
		[SerializeField]
		private GameObject selectedImage;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Search and Add selectable to a parent Panel on Awake")]
		private bool addToPanelOnAwake;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		[Tooltip("On Disable, tell the parent Panel to search for another valid selectable to select")]
		private bool findAnotherSelectableInPanelOnDisable;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x72")]
		[SerializeField]
		[Tooltip("Set to true if you want this to be not selectable when UGUI interactable is set to false")]
		private bool blockSelectionOnInteractableFalse;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Components")]
		private Text _label;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent OnSelected;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent OnDeselected;
	}
}
