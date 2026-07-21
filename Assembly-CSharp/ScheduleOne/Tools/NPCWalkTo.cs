using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087C RID: 2172
	[Token(Token = "0x200087C")]
	[RequireComponent(typeof(NPCMovement))]
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x06003982 RID: 14722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x806FE0", Offset = "0x8061E0", VA = "0x180806FE0")]
		private void Update()
		{
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x55E020", Offset = "0x55D220", VA = "0x18055E020")]
		public NPCWalkTo()
		{
		}

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[FieldOffset(Offset = "0x20")]
		public Transform Target;

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[FieldOffset(Offset = "0x28")]
		public float RepathRate;

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[FieldOffset(Offset = "0x2C")]
		private float timeSinceLastPath;
	}
}
