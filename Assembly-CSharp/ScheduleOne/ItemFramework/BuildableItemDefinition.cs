using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	[CreateAssetMenu(fileName = "BuildableItemDefinition", menuName = "ScriptableObjects/BuildableItemDefinition", order = 1)]
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x06002687 RID: 9863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x6B9960", Offset = "0x6B8B60", VA = "0x1806B9960", Slot = "4")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public BuildableItemDefinition()
		{
		}

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0xB8")]
		public BuildableItem BuiltItem;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0xC0")]
		public BuildableItemDefinition.EBuildSoundType BuildSoundType;

		// Token: 0x02000617 RID: 1559
		[Token(Token = "0x2000617")]
		public enum EBuildSoundType
		{
			// Token: 0x04001E35 RID: 7733
			[Token(Token = "0x4001E35")]
			Cardboard,
			// Token: 0x04001E36 RID: 7734
			[Token(Token = "0x4001E36")]
			Wood,
			// Token: 0x04001E37 RID: 7735
			[Token(Token = "0x4001E37")]
			Metal
		}
	}
}
