using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	[Serializable]
	public class VisibilityAttribute
	{
		// Token: 0x060017FE RID: 6142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x5E0310", Offset = "0x5DF510", VA = "0x1805E0310")]
		public VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1)
		{
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x5E0270", Offset = "0x5DF470", VA = "0x1805E0270")]
		public void Delete()
		{
		}

		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001505")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001506")]
		[FieldOffset(Offset = "0x18")]
		public float pointsChange;

		// Token: 0x04001507 RID: 5383
		[Token(Token = "0x4001507")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float multiplier;
	}
}
