using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008AF RID: 2223
	[Token(Token = "0x20008AF")]
	public class GrowContainerCameraHandler : MonoBehaviour
	{
		// Token: 0x06003AEE RID: 15086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x814760", Offset = "0x813960", VA = "0x180814760")]
		public void PositionCameraContainer()
		{
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x8146E0", Offset = "0x8138E0", VA = "0x1808146E0")]
		public Transform GetCameraPosition(GrowContainerCameraHandler.ECameraPosition pos, bool autoPosition = true)
		{
			return null;
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x814B50", Offset = "0x813D50", VA = "0x180814B50")]
		[Button]
		private void SetCameraPosition()
		{
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x814C90", Offset = "0x813E90", VA = "0x180814C90")]
		public GrowContainerCameraHandler()
		{
		}

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool RotateCameraContainerToFacePlayer;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool SnapRotationToRightAngles;

		// Token: 0x04002B77 RID: 11127
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _midshotCamera;

		// Token: 0x04002B78 RID: 11128
		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _closeupCamera;

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _fullshotContainer;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _birdsEyeCamera;

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0x48")]
		[Header("Debug & Development")]
		[SerializeField]
		private GrowContainerCameraHandler.ECameraPosition _debugCameraPosition;

		// Token: 0x020008B0 RID: 2224
		[Token(Token = "0x20008B0")]
		public enum ECameraPosition
		{
			// Token: 0x04002B7D RID: 11133
			[Token(Token = "0x4002B7D")]
			Closeup,
			// Token: 0x04002B7E RID: 11134
			[Token(Token = "0x4002B7E")]
			Midshot,
			// Token: 0x04002B7F RID: 11135
			[Token(Token = "0x4002B7F")]
			Fullshot,
			// Token: 0x04002B80 RID: 11136
			[Token(Token = "0x4002B80")]
			BirdsEye
		}
	}
}
