using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	public class VisionEvent
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		public ISightable Target
		{
			[Token(Token = "0x6001833")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001834")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		public EntityVisualState State
		{
			[Token(Token = "0x6001835")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001836")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049D")]
		public VisionCone Owner
		{
			[Token(Token = "0x6001837")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001838")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00009B70 File Offset: 0x00007D70
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049E")]
		public float FullNoticeTime
		{
			[Token(Token = "0x6001839")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600183A")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x1700049F")]
		public float NormalizedNoticeLevel
		{
			[Token(Token = "0x600183B")]
			[Address(RVA = "0x5E6370", Offset = "0x5E5570", VA = "0x1805E6370")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x5E6210", Offset = "0x5E5410", VA = "0x1805E6210")]
		public VisionEvent(VisionCone _owner, ISightable _target, EntityVisualState _state, float _noticeTime, bool _playTremolo)
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x5E5E90", Offset = "0x5E5090", VA = "0x1805E5E90")]
		public void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x5E5E00", Offset = "0x5E5000", VA = "0x1805E5E00")]
		public void EndEvent()
		{
		}

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		private const float NOTICE_DROP_THRESHOLD = 1f;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x2C")]
		private float timeSinceSighted;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x30")]
		private float currentNoticeTime;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x34")]
		public bool playTremolo;
	}
}
