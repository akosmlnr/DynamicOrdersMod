using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C26 RID: 3110
	[Token(Token = "0x2000C26")]
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06005B1A RID: 23322 RVA: 0x000171A8 File Offset: 0x000153A8
		// (set) Token: 0x06005B1B RID: 23323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D30")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B1B")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0x9C31E0", Offset = "0x9C23E0", VA = "0x1809C31E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0x9C3550", Offset = "0x9C2750", VA = "0x1809C3550")]
		public void SetOpen(bool open)
		{
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0x9C3750", Offset = "0x9C2950", VA = "0x1809C3750")]
		private void Update()
		{
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0x9C3370", Offset = "0x9C2570", VA = "0x1809C3370")]
		public void SetAppearance(AvatarSettings settings)
		{
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B20")]
		[Address(RVA = "0x9C38D0", Offset = "0x9C2AD0", VA = "0x1809C38D0")]
		public CharacterDisplay()
		{
		}

		// Token: 0x04003D90 RID: 15760
		[Token(Token = "0x4003D90")]
		[FieldOffset(Offset = "0x30")]
		public CharacterDisplay.SlotAlignmentPoint[] AlignmentPoints;

		// Token: 0x04003D91 RID: 15761
		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform Container;

		// Token: 0x04003D92 RID: 15762
		[Token(Token = "0x4003D92")]
		[FieldOffset(Offset = "0x40")]
		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		// Token: 0x04003D93 RID: 15763
		[Token(Token = "0x4003D93")]
		[FieldOffset(Offset = "0x48")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04003D94 RID: 15764
		[Token(Token = "0x4003D94")]
		[FieldOffset(Offset = "0x50")]
		public Transform AvatarContainer;

		// Token: 0x04003D95 RID: 15765
		[Token(Token = "0x4003D95")]
		[FieldOffset(Offset = "0x58")]
		private float targetRotation;

		// Token: 0x02000C27 RID: 3111
		[Token(Token = "0x2000C27")]
		[Serializable]
		public class SlotAlignmentPoint
		{
			// Token: 0x06005B22 RID: 23330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B22")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SlotAlignmentPoint()
			{
			}

			// Token: 0x04003D96 RID: 15766
			[Token(Token = "0x4003D96")]
			[FieldOffset(Offset = "0x10")]
			public EClothingSlot SlotType;

			// Token: 0x04003D97 RID: 15767
			[Token(Token = "0x4003D97")]
			[FieldOffset(Offset = "0x18")]
			public Transform Point;
		}
	}
}
