using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	public class StationRecipeField : ConfigField
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AC")]
		public StationRecipe SelectedRecipe
		{
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x686410", Offset = "0x685610", VA = "0x180686410")]
		public StationRecipeField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x686370", Offset = "0x685570", VA = "0x180686370")]
		public void SetRecipe(StationRecipe recipe, bool network)
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x686210", Offset = "0x685410", VA = "0x180686210", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x686130", Offset = "0x685330", VA = "0x180686130")]
		public StationRecipeFieldData GetData()
		{
			return null;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x686260", Offset = "0x685460", VA = "0x180686260")]
		public void Load(StationRecipeFieldData data)
		{
		}

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x20")]
		public List<StationRecipe> Options;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<StationRecipe> onRecipeChanged;
	}
}
