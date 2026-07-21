using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/")]
	[ExecuteInEditMode]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x7A1D70", Offset = "0x7A0F70", VA = "0x1807A1D70", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x56E800", Offset = "0x56DA00", VA = "0x18056E800", Slot = "5")]
		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return MaterialManager.SD.DynamicOcclusion.Off;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x7A2810", Offset = "0x7A1A10", VA = "0x1807A2810")]
		private void ProcessOcclusionInternal()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x7A2750", Offset = "0x7A1950", VA = "0x1807A2750", Slot = "6")]
		protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			return default(bool);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x7A2AB0", Offset = "0x7A1CB0", VA = "0x1807A2AB0")]
		private void Update()
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x7A2840", Offset = "0x7A1A40", VA = "0x1807A2840")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x7A1DA0", Offset = "0x7A0FA0", VA = "0x1807A1DA0")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x7A27A0", Offset = "0x7A19A0", VA = "0x1807A27A0", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7A1E10", Offset = "0x7A1010", VA = "0x1807A1E10")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7A2440", Offset = "0x7A1640", VA = "0x1807A2440", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7A23A0", Offset = "0x7A15A0", VA = "0x1807A23A0", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x7A1060", Offset = "0x7A0260", VA = "0x1807A1060", Slot = "10")]
		protected override void Awake()
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x7A2210", Offset = "0x7A1410", VA = "0x1807A2210", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7A1C00", Offset = "0x7A0E00", VA = "0x1807A1C00")]
		private void DestroyDepthCamera()
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7A2450", Offset = "0x7A1650", VA = "0x1807A2450", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7A2B80", Offset = "0x7A1D80", VA = "0x1807A2B80")]
		public DynamicOcclusionDepthBuffer()
		{
		}

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x70")]
		public LayerMask layerMask;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x74")]
		public bool useOcclusionCulling;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x78")]
		public int depthMapResolution;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x7C")]
		public float fadeDistanceToSurface;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x80")]
		private Camera m_DepthCamera;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_NeedToUpdateOcclusionNextFrame;
	}
}
