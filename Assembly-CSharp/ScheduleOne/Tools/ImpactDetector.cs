using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x06003973 RID: 14707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x804400", Offset = "0x803600", VA = "0x180804400")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x804470", Offset = "0x803670", VA = "0x180804470")]
		public ImpactDetector()
		{
		}

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x20")]
		public bool DestroyScriptOnImpact;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onImpact;
	}
}
