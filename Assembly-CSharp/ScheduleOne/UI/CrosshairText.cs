using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C2D RID: 3117
	[Token(Token = "0x2000C2D")]
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x06005B55 RID: 23381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B55")]
		[Address(RVA = "0x7E7EC0", Offset = "0x7E70C0", VA = "0x1807E7EC0")]
		private void Awake()
		{
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0x9C7F00", Offset = "0x9C7100", VA = "0x1809C7F00")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x9C7F40", Offset = "0x9C7140", VA = "0x1809C7F40")]
		public void Show(string text, [Optional] Color col)
		{
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x7E7EC0", Offset = "0x7E70C0", VA = "0x1807E7EC0")]
		public void Hide()
		{
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CrosshairText()
		{
		}

		// Token: 0x04003DBA RID: 15802
		[Token(Token = "0x4003DBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		// Token: 0x04003DBB RID: 15803
		[Token(Token = "0x4003DBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool setThisFrame;
	}
}
