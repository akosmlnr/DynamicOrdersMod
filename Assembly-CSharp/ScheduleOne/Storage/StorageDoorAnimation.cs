using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x00011730 File Offset: 0x0000F930
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000976")]
		public bool IsOpen
		{
			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C73")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x81E730", Offset = "0x81D930", VA = "0x18081E730")]
		private void Start()
		{
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x81E4A0", Offset = "0x81D6A0", VA = "0x18081E4A0")]
		[Button]
		public void Open()
		{
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x81E490", Offset = "0x81D690", VA = "0x18081E490")]
		[Button]
		public void Close()
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x81E570", Offset = "0x81D770", VA = "0x18081E570")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x81E4C0", Offset = "0x81D6C0", VA = "0x18081E4C0", Slot = "4")]
		protected virtual void RefreshItemsVisible()
		{
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x81E4B0", Offset = "0x81D6B0", VA = "0x18081E4B0")]
		public void OverrideState(bool open)
		{
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x81E560", Offset = "0x81D760", VA = "0x18081E560")]
		public void ResetOverride()
		{
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7B")]
		[Address(RVA = "0x81EA00", Offset = "0x81DC00", VA = "0x18081EA00")]
		public StorageDoorAnimation()
		{
		}

		// Token: 0x04002C54 RID: 11348
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x21")]
		private bool overriddeIsOpen;

		// Token: 0x04002C55 RID: 11349
		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x22")]
		private bool overrideState;

		// Token: 0x04002C56 RID: 11350
		[Token(Token = "0x4002C56")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _disableItemContainerWhenClosed;

		// Token: 0x04002C57 RID: 11351
		[Token(Token = "0x4002C57")]
		[FieldOffset(Offset = "0x28")]
		[Header("Animations")]
		public Animation[] Anims;

		// Token: 0x04002C58 RID: 11352
		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x30")]
		public AnimationClip OpenAnim;

		// Token: 0x04002C59 RID: 11353
		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x38")]
		public AnimationClip CloseAnim;

		// Token: 0x04002C5A RID: 11354
		[Token(Token = "0x4002C5A")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController OpenSound;

		// Token: 0x04002C5B RID: 11355
		[Token(Token = "0x4002C5B")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController CloseSound;

		// Token: 0x04002C5C RID: 11356
		[Token(Token = "0x4002C5C")]
		[FieldOffset(Offset = "0x50")]
		private StorageEntity storageEntity;

		// Token: 0x04002C5D RID: 11357
		[Token(Token = "0x4002C5D")]
		[FieldOffset(Offset = "0x58")]
		private Transform itemContainer;
	}
}
