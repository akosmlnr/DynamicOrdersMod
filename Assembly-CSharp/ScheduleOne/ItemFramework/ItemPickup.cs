using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	[RequireComponent(typeof(InteractableObject))]
	public class ItemPickup : MonoBehaviour
	{
		// Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x6C4A80", Offset = "0x6C3C80", VA = "0x1806C4A80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x6C5180", Offset = "0x6C4380", VA = "0x1806C5180")]
		private void Start()
		{
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x6C4E20", Offset = "0x6C4020", VA = "0x1806C4E20")]
		private void Init()
		{
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x6C4D40", Offset = "0x6C3F40", VA = "0x1806C4D40", Slot = "5")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x6C5010", Offset = "0x6C4210", VA = "0x1806C5010")]
		private void Interacted()
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x6C4BE0", Offset = "0x6C3DE0", VA = "0x1806C4BE0", Slot = "6")]
		protected virtual bool CanPickup()
		{
			return default(bool);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x6C5060", Offset = "0x6C4260", VA = "0x1806C5060", Slot = "7")]
		protected virtual void Pickup()
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x6C4CE0", Offset = "0x6C3EE0", VA = "0x1806C4CE0")]
		public void Destroy()
		{
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x6C53A0", Offset = "0x6C45A0", VA = "0x1806C53A0")]
		public ItemPickup()
		{
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x6C5330", Offset = "0x6C4530", VA = "0x1806C5330")]
		[CompilerGenerated]
		private IEnumerator <Init>g__Wait|8_0()
		{
			return null;
		}

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x20")]
		public ItemDefinition ItemToGive;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x28")]
		public bool DestroyOnPickup;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x29")]
		public bool ConditionallyActive;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x30")]
		public Condition ActiveCondition;

		// Token: 0x04001E56 RID: 7766
		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001E57 RID: 7767
		[Token(Token = "0x4001E57")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onPickup;
	}
}
