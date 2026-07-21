using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Serialization;
using VLB;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A8 RID: 1448
	[Token(Token = "0x20005A8")]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x0000B508 File Offset: 0x00009708
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D7")]
		public bool Override
		{
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x68A2F0", Offset = "0x6894F0", VA = "0x18068A2F0")]
			set
			{
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0000B520 File Offset: 0x00009720
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D8")]
		public bool Enabled
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x68A2E0", Offset = "0x6894E0", VA = "0x18068A2E0")]
			set
			{
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x689FE0", Offset = "0x6891E0", VA = "0x180689FE0")]
		private void AssignReferences()
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x68A180", Offset = "0x689380", VA = "0x18068A180")]
		private void UpdateEffectsState()
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x68A170", Offset = "0x689370", VA = "0x18068A170")]
		private void Awake()
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VolumetricLightTracker()
		{
		}

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("Override")]
		private bool _Override;

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[FormerlySerializedAs("Enabled")]
		private bool _Enabled;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x28")]
		public Light light;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x30")]
		public OptimizedLight optimizedLight;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x38")]
		public VolumetricLightBeamSD beam;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x40")]
		public VolumetricDustParticles dust;
	}
}
