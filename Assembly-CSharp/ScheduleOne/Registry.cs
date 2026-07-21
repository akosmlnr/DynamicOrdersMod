using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0xAF9760", Offset = "0xAF8960", VA = "0x180AF9760")]
		private void OnValidate()
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0xAF8CF0", Offset = "0xAF7EF0", VA = "0x180AF8CF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0xAF9170", Offset = "0xAF8370", VA = "0x180AF9170")]
		public static ItemDefinition GetItem(string ID)
		{
			return null;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0xAF9200", Offset = "0xAF8400", VA = "0x180AF9200")]
		public static bool ItemExists(string ID)
		{
			return default(bool);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E36")]
		public static T GetItem<T>(string ID) where T : ItemDefinition
		{
			return null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0xAFA140", Offset = "0xAF9340", VA = "0x180AFA140")]
		public ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			return null;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0xAF9130", Offset = "0xAF8330", VA = "0x180AF9130")]
		private static int GetHash(string ID)
		{
			return 0;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0xAF9A10", Offset = "0xAF8C10", VA = "0x180AF9A10")]
		private static string RemoveAssetsAndPrefab(string originalString)
		{
			return null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0xAFA040", Offset = "0xAF9240", VA = "0x180AFA040", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0xAF8B40", Offset = "0xAF7D40", VA = "0x180AF8B40")]
		public void AddToRegistry(ItemDefinition item)
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0xAF9010", Offset = "0xAF8210", VA = "0x180AF9010")]
		public List<ItemDefinition> GetAllItems()
		{
			return null;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0xAF8A10", Offset = "0xAF7C10", VA = "0x180AF8A10")]
		private void AddToItemDictionary(Registry.ItemRegister reg)
		{
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0xAF9C40", Offset = "0xAF8E40", VA = "0x180AF9C40")]
		private void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0xAF9CD0", Offset = "0xAF8ED0", VA = "0x180AF9CD0")]
		public void RemoveRuntimeItems()
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0xAF9AC0", Offset = "0xAF8CC0", VA = "0x180AF9AC0")]
		public void RemoveFromRegistry(ItemDefinition item)
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0xAF92C0", Offset = "0xAF84C0", VA = "0x180AF92C0")]
		[Button]
		public void LogOrderedUnlocks()
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0xAFA430", Offset = "0xAF9630", VA = "0x180AFA430")]
		public Registry()
		{
		}

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Registry.ItemRegister> ItemRegistry;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Registry.ItemRegister> ItemsAddedAtRuntime;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, Registry.ItemRegister> ItemDictionary;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> itemIDAliases;

		// Token: 0x02000280 RID: 640
		[Token(Token = "0x2000280")]
		[Serializable]
		public class ItemRegister
		{
			// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ItemRegister()
			{
			}

			// Token: 0x04000CFD RID: 3325
			[Token(Token = "0x4000CFD")]
			[FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			// Token: 0x04000CFE RID: 3326
			[Token(Token = "0x4000CFE")]
			[FieldOffset(Offset = "0x18")]
			public string ID;

			// Token: 0x04000CFF RID: 3327
			[Token(Token = "0x4000CFF")]
			[FieldOffset(Offset = "0x20")]
			public ItemDefinition Definition;
		}
	}
}
