using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000969 RID: 2409
	[Token(Token = "0x2000969")]
	public class TPEquippedUmbrella : TPEquippedItem
	{
		// Token: 0x0600407C RID: 16508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x867990", Offset = "0x866B90", VA = "0x180867990", Slot = "4")]
		public override void Equip(IEquippedItemHandler handler)
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x867E10", Offset = "0x867010", VA = "0x180867E10")]
		public TPEquippedUmbrella()
		{
		}

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		[FieldOffset(Offset = "0x78")]
		public MeshRenderer[] CanopyMeshes;

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		[FieldOffset(Offset = "0x80")]
		public SkinnedMeshRenderer[] CanopySkinnedMeshes;

		// Token: 0x04002F12 RID: 12050
		[Token(Token = "0x4002F12")]
		[FieldOffset(Offset = "0x88")]
		private global::System.Random _random;
	}
}
