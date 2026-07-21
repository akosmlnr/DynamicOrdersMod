using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D88 RID: 3464
	[Token(Token = "0x2000D88")]
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060063F8 RID: 25592 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063F9 RID: 25593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4C")]
		public List<RouteListField> Fields
		{
			[Token(Token = "0x60063F8")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063F9")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FA")]
		[Address(RVA = "0xA6C690", Offset = "0xA6B890", VA = "0x180A6C690")]
		private void Start()
		{
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0xA6BEA0", Offset = "0xA6B0A0", VA = "0x180A6BEA0")]
		public void Bind(List<RouteListField> field)
		{
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FC")]
		[Address(RVA = "0xA6C0D0", Offset = "0xA6B2D0", VA = "0x180A6C0D0")]
		private void Refresh(List<AdvancedTransitRoute> newVal)
		{
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FD")]
		[Address(RVA = "0xA6C050", Offset = "0xA6B250", VA = "0x180A6C050")]
		private void EntryDeleteClicked(RouteEntryUI entry)
		{
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FE")]
		[Address(RVA = "0xA6BE00", Offset = "0xA6B000", VA = "0x180A6BE00")]
		private void AddClicked()
		{
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063FF")]
		[Address(RVA = "0xA6C630", Offset = "0xA6B830", VA = "0x180A6C630")]
		private void RouteChanged(ITransitEntity newEntity)
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006400")]
		[Address(RVA = "0xA6C880", Offset = "0xA6BA80", VA = "0x180A6C880")]
		public RouteListFieldUI()
		{
		}

		// Token: 0x0400461D RID: 17949
		[Token(Token = "0x400461D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public string FieldText;

		// Token: 0x0400461E RID: 17950
		[Token(Token = "0x400461E")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI FieldLabel;

		// Token: 0x0400461F RID: 17951
		[Token(Token = "0x400461F")]
		[FieldOffset(Offset = "0x38")]
		public RouteEntryUI[] RouteEntries;

		// Token: 0x04004620 RID: 17952
		[Token(Token = "0x4004620")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform MultiEditBlocker;

		// Token: 0x04004621 RID: 17953
		[Token(Token = "0x4004621")]
		[FieldOffset(Offset = "0x48")]
		public Button AddButton;
	}
}
