using System;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Math
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	public static class PathSmoothingUtility
	{
		// Token: 0x06002FF3 RID: 12275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x7680E0", Offset = "0x7672E0", VA = "0x1807680E0")]
		public static void EnsureSplineInitialized()
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x767AE0", Offset = "0x766CE0", VA = "0x180767AE0")]
		public static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5f)
		{
			return null;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x767F80", Offset = "0x767180", VA = "0x180767F80")]
		private static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x768220", Offset = "0x767420", VA = "0x180768220")]
		private static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			return null;
		}

		// Token: 0x04002361 RID: 9057
		[Token(Token = "0x4002361")]
		private const float MinControlPointDistance = 0.5f;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x0")]
		private static CurvySpline _spline;

		// Token: 0x0200072A RID: 1834
		[Token(Token = "0x200072A")]
		public class SmoothedPath
		{
			// Token: 0x06002FF7 RID: 12279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0x768520", Offset = "0x767720", VA = "0x180768520")]
			public void InitializePath()
			{
			}

			// Token: 0x06002FF8 RID: 12280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF8")]
			[Address(RVA = "0x7688E0", Offset = "0x767AE0", VA = "0x1807688E0")]
			public SmoothedPath()
			{
			}

			// Token: 0x04002363 RID: 9059
			[Token(Token = "0x4002363")]
			public const float MARGIN = 10f;

			// Token: 0x04002364 RID: 9060
			[Token(Token = "0x4002364")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> vectorPath;

			// Token: 0x04002365 RID: 9061
			[Token(Token = "0x4002365")]
			[FieldOffset(Offset = "0x18")]
			public List<Bounds> segmentBounds;
		}
	}
}
