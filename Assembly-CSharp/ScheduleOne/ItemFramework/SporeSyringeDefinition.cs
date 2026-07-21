using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	[CreateAssetMenu(fileName = "SporeSyringeDefinition", menuName = "ScriptableObjects/Item Definitions/SporeSyringeDefinition", order = 1)]
	[Serializable]
	public class SporeSyringeDefinition : StorableItemDefinition
	{
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public ShroomSpawnDefinition SpawnDefinition
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x4B4780", Offset = "0x4B3980", VA = "0x1804B4780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x4B52C0", Offset = "0x4B44C0", VA = "0x1804B52C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public SporeSyringeDefinition()
		{
		}
	}
}
