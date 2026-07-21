using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x2000A03")]
	public static class MathUtility
	{
		// Token: 0x06004920 RID: 18720 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x8F8B10", Offset = "0x8F7D10", VA = "0x1808F8B10")]
		public static bool PointInsideCube(Vector3 point, Vector3 center, Vector3 halfExtents)
		{
			return default(bool);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00013C80 File Offset: 0x00011E80
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x8F8B80", Offset = "0x8F7D80", VA = "0x1808F8B80")]
		public static bool PointInsideRectangle(Vector2 point, Vector2 center, Vector2 halfExtents)
		{
			return default(bool);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00013C98 File Offset: 0x00011E98
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x8F8440", Offset = "0x8F7640", VA = "0x1808F8440")]
		public static Vector2 ClosestPointOnSegment(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00013CB0 File Offset: 0x00011EB0
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x8F8540", Offset = "0x8F7740", VA = "0x1808F8540")]
		public static Vector3 ClosestPointOnSegment(Vector3 point, Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x8F8820", Offset = "0x8F7A20", VA = "0x1808F8820")]
		public static float GetNormalizedPositionAlongSegment(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0f;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x8F88C0", Offset = "0x8F7AC0", VA = "0x1808F88C0")]
		public static float GetNormalizedPositionAlongSegment(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x8F89C0", Offset = "0x8F7BC0", VA = "0x1808F89C0")]
		public static int GetWrappedIndex(int index, int change, int size)
		{
			return 0;
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x8F8170", Offset = "0x8F7370", VA = "0x1808F8170")]
		public static bool BetweenValues(float value, float min, float max, bool maxInclusive = false, bool minInclusive = false)
		{
			return default(bool);
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x8F8B00", Offset = "0x8F7D00", VA = "0x1808F8B00")]
		public static float Normalise(float value, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x8F8BE0", Offset = "0x8F7DE0", VA = "0x1808F8BE0")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x8F8A10", Offset = "0x8F7C10", VA = "0x1808F8A10")]
		public static float InverseDistance01(Vector3 a, Vector3 b, float minDist, float maxDist)
		{
			return 0f;
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x8F89D0", Offset = "0x8F7BD0", VA = "0x1808F89D0")]
		public static float InverseDistance01(float sqrDist, float minDist, float maxDist)
		{
			return 0f;
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00013D88 File Offset: 0x00011F88
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x7BC2D0", Offset = "0x7BB4D0", VA = "0x1807BC2D0")]
		public static bool NearlyEqual(float a, float b, float tolerance)
		{
			return default(bool);
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00013DA0 File Offset: 0x00011FA0
		[Token(Token = "0x600492D")]
		[Address(RVA = "0x8F8A90", Offset = "0x8F7C90", VA = "0x1808F8A90")]
		public static float LogLerp(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x8F86B0", Offset = "0x8F78B0", VA = "0x1808F86B0")]
		public static Plane CreatePlaneFromPoints(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Plane);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x8F81B0", Offset = "0x8F73B0", VA = "0x1808F81B0")]
		public static Vector3 ClosestPointOnPlane(in Plane plane, in Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x8F8250", Offset = "0x8F7450", VA = "0x1808F8250")]
		public static Vector3 ClosestPointOnPlane(in Vector3 normal, float distance, in Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x8F82C0", Offset = "0x8F74C0", VA = "0x1808F82C0")]
		public static Vector3 ClosestPointOnQuad(Vector3 point, Vector3 origin, Vector3 axisU, Vector3 axisV, float halfU, float halfV)
		{
			return default(Vector3);
		}
	}
}
