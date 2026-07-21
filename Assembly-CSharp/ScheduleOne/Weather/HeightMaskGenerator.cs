using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	public class HeightMaskGenerator : MonoBehaviour
	{
		// Token: 0x06005887 RID: 22663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005887")]
		[Address(RVA = "0x9ACEC0", Offset = "0x9AC0C0", VA = "0x1809ACEC0")]
		public void InitialiseMaskMap()
		{
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005888")]
		[Address(RVA = "0x9ACA70", Offset = "0x9ABC70", VA = "0x1809ACA70")]
		private void GenerateMaskMap()
		{
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005889")]
		[Address(RVA = "0x9AD1A0", Offset = "0x9AC3A0", VA = "0x1809AD1A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588A")]
		[Address(RVA = "0x9ACA50", Offset = "0x9ABC50", VA = "0x1809ACA50")]
		[Button]
		private void GenerateHeightMapDebug()
		{
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588B")]
		[Address(RVA = "0x9AC9E0", Offset = "0x9ABBE0", VA = "0x1809AC9E0")]
		[Button]
		private void Dispose()
		{
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588C")]
		[Address(RVA = "0x9AD230", Offset = "0x9AC430", VA = "0x1809AD230")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588D")]
		[Address(RVA = "0x9AD3D0", Offset = "0x9AC5D0", VA = "0x1809AD3D0")]
		public HeightMaskGenerator()
		{
		}

		// Token: 0x04003AD1 RID: 15057
		[Token(Token = "0x4003AD1")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private ComputeShader _maskShader;

		// Token: 0x04003AD2 RID: 15058
		[Token(Token = "0x4003AD2")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[SerializeField]
		private float _size;

		// Token: 0x04003AD3 RID: 15059
		[Token(Token = "0x4003AD3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _resolution;

		// Token: 0x04003AD4 RID: 15060
		[Token(Token = "0x4003AD4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _minMaxHeight;

		// Token: 0x04003AD5 RID: 15061
		[Token(Token = "0x4003AD5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask _heightmapLayerMask;

		// Token: 0x04003AD6 RID: 15062
		[Token(Token = "0x4003AD6")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Debugging & Development")]
		[SerializeField]
		private float _debugTileSize;

		// Token: 0x04003AD7 RID: 15063
		[Token(Token = "0x4003AD7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RenderTexture _heightTexture;

		// Token: 0x04003AD8 RID: 15064
		[Token(Token = "0x4003AD8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Material _debugMaterial;

		// Token: 0x04003AD9 RID: 15065
		[Token(Token = "0x4003AD9")]
		[FieldOffset(Offset = "0x50")]
		private int _kernal;

		// Token: 0x04003ADA RID: 15066
		[Token(Token = "0x4003ADA")]
		[FieldOffset(Offset = "0x54")]
		private float _tileSize;

		// Token: 0x04003ADB RID: 15067
		[Token(Token = "0x4003ADB")]
		[FieldOffset(Offset = "0x58")]
		private float _tileHalfSize;

		// Token: 0x04003ADC RID: 15068
		[Token(Token = "0x4003ADC")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _origin;

		// Token: 0x04003ADD RID: 15069
		[Token(Token = "0x4003ADD")]
		[FieldOffset(Offset = "0x68")]
		private ComputeBuffer _heightBuffer;
	}
}
