using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public abstract class UIOption : MonoBehaviour
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x1700025F")]
		protected virtual float NavigationRepeatRateMult
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x7FF9C0", Offset = "0x7FEBC0", VA = "0x1807FF9C0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xAD3990", Offset = "0xAD2B90", VA = "0x180AD3990", Slot = "5")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xAD3C10", Offset = "0xAD2E10", VA = "0x180AD3C10")]
		private void OnValidate()
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xAD3CA0", Offset = "0xAD2EA0", VA = "0x180AD3CA0")]
		private void Update()
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		protected virtual void MoveLeft()
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		protected virtual void MoveRight()
		{
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xAD39D0", Offset = "0xAD2BD0", VA = "0x180AD39D0", Slot = "9")]
		protected virtual void DetectInput()
		{
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xAD3BB0", Offset = "0xAD2DB0", VA = "0x180AD3BB0", Slot = "10")]
		protected virtual bool Navigate(Vector2 navDir)
		{
			return default(bool);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xAD3CF0", Offset = "0xAD2EF0", VA = "0x180AD3CF0")]
		protected UIOption()
		{
		}

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected UISelectable selectable;

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TextMeshProUGUI nameText;

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected string optionName;

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		private const float MoveThreshold = 0.25f;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x38")]
		private bool wasNavPressedLastFrame;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x3C")]
		private float navTimer;

		// Token: 0x0200021A RID: 538
		[Token(Token = "0x200021A")]
		public struct OptionInfo
		{
			// Token: 0x04000C1F RID: 3103
			[Token(Token = "0x4000C1F")]
			[FieldOffset(Offset = "0x0")]
			public string OptionName;

			// Token: 0x04000C20 RID: 3104
			[Token(Token = "0x4000C20")]
			[FieldOffset(Offset = "0x8")]
			public int OptionIndex;
		}
	}
}
