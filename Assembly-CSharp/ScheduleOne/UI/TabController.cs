using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CAF RID: 3247
	[Token(Token = "0x2000CAF")]
	public class TabController : MonoBehaviour
	{
		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06005EF9 RID: 24313 RVA: 0x00017D00 File Offset: 0x00015F00
		[Token(Token = "0x17000DC4")]
		public int CurrentTabIndex
		{
			[Token(Token = "0x6005EF9")]
			[Address(RVA = "0x4B47E0", Offset = "0x4B39E0", VA = "0x1804B47E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0xA14DC0", Offset = "0xA13FC0", VA = "0x180A14DC0")]
		public void Start()
		{
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EFB")]
		[Address(RVA = "0xA14D90", Offset = "0xA13F90", VA = "0x180A14D90")]
		private void SetTab(int index)
		{
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0xA14DA0", Offset = "0xA13FA0", VA = "0x180A14DA0")]
		public void SetToSelectedTab(bool instantIndicatorMove = false)
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0xA14860", Offset = "0xA13A60", VA = "0x180A14860")]
		public void SetTab(int index, bool instantIndicatorMove = false)
		{
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0xA14500", Offset = "0xA13700", VA = "0x180A14500")]
		private IEnumerator DoMoveTabIndicatorRoutine()
		{
			return null;
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0xA146B0", Offset = "0xA138B0", VA = "0x180A146B0")]
		public void SetTabIndicatorText(int index, string text)
		{
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F00")]
		[Address(RVA = "0xA14570", Offset = "0xA13770", VA = "0x180A14570")]
		public void HideTabIndicator(int index)
		{
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F01")]
		[Address(RVA = "0xA14F60", Offset = "0xA14160", VA = "0x180A14F60")]
		public void SubscribeToTabSelected(TabSelectedEvent handler)
		{
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F02")]
		[Address(RVA = "0xA15000", Offset = "0xA14200", VA = "0x180A15000")]
		public void UnsubscribeFromTabSelected(TabSelectedEvent handler)
		{
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F03")]
		[Address(RVA = "0xA14480", Offset = "0xA13680", VA = "0x180A14480")]
		private IEnumerator DoDelayRoutine(float delay, Action onComplete)
		{
			return null;
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F04")]
		[Address(RVA = "0xA150A0", Offset = "0xA142A0", VA = "0x180A150A0")]
		public TabController()
		{
		}

		// Token: 0x0400414B RID: 16715
		[Token(Token = "0x400414B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private RectTransform _tabIndicator;

		// Token: 0x0400414C RID: 16716
		[Token(Token = "0x400414C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TabItemUI> _tabItems;

		// Token: 0x0400414D RID: 16717
		[Token(Token = "0x400414D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		[SerializeField]
		private float _indicatorMoveTime;

		// Token: 0x0400414E RID: 16718
		[Token(Token = "0x400414E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _indicatorMoveCurve;

		// Token: 0x0400414F RID: 16719
		[Token(Token = "0x400414F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Fonts")]
		private ColorFont _tabColorFont;

		// Token: 0x04004150 RID: 16720
		[Token(Token = "0x4004150")]
		[FieldOffset(Offset = "0x48")]
		private int _currentTabIndex;

		// Token: 0x04004151 RID: 16721
		[Token(Token = "0x4004151")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 _indicatorPosition;

		// Token: 0x04004152 RID: 16722
		[Token(Token = "0x4004152")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine _moveIndicatorCo;

		// Token: 0x04004153 RID: 16723
		[Token(Token = "0x4004153")]
		[FieldOffset(Offset = "0x60")]
		private TabSelectedEvent _onTabSelected;
	}
}
