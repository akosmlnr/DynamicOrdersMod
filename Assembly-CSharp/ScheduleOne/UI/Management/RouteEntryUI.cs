using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D87 RID: 3463
	[Token(Token = "0x2000D87")]
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060063ED RID: 25581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4B")]
		public AdvancedTransitRoute AssignedRoute
		{
			[Token(Token = "0x60063EC")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063ED")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0xA6B0A0", Offset = "0xA6A2A0", VA = "0x180A6B0A0")]
		public void AssignRoute(AdvancedTransitRoute route)
		{
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x56B130", Offset = "0x56A330", VA = "0x18056B130")]
		public void ClearRoute()
		{
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0xA6B580", Offset = "0xA6A780", VA = "0x180A6B580")]
		public void RefreshUI()
		{
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0xA6BAE0", Offset = "0xA6ACE0", VA = "0x180A6BAE0")]
		public void SourceClicked()
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0xA6B0D0", Offset = "0xA6A2D0", VA = "0x180A6B0D0")]
		public void DestinationClicked()
		{
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void FilterClicked()
		{
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F4")]
		[Address(RVA = "0x8371C0", Offset = "0x8363C0", VA = "0x1808371C0")]
		public void DeleteClicked()
		{
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00018A50 File Offset: 0x00016C50
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0xA6B380", Offset = "0xA6A580", VA = "0x180A6B380")]
		private bool ObjectValid(ITransitEntity obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F6")]
		[Address(RVA = "0xA6B470", Offset = "0xA6A670", VA = "0x180A6B470")]
		public void ObjectsSelected(List<ITransitEntity> objs)
		{
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063F7")]
		[Address(RVA = "0xA6BD90", Offset = "0xA6AF90", VA = "0x180A6BD90")]
		public RouteEntryUI()
		{
		}

		// Token: 0x04004614 RID: 17940
		[Token(Token = "0x4004614")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Image SourceIcon;

		// Token: 0x04004615 RID: 17941
		[Token(Token = "0x4004615")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI SourceLabel;

		// Token: 0x04004616 RID: 17942
		[Token(Token = "0x4004616")]
		[FieldOffset(Offset = "0x38")]
		public Image DestinationIcon;

		// Token: 0x04004617 RID: 17943
		[Token(Token = "0x4004617")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI DestinationLabel;

		// Token: 0x04004618 RID: 17944
		[Token(Token = "0x4004618")]
		[FieldOffset(Offset = "0x48")]
		public Image FilterIcon;

		// Token: 0x04004619 RID: 17945
		[Token(Token = "0x4004619")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onDeleteClicked;

		// Token: 0x0400461A RID: 17946
		[Token(Token = "0x400461A")]
		[FieldOffset(Offset = "0x58")]
		private bool settingSource;

		// Token: 0x0400461B RID: 17947
		[Token(Token = "0x400461B")]
		[FieldOffset(Offset = "0x59")]
		private bool settingDestination;
	}
}
