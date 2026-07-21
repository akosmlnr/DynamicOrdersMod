using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007E2 RID: 2018
	[Token(Token = "0x20007E2")]
	[CreateAssetMenu(fileName = "Avatar Layer", menuName = "ScriptableObjects/Avatar Layer", order = 1)]
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x0600368C RID: 13964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public AvatarLayer()
		{
		}

		// Token: 0x0400277D RID: 10109
		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400277E RID: 10110
		[Token(Token = "0x400277E")]
		[FieldOffset(Offset = "0x20")]
		public string AssetPath;

		// Token: 0x0400277F RID: 10111
		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D Texture;

		// Token: 0x04002780 RID: 10112
		[Token(Token = "0x4002780")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D Normal;

		// Token: 0x04002781 RID: 10113
		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D Normal_DefaultImportType;

		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		[FieldOffset(Offset = "0x40")]
		public int Order;

		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		[FieldOffset(Offset = "0x48")]
		public Material CombinedMaterial;
	}
}
