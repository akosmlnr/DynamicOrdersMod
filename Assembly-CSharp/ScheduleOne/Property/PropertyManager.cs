using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	public class PropertyManager : Singleton<PropertyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700043F")]
		public string SaveFolderName
		{
			[Token(Token = "0x60015BF")]
			[Address(RVA = "0x59FF30", Offset = "0x59F130", VA = "0x18059FF30", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000440")]
		public string SaveFileName
		{
			[Token(Token = "0x60015C0")]
			[Address(RVA = "0x59FF00", Offset = "0x59F100", VA = "0x18059FF00", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000441")]
		public Loader Loader
		{
			[Token(Token = "0x60015C1")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x17000442")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60015C2")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000443")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60015C3")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015C4")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000444")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60015C5")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015C6")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00009390 File Offset: 0x00007590
		// (set) Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000445")]
		public bool HasChanged
		{
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x496DF0", Offset = "0x495FF0", VA = "0x180496DF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60015C8")]
			[Address(RVA = "0x496E70", Offset = "0x496070", VA = "0x180496E70", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x17000446")]
		public int LoadOrder
		{
			[Token(Token = "0x60015C9")]
			[Address(RVA = "0x596F60", Offset = "0x596160", VA = "0x180596F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x59EDB0", Offset = "0x59DFB0", VA = "0x18059EDB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x59F350", Offset = "0x59E550", VA = "0x18059F350", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x59F310", Offset = "0x59E510", VA = "0x18059F310", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x59F6B0", Offset = "0x59E8B0", VA = "0x18059F6B0", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x59EE00", Offset = "0x59E000", VA = "0x18059EE00", Slot = "34")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x59F3E0", Offset = "0x59E5E0", VA = "0x18059F3E0")]
		public void LoadProperty(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x59F160", Offset = "0x59E360", VA = "0x18059F160")]
		public Property GetProperty(string code)
		{
			return null;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x59EEE0", Offset = "0x59E0E0", VA = "0x18059EEE0")]
		public Property GetNearestProperty(Vector3 point, bool includeOwned = true, bool includeUnowned = true, bool includeBusinesses = true)
		{
			return null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x59FE10", Offset = "0x59F010", VA = "0x18059FE10")]
		public PropertyManager()
		{
		}

		// Token: 0x04001348 RID: 4936
		[Token(Token = "0x4001348")]
		[FieldOffset(Offset = "0x28")]
		private PropertiesLoader loader;
	}
}
