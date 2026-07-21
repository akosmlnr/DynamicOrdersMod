using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000CC5")]
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x00017DA8 File Offset: 0x00015FA8
		// (set) Token: 0x06005F5F RID: 24415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD1")]
		public bool IsOpen
		{
			[Token(Token = "0x6005F5E")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005F5F")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F60")]
		[Address(RVA = "0xA165C0", Offset = "0xA157C0", VA = "0x180A165C0")]
		public void Open()
		{
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0xA16590", Offset = "0xA15790", VA = "0x180A16590")]
		public void Close()
		{
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F62")]
		[Address(RVA = "0xA165F0", Offset = "0xA157F0", VA = "0x180A165F0")]
		public TrashBagCanvas()
		{
		}

		// Token: 0x040041B4 RID: 16820
		[Token(Token = "0x40041B4")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040041B5 RID: 16821
		[Token(Token = "0x40041B5")]
		[FieldOffset(Offset = "0x38")]
		public InputPrompt InputPrompt;
	}
}
