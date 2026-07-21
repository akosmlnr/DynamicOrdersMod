using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		// Token: 0x06005C20 RID: 23584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C20")]
		[Address(RVA = "0x9CE750", Offset = "0x9CD950", VA = "0x1809CE750", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x9CEC30", Offset = "0x9CDE30", VA = "0x1809CEC30", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x9CE920", Offset = "0x9CDB20", VA = "0x1809CE920")]
		public void Open()
		{
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x9CE8F0", Offset = "0x9CDAF0", VA = "0x1809CE8F0")]
		public void Close()
		{
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x9CE950", Offset = "0x9CDB50", VA = "0x1809CE950")]
		public void PhoneClicked()
		{
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x9CE870", Offset = "0x9CDA70", VA = "0x1809CE870")]
		public void CharacterClicked()
		{
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0x9CE9D0", Offset = "0x9CDBD0", VA = "0x1809CE9D0")]
		public void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0x9CED00", Offset = "0x9CDF00", VA = "0x1809CED00")]
		public GameplayMenuInterface()
		{
		}

		// Token: 0x04003E6D RID: 15981
		[Token(Token = "0x4003E6D")]
		[FieldOffset(Offset = "0x28")]
		public Canvas Canvas;

		// Token: 0x04003E6E RID: 15982
		[Token(Token = "0x4003E6E")]
		[FieldOffset(Offset = "0x30")]
		public Button PhoneButton;

		// Token: 0x04003E6F RID: 15983
		[Token(Token = "0x4003E6F")]
		[FieldOffset(Offset = "0x38")]
		public Button CharacterButton;

		// Token: 0x04003E70 RID: 15984
		[Token(Token = "0x4003E70")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform SelectionIndicator;

		// Token: 0x04003E71 RID: 15985
		[Token(Token = "0x4003E71")]
		[FieldOffset(Offset = "0x48")]
		public CharacterInterface CharacterInterface;

		// Token: 0x04003E72 RID: 15986
		[Token(Token = "0x4003E72")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine selectionLerp;
	}
}
