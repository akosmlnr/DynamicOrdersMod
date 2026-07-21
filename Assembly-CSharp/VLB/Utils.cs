using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	public static class Utils
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x7BC4E0", Offset = "0x7BB6E0", VA = "0x1807BC4E0")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return 0f;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x7BC520", Offset = "0x7BB720", VA = "0x1807BC520")]
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return 0f;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000613")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x7BC730", Offset = "0x7BB930", VA = "0x1807BC730")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000615")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000616")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000617")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000618")]
		public static void ForeachComponentsInAnyChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		public static void ForeachComponentsInDirectChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x7BCED0", Offset = "0x7BC0D0", VA = "0x1807BCED0")]
		public static void SetupDepthCamera(Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, Vector3 beamLocalForward, Vector3 lossyScale, bool isScalable, Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BBAF0", VA = "0x1807BC8F0")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x7BC550", Offset = "0x7BB750", VA = "0x1807BC550")]
		public static Vector3 Divide(this Vector3 aVector, Vector3 scale)
		{
			return default(Vector3);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x49F1C0", Offset = "0x49E3C0", VA = "0x18049F1C0")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x7BD490", Offset = "0x7BC690", VA = "0x1807BD490")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x7BD4D0", Offset = "0x7BC6D0", VA = "0x1807BD4D0")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x7BD4B0", Offset = "0x7BC6B0", VA = "0x1807BD4B0")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x7BD4F0", Offset = "0x7BC6F0", VA = "0x1807BD4F0")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x7BD510", Offset = "0x7BC710", VA = "0x1807BD510")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x7BC2D0", Offset = "0x7BB4D0", VA = "0x1807BC2D0")]
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x7BC340", Offset = "0x7BB540", VA = "0x1807BC340")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7BC2F0", Offset = "0x7BB4F0", VA = "0x1807BC2F0")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x7BC250", Offset = "0x7BB450", VA = "0x1807BC250")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7BC380", Offset = "0x7BB580", VA = "0x1807BC380")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x7BCB30", Offset = "0x7BBD30", VA = "0x1807BCB30")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x7BC810", Offset = "0x7BBA10", VA = "0x1807BC810")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return 0f;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x7BC6D0", Offset = "0x7BB8D0", VA = "0x1807BC6D0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return 0f;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7BCA30", Offset = "0x7BBC30", VA = "0x1807BCA30")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x7BC440", Offset = "0x7BB640", VA = "0x1807BC440")]
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			return default(Color);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x7BD360", Offset = "0x7BC560", VA = "0x1807BD360")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x7BC3A0", Offset = "0x7BB5A0", VA = "0x1807BC3A0")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x7BC9C0", Offset = "0x7BBBC0", VA = "0x1807BC9C0")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x7BC9E0", Offset = "0x7BBBE0", VA = "0x1807BC9E0")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x7BCE80", Offset = "0x7BC080", VA = "0x1807BCE80")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x7BCEB0", Offset = "0x7BC0B0", VA = "0x1807BCEB0")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x7BCCC0", Offset = "0x7BBEC0", VA = "0x1807BCCC0")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x7BCBB0", Offset = "0x7BBDB0", VA = "0x1807BCBB0")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x7BD430", Offset = "0x7BC630", VA = "0x1807BD430")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x7BCA50", Offset = "0x7BBC50", VA = "0x1807BCA50")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return 0f;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7BC660", Offset = "0x7BB860", VA = "0x1807BC660")]
		public static Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			return Utils.FloatPackingPrecision.Undef;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x7BC850", Offset = "0x7BBA50", VA = "0x1807BC850")]
		public static bool HasAtLeastOneFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public static void MarkCurrentSceneDirty()
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public static void MarkObjectDirty(global::UnityEngine.Object obj)
		{
		}

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		private const float kEpsilon = 1E-05f;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x0")]
		private static Utils.FloatPackingPrecision ms_FloatPackingPrecision;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		// Token: 0x02000158 RID: 344
		[Token(Token = "0x2000158")]
		public enum FloatPackingPrecision
		{
			// Token: 0x040006F1 RID: 1777
			[Token(Token = "0x40006F1")]
			High = 64,
			// Token: 0x040006F2 RID: 1778
			[Token(Token = "0x40006F2")]
			Low = 8,
			// Token: 0x040006F3 RID: 1779
			[Token(Token = "0x40006F3")]
			Undef = 0
		}
	}
}
