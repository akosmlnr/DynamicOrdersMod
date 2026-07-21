using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000992 RID: 2450
	[Token(Token = "0x2000992")]
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x06004281 RID: 17025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004281")]
		[Address(RVA = "0x8769A0", Offset = "0x875BA0", VA = "0x1808769A0")]
		public void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004282")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CauldronDisplayTub()
		{
		}

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x20")]
		public Transform CocaLeafContainer;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x28")]
		public Transform Container_Min;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x30")]
		public Transform Container_Max;

		// Token: 0x02000993 RID: 2451
		[Token(Token = "0x2000993")]
		public enum EContents
		{
			// Token: 0x04003017 RID: 12311
			[Token(Token = "0x4003017")]
			None,
			// Token: 0x04003018 RID: 12312
			[Token(Token = "0x4003018")]
			CocaLeaf
		}
	}
}
