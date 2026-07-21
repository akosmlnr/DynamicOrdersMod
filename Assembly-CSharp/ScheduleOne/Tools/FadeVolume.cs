using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Tools
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class FadeVolume : MonoBehaviour
	{
		// Token: 0x060038C0 RID: 14528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C1")]
		[Address(RVA = "0x7FAA80", Offset = "0x7F9C80", VA = "0x1807FAA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x7FA7E0", Offset = "0x7F99E0", VA = "0x1807FA7E0")]
		public float GetPositionScalar(Vector3 point)
		{
			return 0f;
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FadeVolume()
		{
		}

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("StartPoint")]
		private Transform _startPoint;

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("EndPoint")]
		private Transform _endPoint;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("BoxCollider")]
		private BoxCollider _boxCollider;
	}
}
