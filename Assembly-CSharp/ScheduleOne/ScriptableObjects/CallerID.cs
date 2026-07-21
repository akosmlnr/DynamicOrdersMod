using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	[CreateAssetMenu(fileName = "CallerID", menuName = "ScriptableObjects/CallerID", order = 1)]
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x06003494 RID: 13460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public CallerID()
		{
		}

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x20")]
		public Sprite ProfilePicture;
	}
}
