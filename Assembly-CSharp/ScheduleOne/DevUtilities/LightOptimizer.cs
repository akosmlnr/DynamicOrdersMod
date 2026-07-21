using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x06004911 RID: 18705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x8F7630", Offset = "0x8F6830", VA = "0x1808F7630")]
		public void Awake()
		{
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x8F7690", Offset = "0x8F6890", VA = "0x1808F7690")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x8F75C0", Offset = "0x8F67C0", VA = "0x1808F75C0")]
		public void ApplyLights()
		{
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x8F7B00", Offset = "0x8F6D00", VA = "0x1808F7B00")]
		public bool PointInCameraView(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x67D8C0", Offset = "0x67CAC0", VA = "0x18067D8C0")]
		public bool Is01(float a)
		{
			return default(bool);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x7FCFD0", Offset = "0x7FC1D0", VA = "0x1807FCFD0")]
		public void LightsEnabled_True()
		{
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004917")]
		[Address(RVA = "0x79FFB0", Offset = "0x79F1B0", VA = "0x18079FFB0")]
		public void LightsEnabled_False()
		{
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004918")]
		[Address(RVA = "0x8F7EE0", Offset = "0x8F70E0", VA = "0x1808F7EE0")]
		public LightOptimizer()
		{
		}

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x20")]
		public bool LightsEnabled;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected BoxCollider[] activationZones;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] viewPoints;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float checkRange;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x40")]
		protected OptimizedLight[] lights;
	}
}
