using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D8C RID: 3468
	[Token(Token = "0x2000D8C")]
	public class StringFieldUI : MonoBehaviour
	{
		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4E")]
		public List<StringField> Fields
		{
			[Token(Token = "0x600640F")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006410")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006411")]
		[Address(RVA = "0xA6D6B0", Offset = "0xA6C8B0", VA = "0x180A6D6B0")]
		public void Bind(List<StringField> field)
		{
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006412")]
		[Address(RVA = "0xA6D990", Offset = "0xA6CB90", VA = "0x180A6D990")]
		private void Refresh(string newVal)
		{
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00018A98 File Offset: 0x00016C98
		[Token(Token = "0x6006413")]
		[Address(RVA = "0xA6D5C0", Offset = "0xA6C7C0", VA = "0x180A6D5C0")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006414")]
		[Address(RVA = "0xA6DAC0", Offset = "0xA6CCC0", VA = "0x180A6DAC0")]
		public void ValueChanged(string value)
		{
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006415")]
		[Address(RVA = "0xA6DB70", Offset = "0xA6CD70", VA = "0x180A6DB70")]
		public StringFieldUI()
		{
		}

		// Token: 0x0400462C RID: 17964
		[Token(Token = "0x400462C")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x0400462D RID: 17965
		[Token(Token = "0x400462D")]
		[FieldOffset(Offset = "0x30")]
		public TMP_InputField InputField;
	}
}
