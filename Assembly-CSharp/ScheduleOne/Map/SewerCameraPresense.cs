using System;
using System.Runtime.CompilerServices;
using Funly.SkyStudio;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.Map
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	public class SewerCameraPresense : Singleton<SewerCameraPresense>
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000565")]
		public float CameraPresenceInSewerArea
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000566")]
		public float SmoothedCameraPresenceInSewerArea
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x62C1C0", Offset = "0x62B3C0", VA = "0x18062C1C0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0x62C320", Offset = "0x62B520", VA = "0x18062C320")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x62C3C0", Offset = "0x62B5C0", VA = "0x18062C3C0")]
		private void UpdatePresense()
		{
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x62C270", Offset = "0x62B470", VA = "0x18062C270")]
		public bool IsPointInSewerArea(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x62C5D0", Offset = "0x62B7D0", VA = "0x18062C5D0")]
		public SewerCameraPresense()
		{
		}

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x30")]
		public Transform FullPresenseVolumesContainer;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x38")]
		public Transform FadeVolumesContainer;

		// Token: 0x0400193D RID: 6461
		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x40")]
		public SkyProfileOverride SewerSkyProfileOverride;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x48")]
		public Volume SewerPPVolume;

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x50")]
		private BoxCollider[] fullPresenceVolumes;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x58")]
		private FadeVolume[] fadeVolumes;
	}
}
