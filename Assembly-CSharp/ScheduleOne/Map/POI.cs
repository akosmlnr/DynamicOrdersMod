using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Map
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	public class POI : MonoBehaviour
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0000AB90 File Offset: 0x00008D90
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055E")]
		public bool UISetup
		{
			[Token(Token = "0x6001DB4")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DB5")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055F")]
		public string MainText
		{
			[Token(Token = "0x6001DB6")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB7")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000560")]
		public RectTransform UI
		{
			[Token(Token = "0x6001DB8")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DB9")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000561")]
		public RectTransform IconContainer
		{
			[Token(Token = "0x6001DBA")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000562")]
		public FontSetter FontSetter
		{
			[Token(Token = "0x6001DBC")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x62A4B0", Offset = "0x6296B0", VA = "0x18062A4B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x62A390", Offset = "0x629590", VA = "0x18062A390")]
		private void OnDisable()
		{
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x62ABF0", Offset = "0x629DF0", VA = "0x18062ABF0")]
		private void Update()
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x62A700", Offset = "0x629900", VA = "0x18062A700")]
		public void SetMainText(string text)
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x62A860", Offset = "0x629A60", VA = "0x18062A860", Slot = "4")]
		public virtual void UpdatePosition()
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x629DC0", Offset = "0x628FC0", VA = "0x180629DC0", Slot = "5")]
		public virtual void InitializeUI()
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x629D90", Offset = "0x628F90", VA = "0x180629D90", Slot = "6")]
		protected virtual void HoverStart()
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x629D60", Offset = "0x628F60", VA = "0x180629D60", Slot = "7")]
		protected virtual void HoverEnd()
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x629C90", Offset = "0x628E90", VA = "0x180629C90", Slot = "8")]
		protected virtual void Clicked()
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x6299D0", Offset = "0x628BD0", VA = "0x1806299D0")]
		public POI()
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x62A7F0", Offset = "0x6299F0", VA = "0x18062A7F0")]
		[CompilerGenerated]
		private IEnumerator <OnEnable>g__Wait|31_0()
		{
			return null;
		}

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0x24")]
		public POI.TextShowMode MainTextVisibility;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x28")]
		public string DefaultMainText;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x30")]
		public bool AutoUpdatePosition;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x31")]
		public bool Rotate;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject UIPrefab;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x60")]
		protected Text mainLabel;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x68")]
		protected Button button;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x70")]
		protected EventTrigger eventTrigger;

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x78")]
		private bool mainTextSet;

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onUICreated;

		// Token: 0x02000542 RID: 1346
		[Token(Token = "0x2000542")]
		public enum TextShowMode
		{
			// Token: 0x0400191B RID: 6427
			[Token(Token = "0x400191B")]
			Off,
			// Token: 0x0400191C RID: 6428
			[Token(Token = "0x400191C")]
			Always,
			// Token: 0x0400191D RID: 6429
			[Token(Token = "0x400191D")]
			OnHover
		}
	}
}
