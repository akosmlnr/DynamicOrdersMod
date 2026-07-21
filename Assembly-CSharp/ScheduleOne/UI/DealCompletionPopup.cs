using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Quests;
using ScheduleOne.UI.Relations;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C31 RID: 3121
	[Token(Token = "0x2000C31")]
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x000172F8 File Offset: 0x000154F8
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3E")]
		public bool IsPlaying
		{
			[Token(Token = "0x6005B80")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B81")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x9C97F0", Offset = "0x9C89F0", VA = "0x1809C97F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x9C9980", Offset = "0x9C8B80", VA = "0x1809C9980")]
		public void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x9C98B0", Offset = "0x9C8AB0", VA = "0x1809C98B0")]
		private IEnumerator PlayPopupRoutine(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			return null;
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x9C9B90", Offset = "0x9C8D90", VA = "0x1809C9B90")]
		private void SetRelationshipLabel(float delta)
		{
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x9C9D40", Offset = "0x9C8F40", VA = "0x1809C9D40")]
		public DealCompletionPopup()
		{
		}

		// Token: 0x04003DD3 RID: 15827
		[Token(Token = "0x4003DD3")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003DD4 RID: 15828
		[Token(Token = "0x4003DD4")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003DD5 RID: 15829
		[Token(Token = "0x4003DD5")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x04003DD6 RID: 15830
		[Token(Token = "0x4003DD6")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;

		// Token: 0x04003DD7 RID: 15831
		[Token(Token = "0x4003DD7")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Title;

		// Token: 0x04003DD8 RID: 15832
		[Token(Token = "0x4003DD8")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI PaymentLabel;

		// Token: 0x04003DD9 RID: 15833
		[Token(Token = "0x4003DD9")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI SatisfactionValueLabel;

		// Token: 0x04003DDA RID: 15834
		[Token(Token = "0x4003DDA")]
		[FieldOffset(Offset = "0x68")]
		public RelationCircle RelationCircle;

		// Token: 0x04003DDB RID: 15835
		[Token(Token = "0x4003DDB")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI RelationshipLabel;

		// Token: 0x04003DDC RID: 15836
		[Token(Token = "0x4003DDC")]
		[FieldOffset(Offset = "0x78")]
		public Gradient SatisfactionGradient;

		// Token: 0x04003DDD RID: 15837
		[Token(Token = "0x4003DDD")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController SoundEffect;

		// Token: 0x04003DDE RID: 15838
		[Token(Token = "0x4003DDE")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI[] BonusLabels;

		// Token: 0x04003DDF RID: 15839
		[Token(Token = "0x4003DDF")]
		[FieldOffset(Offset = "0x90")]
		[Header("Animations")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x04003DE0 RID: 15840
		[Token(Token = "0x4003DE0")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine routine;

		// Token: 0x04003DE1 RID: 15841
		[Token(Token = "0x4003DE1")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationState _animationState;
	}
}
