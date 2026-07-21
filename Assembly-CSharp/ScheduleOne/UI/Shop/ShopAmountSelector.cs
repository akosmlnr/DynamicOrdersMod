using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E10 RID: 3600
	[Token(Token = "0x2000E10")]
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x000191B8 File Offset: 0x000173B8
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA0")]
		public bool IsOpen
		{
			[Token(Token = "0x6006748")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006749")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x000191D0 File Offset: 0x000173D0
		// (set) Token: 0x0600674B RID: 26443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA1")]
		public int SelectedAmount
		{
			[Token(Token = "0x600674A")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600674B")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674C")]
		[Address(RVA = "0xAB41B0", Offset = "0xAB33B0", VA = "0x180AB41B0")]
		private void Awake()
		{
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674D")]
		[Address(RVA = "0xAB4540", Offset = "0xAB3740", VA = "0x180AB4540")]
		public void Open()
		{
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674E")]
		[Address(RVA = "0xAB42E0", Offset = "0xAB34E0", VA = "0x180AB42E0")]
		public void Close()
		{
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600674F")]
		[Address(RVA = "0xAB4320", Offset = "0xAB3520", VA = "0x180AB4320")]
		private void OnSubmitted(string value)
		{
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006750")]
		[Address(RVA = "0xAB4460", Offset = "0xAB3660", VA = "0x180AB4460")]
		private void OnValueChanged(string value)
		{
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006751")]
		[Address(RVA = "0xAB45F0", Offset = "0xAB37F0", VA = "0x180AB45F0")]
		public ShopAmountSelector()
		{
		}

		// Token: 0x040048E5 RID: 18661
		[Token(Token = "0x40048E5")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x040048E6 RID: 18662
		[Token(Token = "0x40048E6")]
		[FieldOffset(Offset = "0x30")]
		public TMP_InputField InputField;

		// Token: 0x040048E7 RID: 18663
		[Token(Token = "0x40048E7")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<int> onSubmitted;
	}
}
