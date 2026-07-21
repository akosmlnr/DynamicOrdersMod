using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x2000D9A")]
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x06006474 RID: 25716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006474")]
		[Address(RVA = "0xA81E60", Offset = "0xA81060", VA = "0x180A81E60")]
		private void Update()
		{
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006475")]
		[Address(RVA = "0xA81A80", Offset = "0xA80C80", VA = "0x180A81A80")]
		public void Set(List<IConfigurable> Configurables)
		{
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006476")]
		[Address(RVA = "0xA82030", Offset = "0xA81230", VA = "0x180A82030")]
		public SelectionInfoUI()
		{
		}

		// Token: 0x04004679 RID: 18041
		[Token(Token = "0x4004679")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Image Icon;

		// Token: 0x0400467A RID: 18042
		[Token(Token = "0x400467A")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Title;

		// Token: 0x0400467B RID: 18043
		[Token(Token = "0x400467B")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public bool SelfUpdate;

		// Token: 0x0400467C RID: 18044
		[Token(Token = "0x400467C")]
		[FieldOffset(Offset = "0x38")]
		public Sprite NonUniformTypeSprite;

		// Token: 0x0400467D RID: 18045
		[Token(Token = "0x400467D")]
		[FieldOffset(Offset = "0x40")]
		public Sprite CrossSprite;
	}
}
