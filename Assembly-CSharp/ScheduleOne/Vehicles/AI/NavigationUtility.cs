using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using ScheduleOne.Math;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class NavigationUtility
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600106A")]
		[Address(RVA = "0xB01820", Offset = "0xB00A20", VA = "0x180B01820")]
		public static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback)
		{
			return null;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106B")]
		[Address(RVA = "0xB01000", Offset = "0xB00200", VA = "0x180B01000")]
		private static void AdjustExitPoint(PathGroup group)
		{
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106C")]
		[Address(RVA = "0xB00CB0", Offset = "0xAFFEB0", VA = "0x180B00CB0")]
		private static void AdjustEntryPoint(PathGroup group)
		{
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x600106D")]
		[Address(RVA = "0xB019D0", Offset = "0xB00BD0", VA = "0x180B019D0")]
		private static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			return default(bool);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600106E")]
		[Address(RVA = "0xB02010", Offset = "0xB01210", VA = "0x180B02010")]
		private static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback)
		{
			return null;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106F")]
		[Address(RVA = "0xB01BF0", Offset = "0xB00DF0", VA = "0x180B01BF0")]
		public static void DrawPath(PathGroup group, float duration = 10f)
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001070")]
		[Address(RVA = "0xB02250", Offset = "0xB01450", VA = "0x180B02250")]
		private static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			return null;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6001071")]
		[Address(RVA = "0xB02350", Offset = "0xB01550", VA = "0x180B02350")]
		public static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			return default(Vector3);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6001072")]
		[Address(RVA = "0xB02120", Offset = "0xB01320", VA = "0x180B02120")]
		public static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			return default(Vector3);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public NavigationUtility()
		{
		}

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		public const float ROAD_MULTIPLIER = 1f;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		public const float OFFROAD_MULTIPLIER = 3f;

		// Token: 0x020002BB RID: 699
		[Token(Token = "0x20002BB")]
		public enum ENavigationCalculationResult
		{
			// Token: 0x04000ECF RID: 3791
			[Token(Token = "0x4000ECF")]
			Success,
			// Token: 0x04000ED0 RID: 3792
			[Token(Token = "0x4000ED0")]
			Failed
		}

		// Token: 0x020002BC RID: 700
		// (Invoke) Token: 0x06001075 RID: 4213
		[Token(Token = "0x20002BC")]
		public delegate void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path);

		// Token: 0x020002BD RID: 701
		// (Invoke) Token: 0x06001079 RID: 4217
		[Token(Token = "0x20002BD")]
		public delegate void PathGroupEvent(PathGroup calculatedGroup);
	}
}
