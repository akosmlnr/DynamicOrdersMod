using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.UI.Relations;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class ContactsApp : App<ContactsApp>
	{
		// Token: 0x06006346 RID: 25414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006346")]
		[Address(RVA = "0xA587E0", Offset = "0xA579E0", VA = "0x180A587E0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006347")]
		[Address(RVA = "0xA59F10", Offset = "0xA59110", VA = "0x180A59F10", Slot = "8")]
		protected override void Update()
		{
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006348")]
		[Address(RVA = "0xA57940", Offset = "0xA56B40", VA = "0x180A57940")]
		private RelationCircle GetRelationCircle(string npcID)
		{
			return null;
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006349")]
		[Address(RVA = "0xA57930", Offset = "0xA56B30", VA = "0x180A57930")]
		private void CircleClicked(RelationCircle circ)
		{
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634A")]
		[Address(RVA = "0xA57A20", Offset = "0xA56C20", VA = "0x180A57A20")]
		private void Select(RelationCircle circ)
		{
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634B")]
		[Address(RVA = "0xA57C80", Offset = "0xA56E80", VA = "0x180A57C80")]
		public void SetSelectedRegion(EMapRegion region, bool selectNPC)
		{
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634C")]
		[Address(RVA = "0xA5A130", Offset = "0xA59330", VA = "0x180A5A130")]
		private void ZoomToRect(RectTransform rect)
		{
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634D")]
		[Address(RVA = "0xA59E70", Offset = "0xA59070", VA = "0x180A59E70")]
		private void StopContentMove()
		{
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634E")]
		[Address(RVA = "0xA57B00", Offset = "0xA56D00", VA = "0x180A57B00", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600634F")]
		[Address(RVA = "0xA5A320", Offset = "0xA59520", VA = "0x180A5A320")]
		public ContactsApp()
		{
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006350")]
		[Address(RVA = "0xA59E90", Offset = "0xA59090", VA = "0x180A59E90")]
		[CompilerGenerated]
		private void <SetSelectedRegion>g__SetCartelInfluenceDisplayVisible|37_0(bool vis)
		{
		}

		// Token: 0x04004551 RID: 17745
		[Token(Token = "0x4004551")]
		[FieldOffset(Offset = "0x68")]
		public EMapRegion SelectedRegion;

		// Token: 0x04004552 RID: 17746
		[Token(Token = "0x4004552")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict;

		// Token: 0x04004553 RID: 17747
		[Token(Token = "0x4004553")]
		[FieldOffset(Offset = "0x78")]
		[Header("References")]
		public PinchableScrollRect ScrollRect;

		// Token: 0x04004554 RID: 17748
		[Token(Token = "0x4004554")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform CirclesContainer;

		// Token: 0x04004555 RID: 17749
		[Token(Token = "0x4004555")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform DemoCirclesContainer;

		// Token: 0x04004556 RID: 17750
		[Token(Token = "0x4004556")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform TutorialCirclesContainer;

		// Token: 0x04004557 RID: 17751
		[Token(Token = "0x4004557")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform ConnectionsContainer;

		// Token: 0x04004558 RID: 17752
		[Token(Token = "0x4004558")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform ContentRect;

		// Token: 0x04004559 RID: 17753
		[Token(Token = "0x4004559")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform SelectionIndicator;

		// Token: 0x0400455A RID: 17754
		[Token(Token = "0x400455A")]
		[FieldOffset(Offset = "0xB0")]
		public ContactsDetailPanel DetailPanel;

		// Token: 0x0400455B RID: 17755
		[Token(Token = "0x400455B")]
		[FieldOffset(Offset = "0xB8")]
		public ContactsApp.RegionUI[] RegionUIs;

		// Token: 0x0400455C RID: 17756
		[Token(Token = "0x400455C")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform RegionSelectionContainer;

		// Token: 0x0400455D RID: 17757
		[Token(Token = "0x400455D")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform RegionSelectionIndicator;

		// Token: 0x0400455E RID: 17758
		[Token(Token = "0x400455E")]
		[FieldOffset(Offset = "0xD0")]
		public RectTransform InfluenceContainer;

		// Token: 0x0400455F RID: 17759
		[Token(Token = "0x400455F")]
		[FieldOffset(Offset = "0xD8")]
		public Slider InfluenceSlider;

		// Token: 0x04004560 RID: 17760
		[Token(Token = "0x4004560")]
		[FieldOffset(Offset = "0xE0")]
		public Text InfluenceCountLabel;

		// Token: 0x04004561 RID: 17761
		[Token(Token = "0x4004561")]
		[FieldOffset(Offset = "0xE8")]
		public RectTransform UnlockRegionSliderNotch;

		// Token: 0x04004562 RID: 17762
		[Token(Token = "0x4004562")]
		[FieldOffset(Offset = "0xF0")]
		public Text InfluenceText;

		// Token: 0x04004563 RID: 17763
		[Token(Token = "0x4004563")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform LowerContainer;

		// Token: 0x04004564 RID: 17764
		[Token(Token = "0x4004564")]
		[FieldOffset(Offset = "0x100")]
		public RectTransform HorizontalScrollbarRectTransform;

		// Token: 0x04004565 RID: 17765
		[Token(Token = "0x4004565")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform RegionLockedContainer;

		// Token: 0x04004566 RID: 17766
		[Token(Token = "0x4004566")]
		[FieldOffset(Offset = "0x110")]
		public RectTransform RegionLocked_Rank;

		// Token: 0x04004567 RID: 17767
		[Token(Token = "0x4004567")]
		[FieldOffset(Offset = "0x118")]
		public RectTransform RegionLocked_CartelInfluence;

		// Token: 0x04004568 RID: 17768
		[Token(Token = "0x4004568")]
		[FieldOffset(Offset = "0x120")]
		public Text RegionLocked_CartelInfluence_Text;

		// Token: 0x04004569 RID: 17769
		[Token(Token = "0x4004569")]
		[FieldOffset(Offset = "0x128")]
		public RectTransform RegionLocked_Unavailable;

		// Token: 0x0400456A RID: 17770
		[Token(Token = "0x400456A")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public GameObject ConnectionPrefab;

		// Token: 0x0400456B RID: 17771
		[Token(Token = "0x400456B")]
		[FieldOffset(Offset = "0x138")]
		[Header("Custom UI")]
		[SerializeField]
		protected UIScreen uiScreen;

		// Token: 0x0400456C RID: 17772
		[Token(Token = "0x400456C")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected UIMapPanel uiPanel;

		// Token: 0x0400456D RID: 17773
		[Token(Token = "0x400456D")]
		[FieldOffset(Offset = "0x148")]
		private List<RelationCircle> RelationCircles;

		// Token: 0x0400456E RID: 17774
		[Token(Token = "0x400456E")]
		[FieldOffset(Offset = "0x150")]
		private Coroutine contentMoveRoutine;

		// Token: 0x0400456F RID: 17775
		[Token(Token = "0x400456F")]
		[FieldOffset(Offset = "0x158")]
		private List<Tuple<NPC, NPC>> connections;

		// Token: 0x02000D60 RID: 3424
		[Token(Token = "0x2000D60")]
		[Serializable]
		public class RegionUI
		{
			// Token: 0x17000E3E RID: 3646
			// (get) Token: 0x06006351 RID: 25425 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x06006352 RID: 25426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E3E")]
			public List<NPC> npcs
			{
				[Token(Token = "0x6006351")]
				[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006352")]
				[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06006353 RID: 25427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006353")]
			[Address(RVA = "0xA6B020", Offset = "0xA6A220", VA = "0x180A6B020")]
			public RegionUI()
			{
			}

			// Token: 0x04004570 RID: 17776
			[Token(Token = "0x4004570")]
			[FieldOffset(Offset = "0x10")]
			public EMapRegion Region;

			// Token: 0x04004571 RID: 17777
			[Token(Token = "0x4004571")]
			[FieldOffset(Offset = "0x18")]
			public Button Button;

			// Token: 0x04004572 RID: 17778
			[Token(Token = "0x4004572")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform Container;

			// Token: 0x04004573 RID: 17779
			[Token(Token = "0x4004573")]
			[FieldOffset(Offset = "0x28")]
			public RectTransform ConnectionsContainer;
		}
	}
}
