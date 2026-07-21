using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A05 RID: 2565
	[Token(Token = "0x2000A05")]
	public static class NavMeshUtility
	{
		// Token: 0x06004946 RID: 18758 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x6004946")]
		[Address(RVA = "0x907F80", Offset = "0x907180", VA = "0x180907F80")]
		public static float GetPathLength(NavMeshPath path)
		{
			return 0f;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x908150", Offset = "0x907350", VA = "0x180908150")]
		public static Transform GetReachableAccessPoint(ITransitEntity entity, NPC npc)
		{
			return null;
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x908810", Offset = "0x907A10", VA = "0x180908810")]
		public static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			return default(bool);
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x907EA0", Offset = "0x9070A0", VA = "0x180907EA0")]
		public static int GetNavMeshAgentID(string name)
		{
			return 0;
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x908BB0", Offset = "0x907DB0", VA = "0x180908BB0")]
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			return default(bool);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x907A00", Offset = "0x906C00", VA = "0x180907A00")]
		private static void CacheSampleResult(Vector3 sourcePosition, Vector3 hitPosition)
		{
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x600494C")]
		[Address(RVA = "0x908B10", Offset = "0x907D10", VA = "0x180908B10")]
		private static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			return default(Vector3);
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494D")]
		[Address(RVA = "0x907E00", Offset = "0x907000", VA = "0x180907E00")]
		public static void ClearCache()
		{
		}

		// Token: 0x040033CB RID: 13259
		[Token(Token = "0x40033CB")]
		public const float SAMPLE_MAX_DISTANCE = 2f;

		// Token: 0x040033CC RID: 13260
		[Token(Token = "0x40033CC")]
		public const float SAMPLE_CACHE_MAX_DIST = 0.5f;

		// Token: 0x040033CD RID: 13261
		[Token(Token = "0x40033CD")]
		public const float SAMPLE_CACHE_MAX_SQR_DIST = 0.25f;

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		public const float MAX_CACHE_SIZE = 10000f;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<Vector3, Vector3> SampleCache;

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[FieldOffset(Offset = "0x8")]
		public static List<Vector3> sampleCacheKeys;
	}
}
