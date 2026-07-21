using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public class FPS_Controller : MonoBehaviour
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x7A4B50", Offset = "0x7A3D50", VA = "0x1807A4B50")]
		private void Start()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x7A4DF0", Offset = "0x7A3FF0", VA = "0x1807A4DF0")]
		private void Update()
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x7A5280", Offset = "0x7A4480", VA = "0x1807A5280")]
		public FPS_Controller()
		{
		}

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x20")]
		private CharacterController characterController;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x28")]
		private Transform mainCamera;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x30")]
		private float inputHor;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x34")]
		private float inputVert;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x38")]
		private float mouseHor;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x3C")]
		private float mouseVert;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x40")]
		private float mouseInvertX;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x44")]
		private float mouseInvertY;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x48")]
		private float camVertAngle;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x4C")]
		private bool isGrounded;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 jumpDirection;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x5C")]
		private float sprint;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x60")]
		public float sprintMax;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x64")]
		public float airControl;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x68")]
		public float jumpHeight;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x6C")]
		public float gravity;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x70")]
		public float characterHeight;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x74")]
		public float cameraHeight;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x78")]
		public float speed;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x7C")]
		public float rotationSpeed;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x80")]
		public float mouseSensitivity;
	}
}
