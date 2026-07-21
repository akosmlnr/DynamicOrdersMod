using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	[AddComponentMenu("")]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	[DisallowMultipleComponent]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x7A17E0", Offset = "0x7A09E0", VA = "0x1807A17E0")]
		public void ProcessOcclusionManually()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x7A1AC0", Offset = "0x7A0CC0", VA = "0x1807A1AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x7A1B60", Offset = "0x7A0D60", VA = "0x1807A1B60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7A17F0", Offset = "0x7A09F0", VA = "0x1807A17F0")]
		protected void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x170000FC")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x4C20D0", Offset = "0x4C12D0", VA = "0x1804C20D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x6000538")]
		protected abstract string GetShaderKeyword();

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		protected abstract MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		protected abstract bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x600053C")]
		protected abstract void OnEnablePostValidate();

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7A16E0", Offset = "0x7A08E0", VA = "0x1807A16E0", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7A1060", Offset = "0x7A0260", VA = "0x1807A1060", Slot = "10")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7A1190", Offset = "0x7A0390", VA = "0x1807A1190", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7A1340", Offset = "0x7A0540", VA = "0x1807A1340", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x7A11C0", Offset = "0x7A03C0", VA = "0x1807A11C0", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x7A1710", Offset = "0x7A0910", VA = "0x1807A1710")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7A10E0", Offset = "0x7A02E0", VA = "0x1807A10E0")]
		private void DisableOcclusion()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7A1AA0", Offset = "0x7A0CA0", VA = "0x1807A1AA0")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x20")]
		public DynamicOcclusionUpdateRate updateRate;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x30")]
		private TransformUtils.Packed m_TransformPacked;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x58")]
		private int m_LastFrameRendered;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x60")]
		protected VolumetricLightBeamSD m_Master;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x68")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		// Token: 0x0200013E RID: 318
		[Token(Token = "0x200013E")]
		protected enum ProcessOcclusionSource
		{
			// Token: 0x04000634 RID: 1588
			[Token(Token = "0x4000634")]
			RenderLoop,
			// Token: 0x04000635 RID: 1589
			[Token(Token = "0x4000635")]
			OnEnable,
			// Token: 0x04000636 RID: 1590
			[Token(Token = "0x4000636")]
			EditorUpdate,
			// Token: 0x04000637 RID: 1591
			[Token(Token = "0x4000637")]
			User
		}
	}
}
