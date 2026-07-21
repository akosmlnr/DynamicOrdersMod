using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D0 RID: 2256
	[Token(Token = "0x20008D0")]
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000963")]
		public StorageGrid _ownerGrid
		{
			[Token(Token = "0x6003C29")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000964")]
		public StoredItem occupant
		{
			[Token(Token = "0x6003C2A")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C2B")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x825C50", Offset = "0x824E50", VA = "0x180825C50")]
		public void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x825C70", Offset = "0x824E70", VA = "0x180825C70")]
		public void SetOccupant(StoredItem occ)
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StorageTile()
		{
		}

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x20")]
		public int x;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x24")]
		public int y;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public StorageGrid ownerGrid;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x30")]
		public Action onOccupantChanged;
	}
}
