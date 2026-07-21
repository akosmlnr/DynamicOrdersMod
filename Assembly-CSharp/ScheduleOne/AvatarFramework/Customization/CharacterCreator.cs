using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.CharacterCreator;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x00010758 File Offset: 0x0000E958
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D4")]
		public bool IsOpen
		{
			[Token(Token = "0x60037B9")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037BA")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060037BC RID: 14268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D5")]
		public BasicAvatarSettings ActiveSettings
		{
			[Token(Token = "0x60037BB")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037BC")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x7EE1E0", Offset = "0x7ED3E0", VA = "0x1807EE1E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x7EF250", Offset = "0x7EE450", VA = "0x1807EF250", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x7EF330", Offset = "0x7EE530", VA = "0x1807EF330")]
		private void Update()
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x7EE6E0", Offset = "0x7ED8E0", VA = "0x1807EE6E0")]
		public void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x7EF100", Offset = "0x7EE300", VA = "0x1807EF100")]
		public void ShowUI()
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x7EE2A0", Offset = "0x7ED4A0", VA = "0x1807EE2A0")]
		public void Close()
		{
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x620680", Offset = "0x61F880", VA = "0x180620680")]
		public void DisableStuff()
		{
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x7EE320", Offset = "0x7ED520", VA = "0x1807EE320")]
		public void Done()
		{
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x7EF230", Offset = "0x7EE430", VA = "0x1807EF230")]
		public void SliderChanged(float newVal)
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037C6")]
		public T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			return null;
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x7EEEA0", Offset = "0x7EE0A0", VA = "0x1807EEEA0")]
		public void SelectPreset(string presetName)
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x7EECF0", Offset = "0x7EDEF0", VA = "0x1807EECF0")]
		public void RefreshCategory(CharacterCreator.ECategory category)
		{
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x7EF410", Offset = "0x7EE610", VA = "0x1807EF410")]
		public CharacterCreator()
		{
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x7EF2C0", Offset = "0x7EE4C0", VA = "0x1807EF2C0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|28_0()
		{
			return null;
		}

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[FieldOffset(Offset = "0x30")]
		public List<BaseCharacterCreatorField> Fields;

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Transform Container;

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		[FieldOffset(Offset = "0x48")]
		public Transform CameraPosition;

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		[FieldOffset(Offset = "0x50")]
		public Transform RigContainer;

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0x58")]
		public Avatar Rig;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		[FieldOffset(Offset = "0x60")]
		public Canvas Canvas;

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x68")]
		public Animation CanvasAnimation;

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x70")]
		[Header("Settings")]
		public bool DemoCreator;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x78")]
		public BasicAvatarSettings DefaultSettings;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x80")]
		public List<BasicAvatarSettings> Presets;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent<BasicAvatarSettings> onComplete;

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions;

		// Token: 0x040028A3 RID: 10403
		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0xA0")]
		private float rigTargetY;

		// Token: 0x0200081B RID: 2075
		[Token(Token = "0x200081B")]
		public enum ECategory
		{
			// Token: 0x040028A5 RID: 10405
			[Token(Token = "0x40028A5")]
			Body,
			// Token: 0x040028A6 RID: 10406
			[Token(Token = "0x40028A6")]
			Hair,
			// Token: 0x040028A7 RID: 10407
			[Token(Token = "0x40028A7")]
			Face,
			// Token: 0x040028A8 RID: 10408
			[Token(Token = "0x40028A8")]
			Eyes,
			// Token: 0x040028A9 RID: 10409
			[Token(Token = "0x40028A9")]
			Eyebrows,
			// Token: 0x040028AA RID: 10410
			[Token(Token = "0x40028AA")]
			Clothing,
			// Token: 0x040028AB RID: 10411
			[Token(Token = "0x40028AB")]
			Accessories
		}
	}
}
