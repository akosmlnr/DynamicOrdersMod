using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	[ExecuteInEditMode]
	[AddComponentMenu("Effects/Liquid Volume")]
	[DisallowMultipleComponent]
	[HelpURL("https://kronnect.com/support")]
	public class LiquidVolume : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event PropertiesChangedEvent onPropertiesChanged
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x7B1060", Offset = "0x7B0260", VA = "0x1807B1060")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x7B13D0", Offset = "0x7B05D0", VA = "0x1807B13D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014D")]
		public TOPOLOGY topology
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			get
			{
				return TOPOLOGY.Sphere;
			}
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x7B3CC0", Offset = "0x7B2EC0", VA = "0x1807B3CC0")]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		public DETAIL detail
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x6A20F0", Offset = "0x6A12F0", VA = "0x1806A20F0")]
			get
			{
				return DETAIL.Simple;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x7B1B70", Offset = "0x7B0D70", VA = "0x1807B1B70")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public float level
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x7B2950", Offset = "0x7B1B50", VA = "0x1807B2950")]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00004FC8 File Offset: 0x000031C8
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		public float levelMultiplier
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x495780", Offset = "0x494980", VA = "0x180495780")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x7B28D0", Offset = "0x7B1AD0", VA = "0x1807B28D0")]
			set
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public bool useLightColor
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x7B13B0", Offset = "0x7B05B0", VA = "0x1807B13B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x7B3EB0", Offset = "0x7B30B0", VA = "0x1807B3EB0")]
			set
			{
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public bool useLightDirection
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x7B13C0", Offset = "0x7B05C0", VA = "0x1807B13C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x7B3F20", Offset = "0x7B3120", VA = "0x1807B3F20")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000153")]
		public Light directionalLight
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x7B1BE0", Offset = "0x7B0DE0", VA = "0x1807B1BE0")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000154")]
		public Color liquidColor1
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x4F8620", Offset = "0x4F7820", VA = "0x1804F8620")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x7B2A40", Offset = "0x7B1C40", VA = "0x1807B2A40")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00005028 File Offset: 0x00003228
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000155")]
		public float liquidScale1
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x4B4830", Offset = "0x4B3A30", VA = "0x1804B4830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x7B2C70", Offset = "0x7B1E70", VA = "0x1807B2C70")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00005040 File Offset: 0x00003240
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000156")]
		public Color liquidColor2
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x7B1250", Offset = "0x7B0450", VA = "0x1807B1250")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x7B2B20", Offset = "0x7B1D20", VA = "0x1807B2B20")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000157")]
		public float liquidScale2
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x4CB740", Offset = "0x4CA940", VA = "0x1804CB740")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x7B2CF0", Offset = "0x7B1EF0", VA = "0x1807B2CF0")]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public float alpha
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x4CBF80", Offset = "0x4CB180", VA = "0x1804CBF80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x7B1490", Offset = "0x7B0690", VA = "0x1807B1490")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00005088 File Offset: 0x00003288
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		public Color emissionColor
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x7B11D0", Offset = "0x7B03D0", VA = "0x1807B11D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x7B1F20", Offset = "0x7B1120", VA = "0x1807B1F20")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x000050A0 File Offset: 0x000032A0
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		public bool ditherShadows
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x4CB610", Offset = "0x4CA810", VA = "0x1804CB610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x7B1E30", Offset = "0x7B1030", VA = "0x1807B1E30")]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000050B8 File Offset: 0x000032B8
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		public float murkiness
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x6A03A0", Offset = "0x69F5A0", VA = "0x1806A03A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x7B2DF0", Offset = "0x7B1FF0", VA = "0x1807B2DF0")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015C")]
		public float turbulence1
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x7B13A0", Offset = "0x7B05A0", VA = "0x1807B13A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x7B3D30", Offset = "0x7B2F30", VA = "0x1807B3D30")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x000050E8 File Offset: 0x000032E8
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public float turbulence2
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x4B4750", Offset = "0x4B3950", VA = "0x1804B4750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x7B3DB0", Offset = "0x7B2FB0", VA = "0x1807B3DB0")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00005100 File Offset: 0x00003300
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		public float frecuency
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x7B1210", Offset = "0x7B0410", VA = "0x1807B1210")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x7B26F0", Offset = "0x7B18F0", VA = "0x1807B26F0")]
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00005118 File Offset: 0x00003318
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public float speed
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x7B1350", Offset = "0x7B0550", VA = "0x1807B1350")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x7B3980", Offset = "0x7B2B80", VA = "0x1807B3980")]
			set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00005130 File Offset: 0x00003330
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000160")]
		public float sparklingIntensity
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x6A03D0", Offset = "0x69F5D0", VA = "0x1806A03D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x7B3900", Offset = "0x7B2B00", VA = "0x1807B3900")]
			set
			{
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00005148 File Offset: 0x00003348
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public float sparklingAmount
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x7B1340", Offset = "0x7B0540", VA = "0x1807B1340")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x7B3880", Offset = "0x7B2A80", VA = "0x1807B3880")]
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00005160 File Offset: 0x00003360
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000162")]
		public float deepObscurance
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x6A03E0", Offset = "0x69F5E0", VA = "0x1806A03E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x7B1920", Offset = "0x7B0B20", VA = "0x1807B1920")]
			set
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00005178 File Offset: 0x00003378
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000163")]
		public Color foamColor
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x4FF9F0", Offset = "0x4FEBF0", VA = "0x1804FF9F0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x7B22B0", Offset = "0x7B14B0", VA = "0x1807B22B0")]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00005190 File Offset: 0x00003390
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public float foamScale
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x4F0950", Offset = "0x4EFB50", VA = "0x1804F0950")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x7B2480", Offset = "0x7B1680", VA = "0x1807B2480")]
			set
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000165")]
		public float foamThickness
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x4F0A20", Offset = "0x4EFC20", VA = "0x1804F0A20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x7B2500", Offset = "0x7B1700", VA = "0x1807B2500")]
			set
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x000051C0 File Offset: 0x000033C0
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		public float foamDensity
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x6B9990", Offset = "0x6B8B90", VA = "0x1806B9990")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x7B2390", Offset = "0x7B1590", VA = "0x1807B2390")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000051D8 File Offset: 0x000033D8
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		public float foamWeight
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x4E7240", Offset = "0x4E6440", VA = "0x1804E7240")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x7B2670", Offset = "0x7B1870", VA = "0x1807B2670")]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000051F0 File Offset: 0x000033F0
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public float foamTurbulence
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x5256E0", Offset = "0x5248E0", VA = "0x1805256E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x7B2580", Offset = "0x7B1780", VA = "0x1807B2580")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00005208 File Offset: 0x00003408
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public bool foamVisibleFromBottom
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x525700", Offset = "0x524900", VA = "0x180525700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x7B2600", Offset = "0x7B1800", VA = "0x1807B2600")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00005220 File Offset: 0x00003420
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		public bool smokeEnabled
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x683EE0", Offset = "0x6830E0", VA = "0x180683EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00005238 File Offset: 0x00003438
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public Color smokeColor
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x7B1320", Offset = "0x7B0520", VA = "0x1807B1320")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x7B3540", Offset = "0x7B2740", VA = "0x1807B3540")]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00005250 File Offset: 0x00003450
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		public float smokeScale
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x51CFD0", Offset = "0x51C1D0", VA = "0x18051CFD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x7B3780", Offset = "0x7B2980", VA = "0x1807B3780")]
			set
			{
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00005268 File Offset: 0x00003468
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public float smokeBaseObscurance
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x50EF00", Offset = "0x50E100", VA = "0x18050EF00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x7B34C0", Offset = "0x7B26C0", VA = "0x1807B34C0")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00005280 File Offset: 0x00003480
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		public float smokeHeightAtten
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x7B1330", Offset = "0x7B0530", VA = "0x1807B1330")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x7B3690", Offset = "0x7B2890", VA = "0x1807B3690")]
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00005298 File Offset: 0x00003498
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public float smokeSpeed
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x51C050", Offset = "0x51B250", VA = "0x18051C050")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x7B3800", Offset = "0x7B2A00", VA = "0x1807B3800")]
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x000052B0 File Offset: 0x000034B0
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public bool fixMesh
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x7B1200", Offset = "0x7B0400", VA = "0x1807B1200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x7B20D0", Offset = "0x7B12D0", VA = "0x1807B20D0")]
			set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000052C8 File Offset: 0x000034C8
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		public Vector3 pivotOffset
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x7B12A0", Offset = "0x7B04A0", VA = "0x1807B12A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x7B2FE0", Offset = "0x7B21E0", VA = "0x1807B2FE0")]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000052E0 File Offset: 0x000034E0
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		public bool limitVerticalRange
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x7B29D0", Offset = "0x7B1BD0", VA = "0x1807B29D0")]
			set
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000173")]
		public float upperLimit
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x7B3E30", Offset = "0x7B3030", VA = "0x1807B3E30")]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00005310 File Offset: 0x00003510
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000174")]
		public float lowerLimit
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x5D6EB0", Offset = "0x5D60B0", VA = "0x1805D6EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x7B2D70", Offset = "0x7B1F70", VA = "0x1807B2D70")]
			set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00005328 File Offset: 0x00003528
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public int subMeshIndex
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x5D6EC0", Offset = "0x5D60C0", VA = "0x1805D6EC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x7B3A00", Offset = "0x7B2C00", VA = "0x1807B3A00")]
			set
			{
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000176")]
		public Material flaskMaterial
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x7B2140", Offset = "0x7B1340", VA = "0x1807B2140")]
			set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00005340 File Offset: 0x00003540
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000177")]
		public float flaskThickness
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x6288E0", Offset = "0x627AE0", VA = "0x1806288E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x7B2230", Offset = "0x7B1430", VA = "0x1807B2230")]
			set
			{
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00005358 File Offset: 0x00003558
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		public float glossinessInternal
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x7B1220", Offset = "0x7B0420", VA = "0x1807B1220")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x7B2770", Offset = "0x7B1970", VA = "0x1807B2770")]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00005370 File Offset: 0x00003570
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public bool scatteringEnabled
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x7B33E0", Offset = "0x7B25E0", VA = "0x1807B33E0")]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00005388 File Offset: 0x00003588
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public int scatteringPower
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x71D590", Offset = "0x71C790", VA = "0x18071D590")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x7B3450", Offset = "0x7B2650", VA = "0x1807B3450")]
			set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000053A0 File Offset: 0x000035A0
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public float scatteringAmount
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x7B1310", Offset = "0x7B0510", VA = "0x1807B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x7B3360", Offset = "0x7B2560", VA = "0x1807B3360")]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x000053B8 File Offset: 0x000035B8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public bool refractionBlur
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x7B12E0", Offset = "0x7B04E0", VA = "0x1807B12E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x7B3210", Offset = "0x7B2410", VA = "0x1807B3210")]
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x000053D0 File Offset: 0x000035D0
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		public float blurIntensity
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x511750", Offset = "0x510950", VA = "0x180511750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x7B15C0", Offset = "0x7B07C0", VA = "0x1807B15C0")]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000053E8 File Offset: 0x000035E8
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public int liquidRaySteps
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x71D510", Offset = "0x71C710", VA = "0x18071D510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x7B2C00", Offset = "0x7B1E00", VA = "0x1807B2C00")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00005400 File Offset: 0x00003600
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public int foamRaySteps
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x6AAEE0", Offset = "0x6AA0E0", VA = "0x1806AAEE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x7B2410", Offset = "0x7B1610", VA = "0x1807B2410")]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00005418 File Offset: 0x00003618
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		public int smokeRaySteps
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x6BCC90", Offset = "0x6BBE90", VA = "0x1806BCC90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x7B3710", Offset = "0x7B2910", VA = "0x1807B3710")]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000181")]
		public Texture2D bumpMap
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x7B17A0", Offset = "0x7B09A0", VA = "0x1807B17A0")]
			set
			{
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00005430 File Offset: 0x00003630
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public float bumpStrength
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x7B1150", Offset = "0x7B0350", VA = "0x1807B1150")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x7B1890", Offset = "0x7B0A90", VA = "0x1807B1890")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00005448 File Offset: 0x00003648
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public float bumpDistortionScale
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x7B1140", Offset = "0x7B0340", VA = "0x1807B1140")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x7B1720", Offset = "0x7B0920", VA = "0x1807B1720")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00005460 File Offset: 0x00003660
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public Vector2 bumpDistortionOffset
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x7B1120", Offset = "0x7B0320", VA = "0x1807B1120")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x7B1670", Offset = "0x7B0870", VA = "0x1807B1670")]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public Texture2D distortionMap
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x7B1D40", Offset = "0x7B0F40", VA = "0x1807B1D40")]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		public Texture2D texture
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x630310", Offset = "0x62F510", VA = "0x180630310")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x7B3BD0", Offset = "0x7B2DD0", VA = "0x1807B3BD0")]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00005478 File Offset: 0x00003678
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		public Vector2 textureScale
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x7B1380", Offset = "0x7B0580", VA = "0x1807B1380")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x7B3B20", Offset = "0x7B2D20", VA = "0x1807B3B20")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00005490 File Offset: 0x00003690
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public Vector2 textureOffset
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x7B1360", Offset = "0x7B0560", VA = "0x1807B1360")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x7B3A70", Offset = "0x7B2C70", VA = "0x1807B3A70")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public float distortionAmount
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x7B11B0", Offset = "0x7B03B0", VA = "0x1807B11B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x7B1CC0", Offset = "0x7B0EC0", VA = "0x1807B1CC0")]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x000054C0 File Offset: 0x000036C0
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public bool depthAware
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x7B11A0", Offset = "0x7B03A0", VA = "0x1807B11A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x7B1B00", Offset = "0x7B0D00", VA = "0x1807B1B00")]
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000054D8 File Offset: 0x000036D8
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018B")]
		public float depthAwareOffset
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x7B1190", Offset = "0x7B0390", VA = "0x1807B1190")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x7B1A80", Offset = "0x7B0C80", VA = "0x1807B1A80")]
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x000054F0 File Offset: 0x000036F0
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018C")]
		public bool irregularDepthDebug
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x7B1240", Offset = "0x7B0440", VA = "0x1807B1240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x7B2860", Offset = "0x7B1A60", VA = "0x1807B2860")]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00005508 File Offset: 0x00003708
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public bool depthAwareCustomPass
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x7B1180", Offset = "0x7B0380", VA = "0x1807B1180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x7B1A10", Offset = "0x7B0C10", VA = "0x1807B1A10")]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00005520 File Offset: 0x00003720
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018E")]
		public bool depthAwareCustomPassDebug
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x7B1170", Offset = "0x7B0370", VA = "0x1807B1170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x7B19A0", Offset = "0x7B0BA0", VA = "0x1807B19A0")]
			set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00005538 File Offset: 0x00003738
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018F")]
		public float doubleSidedBias
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x7B11C0", Offset = "0x7B03C0", VA = "0x1807B11C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x7B1EA0", Offset = "0x7B10A0", VA = "0x1807B1EA0")]
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000190")]
		public float backDepthBias
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x7B1110", Offset = "0x7B0310", VA = "0x1807B1110")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x7B1540", Offset = "0x7B0740", VA = "0x1807B1540")]
			set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000191")]
		public LEVEL_COMPENSATION rotationLevelCompensation
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x7B1300", Offset = "0x7B0500", VA = "0x1807B1300")]
			get
			{
				return LEVEL_COMPENSATION.None;
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x7B32F0", Offset = "0x7B24F0", VA = "0x1807B32F0")]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public bool ignoreGravity
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x7B1230", Offset = "0x7B0430", VA = "0x1807B1230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x7B27F0", Offset = "0x7B19F0", VA = "0x1807B27F0")]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00005598 File Offset: 0x00003798
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public bool reactToForces
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x7B12C0", Offset = "0x7B04C0", VA = "0x1807B12C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x7B30B0", Offset = "0x7B22B0", VA = "0x1807B30B0")]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000055B0 File Offset: 0x000037B0
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public Vector3 extentsScale
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x7B11E0", Offset = "0x7B03E0", VA = "0x1807B11E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x7B2000", Offset = "0x7B1200", VA = "0x1807B2000")]
			set
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000055C8 File Offset: 0x000037C8
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		public int noiseVariation
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x7B1270", Offset = "0x7B0470", VA = "0x1807B1270")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x7B2E70", Offset = "0x7B2070", VA = "0x1807B2E70")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000196")]
		public bool allowViewFromInside
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x7B1100", Offset = "0x7B0300", VA = "0x1807B1100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x7B1470", Offset = "0x7B0670", VA = "0x1807B1470")]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000055F8 File Offset: 0x000037F8
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000197")]
		public bool debugSpillPoint
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x7B1160", Offset = "0x7B0360", VA = "0x1807B1160")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x7B1910", Offset = "0x7B0B10", VA = "0x1807B1910")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		public int renderQueue
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x7B12F0", Offset = "0x7B04F0", VA = "0x1807B12F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x7B3280", Offset = "0x7B2480", VA = "0x1807B3280")]
			set
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000199")]
		public Cubemap reflectionTexture
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x7B12D0", Offset = "0x7B04D0", VA = "0x1807B12D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x7B3120", Offset = "0x7B2320", VA = "0x1807B3120")]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00005628 File Offset: 0x00003828
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019A")]
		public float physicsMass
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x7B1290", Offset = "0x7B0490", VA = "0x1807B1290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x7B2F60", Offset = "0x7B2160", VA = "0x1807B2F60")]
			set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00005640 File Offset: 0x00003840
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019B")]
		public float physicsAngularDamp
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x7B1280", Offset = "0x7B0480", VA = "0x1807B1280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x7B2EE0", Offset = "0x7B20E0", VA = "0x1807B2EE0")]
			set
			{
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x1700019C")]
		public static bool useFPRenderTextures
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x7AB570", Offset = "0x7AA770", VA = "0x1807AB570")]
		private void OnEnable()
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x7AC1F0", Offset = "0x7AB3F0", VA = "0x1807AC1F0")]
		private void Reset()
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x7AB2D0", Offset = "0x7AA4D0", VA = "0x1807AB2D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x7ABFE0", Offset = "0x7AB1E0", VA = "0x1807ABFE0")]
		private void RenderObject()
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x7AB780", Offset = "0x7AA980", VA = "0x1807AB780")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x7A8EF0", Offset = "0x7A80F0", VA = "0x1807A8EF0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x7AB560", Offset = "0x7AA760", VA = "0x1807AB560")]
		private void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x7A8A30", Offset = "0x7A7C30", VA = "0x1807A8A30")]
		public void ClearMeshCache()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x7ABAA0", Offset = "0x7AACA0", VA = "0x1807ABAA0")]
		private void ReadVertices()
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x7B3F90", Offset = "0x7B3190", VA = "0x1807B3F90")]
		private int vertexComparer(Vector3 v0, Vector3 v1)
		{
			return 0;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x7ACA80", Offset = "0x7ABC80", VA = "0x1807ACA80")]
		private void UpdateAnimations()
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x7ABEB0", Offset = "0x7AB0B0", VA = "0x1807ABEB0")]
		public void UpdateMaterialProperties()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x7AED30", Offset = "0x7ADF30", VA = "0x1807AED30")]
		private void UpdateMaterialPropertiesNow()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x7A7810", Offset = "0x7A6A10", VA = "0x1807A7810")]
		private Color ApplyGlobalAlpha(Color originalColor)
		{
			return default(Color);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x7AAD60", Offset = "0x7A9F60", VA = "0x1807AAD60")]
		private void GetRenderer()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x7AD8A0", Offset = "0x7ACAA0", VA = "0x1807AD8A0")]
		private void UpdateLevels(bool updateShaderKeywords = true)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x7AC770", Offset = "0x7AB970", VA = "0x1807AC770")]
		private void RotateVertices()
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x7AC960", Offset = "0x7ABB60", VA = "0x1807AC960")]
		private float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 zeroPoint)
		{
			return 0f;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x7A9020", Offset = "0x7A8220", VA = "0x1807A9020")]
		public float GetMeshVolumeUnderLevelFast(float level01, float yExtent)
		{
			return 0f;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x7AAD40", Offset = "0x7A9F40", VA = "0x1807AAD40")]
		public float GetMeshVolumeWSFast()
		{
			return 0f;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x7A9090", Offset = "0x7A8290", VA = "0x1807A9090")]
		public float GetMeshVolumeUnderLevelWSFast(float level)
		{
			return 0f;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x7A8940", Offset = "0x7A7B40", VA = "0x1807A8940")]
		private Vector3 ClampVertexToSlicePlane(Vector3 p, Vector3 q, float level)
		{
			return default(Vector3);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x7AACD0", Offset = "0x7A9ED0", VA = "0x1807AACD0")]
		public float GetMeshVolumeUnderLevel(float level01, float yExtent)
		{
			return 0f;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x7AAD50", Offset = "0x7A9F50", VA = "0x1807AAD50")]
		public float GetMeshVolumeWS()
		{
			return 0f;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x7A9430", Offset = "0x7A8630", VA = "0x1807A9430")]
		public float GetMeshVolumeUnderLevelWS(float level)
		{
			return 0f;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x7ABA10", Offset = "0x7AAC10", VA = "0x1807ABA10")]
		private int PolygonSortOnPlane(Vector3 p1, Vector3 p2)
		{
			return 0;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x7B0950", Offset = "0x7AFB50", VA = "0x1807B0950")]
		private void UpdateTurbulence()
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x7A80F0", Offset = "0x7A72F0", VA = "0x1807A80F0")]
		private void CheckInsideOut()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x7AB790", Offset = "0x7AA990", VA = "0x1807AB790")]
		private bool PointInAABB(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x7AB880", Offset = "0x7AAA80", VA = "0x1807AB880")]
		private bool PointInCylinder(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x7AD5C0", Offset = "0x7AC7C0", VA = "0x1807AD5C0")]
		private void UpdateInsideOut()
		{
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x1700019D")]
		public float liquidSurfaceYPosition
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x7B1260", Offset = "0x7B0460", VA = "0x1807B1260")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x7AAED0", Offset = "0x7AA0D0", VA = "0x1807AAED0")]
		public bool GetSpillPoint(out Vector3 spillPosition, float apertureStart = 1f)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x7AAF00", Offset = "0x7AA100", VA = "0x1807AAF00")]
		public bool GetSpillPoint(out Vector3 spillPosition, out float spillAmount, float apertureStart = 1f, LEVEL_COMPENSATION rotationCompensation = LEVEL_COMPENSATION.None)
		{
			return default(bool);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x7B0410", Offset = "0x7AF610", VA = "0x1807B0410")]
		private void UpdateSpillPointGizmo()
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x7A7840", Offset = "0x7A6A40", VA = "0x1807A7840")]
		public void BakeRotation()
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x7A7CF0", Offset = "0x7A6EF0", VA = "0x1807A7CF0")]
		public void CenterPivot()
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x7A7D50", Offset = "0x7A6F50", VA = "0x1807A7D50")]
		public void CenterPivot(Vector3 offset)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x7ABF20", Offset = "0x7AB120", VA = "0x1807ABF20")]
		public void RefreshMeshAndCollider()
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x7ABEB0", Offset = "0x7AB0B0", VA = "0x1807ABEB0")]
		public void Redraw()
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x7A85F0", Offset = "0x7A77F0", VA = "0x1807A85F0")]
		private void CheckMeshDisplacement()
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x7AC610", Offset = "0x7AB810", VA = "0x1807AC610")]
		private void RestoreOriginalMesh()
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x7A8AB0", Offset = "0x7A7CB0", VA = "0x1807A8AB0")]
		public void CopyFrom(LiquidVolume lv)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x7B0D50", Offset = "0x7AFF50", VA = "0x1807B0D50")]
		public LiquidVolume()
		{
		}

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x0")]
		public static bool FORCE_GLES_COMPATIBILITY;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TOPOLOGY _topology;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DETAIL _detail;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _level;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _levelMultiplier;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Uses directional light color")]
		private bool _useLightColor;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		[Tooltip("Uses directional light direction for day/night cycle")]
		private bool _useLightDirection;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Light _directionalLight;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[ColorUsage(true)]
		private Color _liquidColor1;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0.1f, 4.85f)]
		private float _liquidScale1;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x5C")]
		[ColorUsage(true)]
		[SerializeField]
		private Color _liquidColor2;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x6C")]
		[Range(2f, 4.85f)]
		[SerializeField]
		private float _liquidScale2;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _alpha;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[ColorUsage(true)]
		private Color _emissionColor;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _ditherShadows;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _murkiness;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _turbulence1;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _turbulence2;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _frecuency;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _speed;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Range(0f, 5f)]
		private float _sparklingIntensity;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _sparklingAmount;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _deepObscurance;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0xA8")]
		[ColorUsage(true)]
		[SerializeField]
		private Color _foamColor;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Range(0.01f, 1f)]
		private float _foamScale;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0xBC")]
		[Range(0f, 0.1f)]
		[SerializeField]
		private float _foamThickness;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _foamDensity;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0xC4")]
		[Range(4f, 100f)]
		[SerializeField]
		private float _foamWeight;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _foamTurbulence;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool _foamVisibleFromBottom;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0xCD")]
		[SerializeField]
		private bool _smokeEnabled;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0xD0")]
		[ColorUsage(true)]
		[SerializeField]
		private Color _smokeColor;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0xE0")]
		[Range(0.01f, 1f)]
		[SerializeField]
		private float _smokeScale;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _smokeBaseObscurance;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _smokeHeightAtten;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[Range(0f, 20f)]
		private float _smokeSpeed;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _fixMesh;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0xF8")]
		public Mesh originalMesh;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x100")]
		public Vector3 originalPivotOffset;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private Vector3 _pivotOffset;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _limitVerticalRange;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x11C")]
		[Range(0f, 1.5f)]
		[SerializeField]
		private float _upperLimit;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Range(-1.5f, 1.5f)]
		private float _lowerLimit;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int _subMeshIndex;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Material _flaskMaterial;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _flaskThickness;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _glossinessInternal;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _scatteringEnabled;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Range(1f, 16f)]
		private int _scatteringPower;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _scatteringAmount;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private bool _refractionBlur;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _blurIntensity;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private int _liquidRaySteps;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private int _foamRaySteps;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private int _smokeRaySteps;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Texture2D _bumpMap;

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x160")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _bumpStrength;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _bumpDistortionScale;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Vector2 _bumpDistortionOffset;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Texture2D _distortionMap;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Vector2 _textureScale;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Vector2 _textureOffset;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x190")]
		[Range(0f, 10f)]
		[SerializeField]
		private float _distortionAmount;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		private bool _depthAware;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private float _depthAwareOffset;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		private bool _irregularDepthDebug;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x19D")]
		[SerializeField]
		private bool _depthAwareCustomPass;

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x19E")]
		[SerializeField]
		private bool _depthAwareCustomPassDebug;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Range(0f, 5f)]
		private float _doubleSidedBias;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private float _backDepthBias;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private LEVEL_COMPENSATION _rotationLevelCompensation;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private bool _ignoreGravity;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x1AD")]
		[SerializeField]
		private bool _reactToForces;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Vector3 _extentsScale;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x1BC")]
		[Range(1f, 3f)]
		[SerializeField]
		private int _noiseVariation;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _allowViewFromInside;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x1C1")]
		[SerializeField]
		private bool _debugSpillPoint;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private int _renderQueue;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Cubemap _reflectionTexture;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Range(0.1f, 5f)]
		private float _physicsMass;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		[Range(0f, 0.2f)]
		private float _physicsAngularDamp;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		private const int SHADER_KEYWORD_DEPTH_AWARE_INDEX = 0;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		private const int SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX = 1;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		private const int SHADER_KEYWORD_IGNORE_GRAVITY_INDEX = 2;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		private const int SHADER_KEYWORD_NON_AABB_INDEX = 3;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		private const int SHADER_KEYWORD_TOPOLOGY_INDEX = 4;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		private const int SHADER_KEYWORD_REFRACTION_INDEX = 5;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		private const string SHADER_KEYWORD_DEPTH_AWARE = "LIQUID_VOLUME_DEPTH_AWARE";

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		private const string SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS = "LIQUID_VOLUME_DEPTH_AWARE_PASS";

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		private const string SHADER_KEYWORD_NON_AABB = "LIQUID_VOLUME_NON_AABB";

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		private const string SHADER_KEYWORD_IGNORE_GRAVITY = "LIQUID_VOLUME_IGNORE_GRAVITY";

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		private const string SHADER_KEYWORD_SPHERE = "LIQUID_VOLUME_SPHERE";

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		private const string SHADER_KEYWORD_CUBE = "LIQUID_VOLUME_CUBE";

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		private const string SHADER_KEYWORD_CYLINDER = "LIQUID_VOLUME_CYLINDER";

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		private const string SHADER_KEYWORD_IRREGULAR = "LIQUID_VOLUME_IRREGULAR";

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		private const string SHADER_KEYWORD_FP_RENDER_TEXTURE = "LIQUID_VOLUME_FP_RENDER_TEXTURES";

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		private const string SHADER_KEYWORD_USE_REFRACTION = "LIQUID_VOLUME_USE_REFRACTION";

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		private const string SPILL_POINT_GIZMO = "SpillPointGizmo";

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x1D8")]
		[NonSerialized]
		public Material liqMat;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x1E0")]
		private Material liqMatSimple;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x1E8")]
		private Material liqMatDefaultNoFlask;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x1F0")]
		private Mesh mesh;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x1F8")]
		[NonSerialized]
		public Renderer mr;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Material> mrSharedMaterials;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x200")]
		private Vector3 lastPosition;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x20C")]
		private Vector3 lastScale;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x218")]
		private Quaternion lastRotation;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x228")]
		private string[] shaderKeywords;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x230")]
		private bool camInside;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x234")]
		private float lastDistanceToCam;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x238")]
		private DETAIL currentDetail;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x23C")]
		private Vector4 turb;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x24C")]
		private Vector4 shaderTurb;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x25C")]
		private float turbulenceSpeed;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x260")]
		private float murkinessSpeed;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x264")]
		private float liquidLevelPos;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x268")]
		private bool shouldUpdateMaterialProperties;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x26C")]
		private int currentNoiseVariation;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x270")]
		private float levelMultipled;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x278")]
		private Texture2D noise3DUnwrapped;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x280")]
		private Texture3D[] noise3DTex;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x288")]
		private Color[][] colors3D;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x290")]
		private Vector3[] verticesUnsorted;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x298")]
		private Vector3[] verticesSorted;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x10")]
		private static Vector3[] rotatedVertices;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x2A0")]
		private int[] verticesIndices;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x2A8")]
		private float volumeRef;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x2AC")]
		private float lastLevelVolumeRef;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x2B0")]
		private Vector3 inertia;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x2BC")]
		private Vector3 lastAvgVelocity;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x2C8")]
		private float angularVelocity;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x2CC")]
		private float angularInertia;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x2D0")]
		private float turbulenceDueForces;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x2D4")]
		private Quaternion liquidRot;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x2E4")]
		private float prevThickness;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x2E8")]
		private GameObject spillPointGizmo;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x18")]
		private static string[] defaultContainerNames;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x2F0")]
		private Color[] pointLightColorBuffer;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x2F8")]
		private Vector4[] pointLightPositionBuffer;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x300")]
		private int lastPointLightCount;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<Mesh, LiquidVolume.MeshCache> meshCache;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x308")]
		private readonly List<Vector3> verts;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x310")]
		private readonly List<Vector3> cutPoints;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x318")]
		private Vector3 cutPlaneCenter;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x328")]
		[SerializeField]
		private Mesh fixedMesh;

		// Token: 0x02000185 RID: 389
		[Token(Token = "0x2000185")]
		private struct MeshCache
		{
			// Token: 0x04000856 RID: 2134
			[Token(Token = "0x4000856")]
			[FieldOffset(Offset = "0x0")]
			public Vector3[] verticesSorted;

			// Token: 0x04000857 RID: 2135
			[Token(Token = "0x4000857")]
			[FieldOffset(Offset = "0x8")]
			public Vector3[] verticesUnsorted;

			// Token: 0x04000858 RID: 2136
			[Token(Token = "0x4000858")]
			[FieldOffset(Offset = "0x10")]
			public int[] indices;
		}

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060007B8 RID: 1976
		[Token(Token = "0x2000186")]
		private delegate float MeshVolumeCalcFunction(float level01, float yExtent);

		// Token: 0x02000187 RID: 391
		[Token(Token = "0x2000187")]
		private static class ShaderParams
		{
			// Token: 0x04000859 RID: 2137
			[Token(Token = "0x4000859")]
			[FieldOffset(Offset = "0x0")]
			public static int PointLightInsideAtten;

			// Token: 0x0400085A RID: 2138
			[Token(Token = "0x400085A")]
			[FieldOffset(Offset = "0x4")]
			public static int PointLightColorArray;

			// Token: 0x0400085B RID: 2139
			[Token(Token = "0x400085B")]
			[FieldOffset(Offset = "0x8")]
			public static int PointLightPositionArray;

			// Token: 0x0400085C RID: 2140
			[Token(Token = "0x400085C")]
			[FieldOffset(Offset = "0xC")]
			public static int PointLightCount;

			// Token: 0x0400085D RID: 2141
			[Token(Token = "0x400085D")]
			[FieldOffset(Offset = "0x10")]
			public static int GlossinessInt;

			// Token: 0x0400085E RID: 2142
			[Token(Token = "0x400085E")]
			[FieldOffset(Offset = "0x14")]
			public static int DoubleSidedBias;

			// Token: 0x0400085F RID: 2143
			[Token(Token = "0x400085F")]
			[FieldOffset(Offset = "0x18")]
			public static int BackDepthBias;

			// Token: 0x04000860 RID: 2144
			[Token(Token = "0x4000860")]
			[FieldOffset(Offset = "0x1C")]
			public static int Muddy;

			// Token: 0x04000861 RID: 2145
			[Token(Token = "0x4000861")]
			[FieldOffset(Offset = "0x20")]
			public static int Alpha;

			// Token: 0x04000862 RID: 2146
			[Token(Token = "0x4000862")]
			[FieldOffset(Offset = "0x24")]
			public static int AlphaCombined;

			// Token: 0x04000863 RID: 2147
			[Token(Token = "0x4000863")]
			[FieldOffset(Offset = "0x28")]
			public static int SparklingIntensity;

			// Token: 0x04000864 RID: 2148
			[Token(Token = "0x4000864")]
			[FieldOffset(Offset = "0x2C")]
			public static int SparklingThreshold;

			// Token: 0x04000865 RID: 2149
			[Token(Token = "0x4000865")]
			[FieldOffset(Offset = "0x30")]
			public static int DepthAtten;

			// Token: 0x04000866 RID: 2150
			[Token(Token = "0x4000866")]
			[FieldOffset(Offset = "0x34")]
			public static int SmokeColor;

			// Token: 0x04000867 RID: 2151
			[Token(Token = "0x4000867")]
			[FieldOffset(Offset = "0x38")]
			public static int SmokeAtten;

			// Token: 0x04000868 RID: 2152
			[Token(Token = "0x4000868")]
			[FieldOffset(Offset = "0x3C")]
			public static int SmokeSpeed;

			// Token: 0x04000869 RID: 2153
			[Token(Token = "0x4000869")]
			[FieldOffset(Offset = "0x40")]
			public static int SmokeHeightAtten;

			// Token: 0x0400086A RID: 2154
			[Token(Token = "0x400086A")]
			[FieldOffset(Offset = "0x44")]
			public static int SmokeRaySteps;

			// Token: 0x0400086B RID: 2155
			[Token(Token = "0x400086B")]
			[FieldOffset(Offset = "0x48")]
			public static int LiquidRaySteps;

			// Token: 0x0400086C RID: 2156
			[Token(Token = "0x400086C")]
			[FieldOffset(Offset = "0x4C")]
			public static int FlaskBlurIntensity;

			// Token: 0x0400086D RID: 2157
			[Token(Token = "0x400086D")]
			[FieldOffset(Offset = "0x50")]
			public static int FoamColor;

			// Token: 0x0400086E RID: 2158
			[Token(Token = "0x400086E")]
			[FieldOffset(Offset = "0x54")]
			public static int FoamRaySteps;

			// Token: 0x0400086F RID: 2159
			[Token(Token = "0x400086F")]
			[FieldOffset(Offset = "0x58")]
			public static int FoamDensity;

			// Token: 0x04000870 RID: 2160
			[Token(Token = "0x4000870")]
			[FieldOffset(Offset = "0x5C")]
			public static int FoamWeight;

			// Token: 0x04000871 RID: 2161
			[Token(Token = "0x4000871")]
			[FieldOffset(Offset = "0x60")]
			public static int FoamBottom;

			// Token: 0x04000872 RID: 2162
			[Token(Token = "0x4000872")]
			[FieldOffset(Offset = "0x64")]
			public static int FoamTurbulence;

			// Token: 0x04000873 RID: 2163
			[Token(Token = "0x4000873")]
			[FieldOffset(Offset = "0x68")]
			public static int RefractTex;

			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x4000874")]
			[FieldOffset(Offset = "0x6C")]
			public static int FlaskThickness;

			// Token: 0x04000875 RID: 2165
			[Token(Token = "0x4000875")]
			[FieldOffset(Offset = "0x70")]
			public static int Size;

			// Token: 0x04000876 RID: 2166
			[Token(Token = "0x4000876")]
			[FieldOffset(Offset = "0x74")]
			public static int Scale;

			// Token: 0x04000877 RID: 2167
			[Token(Token = "0x4000877")]
			[FieldOffset(Offset = "0x78")]
			public static int Center;

			// Token: 0x04000878 RID: 2168
			[Token(Token = "0x4000878")]
			[FieldOffset(Offset = "0x7C")]
			public static int SizeWorld;

			// Token: 0x04000879 RID: 2169
			[Token(Token = "0x4000879")]
			[FieldOffset(Offset = "0x80")]
			public static int DepthAwareOffset;

			// Token: 0x0400087A RID: 2170
			[Token(Token = "0x400087A")]
			[FieldOffset(Offset = "0x84")]
			public static int Turbulence;

			// Token: 0x0400087B RID: 2171
			[Token(Token = "0x400087B")]
			[FieldOffset(Offset = "0x88")]
			public static int TurbulenceSpeed;

			// Token: 0x0400087C RID: 2172
			[Token(Token = "0x400087C")]
			[FieldOffset(Offset = "0x8C")]
			public static int MurkinessSpeed;

			// Token: 0x0400087D RID: 2173
			[Token(Token = "0x400087D")]
			[FieldOffset(Offset = "0x90")]
			public static int Color1;

			// Token: 0x0400087E RID: 2174
			[Token(Token = "0x400087E")]
			[FieldOffset(Offset = "0x94")]
			public static int Color2;

			// Token: 0x0400087F RID: 2175
			[Token(Token = "0x400087F")]
			[FieldOffset(Offset = "0x98")]
			public static int EmissionColor;

			// Token: 0x04000880 RID: 2176
			[Token(Token = "0x4000880")]
			[FieldOffset(Offset = "0x9C")]
			public static int LightColor;

			// Token: 0x04000881 RID: 2177
			[Token(Token = "0x4000881")]
			[FieldOffset(Offset = "0xA0")]
			public static int LightDir;

			// Token: 0x04000882 RID: 2178
			[Token(Token = "0x4000882")]
			[FieldOffset(Offset = "0xA4")]
			public static int LevelPos;

			// Token: 0x04000883 RID: 2179
			[Token(Token = "0x4000883")]
			[FieldOffset(Offset = "0xA8")]
			public static int UpperLimit;

			// Token: 0x04000884 RID: 2180
			[Token(Token = "0x4000884")]
			[FieldOffset(Offset = "0xAC")]
			public static int LowerLimit;

			// Token: 0x04000885 RID: 2181
			[Token(Token = "0x4000885")]
			[FieldOffset(Offset = "0xB0")]
			public static int FoamMaxPos;

			// Token: 0x04000886 RID: 2182
			[Token(Token = "0x4000886")]
			[FieldOffset(Offset = "0xB4")]
			public static int CullMode;

			// Token: 0x04000887 RID: 2183
			[Token(Token = "0x4000887")]
			[FieldOffset(Offset = "0xB8")]
			public static int ZTestMode;

			// Token: 0x04000888 RID: 2184
			[Token(Token = "0x4000888")]
			[FieldOffset(Offset = "0xBC")]
			public static int NoiseTex;

			// Token: 0x04000889 RID: 2185
			[Token(Token = "0x4000889")]
			[FieldOffset(Offset = "0xC0")]
			public static int NoiseTexUnwrapped;

			// Token: 0x0400088A RID: 2186
			[Token(Token = "0x400088A")]
			[FieldOffset(Offset = "0xC4")]
			public static int GlobalRefractionTexture;

			// Token: 0x0400088B RID: 2187
			[Token(Token = "0x400088B")]
			[FieldOffset(Offset = "0xC8")]
			public static int RotationMatrix;

			// Token: 0x0400088C RID: 2188
			[Token(Token = "0x400088C")]
			[FieldOffset(Offset = "0xCC")]
			public static int QueueOffset;

			// Token: 0x0400088D RID: 2189
			[Token(Token = "0x400088D")]
			[FieldOffset(Offset = "0xD0")]
			public static int PreserveSpecular;
		}
	}
}
