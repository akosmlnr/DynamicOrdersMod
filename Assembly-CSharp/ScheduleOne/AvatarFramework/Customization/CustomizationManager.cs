using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x7F0820", Offset = "0x7EFA20", VA = "0x1807F0820", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void CreateSettings(string assetName, string assetPath)
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x7EFE00", Offset = "0x7EF000", VA = "0x1807EFE00")]
		public void CreateSettings()
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x7F05B0", Offset = "0x7EF7B0", VA = "0x1807F05B0")]
		public void LoadSettings(AvatarSettings loadedSettings)
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x7F0490", Offset = "0x7EF690", VA = "0x1807F0490")]
		public void LoadSettings(string path, bool editOriginal = false)
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x7EF8E0", Offset = "0x7EEAE0", VA = "0x1807EF8E0")]
		private void ApplyDefaultSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x7F04C0", Offset = "0x7EF6C0", VA = "0x1807F04C0")]
		public void LoadSettings()
		{
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x7F0310", Offset = "0x7EF510", VA = "0x1807F0310")]
		public void GenderChanged(float genderScale)
		{
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x7F08F0", Offset = "0x7EFAF0", VA = "0x1807F08F0")]
		public void WeightChanged(float weightScale)
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x7F0450", Offset = "0x7EF650", VA = "0x1807F0450")]
		public void HeightChanged(float height)
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x7F0790", Offset = "0x7EF990", VA = "0x1807F0790")]
		public void SkinColorChanged(Color col)
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x7F0350", Offset = "0x7EF550", VA = "0x1807F0350")]
		public void HairChanged(Accessory newHair)
		{
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003792")]
		[Address(RVA = "0x7F0410", Offset = "0x7EF610", VA = "0x1807F0410")]
		public void HairColorChanged(Color newCol)
		{
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003793")]
		[Address(RVA = "0x7EFF00", Offset = "0x7EF100", VA = "0x1807EFF00")]
		public void EyeBallTintChanged(Color col)
		{
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003794")]
		[Address(RVA = "0x7F08B0", Offset = "0x7EFAB0", VA = "0x1807F08B0")]
		public void UpperEyeLidRestingPositionChanged(float newVal)
		{
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x7F0710", Offset = "0x7EF910", VA = "0x1807F0710")]
		public void LowerEyeLidRestingPositionChanged(float newVal)
		{
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x7EFFC0", Offset = "0x7EF1C0", VA = "0x1807EFFC0")]
		public void EyebrowScaleChanged(float newVal)
		{
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x7F0000", Offset = "0x7EF200", VA = "0x1807F0000")]
		public void EyebrowThicknessChanged(float newVal)
		{
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003798")]
		[Address(RVA = "0x7EFF80", Offset = "0x7EF180", VA = "0x1807EFF80")]
		public void EyebrowRestingHeightChanged(float newVal)
		{
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x7EFF40", Offset = "0x7EF140", VA = "0x1807EFF40")]
		public void EyebrowRestingAngleChanged(float newVal)
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x7F0750", Offset = "0x7EF950", VA = "0x1807F0750")]
		public void PupilDilationChanged(float dilation)
		{
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x7F0040", Offset = "0x7EF240", VA = "0x1807F0040")]
		public void FaceLayerChanged(FaceLayer layer, int index)
		{
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x7F01D0", Offset = "0x7EF3D0", VA = "0x1807F01D0")]
		public void FaceLayerColorChanged(Color col, int index)
		{
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x7EFB20", Offset = "0x7EED20", VA = "0x1807EFB20")]
		public void BodyLayerChanged(AvatarLayer layer, int index)
		{
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x7EFCC0", Offset = "0x7EEEC0", VA = "0x1807EFCC0")]
		public void BodyLayerColorChanged(Color col, int index)
		{
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x7EF4F0", Offset = "0x7EE6F0", VA = "0x1807EF4F0")]
		public void AccessoryChanged(Accessory acc, int index)
		{
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x7EF7B0", Offset = "0x7EE9B0", VA = "0x1807EF7B0")]
		public void AccessoryColorChanged(Color col, int index)
		{
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x7F0930", Offset = "0x7EFB30", VA = "0x1807F0930")]
		public CustomizationManager()
		{
		}

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		public const string AppearancesFolderPath = "Assets/Data/Appearances";

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x28")]
		public Avatar TemplateAvatar;

		// Token: 0x04002869 RID: 10345
		[Token(Token = "0x4002869")]
		[FieldOffset(Offset = "0x30")]
		public TMP_InputField SaveInputField;

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x38")]
		public TMP_InputField LoadInputField;

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x40")]
		public Toggle GenerateCombinedLayerToggle;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x48")]
		public CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged;

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x50")]
		public AvatarSettings DefaultSettings;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x58")]
		private bool isEditingOriginal;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x60")]
		private string loadedSettingsAssetPath;

		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		[FieldOffset(Offset = "0x68")]
		private AvatarSettings ActiveSettings;

		// Token: 0x02000811 RID: 2065
		// (Invoke) Token: 0x060037A3 RID: 14243
		[Token(Token = "0x2000811")]
		public delegate void AvatarSettingsChanged(AvatarSettings settings);
	}
}
