using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000DE9")]
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x06006613 RID: 26131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006613")]
		[Address(RVA = "0xA8D000", Offset = "0xA8C200", VA = "0x180A8D000", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006614")]
		[Address(RVA = "0xA8CF80", Offset = "0xA8C180", VA = "0x180A8CF80", Slot = "6")]
		public override void ApplyValue()
		{
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006615")]
		[Address(RVA = "0xA8D0F0", Offset = "0xA8C2F0", VA = "0x180A8D0F0")]
		public void OnButton1()
		{
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006616")]
		[Address(RVA = "0xA8D140", Offset = "0xA8C340", VA = "0x180A8D140")]
		public void OnButton2()
		{
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006617")]
		[Address(RVA = "0xA8D190", Offset = "0xA8C390", VA = "0x180A8D190")]
		public CharacterCreatorToggle()
		{
		}

		// Token: 0x040047F0 RID: 18416
		[Token(Token = "0x40047F0")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Button Button1;

		// Token: 0x040047F1 RID: 18417
		[Token(Token = "0x40047F1")]
		[FieldOffset(Offset = "0x50")]
		public Button Button2;
	}
}
