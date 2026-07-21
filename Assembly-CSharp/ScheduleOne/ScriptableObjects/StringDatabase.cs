using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	[CreateAssetMenu(fileName = "StringDatabase", menuName = "ScriptableObjects/StringDatabase", order = 1)]
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public StringDatabase()
		{
		}

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x18")]
		[TextArea(2, 10)]
		public string[] Strings;
	}
}
