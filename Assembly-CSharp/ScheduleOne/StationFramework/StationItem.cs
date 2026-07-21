using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	public class StationItem : MonoBehaviour
	{
		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003D86 RID: 15750 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003D87 RID: 15751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AE")]
		public List<ItemModule> ActiveModules
		{
			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D87")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x84E700", Offset = "0x84D900", VA = "0x18084E700", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public virtual void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8A")]
		public void ActivateModule<T>() where T : ItemModule
		{
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x84E760", Offset = "0x84D960", VA = "0x18084E760")]
		public void Destroy()
		{
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x6003D8C")]
		public bool HasModule<T>() where T : ItemModule
		{
			return default(bool);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D8D")]
		public T GetModule<T>() where T : ItemModule
		{
			return null;
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x84E7C0", Offset = "0x84D9C0", VA = "0x18084E7C0")]
		public StationItem()
		{
		}

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemModule> Modules;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x30")]
		public TrashItem TrashPrefab;
	}
}
