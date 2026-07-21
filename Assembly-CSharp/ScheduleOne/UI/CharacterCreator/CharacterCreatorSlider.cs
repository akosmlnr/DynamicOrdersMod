using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DE8 RID: 3560
	[Token(Token = "0x2000DE8")]
	public class CharacterCreatorSlider : CharacterCreatorField<float>
	{
		// Token: 0x0600660F RID: 26127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600660F")]
		[Address(RVA = "0xA8CE30", Offset = "0xA8C030", VA = "0x180A8CE30", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006610")]
		[Address(RVA = "0xA8CDC0", Offset = "0xA8BFC0", VA = "0x180A8CDC0", Slot = "6")]
		public override void ApplyValue()
		{
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006611")]
		[Address(RVA = "0xA8CEE0", Offset = "0xA8C0E0", VA = "0x180A8CEE0")]
		public void OnSliderChanged(float newValue)
		{
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006612")]
		[Address(RVA = "0xA8CF40", Offset = "0xA8C140", VA = "0x180A8CF40")]
		public CharacterCreatorSlider()
		{
		}

		// Token: 0x040047EF RID: 18415
		[Token(Token = "0x40047EF")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Slider Slider;
	}
}
