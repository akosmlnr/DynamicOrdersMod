using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AE")]
		public bool IsActivated
		{
			[Token(Token = "0x6002624")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002625")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x6C1890", Offset = "0x6C0A90", VA = "0x1806C1890")]
		public void Start()
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x6C16E0", Offset = "0x6C08E0", VA = "0x1806C16E0")]
		public void Hovered()
		{
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x6C1760", Offset = "0x6C0960", VA = "0x1806C1760")]
		public void Interacted()
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x6C1760", Offset = "0x6C0960", VA = "0x1806C1760")]
		public void Toggle()
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x6C1830", Offset = "0x6C0A30", VA = "0x1806C1830")]
		public void SetState(bool activated)
		{
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x6C17C0", Offset = "0x6C09C0", VA = "0x1806C17C0")]
		public void PoliceDetected()
		{
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x6C1980", Offset = "0x6C0B80", VA = "0x1806C1980")]
		public InteractableToggleable()
		{
		}

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x28")]
		public string ActivateMessage;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x30")]
		public string DeactivateMessage;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x38")]
		public float CoolDown;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onToggle;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onActivate;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onDeactivate;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[FieldOffset(Offset = "0x60")]
		private float lastActivated;
	}
}
