using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000DCB RID: 3531
	[Token(Token = "0x2000DCB")]
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006561 RID: 25953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E70")]
		public Contract CurrentContract
		{
			[Token(Token = "0x6006560")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006561")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x00018CC0 File Offset: 0x00016EC0
		// (set) Token: 0x06006563 RID: 25955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E71")]
		public bool IsOpen
		{
			[Token(Token = "0x6006562")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006563")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06006564 RID: 25956 RVA: 0x00018CD8 File Offset: 0x00016ED8
		// (set) Token: 0x06006565 RID: 25957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E72")]
		public bool TutorialOpen
		{
			[Token(Token = "0x6006564")]
			[Address(RVA = "0x4CBF70", Offset = "0x4CB170", VA = "0x1804CBF70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006565")]
			[Address(RVA = "0x509170", Offset = "0x508370", VA = "0x180509170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x00018CF0 File Offset: 0x00016EF0
		// (set) Token: 0x06006567 RID: 25959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E73")]
		public HandoverScreen.EMode Mode
		{
			[Token(Token = "0x6006566")]
			[Address(RVA = "0x4CBFB0", Offset = "0x4CB1B0", VA = "0x1804CBFB0")]
			[CompilerGenerated]
			get
			{
				return HandoverScreen.EMode.Contract;
			}
			[Token(Token = "0x6006567")]
			[Address(RVA = "0x4E1110", Offset = "0x4E0310", VA = "0x1804E1110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06006568 RID: 25960 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006569 RID: 25961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E74")]
		public Customer CurrentCustomer
		{
			[Token(Token = "0x6006568")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006569")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656A")]
		[Address(RVA = "0xA75910", Offset = "0xA74B10", VA = "0x180A75910", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656B")]
		[Address(RVA = "0xA769B0", Offset = "0xA75BB0", VA = "0x180A769B0")]
		private void Update()
		{
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656C")]
		[Address(RVA = "0xA73C10", Offset = "0xA72E10", VA = "0x180A73C10")]
		private void OpenTutorial()
		{
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656D")]
		[Address(RVA = "0xA72540", Offset = "0xA71740", VA = "0x180A72540")]
		public void CloseTutorial()
		{
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656E")]
		[Address(RVA = "0xA76100", Offset = "0xA75300", VA = "0x180A76100")]
		[Button]
		public void TestOpen()
		{
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656F")]
		[Address(RVA = "0xA73C80", Offset = "0xA72E80", VA = "0x180A73C80", Slot = "7")]
		public virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod, bool _requireFullChanceOfSuccess = false)
		{
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006570")]
		[Address(RVA = "0xA75F50", Offset = "0xA75150", VA = "0x180A75F50")]
		public void SwapActiveScreen()
		{
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006571")]
		[Address(RVA = "0xA725A0", Offset = "0xA717A0", VA = "0x180A725A0", Slot = "8")]
		public virtual void Close(HandoverScreen.EHandoverOutcome outcome)
		{
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006572")]
		[Address(RVA = "0xA72E20", Offset = "0xA72020", VA = "0x180A72E20")]
		public void DonePressed()
		{
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006573")]
		[Address(RVA = "0xA756E0", Offset = "0xA748E0", VA = "0x180A756E0")]
		private void RecordOriginalLocations()
		{
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006574")]
		[Address(RVA = "0xA72E90", Offset = "0xA72090", VA = "0x180A72E90")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006575")]
		[Address(RVA = "0xA72420", Offset = "0xA71620", VA = "0x180A72420")]
		public void ClearCustomerSlots(bool returnToOriginals)
		{
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006576")]
		[Address(RVA = "0xA72C30", Offset = "0xA71E30", VA = "0x180A72C30")]
		private void CustomerItemsChanged()
		{
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006577")]
		[Address(RVA = "0xA76550", Offset = "0xA75750", VA = "0x180A76550")]
		private void UpdateDoneButton()
		{
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006578")]
		[Address(RVA = "0xA76680", Offset = "0xA75880", VA = "0x180A76680")]
		private void UpdateSuccessChance()
		{
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00018D08 File Offset: 0x00016F08
		[Token(Token = "0x6006579")]
		[Address(RVA = "0xA73570", Offset = "0xA72770", VA = "0x180A73570")]
		private bool GetError(out string err)
		{
			return default(bool);
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00018D20 File Offset: 0x00016F20
		[Token(Token = "0x600657A")]
		[Address(RVA = "0xA73900", Offset = "0xA72B00", VA = "0x180A73900")]
		private bool GetWarning(out string warning)
		{
			return default(bool);
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600657B")]
		[Address(RVA = "0xA733A0", Offset = "0xA725A0", VA = "0x180A733A0")]
		private List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			return null;
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x600657C")]
		[Address(RVA = "0xA73110", Offset = "0xA72310", VA = "0x180A73110")]
		private float GetCustomerItemsValue()
		{
			return 0f;
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x600657D")]
		[Address(RVA = "0xA72F40", Offset = "0xA72140", VA = "0x180A72F40")]
		private int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			return 0;
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600657E")]
		[Address(RVA = "0xA76AF0", Offset = "0xA75CF0", VA = "0x180A76AF0")]
		public HandoverScreen()
		{
		}

		// Token: 0x0400472D RID: 18221
		[Token(Token = "0x400472D")]
		public const int CUSTOMER_SLOT_COUNT = 4;

		// Token: 0x0400472E RID: 18222
		[Token(Token = "0x400472E")]
		public const float VEHICLE_MAX_DIST = 20f;

		// Token: 0x04004734 RID: 18228
		[Token(Token = "0x4004734")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public Gradient SuccessColorMap;

		// Token: 0x04004735 RID: 18229
		[Token(Token = "0x4004735")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004736 RID: 18230
		[Token(Token = "0x4004736")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Container;

		// Token: 0x04004737 RID: 18231
		[Token(Token = "0x4004737")]
		[FieldOffset(Offset = "0x58")]
		public UIScreen UIScreen;

		// Token: 0x04004738 RID: 18232
		[Token(Token = "0x4004738")]
		[FieldOffset(Offset = "0x60")]
		public UIScreen AltScreen;

		// Token: 0x04004739 RID: 18233
		[Token(Token = "0x4004739")]
		[FieldOffset(Offset = "0x68")]
		public CanvasGroup CanvasGroup;

		// Token: 0x0400473A RID: 18234
		[Token(Token = "0x400473A")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI DescriptionLabel;

		// Token: 0x0400473B RID: 18235
		[Token(Token = "0x400473B")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI CustomerSubtitle;

		// Token: 0x0400473C RID: 18236
		[Token(Token = "0x400473C")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI FavouriteDrugLabel;

		// Token: 0x0400473D RID: 18237
		[Token(Token = "0x400473D")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI FavouritePropertiesLabel;

		// Token: 0x0400473E RID: 18238
		[Token(Token = "0x400473E")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI[] PropertiesEntries;

		// Token: 0x0400473F RID: 18239
		[Token(Token = "0x400473F")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform[] ExpectationEntries;

		// Token: 0x04004740 RID: 18240
		[Token(Token = "0x4004740")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject NoVehicle;

		// Token: 0x04004741 RID: 18241
		[Token(Token = "0x4004741")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform VehicleSlotContainer;

		// Token: 0x04004742 RID: 18242
		[Token(Token = "0x4004742")]
		[FieldOffset(Offset = "0xB0")]
		public RectTransform CustomerSlotContainer;

		// Token: 0x04004743 RID: 18243
		[Token(Token = "0x4004743")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI VehicleSubtitle;

		// Token: 0x04004744 RID: 18244
		[Token(Token = "0x4004744")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI SuccessLabel;

		// Token: 0x04004745 RID: 18245
		[Token(Token = "0x4004745")]
		[FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04004746 RID: 18246
		[Token(Token = "0x4004746")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI WarningLabel;

		// Token: 0x04004747 RID: 18247
		[Token(Token = "0x4004747")]
		[FieldOffset(Offset = "0xD8")]
		public Button DoneButton;

		// Token: 0x04004748 RID: 18248
		[Token(Token = "0x4004748")]
		[FieldOffset(Offset = "0xE0")]
		public RectTransform VehicleContainer;

		// Token: 0x04004749 RID: 18249
		[Token(Token = "0x4004749")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x0400474A RID: 18250
		[Token(Token = "0x400474A")]
		[FieldOffset(Offset = "0xF0")]
		public HandoverScreenPriceSelector PriceSelector;

		// Token: 0x0400474B RID: 18251
		[Token(Token = "0x400474B")]
		[FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI FairPriceLabel;

		// Token: 0x0400474C RID: 18252
		[Token(Token = "0x400474C")]
		[FieldOffset(Offset = "0x100")]
		public Animation TutorialAnimation;

		// Token: 0x0400474D RID: 18253
		[Token(Token = "0x400474D")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform TutorialContainer;

		// Token: 0x0400474E RID: 18254
		[Token(Token = "0x400474E")]
		[FieldOffset(Offset = "0x110")]
		public HandoverScreenDetailPanel DetailPanel;

		// Token: 0x0400474F RID: 18255
		[Token(Token = "0x400474F")]
		[FieldOffset(Offset = "0x118")]
		public Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete;

		// Token: 0x04004750 RID: 18256
		[Token(Token = "0x4004750")]
		[FieldOffset(Offset = "0x120")]
		public Func<List<ItemInstance>, float, float> SuccessChanceMethod;

		// Token: 0x04004751 RID: 18257
		[Token(Token = "0x4004751")]
		[FieldOffset(Offset = "0x128")]
		private ItemSlotUI[] VehicleSlotUIs;

		// Token: 0x04004752 RID: 18258
		[Token(Token = "0x4004752")]
		[FieldOffset(Offset = "0x130")]
		private ItemSlotUI[] CustomerSlotUIs;

		// Token: 0x04004753 RID: 18259
		[Token(Token = "0x4004753")]
		[FieldOffset(Offset = "0x138")]
		private ItemSlot[] CustomerSlots;

		// Token: 0x04004754 RID: 18260
		[Token(Token = "0x4004754")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations;

		// Token: 0x04004755 RID: 18261
		[Token(Token = "0x4004755")]
		[FieldOffset(Offset = "0x148")]
		private bool ignoreCustomerChangedEvents;

		// Token: 0x04004756 RID: 18262
		[Token(Token = "0x4004756")]
		[FieldOffset(Offset = "0x149")]
		private bool requireFullChanceOfSuccess;

		// Token: 0x04004757 RID: 18263
		[Token(Token = "0x4004757")]
		[FieldOffset(Offset = "0x14A")]
		private bool activeScreenChangedThisFrame;

		// Token: 0x02000DCC RID: 3532
		[Token(Token = "0x2000DCC")]
		public enum EMode
		{
			// Token: 0x04004759 RID: 18265
			[Token(Token = "0x4004759")]
			Contract,
			// Token: 0x0400475A RID: 18266
			[Token(Token = "0x400475A")]
			Sample,
			// Token: 0x0400475B RID: 18267
			[Token(Token = "0x400475B")]
			Offer
		}

		// Token: 0x02000DCD RID: 3533
		[Token(Token = "0x2000DCD")]
		public enum EHandoverOutcome
		{
			// Token: 0x0400475D RID: 18269
			[Token(Token = "0x400475D")]
			Cancelled,
			// Token: 0x0400475E RID: 18270
			[Token(Token = "0x400475E")]
			Finalize
		}

		// Token: 0x02000DCE RID: 3534
		[Token(Token = "0x2000DCE")]
		private enum EItemSource
		{
			// Token: 0x04004760 RID: 18272
			[Token(Token = "0x4004760")]
			Player,
			// Token: 0x04004761 RID: 18273
			[Token(Token = "0x4004761")]
			Vehicle
		}
	}
}
