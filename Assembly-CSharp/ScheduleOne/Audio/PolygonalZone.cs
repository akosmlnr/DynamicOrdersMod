using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BF5 RID: 3061
	[Token(Token = "0x2000BF5")]
	public class PolygonalZone : MonoBehaviour
	{
		// Token: 0x06005A69 RID: 23145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x9AFAC0", Offset = "0x9AECC0", VA = "0x1809AFAC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x9B0B10", Offset = "0x9AFD10", VA = "0x1809B0B10")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00016E60 File Offset: 0x00015060
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x9B08D0", Offset = "0x9AFAD0", VA = "0x1809B08D0")]
		public bool IsPointInsidePolygon(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00016E78 File Offset: 0x00015078
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x9B0A60", Offset = "0x9AFC60", VA = "0x1809B0A60")]
		public bool IsPointInsideZone(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00016E90 File Offset: 0x00015090
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x9B0580", Offset = "0x9AF780", VA = "0x1809B0580")]
		public float GetDistanceToClosestPointOnZone(Vector3 source)
		{
			return 0f;
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x9B0770", Offset = "0x9AF970", VA = "0x1809B0770")]
		protected Vector3[] GetPoints()
		{
			return null;
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00016EA8 File Offset: 0x000150A8
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x9AFD10", Offset = "0x9AEF10", VA = "0x1809AFD10")]
		protected bool DoBoundsContainPoint(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x9AFDB0", Offset = "0x9AEFB0", VA = "0x1809AFDB0")]
		protected Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			return null;
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00016EC0 File Offset: 0x000150C0
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x9AFAF0", Offset = "0x9AECF0", VA = "0x1809AFAF0")]
		protected int CalculateWindingNumber(Vector2[] polygon, Vector2 point)
		{
			return 0;
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00016ED8 File Offset: 0x000150D8
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x9B01F0", Offset = "0x9AF3F0", VA = "0x1809B01F0")]
		protected Vector3 GetClosestPointOnPolygon(Vector3[] polyPoints, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x9B1620", Offset = "0x9B0820", VA = "0x1809B1620")]
		public PolygonalZone()
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x9B1310", Offset = "0x9B0510", VA = "0x1809B1310")]
		[CompilerGenerated]
		internal static bool <CalculateWindingNumber>g__IsPointOnSegment|13_0(Vector2 start, Vector2 end, Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00016F08 File Offset: 0x00015108
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x9B11C0", Offset = "0x9B03C0", VA = "0x1809B11C0")]
		[CompilerGenerated]
		internal static float <CalculateWindingNumber>g__CrossProduct|13_1(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00016F20 File Offset: 0x00015120
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x9B1220", Offset = "0x9B0420", VA = "0x1809B1220")]
		[CompilerGenerated]
		internal static float <CalculateWindingNumber>g__DotProduct|13_2(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00016F38 File Offset: 0x00015138
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x9B1280", Offset = "0x9B0480", VA = "0x1809B1280")]
		[CompilerGenerated]
		internal static int <CalculateWindingNumber>g__IsLeft|13_3(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0;
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00016F50 File Offset: 0x00015150
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x9B1400", Offset = "0x9B0600", VA = "0x1809B1400")]
		[CompilerGenerated]
		internal static Vector3 <GetClosestPointOnPolygon>g__ProjectPointOnLineSegment|14_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x04003C80 RID: 15488
		[Token(Token = "0x4003C80")]
		[FieldOffset(Offset = "0x20")]
		public Transform PointContainer;

		// Token: 0x04003C81 RID: 15489
		[Token(Token = "0x4003C81")]
		[FieldOffset(Offset = "0x28")]
		public bool IsClosed;

		// Token: 0x04003C82 RID: 15490
		[Token(Token = "0x4003C82")]
		[FieldOffset(Offset = "0x2C")]
		public float VerticalSize;

		// Token: 0x04003C83 RID: 15491
		[Token(Token = "0x4003C83")]
		[FieldOffset(Offset = "0x30")]
		[Header("Debug")]
		public Color ZoneColor;

		// Token: 0x04003C84 RID: 15492
		[Token(Token = "0x4003C84")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3[] points;
	}
}
