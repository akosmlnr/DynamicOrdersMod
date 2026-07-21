using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Funly.SkyStudio
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[ExecuteInEditMode]
	public class SkyStudioSetupURPPipeline : MonoBehaviour
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x9FFDC0", Offset = "0x9FEFC0", VA = "0x1809FFDC0")]
		private void Update()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SkyStudioSetupURPPipeline()
		{
		}

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The rendering pipeline that will be assigned into the graphics settings when this scene becomes active.")]
		[HelpBox("For URP projects, Sky Studio will assign this rendering pipeline into GraphicsSettings. We have to install this pipeline so that we can embed our own custom render features, which are required for certain Sky Studio features like rain splashes to work properly. If you need to add rendering features, or customize the rendering pipeline asset please update this reference, and ensure that the 'SkyStudio-WeatherDepthForwardRenderer' is assigned to render feature index 1. Feel free to add any custom render features after index 1.", HelpBoxMessageType.Info)]
		public RenderPipelineAsset pipelineAsset;
	}
}
