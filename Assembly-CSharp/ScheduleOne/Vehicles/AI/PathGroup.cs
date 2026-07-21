using System;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class PathGroup
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PathGroup()
		{
		}

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 entryPoint;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x20")]
		public Path startToEntryPath;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x28")]
		public Path entryToExitPath;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x30")]
		public Path exitToDestinationPath;
	}
}
