using System;
using System.Runtime.InteropServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	[Serializable]
	public class Response
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x62B710", Offset = "0x62A910", VA = "0x18062B710")]
		public Response(string _text, string _label, [Optional] Action _callback, bool _disableDefaultResponseBehaviour = false)
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public Response()
		{
		}

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CodegenExclude]
		public Action callback;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool disableDefaultResponseBehaviour;
	}
}
