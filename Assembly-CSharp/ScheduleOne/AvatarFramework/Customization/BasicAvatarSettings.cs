using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000819 RID: 2073
	[Token(Token = "0x2000819")]
	[CreateAssetMenu(fileName = "BasicAvatarSettings", menuName = "ScriptableObjects/BasicAvatarSettings", order = 1)]
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x060037B3 RID: 14259 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037B3")]
		public T SetValue<T>(string fieldName, T value)
		{
			return null;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037B4")]
		public T GetValue<T>(string fieldName)
		{
			return null;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x7ED200", Offset = "0x7EC400", VA = "0x1807ED200")]
		public AvatarSettings GetAvatarSettings()
		{
			return null;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x7EE060", Offset = "0x7ED260", VA = "0x1807EE060")]
		public static Color GetNippleColor(Color skinColor)
		{
			return default(Color);
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x7EB840", Offset = "0x7EAA40", VA = "0x1807EB840", Slot = "4")]
		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x7EE100", Offset = "0x7ED300", VA = "0x1807EE100")]
		public BasicAvatarSettings()
		{
		}

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		public const float GenderScaleMultiplier = 0.7f;

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x18")]
		public int Gender;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x1C")]
		public float Weight;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x20")]
		public Color SkinColor;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x30")]
		public string HairStyle;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x38")]
		public Color HairColor;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x48")]
		public string Mouth;

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x50")]
		public string FacialHair;

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x58")]
		public string FacialDetails;

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x60")]
		public float FacialDetailsIntensity;

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		[FieldOffset(Offset = "0x64")]
		public Color EyeballColor;

		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		[FieldOffset(Offset = "0x74")]
		public float UpperEyeLidRestingPosition;

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		[FieldOffset(Offset = "0x78")]
		public float LowerEyeLidRestingPosition;

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		[FieldOffset(Offset = "0x7C")]
		public float PupilDilation;

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		[FieldOffset(Offset = "0x80")]
		public float EyebrowScale;

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		[FieldOffset(Offset = "0x84")]
		public float EyebrowThickness;

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		[FieldOffset(Offset = "0x88")]
		public float EyebrowRestingHeight;

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x8C")]
		public float EyebrowRestingAngle;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x90")]
		public string Top;

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x98")]
		public Color TopColor;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0xA8")]
		public string Bottom;

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0xB0")]
		public Color BottomColor;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0xC0")]
		public string Shoes;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0xC8")]
		public Color ShoesColor;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0xD8")]
		public string Headwear;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0xE0")]
		public Color HeadwearColor;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0xF0")]
		public string Eyewear;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0xF8")]
		public Color EyewearColor;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x108")]
		public List<string> Tattoos;
	}
}
