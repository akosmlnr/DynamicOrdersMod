using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	public class QualityField : ConfigField
	{
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0000B2B0 File Offset: 0x000094B0
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AB")]
		public EQuality Value
		{
			[Token(Token = "0x600201F")]
			[Address(RVA = "0x457F70", Offset = "0x457170", VA = "0x180457F70")]
			[CompilerGenerated]
			get
			{
				return EQuality.Trash;
			}
			[Token(Token = "0x6002020")]
			[Address(RVA = "0x49BD70", Offset = "0x49AF70", VA = "0x18049BD70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x64C0D0", Offset = "0x64B2D0", VA = "0x18064C0D0")]
		public QualityField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x64C040", Offset = "0x64B240", VA = "0x18064C040")]
		public void SetValue(EQuality value, bool network)
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x64BFB0", Offset = "0x64B1B0", VA = "0x18064BFB0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x64BF50", Offset = "0x64B150", VA = "0x18064BF50")]
		public QualityFieldData GetData()
		{
			return null;
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x64BFC0", Offset = "0x64B1C0", VA = "0x18064BFC0")]
		public void Load(QualityFieldData data)
		{
		}

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<EQuality> onValueChanged;
	}
}
