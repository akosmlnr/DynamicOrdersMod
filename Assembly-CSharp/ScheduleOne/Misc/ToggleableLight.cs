using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Misc
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D0")]
		public bool isOn
		{
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B2")]
			[Address(RVA = "0x686AA0", Offset = "0x685CA0", VA = "0x180686AA0")]
			set
			{
			}
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x6789E0", Offset = "0x677BE0", VA = "0x1806789E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x686A80", Offset = "0x685C80", VA = "0x180686A80")]
		public void TurnOn()
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x686A60", Offset = "0x685C60", VA = "0x180686A60")]
		public void TurnOff()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x686850", Offset = "0x685A50", VA = "0x180686850", Slot = "5")]
		protected virtual void SetLights()
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ToggleableLight()
		{
		}

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("isOn")]
		private bool _isOn;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected OptimizedLight[] lightSources;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected MeshRenderer[] lightSurfacesMeshes;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x38")]
		public int MaterialIndex;

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x40")]
		[Header("Materials")]
		[SerializeField]
		protected Material lightOnMat;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Material lightOffMat;

		// Token: 0x04001A88 RID: 6792
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x50")]
		private ToggleableLight.State state;

		// Token: 0x02000596 RID: 1430
		[Token(Token = "0x2000596")]
		private enum State
		{
			// Token: 0x04001A8A RID: 6794
			[Token(Token = "0x4001A8A")]
			NotInitialized,
			// Token: 0x04001A8B RID: 6795
			[Token(Token = "0x4001A8B")]
			On,
			// Token: 0x04001A8C RID: 6796
			[Token(Token = "0x4001A8C")]
			Off
		}
	}
}
