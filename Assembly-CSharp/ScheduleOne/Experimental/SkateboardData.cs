using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	[CreateAssetMenu(fileName = "SkateboardData", menuName = "ScriptableObjects/Skateboard/Skateboard Data")]
	public class SkateboardData : ScriptableObject
	{
		// Token: 0x06005A7F RID: 23167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public SkateboardData()
		{
		}

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x18")]
		public SkateboardSettings Settings;
	}
}
