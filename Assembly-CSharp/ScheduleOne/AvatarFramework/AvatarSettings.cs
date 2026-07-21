using System;
using System.Collections.Generic;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007E4 RID: 2020
	[Token(Token = "0x20007E4")]
	[CreateAssetMenu(fileName = "Avatar Settings", menuName = "ScriptableObjects/Avatar Settings", order = 1)]
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x17000892")]
		public float UpperEyelidRestingPosition
		{
			[Token(Token = "0x6003692")]
			[Address(RVA = "0x64ACF0", Offset = "0x649EF0", VA = "0x18064ACF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x17000893")]
		public float LowerEyelidRestingPosition
		{
			[Token(Token = "0x6003693")]
			[Address(RVA = "0x7ED1F0", Offset = "0x7EC3F0", VA = "0x1807ED1F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000894")]
		public string FaceLayer1Path
		{
			[Token(Token = "0x6003694")]
			[Address(RVA = "0x7ECAD0", Offset = "0x7EBCD0", VA = "0x1807ECAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x17000895")]
		public Color FaceLayer1Color
		{
			[Token(Token = "0x6003695")]
			[Address(RVA = "0x7ECA30", Offset = "0x7EBC30", VA = "0x1807ECA30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000896")]
		public string FaceLayer2Path
		{
			[Token(Token = "0x6003696")]
			[Address(RVA = "0x7ECBF0", Offset = "0x7EBDF0", VA = "0x1807ECBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x17000897")]
		public Color FaceLayer2Color
		{
			[Token(Token = "0x6003697")]
			[Address(RVA = "0x7ECB50", Offset = "0x7EBD50", VA = "0x1807ECB50")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000898")]
		public string FaceLayer3Path
		{
			[Token(Token = "0x6003698")]
			[Address(RVA = "0x7ECD10", Offset = "0x7EBF10", VA = "0x1807ECD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x17000899")]
		public Color FaceLayer3Color
		{
			[Token(Token = "0x6003699")]
			[Address(RVA = "0x7ECC70", Offset = "0x7EBE70", VA = "0x1807ECC70")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700089A")]
		public string FaceLayer4Path
		{
			[Token(Token = "0x600369A")]
			[Address(RVA = "0x7ECE30", Offset = "0x7EC030", VA = "0x1807ECE30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x1700089B")]
		public Color FaceLayer4Color
		{
			[Token(Token = "0x600369B")]
			[Address(RVA = "0x7ECD90", Offset = "0x7EBF90", VA = "0x1807ECD90")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700089C")]
		public string FaceLayer5Path
		{
			[Token(Token = "0x600369C")]
			[Address(RVA = "0x7ECF50", Offset = "0x7EC150", VA = "0x1807ECF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x1700089D")]
		public Color FaceLayer5Color
		{
			[Token(Token = "0x600369D")]
			[Address(RVA = "0x7ECEB0", Offset = "0x7EC0B0", VA = "0x1807ECEB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700089E")]
		public string FaceLayer6Path
		{
			[Token(Token = "0x600369E")]
			[Address(RVA = "0x7ED070", Offset = "0x7EC270", VA = "0x1807ED070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x1700089F")]
		public Color FaceLayer6Color
		{
			[Token(Token = "0x600369F")]
			[Address(RVA = "0x7ECFD0", Offset = "0x7EC1D0", VA = "0x1807ECFD0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008A0")]
		public string BodyLayer1Path
		{
			[Token(Token = "0x60036A0")]
			[Address(RVA = "0x7EC410", Offset = "0x7EB610", VA = "0x1807EC410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x170008A1")]
		public Color BodyLayer1Color
		{
			[Token(Token = "0x60036A1")]
			[Address(RVA = "0x7EC370", Offset = "0x7EB570", VA = "0x1807EC370")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008A2")]
		public string BodyLayer2Path
		{
			[Token(Token = "0x60036A2")]
			[Address(RVA = "0x7EC530", Offset = "0x7EB730", VA = "0x1807EC530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x170008A3")]
		public Color BodyLayer2Color
		{
			[Token(Token = "0x60036A3")]
			[Address(RVA = "0x7EC490", Offset = "0x7EB690", VA = "0x1807EC490")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008A4")]
		public string BodyLayer3Path
		{
			[Token(Token = "0x60036A4")]
			[Address(RVA = "0x7EC650", Offset = "0x7EB850", VA = "0x1807EC650")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x170008A5")]
		public Color BodyLayer3Color
		{
			[Token(Token = "0x60036A5")]
			[Address(RVA = "0x7EC5B0", Offset = "0x7EB7B0", VA = "0x1807EC5B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008A6")]
		public string BodyLayer4Path
		{
			[Token(Token = "0x60036A6")]
			[Address(RVA = "0x7EC770", Offset = "0x7EB970", VA = "0x1807EC770")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x170008A7")]
		public Color BodyLayer4Color
		{
			[Token(Token = "0x60036A7")]
			[Address(RVA = "0x7EC6D0", Offset = "0x7EB8D0", VA = "0x1807EC6D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008A8")]
		public string BodyLayer5Path
		{
			[Token(Token = "0x60036A8")]
			[Address(RVA = "0x7EC890", Offset = "0x7EBA90", VA = "0x1807EC890")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x170008A9")]
		public Color BodyLayer5Color
		{
			[Token(Token = "0x60036A9")]
			[Address(RVA = "0x7EC7F0", Offset = "0x7EB9F0", VA = "0x1807EC7F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008AA")]
		public string BodyLayer6Path
		{
			[Token(Token = "0x60036AA")]
			[Address(RVA = "0x7EC9B0", Offset = "0x7EBBB0", VA = "0x1807EC9B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x170008AB")]
		public Color BodyLayer6Color
		{
			[Token(Token = "0x60036AB")]
			[Address(RVA = "0x7EC910", Offset = "0x7EBB10", VA = "0x1807EC910")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008AC")]
		public string Accessory1Path
		{
			[Token(Token = "0x60036AC")]
			[Address(RVA = "0x7EB9F0", Offset = "0x7EABF0", VA = "0x1807EB9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x170008AD")]
		public Color Accessory1Color
		{
			[Token(Token = "0x60036AD")]
			[Address(RVA = "0x7EB950", Offset = "0x7EAB50", VA = "0x1807EB950")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008AE")]
		public string Accessory2Path
		{
			[Token(Token = "0x60036AE")]
			[Address(RVA = "0x7EBB10", Offset = "0x7EAD10", VA = "0x1807EBB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x170008AF")]
		public Color Accessory2Color
		{
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x7EBA70", Offset = "0x7EAC70", VA = "0x1807EBA70")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008B0")]
		public string Accessory3Path
		{
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x7EBC30", Offset = "0x7EAE30", VA = "0x1807EBC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x170008B1")]
		public Color Accessory3Color
		{
			[Token(Token = "0x60036B1")]
			[Address(RVA = "0x7EBB90", Offset = "0x7EAD90", VA = "0x1807EBB90")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008B2")]
		public string Accessory4Path
		{
			[Token(Token = "0x60036B2")]
			[Address(RVA = "0x7EBD50", Offset = "0x7EAF50", VA = "0x1807EBD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x170008B3")]
		public Color Accessory4Color
		{
			[Token(Token = "0x60036B3")]
			[Address(RVA = "0x7EBCB0", Offset = "0x7EAEB0", VA = "0x1807EBCB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008B4")]
		public string Accessory5Path
		{
			[Token(Token = "0x60036B4")]
			[Address(RVA = "0x7EBE70", Offset = "0x7EB070", VA = "0x1807EBE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x170008B5")]
		public Color Accessory5Color
		{
			[Token(Token = "0x60036B5")]
			[Address(RVA = "0x7EBDD0", Offset = "0x7EAFD0", VA = "0x1807EBDD0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008B6")]
		public string Accessory6Path
		{
			[Token(Token = "0x60036B6")]
			[Address(RVA = "0x7EBF90", Offset = "0x7EB190", VA = "0x1807EBF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x170008B7")]
		public Color Accessory6Color
		{
			[Token(Token = "0x60036B7")]
			[Address(RVA = "0x7EBEF0", Offset = "0x7EB0F0", VA = "0x1807EBEF0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008B8")]
		public string Accessory7Path
		{
			[Token(Token = "0x60036B8")]
			[Address(RVA = "0x7EC0B0", Offset = "0x7EB2B0", VA = "0x1807EC0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x170008B9")]
		public Color Accessory7Color
		{
			[Token(Token = "0x60036B9")]
			[Address(RVA = "0x7EC010", Offset = "0x7EB210", VA = "0x1807EC010")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008BA")]
		public string Accessory8Path
		{
			[Token(Token = "0x60036BA")]
			[Address(RVA = "0x7EC1D0", Offset = "0x7EB3D0", VA = "0x1807EC1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x170008BB")]
		public Color Accessory8Color
		{
			[Token(Token = "0x60036BB")]
			[Address(RVA = "0x7EC130", Offset = "0x7EB330", VA = "0x1807EC130")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008BC")]
		public string Accessory9Path
		{
			[Token(Token = "0x60036BC")]
			[Address(RVA = "0x7EC2F0", Offset = "0x7EB4F0", VA = "0x1807EC2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x170008BD")]
		public Color Accessory9Color
		{
			[Token(Token = "0x60036BD")]
			[Address(RVA = "0x7EC250", Offset = "0x7EB450", VA = "0x1807EC250")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170008BE RID: 2238
		[Token(Token = "0x170008BE")]
		public object this[string propertyName]
		{
			[Token(Token = "0x60036BE")]
			[Address(RVA = "0x7ED0F0", Offset = "0x7EC2F0", VA = "0x1807ED0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x7EB840", Offset = "0x7EAA40", VA = "0x1807EB840", Slot = "4")]
		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x7EB850", Offset = "0x7EAA50", VA = "0x1807EB850")]
		public AvatarSettings()
		{
		}

		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x18")]
		public Color SkinColor;

		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x28")]
		public float Height;

		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x2C")]
		public float Gender;

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x30")]
		public float Weight;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x38")]
		public string HairPath;

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x40")]
		public Color HairColor;

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x50")]
		public float EyebrowScale;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x54")]
		public float EyebrowThickness;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x58")]
		public float EyebrowRestingHeight;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x5C")]
		public float EyebrowRestingAngle;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x60")]
		public Color LeftEyeLidColor;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x70")]
		public Color RightEyeLidColor;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x80")]
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0x88")]
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x90")]
		public string EyeballMaterialIdentifier;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x98")]
		public Color EyeBallTint;

		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0xA8")]
		public float PupilDilation;

		// Token: 0x0400279A RID: 10138
		[Token(Token = "0x400279A")]
		[FieldOffset(Offset = "0xB0")]
		public List<AvatarSettings.LayerSetting> FaceLayerSettings;

		// Token: 0x0400279B RID: 10139
		[Token(Token = "0x400279B")]
		[FieldOffset(Offset = "0xB8")]
		public List<AvatarSettings.LayerSetting> BodyLayerSettings;

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0xC0")]
		public List<AvatarSettings.AccessorySetting> AccessorySettings;

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0xC8")]
		[CodegenExclude]
		public bool UseCombinedLayer;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0xD0")]
		[CodegenExclude]
		public AvatarLayer CombinedLayer;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0xD8")]
		[CodegenExclude]
		public Texture2D ImpostorTexture;

		// Token: 0x020007E5 RID: 2021
		[Token(Token = "0x20007E5")]
		[Serializable]
		public struct LayerSetting
		{
			// Token: 0x040027A0 RID: 10144
			[Token(Token = "0x40027A0")]
			[FieldOffset(Offset = "0x0")]
			public string layerPath;

			// Token: 0x040027A1 RID: 10145
			[Token(Token = "0x40027A1")]
			[FieldOffset(Offset = "0x8")]
			public Color layerTint;
		}

		// Token: 0x020007E6 RID: 2022
		[Token(Token = "0x20007E6")]
		[Serializable]
		public class AccessorySetting
		{
			// Token: 0x060036C1 RID: 14017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036C1")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public AccessorySetting()
			{
			}

			// Token: 0x040027A2 RID: 10146
			[Token(Token = "0x40027A2")]
			[FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x040027A3 RID: 10147
			[Token(Token = "0x40027A3")]
			[FieldOffset(Offset = "0x18")]
			public Color color;
		}
	}
}
