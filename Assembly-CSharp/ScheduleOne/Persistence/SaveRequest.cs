using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public class SaveRequest
	{
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D1")]
		public string SaveString
		{
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001935")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x5FB190", Offset = "0x5FA390", VA = "0x1805FB190")]
		public SaveRequest(ISaveable saveable, string parentFolderPath)
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x5FB030", Offset = "0x5FA230", VA = "0x1805FB030")]
		public void Complete()
		{
		}

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x10")]
		public ISaveable Saveable;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x18")]
		public string ParentFolderPath;
	}
}
