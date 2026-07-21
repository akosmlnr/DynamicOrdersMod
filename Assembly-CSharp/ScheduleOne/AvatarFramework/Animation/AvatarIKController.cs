using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x06003819 RID: 14361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x7E7D10", Offset = "0x7E6F10", VA = "0x1807E7D10")]
		private void Awake()
		{
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x7E7EC0", Offset = "0x7E70C0", VA = "0x1807E7EC0")]
		private void Start()
		{
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x7E7EA0", Offset = "0x7E70A0", VA = "0x1807E7EA0")]
		public void SetIKActive(bool active)
		{
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x7E7DA0", Offset = "0x7E6FA0", VA = "0x1807E7DA0")]
		public void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x7E7E20", Offset = "0x7E7020", VA = "0x1807E7E20")]
		public void ResetLegBendTargets()
		{
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AvatarIKController()
		{
		}

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public BipedIK BodyIK;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x28")]
		private Transform defaultLeftLegBendTarget;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x30")]
		private Transform defaultRightLegBendTarget;
	}
}
