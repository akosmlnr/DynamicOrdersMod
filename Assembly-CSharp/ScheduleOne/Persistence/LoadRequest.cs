using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class LoadRequest
	{
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00009F30 File Offset: 0x00008130
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C7")]
		public bool IsDone
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x5F1B20", Offset = "0x5F0D20", VA = "0x1805F1B20")]
		public LoadRequest(string filePath, Loader loader)
		{
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x5F1A70", Offset = "0x5F0C70", VA = "0x1805F1A70")]
		public void Complete()
		{
		}

		// Token: 0x040015AA RID: 5546
		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x10")]
		public string Path;

		// Token: 0x040015AB RID: 5547
		[Token(Token = "0x40015AB")]
		[FieldOffset(Offset = "0x18")]
		public Loader Loader;
	}
}
