using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	public class NumberField : ConfigField
	{
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A7")]
		public float Value
		{
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x549260", Offset = "0x548460", VA = "0x180549260")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x6466E0", Offset = "0x6458E0", VA = "0x1806466E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A8")]
		public float MinValue
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x496FB0", Offset = "0x4961B0", VA = "0x180496FB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0000B238 File Offset: 0x00009438
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A9")]
		public float MaxValue
		{
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002008")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0000B250 File Offset: 0x00009450
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AA")]
		public bool WholeNumbers
		{
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x6466D0", Offset = "0x6458D0", VA = "0x1806466D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200A")]
			[Address(RVA = "0x6466F0", Offset = "0x6458F0", VA = "0x1806466F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x646640", Offset = "0x645840", VA = "0x180646640")]
		public NumberField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x6465A0", Offset = "0x6457A0", VA = "0x1806465A0")]
		public void SetValue(float value, bool network)
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x646480", Offset = "0x645680", VA = "0x180646480")]
		public void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x6464F0", Offset = "0x6456F0", VA = "0x1806464F0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x646490", Offset = "0x645690", VA = "0x180646490")]
		public NumberFieldData GetData()
		{
			return null;
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x646510", Offset = "0x645710", VA = "0x180646510")]
		public void Load(NumberFieldData data)
		{
		}

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<float> onItemChanged;
	}
}
