using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	[CreateAssetMenu(fileName = "ShroomSpawnDefinition", menuName = "ScriptableObjects/Item Definitions/ShroomSpawnDefinition", order = 1)]
	[Serializable]
	public class ShroomSpawnDefinition : StorableItemDefinition
	{
		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D3")]
		public ShroomColony ColonyPrefab
		{
			[Token(Token = "0x600274E")]
			[Address(RVA = "0x4B4780", Offset = "0x4B3980", VA = "0x1804B4780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x4B52C0", Offset = "0x4B44C0", VA = "0x1804B52C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		public ShroomDefinition Shroom
		{
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x4B4760", Offset = "0x4B3960", VA = "0x1804B4760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002751")]
			[Address(RVA = "0x4B5280", Offset = "0x4B4480", VA = "0x1804B5280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D5")]
		public SpawnChunk ChunkPrefab
		{
			[Token(Token = "0x6002752")]
			[Address(RVA = "0x4B4790", Offset = "0x4B3990", VA = "0x1804B4790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002753")]
			[Address(RVA = "0x4B52E0", Offset = "0x4B44E0", VA = "0x1804B52E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D6")]
		public DecalProjector MixTaskProjectorPrefab
		{
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x4B47A0", Offset = "0x4B39A0", VA = "0x1804B47A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x4B5300", Offset = "0x4B4500", VA = "0x1804B5300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x6B9960", Offset = "0x6B8B60", VA = "0x1806B9960", Slot = "4")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public ShroomSpawnDefinition()
		{
		}
	}
}
