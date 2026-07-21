using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	[ImageEffectAllowedInSceneView]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x6995E0", Offset = "0x6987E0", VA = "0x1806995E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x69A1D0", Offset = "0x6993D0", VA = "0x18069A1D0")]
		private void OnPreCull()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x69A8F0", Offset = "0x699AF0", VA = "0x18069A8F0")]
		private void OnPreRender()
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x69A0C0", Offset = "0x6992C0", VA = "0x18069A0C0")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x69AA00", Offset = "0x699C00", VA = "0x18069AA00")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x699EE0", Offset = "0x6990E0", VA = "0x180699EE0")]
		private void OnGUI()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x6991E0", Offset = "0x6983E0", VA = "0x1806991E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x69B130", Offset = "0x69A330", VA = "0x18069B130")]
		public void ResetTemporalEffects()
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x698CD0", Offset = "0x697ED0", VA = "0x180698CD0")]
		private void CheckObservers()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x699090", Offset = "0x698290", VA = "0x180699090")]
		private void DisableComponents()
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000313")]
		private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		private void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000315")]
		private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000317")]
		private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000318")]
		private T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			return null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x69B180", Offset = "0x69A380", VA = "0x18069B180")]
		public PostProcessingBehaviour()
		{
		}

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x20")]
		public PostProcessingProfile profile;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x38")]
		private List<PostProcessingComponentBase> m_Components;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x48")]
		private MaterialFactory m_MaterialFactory;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x50")]
		private RenderTextureFactory m_RenderTextureFactory;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x58")]
		private PostProcessingContext m_Context;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_Camera;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x68")]
		private PostProcessingProfile m_PreviousProfile;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x70")]
		private bool m_RenderingInSceneView;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x78")]
		private BuiltinDebugViewsComponent m_DebugViews;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x80")]
		private AmbientOcclusionComponent m_AmbientOcclusion;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x88")]
		private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x90")]
		private FogComponent m_FogComponent;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x98")]
		private MotionBlurComponent m_MotionBlur;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0xA0")]
		private TaaComponent m_Taa;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0xA8")]
		private EyeAdaptationComponent m_EyeAdaptation;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0xB0")]
		private DepthOfFieldComponent m_DepthOfField;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0xB8")]
		private BloomComponent m_Bloom;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0xC0")]
		private ChromaticAberrationComponent m_ChromaticAberration;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0xC8")]
		private ColorGradingComponent m_ColorGrading;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0xD0")]
		private UserLutComponent m_UserLut;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0xD8")]
		private GrainComponent m_Grain;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0xE0")]
		private VignetteComponent m_Vignette;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0xE8")]
		private DitheringComponent m_Dithering;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0xF0")]
		private FxaaComponent m_Fxaa;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0xF8")]
		private List<PostProcessingComponentBase> m_ComponentsToEnable;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x100")]
		private List<PostProcessingComponentBase> m_ComponentsToDisable;
	}
}
