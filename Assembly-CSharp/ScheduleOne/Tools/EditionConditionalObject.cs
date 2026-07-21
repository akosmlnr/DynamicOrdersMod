using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x06003919 RID: 14617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x7FA5A0", Offset = "0x7F97A0", VA = "0x1807FA5A0")]
		private void Awake()
		{
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public EditionConditionalObject()
		{
		}

		// Token: 0x04002A17 RID: 10775
		[Token(Token = "0x4002A17")]
		[FieldOffset(Offset = "0x20")]
		public EditionConditionalObject.EType type;

		// Token: 0x0200085F RID: 2143
		[Token(Token = "0x200085F")]
		public enum EType
		{
			// Token: 0x04002A19 RID: 10777
			[Token(Token = "0x4002A19")]
			ActiveInDemo,
			// Token: 0x04002A1A RID: 10778
			[Token(Token = "0x4002A1A")]
			ActiveInFullGame
		}
	}
}
