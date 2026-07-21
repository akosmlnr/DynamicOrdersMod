using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x060017FD RID: 6141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x5DDB30", Offset = "0x5DCD30", VA = "0x1805DDB30")]
		public UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1)
		{
		}

		// Token: 0x04001504 RID: 5380
		[Token(Token = "0x4001504")]
		[FieldOffset(Offset = "0x20")]
		public string uniquenessCode;
	}
}
