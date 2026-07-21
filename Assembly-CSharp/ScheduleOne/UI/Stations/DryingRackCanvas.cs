using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Stations.Drying_rack;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x2000CE1")]
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x00018000 File Offset: 0x00016200
		// (set) Token: 0x06006008 RID: 24584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE6")]
		public bool isOpen
		{
			[Token(Token = "0x6006007")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006008")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600600A RID: 24586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE7")]
		public DryingRack Rack
		{
			[Token(Token = "0x6006009")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600600A")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600B")]
		[Address(RVA = "0xA26AA0", Offset = "0xA25CA0", VA = "0x180A26AA0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600C")]
		[Address(RVA = "0xA25C90", Offset = "0xA24E90", VA = "0x180A25C90")]
		private void MinPass()
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600D")]
		[Address(RVA = "0xA272D0", Offset = "0xA264D0", VA = "0x180A272D0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600E")]
		[Address(RVA = "0xA27100", Offset = "0xA26300", VA = "0x180A27100")]
		private void UpdateUI()
		{
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600600F")]
		[Address(RVA = "0xA26C50", Offset = "0xA25E50", VA = "0x180A26C50")]
		private void UpdateDryingOperations()
		{
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006010")]
		[Address(RVA = "0xA26F60", Offset = "0xA26160", VA = "0x180A26F60")]
		private void UpdateQuantities()
		{
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006011")]
		[Address(RVA = "0xA25CA0", Offset = "0xA24EA0", VA = "0x180A25CA0")]
		public void SetIsOpen(DryingRack rack, bool open)
		{
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006012")]
		[Address(RVA = "0xA258A0", Offset = "0xA24AA0", VA = "0x180A258A0")]
		private void CreateOperationUI(DryingOperation operation)
		{
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006013")]
		[Address(RVA = "0xA25A60", Offset = "0xA24C60", VA = "0x180A25A60")]
		private void DestroyOperationUI(DryingOperation operation)
		{
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006014")]
		[Address(RVA = "0xA25C40", Offset = "0xA24E40", VA = "0x180A25C40")]
		public void Insert()
		{
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006015")]
		[Address(RVA = "0xA272E0", Offset = "0xA264E0", VA = "0x180A272E0")]
		public DryingRackCanvas()
		{
		}

		// Token: 0x0400425C RID: 16988
		[Token(Token = "0x400425C")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400425D RID: 16989
		[Token(Token = "0x400425D")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Container;

		// Token: 0x0400425E RID: 16990
		[Token(Token = "0x400425E")]
		[FieldOffset(Offset = "0x48")]
		public UIScreen UIScreen;

		// Token: 0x0400425F RID: 16991
		[Token(Token = "0x400425F")]
		[FieldOffset(Offset = "0x50")]
		public UIPanel ProgressContainerPanel;

		// Token: 0x04004260 RID: 16992
		[Token(Token = "0x4004260")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI InputSlotUI;

		// Token: 0x04004261 RID: 16993
		[Token(Token = "0x4004261")]
		[FieldOffset(Offset = "0x60")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04004262 RID: 16994
		[Token(Token = "0x4004262")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04004263 RID: 16995
		[Token(Token = "0x4004263")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI CapacityLabel;

		// Token: 0x04004264 RID: 16996
		[Token(Token = "0x4004264")]
		[FieldOffset(Offset = "0x78")]
		public Button InsertButton;

		// Token: 0x04004265 RID: 16997
		[Token(Token = "0x4004265")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform IndicatorContainer;

		// Token: 0x04004266 RID: 16998
		[Token(Token = "0x4004266")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform[] IndicatorAlignments;

		// Token: 0x04004267 RID: 16999
		[Token(Token = "0x4004267")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefabs")]
		public DryingOperationUI IndicatorPrefab;

		// Token: 0x04004268 RID: 17000
		[Token(Token = "0x4004268")]
		[FieldOffset(Offset = "0x98")]
		private List<DryingOperationUI> operationUIs;
	}
}
