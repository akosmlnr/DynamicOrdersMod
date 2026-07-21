using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	[Serializable]
	public class TrashItemData
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x61B310", Offset = "0x61A510", VA = "0x18061B310")]
		public TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x10")]
		public string DataType;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x18")]
		public string TrashID;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		[FieldOffset(Offset = "0x20")]
		public string GUID;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 Position;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion Rotation;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x48")]
		public TrashContentData Contents;
	}
}
