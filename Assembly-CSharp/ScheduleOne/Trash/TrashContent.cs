using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;

namespace ScheduleOne.Trash
{
	// Token: 0x020007CD RID: 1997
	[Token(Token = "0x20007CD")]
	[Serializable]
	public class TrashContent
	{
		// Token: 0x0600356C RID: 13676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x7D5120", Offset = "0x7D4320", VA = "0x1807D5120")]
		public void AddTrash(string trashID, int quantity)
		{
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356D")]
		[Address(RVA = "0x7D58D0", Offset = "0x7D4AD0", VA = "0x1807D58D0")]
		public void RemoveTrash(string trashID, int quantity)
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x600356E")]
		[Address(RVA = "0x7D5740", Offset = "0x7D4940", VA = "0x1807D5740")]
		public int GetTrashQuantity(string trashID)
		{
			return 0;
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356F")]
		[Address(RVA = "0x7D53E0", Offset = "0x7D45E0", VA = "0x1807D53E0")]
		public void Clear()
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x7D5610", Offset = "0x7D4810", VA = "0x1807D5610")]
		public int GetTotalSize()
		{
			return 0;
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x7D5440", Offset = "0x7D4640", VA = "0x1807D5440")]
		public TrashContentData GetData()
		{
			return null;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x7D5830", Offset = "0x7D4A30", VA = "0x1807D5830")]
		public void LoadFromData(TrashContentData data)
		{
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x7D5A00", Offset = "0x7D4C00", VA = "0x1807D5A00")]
		public TrashContent()
		{
		}

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x10")]
		public List<TrashContent.Entry> Entries;

		// Token: 0x020007CE RID: 1998
		[Token(Token = "0x20007CE")]
		[Serializable]
		public class Entry
		{
			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06003574 RID: 13684 RVA: 0x00010008 File Offset: 0x0000E208
			// (set) Token: 0x06003575 RID: 13685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086A")]
			public int UnitSize
			{
				[Token(Token = "0x6003574")]
				[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003575")]
				[Address(RVA = "0x4A0510", Offset = "0x49F710", VA = "0x1804A0510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06003576 RID: 13686 RVA: 0x00010020 File Offset: 0x0000E220
			// (set) Token: 0x06003577 RID: 13687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086B")]
			public int UnitValue
			{
				[Token(Token = "0x6003576")]
				[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003577")]
				[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003578 RID: 13688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003578")]
			[Address(RVA = "0x7CF5A0", Offset = "0x7CE7A0", VA = "0x1807CF5A0")]
			public Entry(string id, int quantity)
			{
			}

			// Token: 0x040026CF RID: 9935
			[Token(Token = "0x40026CF")]
			[FieldOffset(Offset = "0x10")]
			public string TrashID;

			// Token: 0x040026D0 RID: 9936
			[Token(Token = "0x40026D0")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}
	}
}
