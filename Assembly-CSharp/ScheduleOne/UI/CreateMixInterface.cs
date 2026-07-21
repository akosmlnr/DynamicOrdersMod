using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x00017220 File Offset: 0x00015420
		// (set) Token: 0x06005B3D RID: 23357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D35")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B3C")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B3D")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06005B3E RID: 23358 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D36")]
		private ItemSlot beanSlot
		{
			[Token(Token = "0x6005B3E")]
			[Address(RVA = "0x9C7D80", Offset = "0x9C6F80", VA = "0x1809C7D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D37")]
		private ItemSlot mixerSlot
		{
			[Token(Token = "0x6005B3F")]
			[Address(RVA = "0x9C7DE0", Offset = "0x9C6FE0", VA = "0x1809C7DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D38")]
		private ItemSlot outputSlot
		{
			[Token(Token = "0x6005B40")]
			[Address(RVA = "0x9C7E40", Offset = "0x9C7040", VA = "0x1809C7E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D39")]
		private ItemSlot productSlot
		{
			[Token(Token = "0x6005B41")]
			[Address(RVA = "0x9C7EA0", Offset = "0x9C70A0", VA = "0x1809C7EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B42")]
		[Address(RVA = "0x9C4AF0", Offset = "0x9C3CF0", VA = "0x1809C4AF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B43")]
		[Address(RVA = "0x9C5EE0", Offset = "0x9C50E0", VA = "0x1809C5EE0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x9C68C0", Offset = "0x9C5AC0", VA = "0x1809C68C0")]
		public void Open()
		{
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x9C5EC0", Offset = "0x9C50C0", VA = "0x1809C5EC0")]
		private void ContentsChanged()
		{
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B46")]
		[Address(RVA = "0x9C70B0", Offset = "0x9C62B0", VA = "0x1809C70B0")]
		private void UpdateCanBegin()
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B47")]
		[Address(RVA = "0x9C7490", Offset = "0x9C6690", VA = "0x1809C7490")]
		private void UpdateOutput()
		{
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x9C51A0", Offset = "0x9C43A0", VA = "0x1809C51A0")]
		private void BeginPressed()
		{
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x9C6110", Offset = "0x9C5310", VA = "0x1809C6110")]
		private List<Effect> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			return null;
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00017238 File Offset: 0x00015438
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x9C66E0", Offset = "0x9C58E0", VA = "0x1809C66E0")]
		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			return default(bool);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x9C62D0", Offset = "0x9C54D0", VA = "0x1809C62D0")]
		private string GetPropertyListString(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x9C6480", Offset = "0x9C5680", VA = "0x1809C6480")]
		private string GetPropertyString(Effect property)
		{
			return null;
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00017250 File Offset: 0x00015450
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0x9C53F0", Offset = "0x9C45F0", VA = "0x1809C53F0")]
		private bool CanBegin()
		{
			return default(bool);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x9C5540", Offset = "0x9C4740", VA = "0x1809C5540")]
		public void Close()
		{
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x00017268 File Offset: 0x00015468
		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x9C6680", Offset = "0x9C5880", VA = "0x1809C6680")]
		private bool HasProduct()
		{
			return default(bool);
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x00017280 File Offset: 0x00015480
		[Token(Token = "0x6005B50")]
		[Address(RVA = "0x9C65B0", Offset = "0x9C57B0", VA = "0x1809C65B0")]
		private bool HasBeans()
		{
			return default(bool);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00017298 File Offset: 0x00015498
		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x9C6620", Offset = "0x9C5820", VA = "0x1809C6620")]
		private bool HasMixer()
		{
			return default(bool);
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x9C61A0", Offset = "0x9C53A0", VA = "0x1809C61A0")]
		private ProductDefinition GetProduct()
		{
			return null;
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x9C5F30", Offset = "0x9C5130", VA = "0x1809C5F30")]
		private PropertyItemDefinition GetMixer()
		{
			return null;
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x9C7D40", Offset = "0x9C6F40", VA = "0x1809C7D40")]
		public CreateMixInterface()
		{
		}

		// Token: 0x04003DA6 RID: 15782
		[Token(Token = "0x4003DA6")]
		public const int BEAN_REQUIREMENT = 5;

		// Token: 0x04003DA8 RID: 15784
		[Token(Token = "0x4003DA8")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003DA9 RID: 15785
		[Token(Token = "0x4003DA9")]
		[FieldOffset(Offset = "0x38")]
		public ItemSlotUI BeansSlot;

		// Token: 0x04003DAA RID: 15786
		[Token(Token = "0x4003DAA")]
		[FieldOffset(Offset = "0x40")]
		public ItemSlotUI ProductSlot;

		// Token: 0x04003DAB RID: 15787
		[Token(Token = "0x4003DAB")]
		[FieldOffset(Offset = "0x48")]
		public ItemSlotUI MixerSlot;

		// Token: 0x04003DAC RID: 15788
		[Token(Token = "0x4003DAC")]
		[FieldOffset(Offset = "0x50")]
		public ItemSlotUI OutputSlot;

		// Token: 0x04003DAD RID: 15789
		[Token(Token = "0x4003DAD")]
		[FieldOffset(Offset = "0x58")]
		public Image OutputIcon;

		// Token: 0x04003DAE RID: 15790
		[Token(Token = "0x4003DAE")]
		[FieldOffset(Offset = "0x60")]
		public Button BeginButton;

		// Token: 0x04003DAF RID: 15791
		[Token(Token = "0x4003DAF")]
		[FieldOffset(Offset = "0x68")]
		public WorldStorageEntity Storage;

		// Token: 0x04003DB0 RID: 15792
		[Token(Token = "0x4003DB0")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI ProductPropertiesLabel;

		// Token: 0x04003DB1 RID: 15793
		[Token(Token = "0x4003DB1")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI OutputPropertiesLabel;

		// Token: 0x04003DB2 RID: 15794
		[Token(Token = "0x4003DB2")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI BeanProblemLabel;

		// Token: 0x04003DB3 RID: 15795
		[Token(Token = "0x4003DB3")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI ProductProblemLabel;

		// Token: 0x04003DB4 RID: 15796
		[Token(Token = "0x4003DB4")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI MixerProblemLabel;

		// Token: 0x04003DB5 RID: 15797
		[Token(Token = "0x4003DB5")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI OutputProblemLabel;

		// Token: 0x04003DB6 RID: 15798
		[Token(Token = "0x4003DB6")]
		[FieldOffset(Offset = "0xA0")]
		public Transform CameraPosition;

		// Token: 0x04003DB7 RID: 15799
		[Token(Token = "0x4003DB7")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform UnknownOutputIcon;

		// Token: 0x04003DB8 RID: 15800
		[Token(Token = "0x4003DB8")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent onOpen;

		// Token: 0x04003DB9 RID: 15801
		[Token(Token = "0x4003DB9")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onClose;
	}
}
