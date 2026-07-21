using System;
using Il2CppDummyDll;
using ScheduleOne.Math;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	public static class PathUtility
	{
		// Token: 0x0600109A RID: 4250 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x600109A")]
		[Address(RVA = "0xB03040", Offset = "0xB02240", VA = "0x180B03040")]
		public static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)
		{
			return default(Vector3);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x600109B")]
		[Address(RVA = "0xB02F90", Offset = "0xB02190", VA = "0x180B02F90")]
		public static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)
		{
			return default(Vector3);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x600109C")]
		[Address(RVA = "0xB02F40", Offset = "0xB02140", VA = "0x180B02F40")]
		public static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			return default(Vector3);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x600109D")]
		[Address(RVA = "0xB038B0", Offset = "0xB02AB0", VA = "0x180B038B0")]
		public static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			return default(Vector3);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x600109E")]
		[Address(RVA = "0xB027A0", Offset = "0xB019A0", VA = "0x180B027A0")]
		public static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			return 0f;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x600109F")]
		[Address(RVA = "0xB02B70", Offset = "0xB01D70", VA = "0x180B02B70")]
		public static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)
		{
			return 0f;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0xB03380", Offset = "0xB02580", VA = "0x180B03380")]
		public static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			return default(Vector3);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0xB02DE0", Offset = "0xB01FE0", VA = "0x180B02DE0")]
		public static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)
		{
			return default(Vector3);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0xB03200", Offset = "0xB02400", VA = "0x180B03200")]
		private static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = true)
		{
			return default(Vector3);
		}
	}
}
