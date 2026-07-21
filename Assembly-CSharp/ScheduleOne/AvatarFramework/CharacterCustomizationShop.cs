using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public class CharacterCustomizationShop : MonoBehaviour
	{
		// Token: 0x060036C2 RID: 14018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CharacterCustomizationShop()
		{
		}

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x20")]
		public Transform CameraPosition;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x28")]
		public Transform RigContainer;

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x30")]
		public Avatar AvatarRig;
	}
}
