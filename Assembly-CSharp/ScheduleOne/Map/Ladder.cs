using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Doors;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Map
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	[RequireComponent(typeof(BoxCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class Ladder : MonoBehaviour
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000554")]
		public Transform LadderTransform
		{
			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x623950", Offset = "0x622B50", VA = "0x180623950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x17000555")]
		public Vector2 LadderSize
		{
			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x623880", Offset = "0x622A80", VA = "0x180623880")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x17000556")]
		public Vector3 BottomCenter
		{
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x623760", Offset = "0x622960", VA = "0x180623760")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x17000557")]
		public Vector3 TopCenter
		{
			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x623970", Offset = "0x622B70", VA = "0x180623970")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x622E00", Offset = "0x622000", VA = "0x180622E00")]
		private void Awake()
		{
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x623290", Offset = "0x622490", VA = "0x180623290")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x623410", Offset = "0x622610", VA = "0x180623410")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x622F50", Offset = "0x622150", VA = "0x180622F50")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x623670", Offset = "0x622870", VA = "0x180623670")]
		public Vector2 ProjectOnLadderSurface(Vector3 position)
		{
			return default(Vector2);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x622E70", Offset = "0x622070", VA = "0x180622E70")]
		public Vector2 NormalizeProjectedPosition(Vector2 projectedPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x623580", Offset = "0x622780", VA = "0x180623580")]
		public void PlayClimbSound(Vector3 position)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Ladder()
		{
		}

		// Token: 0x040018CB RID: 6347
		[Token(Token = "0x40018CB")]
		public const float NPCClimbOffset = 0.42f;

		// Token: 0x040018CC RID: 6348
		[Token(Token = "0x40018CC")]
		public const float LadderMountDismountTimeMultiplier = 0.4f;

		// Token: 0x040018CD RID: 6349
		[Token(Token = "0x40018CD")]
		public const float LadderClimbTimeMultiplier = 0.75f;

		// Token: 0x040018CE RID: 6350
		[Token(Token = "0x40018CE")]
		public const float NPCClimbSoundInterval = 0.3f;

		// Token: 0x040018CF RID: 6351
		[Token(Token = "0x40018CF")]
		public const float PlayerClimbSoundLengthInterval = 0.8f;

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public OffMeshLink OffMeshLink;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController ClimbSound;

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x30")]
		public SewerDoorController LinkedManholeCover;

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x38")]
		private BoxCollider boxCollider;

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x40")]
		private float timeOnLastClimbSound;
	}
}
