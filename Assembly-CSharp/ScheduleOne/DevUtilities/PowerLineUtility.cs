using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	public class PowerLineUtility
	{
		// Token: 0x06004991 RID: 18833 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x6004991")]
		[Address(RVA = "0x90CF50", Offset = "0x90C150", VA = "0x18090CF50")]
		public static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			return 0;
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004992")]
		[Address(RVA = "0x90C600", Offset = "0x90B800", VA = "0x18090C600")]
		public static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004993")]
		[Address(RVA = "0x90D0B0", Offset = "0x90C2B0", VA = "0x18090D0B0")]
		private static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004994")]
		[Address(RVA = "0x90C6E0", Offset = "0x90B8E0", VA = "0x18090C6E0")]
		private static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			return null;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004995")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PowerLineUtility()
		{
		}

		// Token: 0x040033F7 RID: 13303
		[Token(Token = "0x40033F7")]
		[FieldOffset(Offset = "0x0")]
		public static int MinSegmentCount;

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[FieldOffset(Offset = "0x4")]
		public static int MaxSegmentCount;
	}
}
