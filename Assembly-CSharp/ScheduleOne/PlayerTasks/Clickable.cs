using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class Clickable : MonoBehaviour
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00009660 File Offset: 0x00007860
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045B")]
		public virtual CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x600166E")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00009678 File Offset: 0x00007878
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		public Vector3 originalHitPoint
		{
			[Token(Token = "0x600166F")]
			[Address(RVA = "0x599260", Offset = "0x598460", VA = "0x180599260")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001670")]
			[Address(RVA = "0x599170", Offset = "0x598370", VA = "0x180599170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00009690 File Offset: 0x00007890
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public bool IsHeld
		{
			[Token(Token = "0x6001671")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x5990E0", Offset = "0x5982E0", VA = "0x1805990E0")]
		private void Awake()
		{
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x599180", Offset = "0x598380", VA = "0x180599180", Slot = "6")]
		public virtual void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x599140", Offset = "0x598340", VA = "0x180599140", Slot = "7")]
		public virtual void EndClick()
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x599170", Offset = "0x598370", VA = "0x180599170")]
		public void SetOriginalHitPoint(Vector3 hitPoint)
		{
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x599200", Offset = "0x598400", VA = "0x180599200")]
		public Clickable()
		{
		}

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x20")]
		public bool ClickableEnabled;

		// Token: 0x040013AE RID: 5038
		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0x21")]
		public bool AutoCalculateOffset;

		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0x22")]
		public bool FlattenZOffset;

		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<RaycastHit> onClickStart;

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onClickEnd;
	}
}
