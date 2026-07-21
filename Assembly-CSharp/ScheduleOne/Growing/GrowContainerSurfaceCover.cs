using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Growing
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	public class GrowContainerSurfaceCover : MonoBehaviour
	{
		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00011208 File Offset: 0x0000F408
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000939")]
		public float CurrentCoverage
		{
			[Token(Token = "0x6003AFC")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AFD")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700093A")]
		public float PourApplicationStrength
		{
			[Token(Token = "0x6003AFE")]
			[Address(RVA = "0x6A03E0", Offset = "0x69F5E0", VA = "0x1806A03E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AFF")]
			[Address(RVA = "0x816300", Offset = "0x815500", VA = "0x180816300")]
			set
			{
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700093B")]
		public bool UseApplyOverTime
		{
			[Token(Token = "0x6003B00")]
			[Address(RVA = "0x6466D0", Offset = "0x6458D0", VA = "0x1806466D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B01")]
			[Address(RVA = "0x6466F0", Offset = "0x6458F0", VA = "0x1806466F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x00011250 File Offset: 0x0000F450
		[Token(Token = "0x1700093C")]
		private float _sideLength
		{
			[Token(Token = "0x6003B02")]
			[Address(RVA = "0x8162D0", Offset = "0x8154D0", VA = "0x1808162D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x816190", Offset = "0x815390", VA = "0x180816190")]
		private void OnEnable()
		{
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x815E70", Offset = "0x815070", VA = "0x180815E70")]
		public void ConfigureAppearance(Color col, float transparency)
		{
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B06")]
		[Address(RVA = "0x816230", Offset = "0x815430", VA = "0x180816230")]
		public void Reset()
		{
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x816210", Offset = "0x815410", VA = "0x180816210")]
		public void QueuePour(Vector3 worldSpacePosition)
		{
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x00011268 File Offset: 0x0000F468
		[Token(Token = "0x6003B08")]
		[Address(RVA = "0x816100", Offset = "0x815300", VA = "0x180816100")]
		public float GetNormalizedProgress()
		{
			return 0f;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x815E00", Offset = "0x815000", VA = "0x180815E00")]
		private IEnumerator CheckQueue()
		{
			return null;
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x815C50", Offset = "0x814E50", VA = "0x180815C50")]
		private void Blank()
		{
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x815F30", Offset = "0x815130", VA = "0x180815F30")]
		private void DelayedApplyPour(Vector3 worldSpace)
		{
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x8158C0", Offset = "0x814AC0", VA = "0x1808158C0")]
		private void ApplyPour(Vector3 worldSpace, bool applyOverTime = false)
		{
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x815850", Offset = "0x814A50", VA = "0x180815850")]
		private IEnumerator ApplyPourOverTime()
		{
			return null;
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00011280 File Offset: 0x0000F480
		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0x816110", Offset = "0x815310", VA = "0x180816110")]
		private float GetPourMaskValue(int x, int y)
		{
			return 0f;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00011298 File Offset: 0x0000F498
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x816020", Offset = "0x815220", VA = "0x180816020")]
		private float GetCoverage()
		{
			return 0f;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x816260", Offset = "0x815460", VA = "0x180816260")]
		public GrowContainerSurfaceCover()
		{
		}

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		public const int TextureSize = 128;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		public const int PourRadius = 32;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		public const int UpdatesPerSecond = 24;

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		public const float CoveredPixelThreshold = 0.8f;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		public const float Delay = 0.35f;

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float SuccessfulCoverageThreshold;

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public GrowContainer GrowContainer;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0x38")]
		public MeshRenderer MeshRenderer;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D PourMask;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Pour Over time Settings")]
		private float _applyPoutOverTimeDuration;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationCurve _applyPoutOverTimeCurve;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onSufficientCoverage;

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x60")]
		private bool queued;

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 queuedWorldPos;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x70")]
		private Texture2D mainTex;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x78")]
		private Texture2D tempTex;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 relative;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x8C")]
		private Vector2 vector2;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x94")]
		private Vector2 normalizedOffset;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x9C")]
		private Vector2 originPixel;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0xA4")]
		private float _pourApplicationStrength;
	}
}
