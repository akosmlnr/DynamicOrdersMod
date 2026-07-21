using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	public class DemoEndScreen : MonoBehaviour
	{
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x00017340 File Offset: 0x00015540
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D41")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B8E")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B8F")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x9C9D80", Offset = "0x9C8F80", VA = "0x1809C9D80")]
		public void Awake()
		{
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x9CA230", Offset = "0x9C9430", VA = "0x1809CA230")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		[Button]
		public void Open()
		{
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x9CA2C0", Offset = "0x9C94C0", VA = "0x1809CA2C0")]
		private void Update()
		{
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x9C9E50", Offset = "0x9C9050", VA = "0x1809C9E50")]
		public void Close()
		{
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0x9CA1B0", Offset = "0x9C93B0", VA = "0x1809CA1B0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x9CA200", Offset = "0x9C9400", VA = "0x1809CA200")]
		public void LinkClicked()
		{
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DemoEndScreen()
		{
		}

		// Token: 0x04003DF0 RID: 15856
		[Token(Token = "0x4003DF0")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003DF1 RID: 15857
		[Token(Token = "0x4003DF1")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform Container;
	}
}
