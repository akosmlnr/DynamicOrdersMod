using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C2A RID: 3114
	[Token(Token = "0x2000C2A")]
	public class ConsoleUI : MonoBehaviour
	{
		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x000171F0 File Offset: 0x000153F0
		[Token(Token = "0x17000D32")]
		public bool IS_CONSOLE_ENABLED
		{
			[Token(Token = "0x6005B2C")]
			[Address(RVA = "0x9C4A30", Offset = "0x9C3C30", VA = "0x1809C4A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0x9C3F70", Offset = "0x9C3170", VA = "0x1809C3F70")]
		private void Awake()
		{
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0x9C4790", Offset = "0x9C3990", VA = "0x1809C4790")]
		private void Update()
		{
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x9C45B0", Offset = "0x9C37B0", VA = "0x1809C45B0")]
		private void UpdateCommandHistory()
		{
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x9C40B0", Offset = "0x9C32B0", VA = "0x1809C40B0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x9C4160", Offset = "0x9C3360", VA = "0x1809C4160")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B32")]
		[Address(RVA = "0x9C4450", Offset = "0x9C3650", VA = "0x1809C4450")]
		public void Submit(string val)
		{
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B33")]
		[Address(RVA = "0x9C4A20", Offset = "0x9C3C20", VA = "0x1809C4A20")]
		public ConsoleUI()
		{
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B35")]
		[Address(RVA = "0x9C4540", Offset = "0x9C3740", VA = "0x1809C4540")]
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x04003D9E RID: 15774
		[Token(Token = "0x4003D9E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003D9F RID: 15775
		[Token(Token = "0x4003D9F")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField InputField;

		// Token: 0x04003DA0 RID: 15776
		[Token(Token = "0x4003DA0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;

		// Token: 0x04003DA1 RID: 15777
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> _commandHistory;

		// Token: 0x04003DA2 RID: 15778
		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x38")]
		private int _currentCommandIndex;
	}
}
