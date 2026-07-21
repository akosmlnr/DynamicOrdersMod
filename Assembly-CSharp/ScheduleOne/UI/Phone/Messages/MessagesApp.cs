using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000D52 RID: 3410
	[Token(Token = "0x2000D52")]
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060062F8 RID: 25336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E34")]
		public MSGConversation currentConversation
		{
			[Token(Token = "0x60062F7")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062F8")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F9")]
		[Address(RVA = "0xA65A60", Offset = "0xA64C60", VA = "0x180A65A60", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0xA65D60", Offset = "0xA64F60", VA = "0x180A65D60", Slot = "8")]
		protected override void Update()
		{
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FB")]
		[Address(RVA = "0xA65370", Offset = "0xA64570", VA = "0x180A65370")]
		private void Loaded()
		{
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FC")]
		[Address(RVA = "0xA64630", Offset = "0xA63830", VA = "0x180A64630")]
		private void Clean()
		{
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0xA64890", Offset = "0xA63A90", VA = "0x180A64890")]
		public void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0xA65670", Offset = "0xA64870", VA = "0x180A65670")]
		public void RepositionEntries()
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0xA657E0", Offset = "0xA649E0", VA = "0x180A657E0")]
		public void ReturnButtonClicked()
		{
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006300")]
		[Address(RVA = "0xA65580", Offset = "0xA64780", VA = "0x180A65580")]
		public void RefreshNotifications()
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006301")]
		[Address(RVA = "0xA64FC0", Offset = "0xA641C0", VA = "0x180A64FC0", Slot = "10")]
		public override void Exit(ExitAction exit)
		{
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006302")]
		[Address(RVA = "0xA659A0", Offset = "0xA64BA0", VA = "0x180A659A0")]
		public void SetCurrentConversation(MSGConversation conversation)
		{
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006303")]
		[Address(RVA = "0xA652A0", Offset = "0xA644A0", VA = "0x180A652A0")]
		public MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			return null;
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006304")]
		[Address(RVA = "0xA65080", Offset = "0xA64280", VA = "0x180A65080")]
		public void FilterByCategory(int category)
		{
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006305")]
		[Address(RVA = "0xA64700", Offset = "0xA63900", VA = "0x180A64700")]
		public void ClearFilter()
		{
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006306")]
		[Address(RVA = "0xA65A00", Offset = "0xA64C00", VA = "0x180A65A00", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006307")]
		[Address(RVA = "0xA65530", Offset = "0xA64730", VA = "0x180A65530", Slot = "9")]
		protected override void OnPhoneOpened()
		{
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006308")]
		[Address(RVA = "0xA65890", Offset = "0xA64A90", VA = "0x180A65890")]
		private void SelectMessageSelectable()
		{
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006309")]
		[Address(RVA = "0xA64E50", Offset = "0xA64050", VA = "0x180A64E50")]
		private IEnumerator DelaySelectCurrentSelectedSelectable()
		{
			return null;
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600630A")]
		[Address(RVA = "0xA64F50", Offset = "0xA64150", VA = "0x180A64F50")]
		private IEnumerator DelaySelect()
		{
			return null;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600630B")]
		[Address(RVA = "0xA65800", Offset = "0xA64A00", VA = "0x180A65800")]
		public void SelectDialogueUIPanel(UIPanel uIPanel)
		{
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600630C")]
		[Address(RVA = "0xA64EC0", Offset = "0xA640C0", VA = "0x180A64EC0")]
		private IEnumerator DelaySelectDialogueUIPanel(UIPanel uIPanel)
		{
			return null;
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600630D")]
		[Address(RVA = "0xA65E70", Offset = "0xA65070", VA = "0x180A65E70")]
		public MessagesApp()
		{
		}

		// Token: 0x040044F9 RID: 17657
		[Token(Token = "0x40044F9")]
		[FieldOffset(Offset = "0x0")]
		public static List<MSGConversation> Conversations;

		// Token: 0x040044FA RID: 17658
		[Token(Token = "0x40044FA")]
		[FieldOffset(Offset = "0x8")]
		public static List<MSGConversation> ActiveConversations;

		// Token: 0x040044FB RID: 17659
		[Token(Token = "0x40044FB")]
		[FieldOffset(Offset = "0x68")]
		public List<MessagesApp.CategoryInfo> categoryInfos;

		// Token: 0x040044FC RID: 17660
		[Token(Token = "0x40044FC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("References")]
		protected RectTransform conversationEntryContainer;

		// Token: 0x040044FD RID: 17661
		[Token(Token = "0x40044FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected RectTransform conversationContainer;

		// Token: 0x040044FE RID: 17662
		[Token(Token = "0x40044FE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject homePage;

		// Token: 0x040044FF RID: 17663
		[Token(Token = "0x40044FF")]
		[FieldOffset(Offset = "0x88")]
		public GameObject dialoguePage;

		// Token: 0x04004500 RID: 17664
		[Token(Token = "0x4004500")]
		[FieldOffset(Offset = "0x90")]
		public Text dialoguePageNameText;

		// Token: 0x04004501 RID: 17665
		[Token(Token = "0x4004501")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform relationshipContainer;

		// Token: 0x04004502 RID: 17666
		[Token(Token = "0x4004502")]
		[FieldOffset(Offset = "0xA0")]
		public Scrollbar relationshipScrollbar;

		// Token: 0x04004503 RID: 17667
		[Token(Token = "0x4004503")]
		[FieldOffset(Offset = "0xA8")]
		public Tooltip relationshipTooltip;

		// Token: 0x04004504 RID: 17668
		[Token(Token = "0x4004504")]
		[FieldOffset(Offset = "0xB0")]
		public RectTransform debtContainer;

		// Token: 0x04004505 RID: 17669
		[Token(Token = "0x4004505")]
		[FieldOffset(Offset = "0xB8")]
		public Text debtLabel;

		// Token: 0x04004506 RID: 17670
		[Token(Token = "0x4004506")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform standardsContainer;

		// Token: 0x04004507 RID: 17671
		[Token(Token = "0x4004507")]
		[FieldOffset(Offset = "0xC8")]
		public Image standardsStar;

		// Token: 0x04004508 RID: 17672
		[Token(Token = "0x4004508")]
		[FieldOffset(Offset = "0xD0")]
		public Tooltip standardsTooltip;

		// Token: 0x04004509 RID: 17673
		[Token(Token = "0x4004509")]
		[FieldOffset(Offset = "0xD8")]
		public RectTransform iconContainerRect;

		// Token: 0x0400450A RID: 17674
		[Token(Token = "0x400450A")]
		[FieldOffset(Offset = "0xE0")]
		public Image iconImage;

		// Token: 0x0400450B RID: 17675
		[Token(Token = "0x400450B")]
		[FieldOffset(Offset = "0xE8")]
		public Sprite BlankAvatarSprite;

		// Token: 0x0400450C RID: 17676
		[Token(Token = "0x400450C")]
		[FieldOffset(Offset = "0xF0")]
		public DealWindowSelector DealWindowSelector;

		// Token: 0x0400450D RID: 17677
		[Token(Token = "0x400450D")]
		[FieldOffset(Offset = "0xF8")]
		public PhoneShopInterface PhoneShopInterface;

		// Token: 0x0400450E RID: 17678
		[Token(Token = "0x400450E")]
		[FieldOffset(Offset = "0x100")]
		public CounterofferInterface CounterofferInterface;

		// Token: 0x0400450F RID: 17679
		[Token(Token = "0x400450F")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform ClearFilterButton;

		// Token: 0x04004510 RID: 17680
		[Token(Token = "0x4004510")]
		[FieldOffset(Offset = "0x110")]
		public Button[] CategoryButtons;

		// Token: 0x04004511 RID: 17681
		[Token(Token = "0x4004511")]
		[FieldOffset(Offset = "0x118")]
		public AudioSourceController MessageReceivedSound;

		// Token: 0x04004512 RID: 17682
		[Token(Token = "0x4004512")]
		[FieldOffset(Offset = "0x120")]
		public AudioSourceController MessageSentSound;

		// Token: 0x04004513 RID: 17683
		[Token(Token = "0x4004513")]
		[FieldOffset(Offset = "0x128")]
		public ConfirmationPopup ConfirmationPopup;

		// Token: 0x04004514 RID: 17684
		[Token(Token = "0x4004514")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject conversationEntryPrefab;

		// Token: 0x04004515 RID: 17685
		[Token(Token = "0x4004515")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected GameObject conversationContainerPrefab;

		// Token: 0x04004516 RID: 17686
		[Token(Token = "0x4004516")]
		[FieldOffset(Offset = "0x140")]
		public GameObject messageBubblePrefab;

		// Token: 0x04004517 RID: 17687
		[Token(Token = "0x4004517")]
		[FieldOffset(Offset = "0x148")]
		public List<MSGConversation> unreadConversations;

		// Token: 0x04004518 RID: 17688
		[Token(Token = "0x4004518")]
		[FieldOffset(Offset = "0x150")]
		[Header("Custom UI")]
		public UIScreen mainMessagesUIScreen;

		// Token: 0x04004519 RID: 17689
		[Token(Token = "0x4004519")]
		[FieldOffset(Offset = "0x158")]
		public UIPanel mainMessagesUIPanel;

		// Token: 0x0400451A RID: 17690
		[Token(Token = "0x400451A")]
		[FieldOffset(Offset = "0x160")]
		public UIScreen dialogueMainUIScreen;

		// Token: 0x02000D53 RID: 3411
		[Token(Token = "0x2000D53")]
		[Serializable]
		public class CategoryInfo
		{
			// Token: 0x0600630F RID: 25359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600630F")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public CategoryInfo()
			{
			}

			// Token: 0x0400451C RID: 17692
			[Token(Token = "0x400451C")]
			[FieldOffset(Offset = "0x10")]
			public EConversationCategory Category;

			// Token: 0x0400451D RID: 17693
			[Token(Token = "0x400451D")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x0400451E RID: 17694
			[Token(Token = "0x400451E")]
			[FieldOffset(Offset = "0x20")]
			public Color Color;
		}
	}
}
