using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C5A RID: 3162
	[Token(Token = "0x2000C5A")]
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06005C93 RID: 23699 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005C94 RID: 23700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D66")]
		public string currentModuleLabel
		{
			[Token(Token = "0x6005C93")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C94")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06005C95 RID: 23701 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005C96 RID: 23702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D67")]
		public RectTransform currentModule
		{
			[Token(Token = "0x6005C95")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C96")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x9DC4B0", Offset = "0x9DB6B0", VA = "0x1809DC4B0")]
		public void LoadModule(string key)
		{
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0x9DC6F0", Offset = "0x9DB8F0", VA = "0x1809DC6F0")]
		public void UnloadModule()
		{
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0x9DC7B0", Offset = "0x9DB9B0", VA = "0x1809DC7B0")]
		public InputPromptsCanvas()
		{
		}

		// Token: 0x04003EF2 RID: 16114
		[Token(Token = "0x4003EF2")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform InputPromptsContainer;

		// Token: 0x04003EF3 RID: 16115
		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0x30")]
		[Header("Input prompt modules")]
		public List<InputPromptsCanvas.Module> Modules;

		// Token: 0x02000C5B RID: 3163
		[Token(Token = "0x2000C5B")]
		[Serializable]
		public class Module
		{
			// Token: 0x06005C9A RID: 23706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C9A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Module()
			{
			}

			// Token: 0x04003EF6 RID: 16118
			[Token(Token = "0x4003EF6")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04003EF7 RID: 16119
			[Token(Token = "0x4003EF7")]
			[FieldOffset(Offset = "0x18")]
			public GameObject module;
		}
	}
}
