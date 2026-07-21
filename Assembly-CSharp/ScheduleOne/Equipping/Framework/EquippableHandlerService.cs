using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Configuration;
using ScheduleOne.Core.Equipping.Framework;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x0200096D RID: 2413
	[Token(Token = "0x200096D")]
	public static class EquippableHandlerService
	{
		// Token: 0x06004085 RID: 16517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x850D60", Offset = "0x84FF60", VA = "0x180850D60")]
		private static void SetupHandlerKeys()
		{
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x8507B0", Offset = "0x84F9B0", VA = "0x1808507B0")]
		public static IEquippedItemHandler GetHandlerPrefab(EquippableData equippedData)
		{
			return null;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x850FF0", Offset = "0x8501F0", VA = "0x180850FF0")]
		[CompilerGenerated]
		internal static void <.cctor>g__LoadConfig|3_0()
		{
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x8510D0", Offset = "0x8502D0", VA = "0x1808510D0")]
		[CompilerGenerated]
		internal static void <.cctor>g__SetConfig|3_1(BaseConfiguration config)
		{
		}

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		[FieldOffset(Offset = "0x0")]
		private static EquipConfiguration _configuration;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x8")]
		private static List<EquippableHandlerService.HandlerInfo> _defaultHandlers;

		// Token: 0x0200096E RID: 2414
		[Token(Token = "0x200096E")]
		private class HandlerInfo
		{
			// Token: 0x06004089 RID: 16521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004089")]
			[Address(RVA = "0x85B690", Offset = "0x85A890", VA = "0x18085B690")]
			public HandlerInfo(Type dataType, Type handlerType)
			{
			}

			// Token: 0x04002F17 RID: 12055
			[Token(Token = "0x4002F17")]
			[FieldOffset(Offset = "0x10")]
			public Type DataType;

			// Token: 0x04002F18 RID: 12056
			[Token(Token = "0x4002F18")]
			[FieldOffset(Offset = "0x18")]
			public Type HandlerType;
		}
	}
}
