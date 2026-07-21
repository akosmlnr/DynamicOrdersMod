using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	public class StringField : ConfigField
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AD")]
		public string Value
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0000B328 File Offset: 0x00009528
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AE")]
		public int CharacterLimit
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x6866B0", Offset = "0x6858B0", VA = "0x1806866B0")]
		public StringField(EntityConfiguration parentConfig, string defaultValue)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x686600", Offset = "0x685800", VA = "0x180686600")]
		public void SetValue(string value, bool network)
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x6864E0", Offset = "0x6856E0", VA = "0x1806864E0")]
		public void Configure(int characterLimit, bool canBeNullOrEmpty)
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x686550", Offset = "0x685750", VA = "0x180686550", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x6864F0", Offset = "0x6856F0", VA = "0x1806864F0")]
		public StringFieldData GetData()
		{
			return null;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x686560", Offset = "0x685760", VA = "0x180686560")]
		public void Load(StringFieldData data)
		{
		}

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x28")]
		private string _defaultValue;

		// Token: 0x04001A54 RID: 6740
		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x30")]
		private bool _canBeNullOrEmpty;

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<string> onItemChanged;
	}
}
