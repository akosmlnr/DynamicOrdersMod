using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x7F37F0", Offset = "0x7F29F0", VA = "0x1807F37F0")]
		public ImpostorGenerator()
		{
		}

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Camera ImpostorCamera;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x28")]
		public Avatar Avatar;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public List<AvatarSettings> GenerationQueue;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture2D output;
	}
}
