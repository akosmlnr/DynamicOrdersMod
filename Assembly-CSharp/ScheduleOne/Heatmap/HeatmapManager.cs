using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.Temperature;
using UnityEngine;

namespace ScheduleOne.Heatmap
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	public class HeatmapManager : Singleton<HeatmapManager>
	{
		// Token: 0x06002666 RID: 9830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x6BD780", Offset = "0x6BC980", VA = "0x1806BD780", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x6BF0B0", Offset = "0x6BE2B0", VA = "0x1806BF0B0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x6BDEA0", Offset = "0x6BD0A0", VA = "0x1806BDEA0")]
		private void Initialise()
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x6BEDB0", Offset = "0x6BDFB0", VA = "0x1806BEDB0")]
		private void SetShader()
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x6BE670", Offset = "0x6BD870", VA = "0x1806BE670")]
		private void SetPropertyData()
		{
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x6BE0D0", Offset = "0x6BD2D0", VA = "0x1806BE0D0")]
		private void OnEmitterUpdate(string propertyCode, TemperatureEmitterInfo[] emitterInfos)
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x6BD860", Offset = "0x6BCA60", VA = "0x1806BD860")]
		private void DispatchHeatmap(string propertyCode, TemperatureEmitterInfo[] emitterInfos)
		{
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x6BDDA0", Offset = "0x6BCFA0", VA = "0x1806BDDA0")]
		private Vector2Int GetPropertyRegionStartAndEndIndex(string propertyCode)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x6BE390", Offset = "0x6BD590", VA = "0x1806BE390")]
		public void SetHeatmapActive(string propertyCode, bool isActive)
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x6BE440", Offset = "0x6BD640", VA = "0x1806BE440")]
		public void SetHeatmapActive(Property property, bool isActive)
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x6BF110", Offset = "0x6BE310", VA = "0x1806BF110")]
		public void ToggleHeatmapActive(Property property)
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x6BE230", Offset = "0x6BD430", VA = "0x1806BE230")]
		public void SetAllHeatmapsActive(bool isActive)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x6BDF60", Offset = "0x6BD160", VA = "0x1806BDF60")]
		public bool IsHeatmapActive(Property property)
		{
			return default(bool);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x6BE080", Offset = "0x6BD280", VA = "0x1806BE080", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x6BF320", Offset = "0x6BE520", VA = "0x1806BF320")]
		[Button]
		public void TurnOnAllHeatmaps()
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x6BF1D0", Offset = "0x6BE3D0", VA = "0x1806BF1D0")]
		[Button]
		public void TurnOffAllHeatmaps()
		{
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x6BE0E0", Offset = "0x6BD2E0", VA = "0x1806BE0E0")]
		[Button]
		public void RunDispatchHeatmap()
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x6BF4A0", Offset = "0x6BE6A0", VA = "0x1806BF4A0")]
		public HeatmapManager()
		{
		}

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x28")]
		public Action<Property, bool> onHeatmapVisibilityChanged;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Components")]
		private ComputeShader _shader;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RenderTexture _heatmaps;

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HeatmapRegion _heatmapRegionPrefab;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Material _heatmapMat;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		[SerializeField]
		private Texture2D _gradientTexture;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x58")]
		[Header("Debugging & Testing")]
		[SerializeField]
		private string _propertyCodeToTest;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, HeatmapManager.PropertyData> _propertyGridMasks;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x68")]
		private List<HeatmapManager.PropertyRegionReference> _propertyRegionReferences;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x70")]
		private int _kernal;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x74")]
		private int _textureDepth;

		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		public const int TEXTURE_SIZE = 128;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		public const int MAX_REGIONS = 16;

		// Token: 0x02000610 RID: 1552
		[Token(Token = "0x2000610")]
		[Serializable]
		public class PropertyData
		{
			// Token: 0x06002679 RID: 9849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002679")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public PropertyData()
			{
			}

			// Token: 0x04001E1D RID: 7709
			[Token(Token = "0x4001E1D")]
			[FieldOffset(Offset = "0x10")]
			public int[] MaskData;

			// Token: 0x04001E1E RID: 7710
			[Token(Token = "0x4001E1E")]
			[FieldOffset(Offset = "0x18")]
			public Matrix4x4[] Matrices;

			// Token: 0x04001E1F RID: 7711
			[Token(Token = "0x4001E1F")]
			[FieldOffset(Offset = "0x20")]
			public List<HeatmapRegion> Regions;

			// Token: 0x04001E20 RID: 7712
			[Token(Token = "0x4001E20")]
			[FieldOffset(Offset = "0x28")]
			public Property Property;

			// Token: 0x04001E21 RID: 7713
			[Token(Token = "0x4001E21")]
			[FieldOffset(Offset = "0x30")]
			public bool InitialDispatched;
		}

		// Token: 0x02000611 RID: 1553
		[Token(Token = "0x2000611")]
		private struct PropertyRegionReference
		{
			// Token: 0x04001E22 RID: 7714
			[Token(Token = "0x4001E22")]
			[FieldOffset(Offset = "0x0")]
			public string PropertyCode;

			// Token: 0x04001E23 RID: 7715
			[Token(Token = "0x4001E23")]
			[FieldOffset(Offset = "0x8")]
			public int RegionAmount;
		}
	}
}
