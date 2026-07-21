using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x00013F08 File Offset: 0x00012108
		// (set) Token: 0x0600495B RID: 18779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B79")]
		public bool Enabled
		{
			[Token(Token = "0x600495A")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600495B")]
			[Address(RVA = "0x909750", Offset = "0x908950", VA = "0x180909750")]
			set
			{
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x00013F20 File Offset: 0x00012120
		// (set) Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7A")]
		public bool DisabledForOptimization
		{
			[Token(Token = "0x600495C")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600495D")]
			[Address(RVA = "0x909740", Offset = "0x908940", VA = "0x180909740")]
			set
			{
			}
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495E")]
		[Address(RVA = "0x908F50", Offset = "0x908150", VA = "0x180908F50", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x909110", Offset = "0x908310", VA = "0x180909110")]
		private void Start()
		{
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x908FE0", Offset = "0x9081E0", VA = "0x180908FE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x9094A0", Offset = "0x9086A0", VA = "0x1809094A0")]
		private void UpdateCull()
		{
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x9090E0", Offset = "0x9082E0", VA = "0x1809090E0")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x909630", Offset = "0x908830", VA = "0x180909630")]
		private void UpdateLightState()
		{
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x909720", Offset = "0x908920", VA = "0x180909720")]
		public OptimizedLight()
		{
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x909280", Offset = "0x908480", VA = "0x180909280")]
		[CompilerGenerated]
		private void <Start>g__Register|14_0()
		{
		}

		// Token: 0x040033D5 RID: 13269
		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("Enabled")]
		[SerializeField]
		private bool _Enabled;

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("DisabledForOptimization")]
		private bool _DisabledForOptimization;

		// Token: 0x040033D7 RID: 13271
		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x24")]
		[Range(10f, 500f)]
		public float MaxDistance;

		// Token: 0x040033D8 RID: 13272
		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x28")]
		public Light _Light;

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LensFlareComponentSRP _lensFlare;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x38")]
		private bool culled;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x3C")]
		private float maxDistanceSquared;
	}
}
