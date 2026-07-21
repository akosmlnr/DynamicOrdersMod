using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x2000DD9")]
	public class CharacterCustomizationUI : MonoBehaviour
	{
		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x00018DE0 File Offset: 0x00016FE0
		// (set) Token: 0x060065C8 RID: 26056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E7B")]
		public bool IsOpen
		{
			[Token(Token = "0x60065C7")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60065C8")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E7C")]
		public CharacterCustomizationCategory ActiveCategory
		{
			[Token(Token = "0x60065C9")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60065CA")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0xA8EE50", Offset = "0xA8E050", VA = "0x180A8EE50")]
		private void OnValidate()
		{
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0xA8E760", Offset = "0xA8D960", VA = "0x180A8E760")]
		private void Awake()
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0xA8F570", Offset = "0xA8E770", VA = "0x180A8F570", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0xA8F2B0", Offset = "0xA8E4B0", VA = "0x180A8F2B0")]
		public void SetActiveCategory(CharacterCustomizationCategory category)
		{
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "5")]
		public virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return default(bool);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0xA8F260", Offset = "0xA8E460", VA = "0x180A8F260", Slot = "6")]
		public virtual void OptionSelected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0xA8F1A0", Offset = "0xA8E3A0", VA = "0x180A8F1A0", Slot = "7")]
		public virtual void OptionDeselected(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xA8F220", Offset = "0xA8E420", VA = "0x180A8F220", Slot = "8")]
		public virtual void OptionPurchased(CharacterCustomizationOption option)
		{
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xA8EED0", Offset = "0xA8E0D0", VA = "0x180A8EED0", Slot = "9")]
		public virtual void Open()
		{
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xA8ECD0", Offset = "0xA8DED0", VA = "0x180A8ECD0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0xA8EB80", Offset = "0xA8DD80", VA = "0x180A8EB80", Slot = "10")]
		protected virtual void Close()
		{
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0xA8F670", Offset = "0xA8E870", VA = "0x180A8F670")]
		public CharacterCustomizationUI()
		{
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0xA8F500", Offset = "0xA8E700", VA = "0x180A8F500")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Close|32_0()
		{
			return null;
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0xA8F490", Offset = "0xA8E690", VA = "0x180A8F490")]
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|34_0()
		{
			return null;
		}

		// Token: 0x040047B5 RID: 18357
		[Token(Token = "0x40047B5")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public string Title;

		// Token: 0x040047B6 RID: 18358
		[Token(Token = "0x40047B6")]
		[FieldOffset(Offset = "0x38")]
		public CharacterCustomizationCategory[] Categories;

		// Token: 0x040047B7 RID: 18359
		[Token(Token = "0x40047B7")]
		[FieldOffset(Offset = "0x40")]
		public bool LoadAvatarSettingsNaked;

		// Token: 0x040047B8 RID: 18360
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040047B9 RID: 18361
		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform MainContainer;

		// Token: 0x040047BA RID: 18362
		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform MenuContainer;

		// Token: 0x040047BB RID: 18363
		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI TitleText;

		// Token: 0x040047BC RID: 18364
		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform ButtonContainer;

		// Token: 0x040047BD RID: 18365
		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x70")]
		public Button ExitButton;

		// Token: 0x040047BE RID: 18366
		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x78")]
		public Slider RigRotationSlider;

		// Token: 0x040047BF RID: 18367
		[Token(Token = "0x40047BF")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform PreviewIndicator;

		// Token: 0x040047C0 RID: 18368
		[Token(Token = "0x40047C0")]
		[FieldOffset(Offset = "0x88")]
		public CharacterCustomizationShop CharacterCustomizationShop;

		// Token: 0x040047C1 RID: 18369
		[Token(Token = "0x40047C1")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefab")]
		public Button CategoryButtonPrefab;

		// Token: 0x040047C2 RID: 18370
		[Token(Token = "0x40047C2")]
		[FieldOffset(Offset = "0x98")]
		private float rigTargetY;

		// Token: 0x040047C3 RID: 18371
		[Token(Token = "0x40047C3")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine openCloseRoutine;

		// Token: 0x040047C4 RID: 18372
		[Token(Token = "0x40047C4")]
		[FieldOffset(Offset = "0xA8")]
		protected BasicAvatarSettings currentSettings;
	}
}
