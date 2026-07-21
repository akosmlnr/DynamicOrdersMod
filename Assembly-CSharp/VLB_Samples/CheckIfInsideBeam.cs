using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x7A0140", Offset = "0x79F340", VA = "0x1807A0140")]
		private void Start()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x7A0210", Offset = "0x79F410", VA = "0x1807A0210")]
		private void Update()
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x79FFB0", Offset = "0x79F1B0", VA = "0x18079FFB0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x79FFC0", Offset = "0x79F1C0", VA = "0x18079FFC0")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CheckIfInsideBeam()
		{
		}

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x20")]
		private bool isInsideBeam;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x28")]
		private Material m_Material;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x30")]
		private Collider m_Collider;
	}
}
