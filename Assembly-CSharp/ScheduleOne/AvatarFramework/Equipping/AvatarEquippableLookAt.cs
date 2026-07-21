using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	[RequireComponent(typeof(AvatarEquippable))]
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x06003853 RID: 14419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003853")]
		[Address(RVA = "0x7E65E0", Offset = "0x7E57E0", VA = "0x1807E65E0")]
		private void Start()
		{
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003854")]
		[Address(RVA = "0x7E6510", Offset = "0x7E5710", VA = "0x1807E6510")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AvatarEquippableLookAt()
		{
		}

		// Token: 0x0400294B RID: 10571
		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x20")]
		public int Priority;

		// Token: 0x0400294C RID: 10572
		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x28")]
		private Avatar avatar;
	}
}
