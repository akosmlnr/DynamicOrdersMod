using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008CC RID: 2252
	[Token(Token = "0x20008CC")]
	[RequireComponent(typeof(StorageEntity))]
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x81EC30", Offset = "0x81DE30", VA = "0x18081EC30", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C06")]
		[Address(RVA = "0x81EE50", Offset = "0x81E050", VA = "0x18081EE50")]
		public StorageEntityVisualizer()
		{
		}

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x58")]
		private StorageEntity storageEntity;
	}
}
