using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Clothing;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x2000DE1")]
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060065F9 RID: 26105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E81")]
		public T value
		{
			[Token(Token = "0x60065F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60065F9")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60065FA")]
		public virtual T ReadValue()
		{
			return null;
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FB")]
		public override void WriteValue(bool applyValue = true)
		{
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FC")]
		public override void ApplyValue()
		{
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FD")]
		public CharacterCreatorField()
		{
		}

		// Token: 0x040047DA RID: 18394
		[Token(Token = "0x40047DA")]
		[FieldOffset(Offset = "0x0")]
		protected ClothingDefinition selectedClothingDefinition;
	}
}
