using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public static class BatchingHelper
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x68B3A0", Offset = "0x68A5A0", VA = "0x18068B3A0")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x68B3C0", Offset = "0x68A5C0", VA = "0x18068B3C0")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x1700007B")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x68B3E0", Offset = "0x68A5E0", VA = "0x18068B3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x68B220", Offset = "0x68A420", VA = "0x18068B220")]
		private static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x68A790", Offset = "0x689990", VA = "0x18068A790")]
		public static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x68A610", Offset = "0x689810", VA = "0x18068A610")]
		public static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x68AC60", Offset = "0x689E60", VA = "0x18068AC60")]
		public static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x68A440", Offset = "0x689640", VA = "0x18068A440")]
		public static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x68B0D0", Offset = "0x68A2D0", VA = "0x18068B0D0")]
		public static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			return default(bool);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x68A390", Offset = "0x689590", VA = "0x18068A390")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
}
