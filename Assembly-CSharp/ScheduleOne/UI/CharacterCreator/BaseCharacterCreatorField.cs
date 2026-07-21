using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000DDE RID: 3550
	[Token(Token = "0x2000DDE")]
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x060065EC RID: 26092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public virtual void ApplyValue()
		{
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public virtual void WriteValue(bool applyValue = true)
		{
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BaseCharacterCreatorField()
		{
		}

		// Token: 0x040047CD RID: 18381
		[Token(Token = "0x40047CD")]
		[FieldOffset(Offset = "0x20")]
		public string PropertyName;

		// Token: 0x040047CE RID: 18382
		[Token(Token = "0x40047CE")]
		[FieldOffset(Offset = "0x28")]
		public CharacterCreator.ECategory Category;

		// Token: 0x040047CF RID: 18383
		[Token(Token = "0x40047CF")]
		[FieldOffset(Offset = "0x30")]
		private CharacterCreator Creator;
	}
}
