using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DBA RID: 3514
	[Token(Token = "0x2000DBA")]
	public class MainMenuRig : MonoBehaviour
	{
		// Token: 0x06006514 RID: 25876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006514")]
		[Address(RVA = "0xA7A500", Offset = "0xA79700", VA = "0x180A7A500")]
		public void Awake()
		{
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006515")]
		[Address(RVA = "0xA7A5F0", Offset = "0xA797F0", VA = "0x180A7A5F0")]
		private void LoadStuff()
		{
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006516")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MainMenuRig()
		{
		}

		// Token: 0x040046E6 RID: 18150
		[Token(Token = "0x40046E6")]
		[FieldOffset(Offset = "0x20")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x040046E7 RID: 18151
		[Token(Token = "0x40046E7")]
		[FieldOffset(Offset = "0x28")]
		public BasicAvatarSettings DefaultSettings;

		// Token: 0x040046E8 RID: 18152
		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0x30")]
		public CashPile[] CashPiles;
	}
}
