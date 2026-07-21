using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	[CreateAssetMenu(fileName = "SeedDefinition", menuName = "ScriptableObjects/Item Definitions/SeedDefinition", order = 1)]
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x06003B56 RID: 15190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public SeedDefinition()
		{
		}

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0xB8")]
		public FunctionalSeed FunctionSeedPrefab;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0xC0")]
		public Plant PlantPrefab;
	}
}
